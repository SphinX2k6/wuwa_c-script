using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002560 RID: 9568
	public static class ECountDownUiStyleExtensions
	{
		// Token: 0x0600CF8A RID: 53130 RVA: 0x001E1500 File Offset: 0x001DF700
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

		// Token: 0x0600CF8B RID: 53131 RVA: 0x001E1548 File Offset: 0x001DF748
		public static ECountDownUiStyle FromString(string name)
		{
			ECountDownUiStyle result;
			if (!ECountDownUiStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECountDownUiStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x001E1574 File Offset: 0x001DF774
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

		// Token: 0x0600CF8D RID: 53133 RVA: 0x001E15CA File Offset: 0x001DF7CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Common",
				"MotorRacing",
				"MotorFight"
			};
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x001E15EA File Offset: 0x001DF7EA
		public static ECountDownUiStyle[] GetValues()
		{
			return new ECountDownUiStyle[]
			{
				ECountDownUiStyle.Common,
				ECountDownUiStyle.MotorRacing,
				ECountDownUiStyle.MotorFight
			};
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x001E15FA File Offset: 0x001DF7FA
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
