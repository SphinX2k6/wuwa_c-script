using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002532 RID: 9522
	public static class EBpActorFuncTypeExtensions
	{
		// Token: 0x0600CEBB RID: 52923 RVA: 0x001DF89C File Offset: 0x001DDA9C
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

		// Token: 0x0600CEBC RID: 52924 RVA: 0x001DF8D4 File Offset: 0x001DDAD4
		public static EBpActorFuncType FromString(string name)
		{
			EBpActorFuncType result;
			if (!EBpActorFuncTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBpActorFuncType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEBD RID: 52925 RVA: 0x001DF8FD File Offset: 0x001DDAFD
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

		// Token: 0x0600CEBE RID: 52926 RVA: 0x001DF936 File Offset: 0x001DDB36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CarPaintChange",
				"BrokenBridgeEffectInMobile"
			};
		}

		// Token: 0x0600CEBF RID: 52927 RVA: 0x001DF94E File Offset: 0x001DDB4E
		public static EBpActorFuncType[] GetValues()
		{
			return new EBpActorFuncType[]
			{
				EBpActorFuncType.CarPaintChange,
				EBpActorFuncType.BrokenBridgeEffectInMobile
			};
		}

		// Token: 0x0600CEC0 RID: 52928 RVA: 0x001DF95A File Offset: 0x001DDB5A
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
