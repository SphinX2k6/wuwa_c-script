using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B1 RID: 9137
	public static class ENpcLeisureInteractExtensions
	{
		// Token: 0x0600C71B RID: 50971 RVA: 0x001D26EC File Offset: 0x001D08EC
		public static string ToEnumString(this ENpcLeisureInteract value)
		{
			string result;
			switch (value)
			{
			case ENpcLeisureInteract.SitDown:
				result = "SitDown";
				break;
			case ENpcLeisureInteract.Swing:
				result = "Swing";
				break;
			case ENpcLeisureInteract.SwingGetUp:
				result = "SwingGetUp";
				break;
			case ENpcLeisureInteract.ExitCurrentInteract:
				result = "ExitCurrentInteract";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x001D2740 File Offset: 0x001D0940
		public static ENpcLeisureInteract FromString(string name)
		{
			ENpcLeisureInteract result;
			if (!ENpcLeisureInteractExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcLeisureInteract 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x001D276C File Offset: 0x001D096C
		public static bool TryFromString(string name, out ENpcLeisureInteract value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcLeisureInteract.SitDown;
				return false;
			}
			if (name == "SitDown")
			{
				value = ENpcLeisureInteract.SitDown;
				return true;
			}
			if (name == "Swing")
			{
				value = ENpcLeisureInteract.Swing;
				return true;
			}
			if (name == "SwingGetUp")
			{
				value = ENpcLeisureInteract.SwingGetUp;
				return true;
			}
			if (!(name == "ExitCurrentInteract"))
			{
				value = ENpcLeisureInteract.SitDown;
				return false;
			}
			value = ENpcLeisureInteract.ExitCurrentInteract;
			return true;
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x001D27D4 File Offset: 0x001D09D4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SitDown",
				"Swing",
				"SwingGetUp",
				"ExitCurrentInteract"
			};
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x001D27FC File Offset: 0x001D09FC
		public static ENpcLeisureInteract[] GetValues()
		{
			return new ENpcLeisureInteract[]
			{
				ENpcLeisureInteract.SitDown,
				ENpcLeisureInteract.Swing,
				ENpcLeisureInteract.SwingGetUp,
				ENpcLeisureInteract.ExitCurrentInteract
			};
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x001D280F File Offset: 0x001D0A0F
		public static string[] GetNames()
		{
			return new string[]
			{
				"SitDown",
				"Swing",
				"SwingGetUp",
				"ExitCurrentInteract"
			};
		}
	}
}
