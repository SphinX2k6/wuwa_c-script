using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250C RID: 9484
	public static class EAlertSystemOptionExtensions
	{
		// Token: 0x0600CE10 RID: 52752 RVA: 0x001DE044 File Offset: 0x001DC244
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

		// Token: 0x0600CE11 RID: 52753 RVA: 0x001DE098 File Offset: 0x001DC298
		public static EAlertSystemOption FromString(string name)
		{
			EAlertSystemOption result;
			if (!EAlertSystemOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAlertSystemOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE12 RID: 52754 RVA: 0x001DE0C4 File Offset: 0x001DC2C4
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

		// Token: 0x0600CE13 RID: 52755 RVA: 0x001DE12C File Offset: 0x001DC32C
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

		// Token: 0x0600CE14 RID: 52756 RVA: 0x001DE154 File Offset: 0x001DC354
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

		// Token: 0x0600CE15 RID: 52757 RVA: 0x001DE167 File Offset: 0x001DC367
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
