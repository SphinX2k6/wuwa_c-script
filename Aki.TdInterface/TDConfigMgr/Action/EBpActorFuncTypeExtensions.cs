using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C3 RID: 8899
	public static class EBpActorFuncTypeExtensions
	{
		// Token: 0x0600C2EC RID: 49900 RVA: 0x001C7A94 File Offset: 0x001C5C94
		public static string ToEnumString(this EBpActorFuncType value)
		{
			string result;
			if (value != EBpActorFuncType.CarPaintChange)
			{
				if (value != EBpActorFuncType.BrokenBridgeEffectInMobile)
				{
					result = value.ToString();
				}
				else
				{
					result = "BrokenBridgeEffectInMobile";
				}
			}
			else
			{
				result = "CarPaintChange";
			}
			return result;
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x001C7ACC File Offset: 0x001C5CCC
		public static EBpActorFuncType FromString(string name)
		{
			EBpActorFuncType result;
			if (!EBpActorFuncTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBpActorFuncType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2EE RID: 49902 RVA: 0x001C7AF5 File Offset: 0x001C5CF5
		public static bool TryFromString(string name, out EBpActorFuncType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBpActorFuncType.CarPaintChange;
				return false;
			}
			if (name == "CarPaintChange")
			{
				value = EBpActorFuncType.CarPaintChange;
				return true;
			}
			if (!(name == "BrokenBridgeEffectInMobile"))
			{
				value = EBpActorFuncType.CarPaintChange;
				return false;
			}
			value = EBpActorFuncType.BrokenBridgeEffectInMobile;
			return true;
		}

		// Token: 0x0600C2EF RID: 49903 RVA: 0x001C7B2E File Offset: 0x001C5D2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CarPaintChange",
				"BrokenBridgeEffectInMobile"
			};
		}

		// Token: 0x0600C2F0 RID: 49904 RVA: 0x001C7B46 File Offset: 0x001C5D46
		public static EBpActorFuncType[] GetValues()
		{
			return new EBpActorFuncType[]
			{
				EBpActorFuncType.CarPaintChange,
				EBpActorFuncType.BrokenBridgeEffectInMobile
			};
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x001C7B52 File Offset: 0x001C5D52
		public static string[] GetNames()
		{
			return new string[]
			{
				"CarPaintChange",
				"BrokenBridgeEffectInMobile"
			};
		}
	}
}
