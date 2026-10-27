using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F1 RID: 8945
	public static class ECountDownUiStyleExtensions
	{
		// Token: 0x0600C3BB RID: 50107 RVA: 0x001C96B4 File Offset: 0x001C78B4
		public static string ToEnumString(this ECountDownUiStyle value)
		{
			string result;
			switch (value)
			{
			case ECountDownUiStyle.Common:
				result = "Common";
				break;
			case ECountDownUiStyle.MotorRacing:
				result = "MotorRacing";
				break;
			case ECountDownUiStyle.MotorFight:
				result = "MotorFight";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x001C96FC File Offset: 0x001C78FC
		public static ECountDownUiStyle FromString(string name)
		{
			ECountDownUiStyle result;
			if (!ECountDownUiStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECountDownUiStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x001C9728 File Offset: 0x001C7928
		public static bool TryFromString(string name, out ECountDownUiStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECountDownUiStyle.Common;
				return false;
			}
			if (name == "Common")
			{
				value = ECountDownUiStyle.Common;
				return true;
			}
			if (name == "MotorRacing")
			{
				value = ECountDownUiStyle.MotorRacing;
				return true;
			}
			if (!(name == "MotorFight"))
			{
				value = ECountDownUiStyle.Common;
				return false;
			}
			value = ECountDownUiStyle.MotorFight;
			return true;
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x001C977E File Offset: 0x001C797E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Common",
				"MotorRacing",
				"MotorFight"
			};
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x001C979E File Offset: 0x001C799E
		public static ECountDownUiStyle[] GetValues()
		{
			return new ECountDownUiStyle[]
			{
				ECountDownUiStyle.Common,
				ECountDownUiStyle.MotorRacing,
				ECountDownUiStyle.MotorFight
			};
		}

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x001C97AE File Offset: 0x001C79AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Common",
				"MotorRacing",
				"MotorFight"
			};
		}
	}
}
