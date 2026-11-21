using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002644 RID: 9796
	public static class EOccupationActionTypeExtensions
	{
		// Token: 0x0600D38C RID: 54156 RVA: 0x001EBCA8 File Offset: 0x001E9EA8
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

		// Token: 0x0600D38D RID: 54157 RVA: 0x001EBCE0 File Offset: 0x001E9EE0
		public static EOccupationActionType FromString(string name)
		{
			EOccupationActionType result;
			if (!EOccupationActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOccupationActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x001EBD09 File Offset: 0x001E9F09
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

		// Token: 0x0600D38F RID: 54159 RVA: 0x001EBD42 File Offset: 0x001E9F42
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Request",
				"Release"
			};
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x001EBD5A File Offset: 0x001E9F5A
		public static EOccupationActionType[] GetValues()
		{
			return new EOccupationActionType[]
			{
				EOccupationActionType.Request,
				EOccupationActionType.Release
			};
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x001EBD66 File Offset: 0x001E9F66
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
