using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D1 RID: 9169
	public static class EPlayerOperationTypeExtensions
	{
		// Token: 0x0600C7AB RID: 51115 RVA: 0x001D3ADC File Offset: 0x001D1CDC
		public static string ToEnumString(this EPlayerOperationType value)
		{
			string result;
			switch (value)
			{
			case EPlayerOperationType.EnableAll:
				result = "EnableAll";
				break;
			case EPlayerOperationType.DisableAll:
				result = "DisableAll";
				break;
			case EPlayerOperationType.DisableModule:
				result = "DisableModule";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C7AC RID: 51116 RVA: 0x001D3B24 File Offset: 0x001D1D24
		public static EPlayerOperationType FromString(string name)
		{
			EPlayerOperationType result;
			if (!EPlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7AD RID: 51117 RVA: 0x001D3B50 File Offset: 0x001D1D50
		public static bool TryFromString(string name, out EPlayerOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerOperationType.EnableAll;
				return false;
			}
			if (name == "EnableAll")
			{
				value = EPlayerOperationType.EnableAll;
				return true;
			}
			if (name == "DisableAll")
			{
				value = EPlayerOperationType.DisableAll;
				return true;
			}
			if (!(name == "DisableModule"))
			{
				value = EPlayerOperationType.EnableAll;
				return false;
			}
			value = EPlayerOperationType.DisableModule;
			return true;
		}

		// Token: 0x0600C7AE RID: 51118 RVA: 0x001D3BA6 File Offset: 0x001D1DA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll",
				"DisableModule"
			};
		}

		// Token: 0x0600C7AF RID: 51119 RVA: 0x001D3BC6 File Offset: 0x001D1DC6
		public static EPlayerOperationType[] GetValues()
		{
			return new EPlayerOperationType[]
			{
				EPlayerOperationType.EnableAll,
				EPlayerOperationType.DisableAll,
				EPlayerOperationType.DisableModule
			};
		}

		// Token: 0x0600C7B0 RID: 51120 RVA: 0x001D3BD6 File Offset: 0x001D1DD6
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll",
				"DisableModule"
			};
		}
	}
}
