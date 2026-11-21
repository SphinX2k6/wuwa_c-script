using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001400 RID: 5120
	public static class EWarningPreformTypeExtensions
	{
		// Token: 0x0600725A RID: 29274 RVA: 0x00111C1C File Offset: 0x0010FE1C
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

		// Token: 0x0600725B RID: 29275 RVA: 0x00111C54 File Offset: 0x0010FE54
		public static EWarningPreformType FromString(string name)
		{
			EWarningPreformType result;
			if (!EWarningPreformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWarningPreformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x00111C7D File Offset: 0x0010FE7D
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

		// Token: 0x0600725D RID: 29277 RVA: 0x00111CB6 File Offset: 0x0010FEB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FadeInScreen",
				"ActivateStateRecordEntity"
			};
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00111CCE File Offset: 0x0010FECE
		public static EWarningPreformType[] GetValues()
		{
			return new EWarningPreformType[]
			{
				EWarningPreformType.FadeInScreen,
				EWarningPreformType.ActivateStateRecordEntity
			};
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00111CDA File Offset: 0x0010FEDA
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
