using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B3 RID: 9139
	public static class EOccupationActionTypeExtensions
	{
		// Token: 0x0600C724 RID: 50980 RVA: 0x001D2874 File Offset: 0x001D0A74
		public static string ToEnumString(this EOccupationActionType value)
		{
			string result;
			if (value != EOccupationActionType.Request)
			{
				if (value != EOccupationActionType.Release)
				{
					result = value.ToString();
				}
				else
				{
					result = "Release";
				}
			}
			else
			{
				result = "Request";
			}
			return result;
		}

		// Token: 0x0600C725 RID: 50981 RVA: 0x001D28AC File Offset: 0x001D0AAC
		public static EOccupationActionType FromString(string name)
		{
			EOccupationActionType result;
			if (!EOccupationActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOccupationActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C726 RID: 50982 RVA: 0x001D28D5 File Offset: 0x001D0AD5
		public static bool TryFromString(string name, out EOccupationActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOccupationActionType.Request;
				return false;
			}
			if (name == "Request")
			{
				value = EOccupationActionType.Request;
				return true;
			}
			if (!(name == "Release"))
			{
				value = EOccupationActionType.Request;
				return false;
			}
			value = EOccupationActionType.Release;
			return true;
		}

		// Token: 0x0600C727 RID: 50983 RVA: 0x001D290E File Offset: 0x001D0B0E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Request",
				"Release"
			};
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x001D2926 File Offset: 0x001D0B26
		public static EOccupationActionType[] GetValues()
		{
			return new EOccupationActionType[]
			{
				EOccupationActionType.Request,
				EOccupationActionType.Release
			};
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x001D2932 File Offset: 0x001D0B32
		public static string[] GetNames()
		{
			return new string[]
			{
				"Request",
				"Release"
			};
		}
	}
}
