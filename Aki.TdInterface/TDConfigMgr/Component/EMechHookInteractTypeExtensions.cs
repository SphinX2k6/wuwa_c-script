using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4D RID: 2637
	public static class EMechHookInteractTypeExtensions
	{
		// Token: 0x06003A6D RID: 14957 RVA: 0x00096CD8 File Offset: 0x00094ED8
		public static string ToEnumString(this EMechHookInteractType value)
		{
			string result;
			switch (value)
			{
			case EMechHookInteractType.FixedPointHook:
				result = "FixedPointHook";
				break;
			case EMechHookInteractType.BurrowHook:
				result = "BurrowHook";
				break;
			case EMechHookInteractType.MechPullInteract:
				result = "MechPullInteract";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00096D20 File Offset: 0x00094F20
		public static EMechHookInteractType FromString(string name)
		{
			EMechHookInteractType result;
			if (!EMechHookInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechHookInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00096D4C File Offset: 0x00094F4C
		public static bool TryFromString(string name, out EMechHookInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMechHookInteractType.FixedPointHook;
				return false;
			}
			if (name == "FixedPointHook")
			{
				value = EMechHookInteractType.FixedPointHook;
				return true;
			}
			if (name == "BurrowHook")
			{
				value = EMechHookInteractType.BurrowHook;
				return true;
			}
			if (!(name == "MechPullInteract"))
			{
				value = EMechHookInteractType.FixedPointHook;
				return false;
			}
			value = EMechHookInteractType.MechPullInteract;
			return true;
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00096DA2 File Offset: 0x00094FA2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixedPointHook",
				"BurrowHook",
				"MechPullInteract"
			};
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00096DC2 File Offset: 0x00094FC2
		public static EMechHookInteractType[] GetValues()
		{
			return new EMechHookInteractType[]
			{
				EMechHookInteractType.FixedPointHook,
				EMechHookInteractType.BurrowHook,
				EMechHookInteractType.MechPullInteract
			};
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00096DD2 File Offset: 0x00094FD2
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixedPointHook",
				"BurrowHook",
				"MechPullInteract"
			};
		}
	}
}
