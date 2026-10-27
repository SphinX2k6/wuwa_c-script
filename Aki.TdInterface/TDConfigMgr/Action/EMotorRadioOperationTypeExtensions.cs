using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002395 RID: 9109
	public static class EMotorRadioOperationTypeExtensions
	{
		// Token: 0x0600C69D RID: 50845 RVA: 0x001D16C8 File Offset: 0x001CF8C8
		public static string ToEnumString(this EMotorRadioOperationType value)
		{
			string result;
			if (value != EMotorRadioOperationType.EnableAll)
			{
				if (value != EMotorRadioOperationType.DisableAll)
				{
					result = value.ToString();
				}
				else
				{
					result = "DisableAll";
				}
			}
			else
			{
				result = "EnableAll";
			}
			return result;
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x001D1700 File Offset: 0x001CF900
		public static EMotorRadioOperationType FromString(string name)
		{
			EMotorRadioOperationType result;
			if (!EMotorRadioOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorRadioOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x001D1729 File Offset: 0x001CF929
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
			if (!(name == "DisableAll"))
			{
				value = EMotorRadioOperationType.EnableAll;
				return false;
			}
			value = EMotorRadioOperationType.DisableAll;
			return true;
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x001D1762 File Offset: 0x001CF962
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll"
			};
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x001D177A File Offset: 0x001CF97A
		public static EMotorRadioOperationType[] GetValues()
		{
			return new EMotorRadioOperationType[]
			{
				EMotorRadioOperationType.EnableAll,
				EMotorRadioOperationType.DisableAll
			};
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x001D1786 File Offset: 0x001CF986
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll"
			};
		}
	}
}
