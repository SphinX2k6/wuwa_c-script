using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002620 RID: 9760
	public static class EMotorRadioOperationTypeExtensions
	{
		// Token: 0x0600D2EA RID: 53994 RVA: 0x001EA7F4 File Offset: 0x001E89F4
		public static string ToEnumString(this EMotorRadioOperationType value)
		{
			string result;
			switch (value)
			{
			case EMotorRadioOperationType.EnableAll:
				result = "EnableAll";
				break;
			case EMotorRadioOperationType.DisableAll:
				result = "DisableAll";
				break;
			case EMotorRadioOperationType.EnableInRange:
				result = "EnableInRange";
				break;
			case EMotorRadioOperationType.DisableInRange:
				result = "DisableInRange";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D2EB RID: 53995 RVA: 0x001EA848 File Offset: 0x001E8A48
		public static EMotorRadioOperationType FromString(string name)
		{
			EMotorRadioOperationType result;
			if (!EMotorRadioOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorRadioOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2EC RID: 53996 RVA: 0x001EA874 File Offset: 0x001E8A74
		public static bool TryFromString(string name, out EMotorRadioOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorRadioOperationType.EnableAll;
				return false;
			}
			if (name == "EnableAll")
			{
				value = EMotorRadioOperationType.EnableAll;
				return true;
			}
			if (name == "DisableAll")
			{
				value = EMotorRadioOperationType.DisableAll;
				return true;
			}
			if (name == "EnableInRange")
			{
				value = EMotorRadioOperationType.EnableInRange;
				return true;
			}
			if (!(name == "DisableInRange"))
			{
				value = EMotorRadioOperationType.EnableAll;
				return false;
			}
			value = EMotorRadioOperationType.DisableInRange;
			return true;
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x001EA8DC File Offset: 0x001E8ADC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll",
				"EnableInRange",
				"DisableInRange"
			};
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x001EA904 File Offset: 0x001E8B04
		public static EMotorRadioOperationType[] GetValues()
		{
			return new EMotorRadioOperationType[]
			{
				EMotorRadioOperationType.EnableAll,
				EMotorRadioOperationType.DisableAll,
				EMotorRadioOperationType.EnableInRange,
				EMotorRadioOperationType.DisableInRange
			};
		}

		// Token: 0x0600D2EF RID: 53999 RVA: 0x001EA917 File Offset: 0x001E8B17
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll",
				"EnableInRange",
				"DisableInRange"
			};
		}
	}
}
