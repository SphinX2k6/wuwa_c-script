using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002734 RID: 10036
	public static class EUiOperationTypeExtensions
	{
		// Token: 0x0600D7C4 RID: 55236 RVA: 0x001F8678 File Offset: 0x001F6878
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

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x001F86C0 File Offset: 0x001F68C0
		public static EUiOperationType FromString(string name)
		{
			EUiOperationType result;
			if (!EUiOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x001F86EC File Offset: 0x001F68EC
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

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x001F8742 File Offset: 0x001F6942
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"EnableSectionalUi",
				"Disable"
			};
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x001F8762 File Offset: 0x001F6962
		public static EUiOperationType[] GetValues()
		{
			return new EUiOperationType[]
			{
				EUiOperationType.Enable,
				EUiOperationType.EnableSectionalUi,
				EUiOperationType.Disable
			};
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x001F8772 File Offset: 0x001F6972
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
