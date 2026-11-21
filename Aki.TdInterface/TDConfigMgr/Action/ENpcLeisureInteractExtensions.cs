using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002642 RID: 9794
	public static class ENpcLeisureInteractExtensions
	{
		// Token: 0x0600D383 RID: 54147 RVA: 0x001EBB20 File Offset: 0x001E9D20
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

		// Token: 0x0600D384 RID: 54148 RVA: 0x001EBB74 File Offset: 0x001E9D74
		public static ENpcLeisureInteract FromString(string name)
		{
			ENpcLeisureInteract result;
			if (!ENpcLeisureInteractExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcLeisureInteract 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D385 RID: 54149 RVA: 0x001EBBA0 File Offset: 0x001E9DA0
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

		// Token: 0x0600D386 RID: 54150 RVA: 0x001EBC08 File Offset: 0x001E9E08
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

		// Token: 0x0600D387 RID: 54151 RVA: 0x001EBC30 File Offset: 0x001E9E30
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

		// Token: 0x0600D388 RID: 54152 RVA: 0x001EBC43 File Offset: 0x001E9E43
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
