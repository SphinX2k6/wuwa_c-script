using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002582 RID: 9602
	public static class EEffectTypeExtensions
	{
		// Token: 0x0600D023 RID: 53283 RVA: 0x001E27A0 File Offset: 0x001E09A0
		public static string ToEnumString(this EEffectType value)
		{
			string result;
			switch (value)
			{
			case EEffectType.Effect:
				result = "Effect";
				break;
			case EEffectType.ScreenEffect:
				result = "ScreenEffect";
				break;
			case EEffectType.DissolveEffect:
				result = "DissolveEffect";
				break;
			case EEffectType.MpcEffect:
				result = "MpcEffect";
				break;
			case EEffectType.SwitchEffectState:
				result = "SwitchEffectState";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D024 RID: 53284 RVA: 0x001E2800 File Offset: 0x001E0A00
		public static EEffectType FromString(string name)
		{
			EEffectType result;
			if (!EEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D025 RID: 53285 RVA: 0x001E282C File Offset: 0x001E0A2C
		public static bool TryFromString(string name, out EEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEffectType.Effect;
				return false;
			}
			if (name == "Effect")
			{
				value = EEffectType.Effect;
				return true;
			}
			if (name == "ScreenEffect")
			{
				value = EEffectType.ScreenEffect;
				return true;
			}
			if (name == "DissolveEffect")
			{
				value = EEffectType.DissolveEffect;
				return true;
			}
			if (name == "MpcEffect")
			{
				value = EEffectType.MpcEffect;
				return true;
			}
			if (!(name == "SwitchEffectState"))
			{
				value = EEffectType.Effect;
				return false;
			}
			value = EEffectType.SwitchEffectState;
			return true;
		}

		// Token: 0x0600D026 RID: 53286 RVA: 0x001E28A6 File Offset: 0x001E0AA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Effect",
				"ScreenEffect",
				"DissolveEffect",
				"MpcEffect",
				"SwitchEffectState"
			};
		}

		// Token: 0x0600D027 RID: 53287 RVA: 0x001E28D6 File Offset: 0x001E0AD6
		public static EEffectType[] GetValues()
		{
			return new EEffectType[]
			{
				EEffectType.Effect,
				EEffectType.ScreenEffect,
				EEffectType.DissolveEffect,
				EEffectType.MpcEffect,
				EEffectType.SwitchEffectState
			};
		}

		// Token: 0x0600D028 RID: 53288 RVA: 0x001E28E9 File Offset: 0x001E0AE9
		public static string[] GetNames()
		{
			return new string[]
			{
				"Effect",
				"ScreenEffect",
				"DissolveEffect",
				"MpcEffect",
				"SwitchEffectState"
			};
		}
	}
}
