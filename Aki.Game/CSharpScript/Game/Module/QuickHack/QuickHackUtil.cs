using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F40 RID: 16192
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackUtil
	{
		// Token: 0x0602900D RID: 167949 RVA: 0x00B83918 File Offset: 0x00B81B18
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

		// Token: 0x0602900E RID: 167950 RVA: 0x00B83986 File Offset: 0x00B81B86
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

		// Token: 0x0602900F RID: 167951 RVA: 0x00B8399E File Offset: 0x00B81B9E
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

		// Token: 0x06029010 RID: 167952 RVA: 0x00B839C7 File Offset: 0x00B81BC7
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
