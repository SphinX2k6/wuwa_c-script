using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232D RID: 9005
	public static class EExploreStateTypeExtensions
	{
		// Token: 0x0600C4C9 RID: 50377 RVA: 0x001CBB34 File Offset: 0x001C9D34
		public static string ToEnumString(this EExploreStateType value)
		{
			string result;
			if (value == EExploreStateType.TeleControl)
			{
				result = "TeleControl";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x001CBB5C File Offset: 0x001C9D5C
		public static EExploreStateType FromString(string name)
		{
			EExploreStateType result;
			if (!EExploreStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x001CBB85 File Offset: 0x001C9D85
		public static bool TryFromString(string name, out EExploreStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExploreStateType.TeleControl;
				return false;
			}
			if (name == "TeleControl")
			{
				value = EExploreStateType.TeleControl;
				return true;
			}
			value = EExploreStateType.TeleControl;
			return false;
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x001CBBAA File Offset: 0x001C9DAA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleControl"
			};
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x001CBBBA File Offset: 0x001C9DBA
		public static EExploreStateType[] GetValues()
		{
			return new EExploreStateType[1];
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x001CBBC2 File Offset: 0x001C9DC2
		public static string[] GetNames()
		{
			return new string[]
			{
				"TeleControl"
			};
		}
	}
}
