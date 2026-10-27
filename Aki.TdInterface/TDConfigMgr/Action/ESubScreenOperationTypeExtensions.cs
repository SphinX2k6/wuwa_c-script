using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002437 RID: 9271
	public static class ESubScreenOperationTypeExtensions
	{
		// Token: 0x0600C976 RID: 51574 RVA: 0x001D7FC8 File Offset: 0x001D61C8
		public static string ToEnumString(this ESubScreenOperationType value)
		{
			string result;
			switch (value)
			{
			case ESubScreenOperationType.Init:
				result = "Init";
				break;
			case ESubScreenOperationType.Adjust:
				result = "Adjust";
				break;
			case ESubScreenOperationType.Exit:
				result = "Exit";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x001D8010 File Offset: 0x001D6210
		public static ESubScreenOperationType FromString(string name)
		{
			ESubScreenOperationType result;
			if (!ESubScreenOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C978 RID: 51576 RVA: 0x001D803C File Offset: 0x001D623C
		public static bool TryFromString(string name, out ESubScreenOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESubScreenOperationType.Init;
				return false;
			}
			if (name == "Init")
			{
				value = ESubScreenOperationType.Init;
				return true;
			}
			if (name == "Adjust")
			{
				value = ESubScreenOperationType.Adjust;
				return true;
			}
			if (!(name == "Exit"))
			{
				value = ESubScreenOperationType.Init;
				return false;
			}
			value = ESubScreenOperationType.Exit;
			return true;
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x001D8092 File Offset: 0x001D6292
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Init",
				"Adjust",
				"Exit"
			};
		}

		// Token: 0x0600C97A RID: 51578 RVA: 0x001D80B2 File Offset: 0x001D62B2
		public static ESubScreenOperationType[] GetValues()
		{
			return new ESubScreenOperationType[]
			{
				ESubScreenOperationType.Init,
				ESubScreenOperationType.Adjust,
				ESubScreenOperationType.Exit
			};
		}

		// Token: 0x0600C97B RID: 51579 RVA: 0x001D80C2 File Offset: 0x001D62C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Init",
				"Adjust",
				"Exit"
			};
		}
	}
}
