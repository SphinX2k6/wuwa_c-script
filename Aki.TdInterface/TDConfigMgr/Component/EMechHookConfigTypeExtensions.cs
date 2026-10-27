using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099A RID: 2458
	public static class EMechHookConfigTypeExtensions
	{
		// Token: 0x060036E6 RID: 14054 RVA: 0x0008ED6C File Offset: 0x0008CF6C
		public static string ToEnumString(this EMechHookConfigType value)
		{
			string result;
			if (value != EMechHookConfigType.BurrowHook)
			{
				if (value != EMechHookConfigType.FixedPointHook)
				{
					result = value.ToString();
				}
				else
				{
					result = "FixedPointHook";
				}
			}
			else
			{
				result = "BurrowHook";
			}
			return result;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x0008EDA4 File Offset: 0x0008CFA4
		public static EMechHookConfigType FromString(string name)
		{
			EMechHookConfigType result;
			if (!EMechHookConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechHookConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0008EDCD File Offset: 0x0008CFCD
		public static bool TryFromString(string name, out EMechHookConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMechHookConfigType.BurrowHook;
				return false;
			}
			if (name == "BurrowHook")
			{
				value = EMechHookConfigType.BurrowHook;
				return true;
			}
			if (!(name == "FixedPointHook"))
			{
				value = EMechHookConfigType.BurrowHook;
				return false;
			}
			value = EMechHookConfigType.FixedPointHook;
			return true;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0008EE06 File Offset: 0x0008D006
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BurrowHook",
				"FixedPointHook"
			};
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x0008EE1E File Offset: 0x0008D01E
		public static EMechHookConfigType[] GetValues()
		{
			return new EMechHookConfigType[]
			{
				EMechHookConfigType.BurrowHook,
				EMechHookConfigType.FixedPointHook
			};
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x0008EE2A File Offset: 0x0008D02A
		public static string[] GetNames()
		{
			return new string[]
			{
				"BurrowHook",
				"FixedPointHook"
			};
		}
	}
}
