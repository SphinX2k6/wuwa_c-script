using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237D RID: 9085
	public static class EMapMarkStateExtensions
	{
		// Token: 0x0600C631 RID: 50737 RVA: 0x001D084C File Offset: 0x001CEA4C
		public static string ToEnumString(this EMapMarkState value)
		{
			string result;
			switch (value)
			{
			case EMapMarkState.Show:
				result = "Show";
				break;
			case EMapMarkState.Hide:
				result = "Hide";
				break;
			case EMapMarkState.Disable:
				result = "Disable";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x001D0894 File Offset: 0x001CEA94
		public static EMapMarkState FromString(string name)
		{
			EMapMarkState result;
			if (!EMapMarkStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapMarkState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x001D08C0 File Offset: 0x001CEAC0
		public static bool TryFromString(string name, out EMapMarkState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMapMarkState.Show;
				return false;
			}
			if (name == "Show")
			{
				value = EMapMarkState.Show;
				return true;
			}
			if (name == "Hide")
			{
				value = EMapMarkState.Hide;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EMapMarkState.Show;
				return false;
			}
			value = EMapMarkState.Disable;
			return true;
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x001D0916 File Offset: 0x001CEB16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"Disable"
			};
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x001D0936 File Offset: 0x001CEB36
		public static EMapMarkState[] GetValues()
		{
			return new EMapMarkState[]
			{
				EMapMarkState.Show,
				EMapMarkState.Hide,
				EMapMarkState.Disable
			};
		}

		// Token: 0x0600C636 RID: 50742 RVA: 0x001D0946 File Offset: 0x001CEB46
		public static string[] GetNames()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"Disable"
			};
		}
	}
}
