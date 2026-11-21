using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252C RID: 9516
	public static class EBlendAnimStateExtensions
	{
		// Token: 0x0600CEA0 RID: 52896 RVA: 0x001DF4F4 File Offset: 0x001DD6F4
		public static string ToEnumString(this EBlendAnimState value)
		{
			string result;
			switch (value)
			{
			case EBlendAnimState.CombatIdle:
				result = "CombatIdle";
				break;
			case EBlendAnimState.Fall:
				result = "Fall";
				break;
			case EBlendAnimState.Slide:
				result = "Slide";
				break;
			case EBlendAnimState.Run:
				result = "Run";
				break;
			case EBlendAnimState.Walk:
				result = "Walk";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x001DF554 File Offset: 0x001DD754
		public static EBlendAnimState FromString(string name)
		{
			EBlendAnimState result;
			if (!EBlendAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x001DF580 File Offset: 0x001DD780
		public static bool TryFromString(string name, out EBlendAnimState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBlendAnimState.CombatIdle;
				return false;
			}
			if (name == "CombatIdle")
			{
				value = EBlendAnimState.CombatIdle;
				return true;
			}
			if (name == "Fall")
			{
				value = EBlendAnimState.Fall;
				return true;
			}
			if (name == "Slide")
			{
				value = EBlendAnimState.Slide;
				return true;
			}
			if (name == "Run")
			{
				value = EBlendAnimState.Run;
				return true;
			}
			if (!(name == "Walk"))
			{
				value = EBlendAnimState.CombatIdle;
				return false;
			}
			value = EBlendAnimState.Walk;
			return true;
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x001DF5FA File Offset: 0x001DD7FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CombatIdle",
				"Fall",
				"Slide",
				"Run",
				"Walk"
			};
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x001DF62A File Offset: 0x001DD82A
		public static EBlendAnimState[] GetValues()
		{
			return new EBlendAnimState[]
			{
				EBlendAnimState.CombatIdle,
				EBlendAnimState.Fall,
				EBlendAnimState.Slide,
				EBlendAnimState.Run,
				EBlendAnimState.Walk
			};
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x001DF63D File Offset: 0x001DD83D
		public static string[] GetNames()
		{
			return new string[]
			{
				"CombatIdle",
				"Fall",
				"Slide",
				"Run",
				"Walk"
			};
		}
	}
}
