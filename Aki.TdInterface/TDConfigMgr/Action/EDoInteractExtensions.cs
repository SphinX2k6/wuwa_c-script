using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002576 RID: 9590
	public static class EDoInteractExtensions
	{
		// Token: 0x0600CFED RID: 53229 RVA: 0x001E2148 File Offset: 0x001E0348
		public static string ToEnumString(this EDoInteract value)
		{
			string result;
			switch (value)
			{
			case EDoInteract.Direct:
				result = "Direct";
				break;
			case EDoInteract.Option:
				result = "Option";
				break;
			case EDoInteract.Auto:
				result = "Auto";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x001E2190 File Offset: 0x001E0390
		public static EDoInteract FromString(string name)
		{
			EDoInteract result;
			if (!EDoInteractExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDoInteract 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFEF RID: 53231 RVA: 0x001E21BC File Offset: 0x001E03BC
		public static bool TryFromString(string name, out EDoInteract value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDoInteract.Direct;
				return false;
			}
			if (name == "Direct")
			{
				value = EDoInteract.Direct;
				return true;
			}
			if (name == "Option")
			{
				value = EDoInteract.Option;
				return true;
			}
			if (!(name == "Auto"))
			{
				value = EDoInteract.Direct;
				return false;
			}
			value = EDoInteract.Auto;
			return true;
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x001E2212 File Offset: 0x001E0412
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Direct",
				"Option",
				"Auto"
			};
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x001E2232 File Offset: 0x001E0432
		public static EDoInteract[] GetValues()
		{
			return new EDoInteract[]
			{
				EDoInteract.Direct,
				EDoInteract.Option,
				EDoInteract.Auto
			};
		}

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x001E2242 File Offset: 0x001E0442
		public static string[] GetNames()
		{
			return new string[]
			{
				"Direct",
				"Option",
				"Auto"
			};
		}
	}
}
