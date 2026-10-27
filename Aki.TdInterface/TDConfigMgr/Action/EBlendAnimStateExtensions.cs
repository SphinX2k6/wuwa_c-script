using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BD RID: 8893
	public static class EBlendAnimStateExtensions
	{
		// Token: 0x0600C2D1 RID: 49873 RVA: 0x001C76EC File Offset: 0x001C58EC
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

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x001C774C File Offset: 0x001C594C
		public static EBlendAnimState FromString(string name)
		{
			EBlendAnimState result;
			if (!EBlendAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x001C7778 File Offset: 0x001C5978
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

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x001C77F2 File Offset: 0x001C59F2
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

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x001C7822 File Offset: 0x001C5A22
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

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x001C7835 File Offset: 0x001C5A35
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
