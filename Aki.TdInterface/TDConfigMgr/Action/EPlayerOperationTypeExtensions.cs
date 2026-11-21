using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002668 RID: 9832
	public static class EPlayerOperationTypeExtensions
	{
		// Token: 0x0600D42E RID: 54318 RVA: 0x001ED288 File Offset: 0x001EB488
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

		// Token: 0x0600D42F RID: 54319 RVA: 0x001ED2D0 File Offset: 0x001EB4D0
		public static EPlayerOperationType FromString(string name)
		{
			EPlayerOperationType result;
			if (!EPlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x001ED2FC File Offset: 0x001EB4FC
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

		// Token: 0x0600D431 RID: 54321 RVA: 0x001ED352 File Offset: 0x001EB552
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnableAll",
				"DisableAll",
				"DisableModule"
			};
		}

		// Token: 0x0600D432 RID: 54322 RVA: 0x001ED372 File Offset: 0x001EB572
		public static EPlayerOperationType[] GetValues()
		{
			return new EPlayerOperationType[]
			{
				EPlayerOperationType.EnableAll,
				EPlayerOperationType.DisableAll,
				EPlayerOperationType.DisableModule
			};
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x001ED382 File Offset: 0x001EB582
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
