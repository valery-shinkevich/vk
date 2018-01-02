﻿// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY
using VkNet.Enums;
namespace VkNet.Utils
{
	public partial class VkResponse
	{
		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator AddFriendStatus(VkResponse response)
		{
			if (response == null)
			{
				return AddFriendStatus.Unknown;
			}

			return Utilities.EnumFrom<AddFriendStatus>(response);
		}

		/// <summary>
		/// Преобразовать из VkResponse
		/// </summary>
		/// <param name="response">Ответ.</param>
		/// <returns>
		/// Результат преобразования.
		/// </returns>
		public static implicit operator AgeLimit(VkResponse response)
		{
			if (response == null)
			{
				return AgeLimit.Withoutlimit;
			}

			return Utilities.EnumFrom<AgeLimit>(response);
		}


		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator Attitude(VkResponse response)
		{
			if (response == null)
			{
				return Attitude.Unknown;
			}

			return Utilities.EnumFrom<Attitude>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator BanReason(VkResponse response)
		{
			if (response == null)
			{
				return BanReason.Other;
			}

			return Utilities.EnumFrom<BanReason>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator BirthdayVisibility(VkResponse response)
		{
			if (response == null)
			{
				return BirthdayVisibility.Invisible;
			}

			return Utilities.EnumFrom<BirthdayVisibility>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator DeleteFriendStatus(VkResponse response)
		{
			if (response == null || response["success"] == 0)
				return DeleteFriendStatus.Unknown;
			if ((response["in_request_deleted"] != null && response["in_request_deleted"] == 1)
				|| (response["out_request_deleted"] != null && response["out_request_deleted"] == 1))
				return DeleteFriendStatus.RequestRejected;
			if (response["suggestion_deleted"] != null && response["suggestion_deleted"] == 1)
				return DeleteFriendStatus.RecommendationDeleted;
			if (response["friend_deleted"] != null && response["friend_deleted"] == 1)
				return DeleteFriendStatus.UserIsDeleted;
			return DeleteFriendStatus.Unknown;
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator FriendStatus(VkResponse response)
		{
			if (response == null)
			{
				return FriendStatus.NotFriend;
			}

			return Utilities.EnumFrom<FriendStatus>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator GiftPrivacy(VkResponse response)
		{
			if (response == null)
			{
				return GiftPrivacy.NameHideMessageUser;
			}

			return Utilities.EnumFrom<GiftPrivacy>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator GroupAccess(VkResponse response)
		{
			if (response == null)
			{
				return GroupAccess.Open;
			}

			return Utilities.EnumFrom<GroupAccess>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator LeaderboardTypes(VkResponse response)
		{
			if (response == null)
			{
				return LeaderboardTypes.NotSupported;
			}

			return Utilities.EnumFrom<LeaderboardTypes>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator LifeMain(VkResponse response)
		{
			if (response == null)
			{
				return LifeMain.Unknown;
			}

			return Utilities.EnumFrom<LifeMain>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator MainSection(VkResponse response)
		{
			if (response == null)
			{
				return MainSection.NoSection;
			}

			return Utilities.EnumFrom<MainSection>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator MarketCurrencyId(VkResponse response)
		{
			if (response == null)
			{
				return MarketCurrencyId.Rub;
			}

			return Utilities.EnumFrom<MarketCurrencyId>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator PeopleMain(VkResponse response)
		{
			if (response == null)
			{
				return PeopleMain.Unknown;
			}

			return Utilities.EnumFrom<PeopleMain>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator PoliticalPreferences(VkResponse response)
		{
			if (response == null)
			{
				return PoliticalPreferences.Unknown;
			}

			return Utilities.EnumFrom<PoliticalPreferences>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator ProductAvailability(VkResponse response)
		{
			if (response == null)
			{
				return ProductAvailability.Unavailable;
			}

			return Utilities.EnumFrom<ProductAvailability>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator ProductSort(VkResponse response)
		{
			if (response == null)
			{
				return ProductSort.UserSort;
			}

			return Utilities.EnumFrom<ProductSort>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator RelationType(VkResponse response)
		{
			if (response == null)
			{
				return RelationType.Unknown;
			}

			return Utilities.EnumFrom<RelationType>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator ReportReason(VkResponse response)
		{
			if (response == null)
			{
				return ReportReason.Spam;
			}

			return Utilities.EnumFrom<ReportReason>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator Sex(VkResponse response)
		{
			if (response == null)
			{
				return Sex.Unknown;
			}

			return Utilities.EnumFrom<Sex>(response);
		}

		/// <summary>
        /// Преобразовать из VkResponse
        /// </summary>
        /// <param name="response">Ответ.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns>
		public static implicit operator WallContentAccess(VkResponse response)
		{
			if (response == null)
			{
				return WallContentAccess.Off;
			}

			return Utilities.EnumFrom<WallContentAccess>(response);
		}

	}
}