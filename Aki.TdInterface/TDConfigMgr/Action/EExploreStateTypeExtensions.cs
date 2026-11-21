using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259E RID: 9630
	public static class EExploreStateTypeExtensions
	{
		// Token: 0x0600D0A1 RID: 53409 RVA: 0x001E3BEC File Offset: 0x001E1DEC
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

		// Token: 0x0600D0A2 RID: 53410 RVA: 0x001E3C14 File Offset: 0x001E1E14
		public static EExploreStateType FromString(string name)
		{
			EExploreStateType result;
			if (!EExploreStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x001E3C3D File Offset: 0x001E1E3D
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

		// Token: 0x0600D0A4 RID: 53412 RVA: 0x001E3C62 File Offset: 0x001E1E62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleControl"
			};
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x001E3C72 File Offset: 0x001E1E72
		public static EExploreStateType[] GetValues()
		{
			return new EExploreStateType[1];
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x001E3C7A File Offset: 0x001E1E7A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TeleControl"
			};
		}
	}
}
