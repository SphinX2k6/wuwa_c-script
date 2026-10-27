using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002491 RID: 9361
	public static class EUiOperationTypeExtensions
	{
		// Token: 0x0600CB0B RID: 51979 RVA: 0x001DE4B0 File Offset: 0x001DC6B0
		public static string ToEnumString(this EUiOperationType value)
		{
			string result;
			switch (value)
			{
			case EUiOperationType.Enable:
				result = "Enable";
				break;
			case EUiOperationType.EnableSectionalUi:
				result = "EnableSectionalUi";
				break;
			case EUiOperationType.Disable:
				result = "Disable";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x001DE4F8 File Offset: 0x001DC6F8
		public static EUiOperationType FromString(string name)
		{
			EUiOperationType result;
			if (!EUiOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x001DE524 File Offset: 0x001DC724
		public static bool TryFromString(string name, out EUiOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUiOperationType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EUiOperationType.Enable;
				return true;
			}
			if (name == "EnableSectionalUi")
			{
				value = EUiOperationType.EnableSectionalUi;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EUiOperationType.Enable;
				return false;
			}
			value = EUiOperationType.Disable;
			return true;
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x001DE57A File Offset: 0x001DC77A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"EnableSectionalUi",
				"Disable"
			};
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x001DE59A File Offset: 0x001DC79A
		public static EUiOperationType[] GetValues()
		{
			return new EUiOperationType[]
			{
				EUiOperationType.Enable,
				EUiOperationType.EnableSectionalUi,
				EUiOperationType.Disable
			};
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x001DE5AA File Offset: 0x001DC7AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"EnableSectionalUi",
				"Disable"
			};
		}
	}
}
