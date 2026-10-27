using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BA RID: 4794
	public static class EWarningPreformTypeExtensions
	{
		// Token: 0x06006BEC RID: 27628 RVA: 0x00103C54 File Offset: 0x00101E54
		public static string ToEnumString(this EWarningPreformType value)
		{
			string result;
			if (value != EWarningPreformType.FadeInScreen)
			{
				if (value != EWarningPreformType.ActivateStateRecordEntity)
				{
					result = value.ToString();
				}
				else
				{
					result = "ActivateStateRecordEntity";
				}
			}
			else
			{
				result = "FadeInScreen";
			}
			return result;
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x00103C8C File Offset: 0x00101E8C
		public static EWarningPreformType FromString(string name)
		{
			EWarningPreformType result;
			if (!EWarningPreformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWarningPreformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x00103CB5 File Offset: 0x00101EB5
		public static bool TryFromString(string name, out EWarningPreformType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWarningPreformType.FadeInScreen;
				return false;
			}
			if (name == "FadeInScreen")
			{
				value = EWarningPreformType.FadeInScreen;
				return true;
			}
			if (!(name == "ActivateStateRecordEntity"))
			{
				value = EWarningPreformType.FadeInScreen;
				return false;
			}
			value = EWarningPreformType.ActivateStateRecordEntity;
			return true;
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00103CEE File Offset: 0x00101EEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FadeInScreen",
				"ActivateStateRecordEntity"
			};
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00103D06 File Offset: 0x00101F06
		public static EWarningPreformType[] GetValues()
		{
			return new EWarningPreformType[]
			{
				EWarningPreformType.FadeInScreen,
				EWarningPreformType.ActivateStateRecordEntity
			};
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00103D12 File Offset: 0x00101F12
		public static string[] GetNames()
		{
			return new string[]
			{
				"FadeInScreen",
				"ActivateStateRecordEntity"
			};
		}
	}
}
