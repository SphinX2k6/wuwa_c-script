using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002313 RID: 8979
	public static class EEffectTypeExtensions
	{
		// Token: 0x0600C454 RID: 50260 RVA: 0x001CA8D8 File Offset: 0x001C8AD8
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

		// Token: 0x0600C455 RID: 50261 RVA: 0x001CA938 File Offset: 0x001C8B38
		public static EEffectType FromString(string name)
		{
			EEffectType result;
			if (!EEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C456 RID: 50262 RVA: 0x001CA964 File Offset: 0x001C8B64
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

		// Token: 0x0600C457 RID: 50263 RVA: 0x001CA9DE File Offset: 0x001C8BDE
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

		// Token: 0x0600C458 RID: 50264 RVA: 0x001CAA0E File Offset: 0x001C8C0E
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

		// Token: 0x0600C459 RID: 50265 RVA: 0x001CAA21 File Offset: 0x001C8C21
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
