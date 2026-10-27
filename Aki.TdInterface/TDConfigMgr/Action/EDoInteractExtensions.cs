using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002307 RID: 8967
	public static class EDoInteractExtensions
	{
		// Token: 0x0600C41E RID: 50206 RVA: 0x001CA280 File Offset: 0x001C8480
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

		// Token: 0x0600C41F RID: 50207 RVA: 0x001CA2C8 File Offset: 0x001C84C8
		public static EDoInteract FromString(string name)
		{
			EDoInteract result;
			if (!EDoInteractExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDoInteract 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x001CA2F4 File Offset: 0x001C84F4
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

		// Token: 0x0600C421 RID: 50209 RVA: 0x001CA34A File Offset: 0x001C854A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Direct",
				"Option",
				"Auto"
			};
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x001CA36A File Offset: 0x001C856A
		public static EDoInteract[] GetValues()
		{
			return new EDoInteract[]
			{
				EDoInteract.Direct,
				EDoInteract.Option,
				EDoInteract.Auto
			};
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x001CA37A File Offset: 0x001C857A
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
