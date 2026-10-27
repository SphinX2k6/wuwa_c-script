using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229F RID: 8863
	public static class EAlertSystemOptionExtensions
	{
		// Token: 0x0600C24A RID: 49738 RVA: 0x001C6350 File Offset: 0x001C4550
		public static string ToEnumString(this EAlertSystemOption value)
		{
			string result;
			switch (value)
			{
			case EAlertSystemOption.EnableAlertArea:
				result = "EnableAlertArea";
				break;
			case EAlertSystemOption.ModifyAlertValue:
				result = "ModifyAlertValue";
				break;
			case EAlertSystemOption.EnableAlertUi:
				result = "EnableAlertUi";
				break;
			case EAlertSystemOption.SetAlertUiVisible:
				result = "SetAlertUiVisible";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x001C63A4 File Offset: 0x001C45A4
		public static EAlertSystemOption FromString(string name)
		{
			EAlertSystemOption result;
			if (!EAlertSystemOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAlertSystemOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C24C RID: 49740 RVA: 0x001C63D0 File Offset: 0x001C45D0
		public static bool TryFromString(string name, out EAlertSystemOption value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAlertSystemOption.EnableAlertArea;
				return false;
			}
			if (name == "EnableAlertArea")
			{
				value = EAlertSystemOption.EnableAlertArea;
				return true;
			}
			if (name == "ModifyAlertValue")
			{
				value = EAlertSystemOption.ModifyAlertValue;
				return true;
			}
			if (name == "EnableAlertUi")
			{
				value = EAlertSystemOption.EnableAlertUi;
				return true;
			}
			if (!(name == "SetAlertUiVisible"))
			{
				value = EAlertSystemOption.EnableAlertArea;
				return false;
			}
			value = EAlertSystemOption.SetAlertUiVisible;
			return true;
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x001C6438 File Offset: 0x001C4638
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnableAlertArea",
				"ModifyAlertValue",
				"EnableAlertUi",
				"SetAlertUiVisible"
			};
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x001C6460 File Offset: 0x001C4660
		public static EAlertSystemOption[] GetValues()
		{
			return new EAlertSystemOption[]
			{
				EAlertSystemOption.EnableAlertArea,
				EAlertSystemOption.ModifyAlertValue,
				EAlertSystemOption.EnableAlertUi,
				EAlertSystemOption.SetAlertUiVisible
			};
		}

		// Token: 0x0600C24F RID: 49743 RVA: 0x001C6473 File Offset: 0x001C4673
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnableAlertArea",
				"ModifyAlertValue",
				"EnableAlertUi",
				"SetAlertUiVisible"
			};
		}
	}
}
