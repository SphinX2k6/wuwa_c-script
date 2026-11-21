using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D8 RID: 9944
	public static class ESubScreenOperationTypeExtensions
	{
		// Token: 0x0600D626 RID: 54822 RVA: 0x001F1E90 File Offset: 0x001F0090
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

		// Token: 0x0600D627 RID: 54823 RVA: 0x001F1ED8 File Offset: 0x001F00D8
		public static ESubScreenOperationType FromString(string name)
		{
			ESubScreenOperationType result;
			if (!ESubScreenOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x001F1F04 File Offset: 0x001F0104
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

		// Token: 0x0600D629 RID: 54825 RVA: 0x001F1F5A File Offset: 0x001F015A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Init",
				"Adjust",
				"Exit"
			};
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x001F1F7A File Offset: 0x001F017A
		public static ESubScreenOperationType[] GetValues()
		{
			return new ESubScreenOperationType[]
			{
				ESubScreenOperationType.Init,
				ESubScreenOperationType.Adjust,
				ESubScreenOperationType.Exit
			};
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x001F1F8A File Offset: 0x001F018A
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
