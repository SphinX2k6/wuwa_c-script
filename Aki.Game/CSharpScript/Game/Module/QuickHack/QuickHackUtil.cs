using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F77 RID: 20343
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackUtil
	{
		// Token: 0x0603419F RID: 213407 RVA: 0x00C3A16C File Offset: 0x00C3836C
		[NullableContext(1)]
		public static string GetFailTextIdByCondition(EQuickHackSkillCondition? condition)
		{
			string result = "QuickHack_Prohibit_1";
			if (condition == null)
			{
				return result;
			}
			if (condition != null)
			{
				switch (condition.GetValueOrDefault())
				{
				case EQuickHackSkillCondition.CheckTargetTypeMatch:
					return "QuickHack_Prohibit_2";
				case EQuickHackSkillCondition.CheckRamEnough:
					return "QuickHack_Prohibit_3";
				case EQuickHackSkillCondition.CheckUsageCountEnough:
					return "QuickHack_Prohibit_4";
				case EQuickHackSkillCondition.CheckAnyMonsterTypeMatch:
					return "QuickHack_Prohibit_5";
				case EQuickHackSkillCondition.CheckAnySceneItemCanHack:
				case EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill:
					return "QuickHack_Prohibit_6";
				}
			}
			return result;
		}

		// Token: 0x060341A0 RID: 213408 RVA: 0x00C3A1DA File Offset: 0x00C383DA
		public static QuickHackRamManager CreateRamManager(EQuickHackRamManagerType type)
		{
			if (type == EQuickHackRamManagerType.Fix)
			{
				return new QuickHackFixRamManager();
			}
			if (type != EQuickHackRamManagerType.FormationAttribute)
			{
				return null;
			}
			return new QuickHackFormationAttributeRamManager();
		}

		// Token: 0x060341A1 RID: 213409 RVA: 0x00C3A1F2 File Offset: 0x00C383F2
		public static QuickHackTargetSelector CreateTargetSelector(EQuickHackTargetSelectorType type)
		{
			switch (type)
			{
			case EQuickHackTargetSelectorType.EnemyMonsterOnScreen:
				return new QuickHackMonsterOnScreenTargetSelector();
			case EQuickHackTargetSelectorType.Aim:
				return new QuickHackAimTargetSelector();
			case EQuickHackTargetSelectorType.SceneItemOnScreen:
				return new QuickHackSceneItemOnScreenTargetSelector();
			default:
				return null;
			}
		}

		// Token: 0x060341A2 RID: 213410 RVA: 0x00C3A21B File Offset: 0x00C3841B
		public static IQuickHackTimeScaleManager CreateTimeScaleManager(EQuickHackTimeScaleMode type)
		{
			if (type == EQuickHackTimeScaleMode.WorldTimeDilation)
			{
				return new QuickHackWorldTimeDilationManager();
			}
			if (type != EQuickHackTimeScaleMode.AbsoluteTimeStop)
			{
				return null;
			}
			return new QuickHackAbsoluteTimeStopManager();
		}
	}
}
