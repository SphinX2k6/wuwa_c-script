using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F63 RID: 20323
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillConditionHelper
	{
		// Token: 0x0603411A RID: 213274 RVA: 0x00C3646C File Offset: 0x00C3466C
		public QuickHackSkillConditionResult CheckConditions(IEnumerable<QuickHackConditionInfo> conditionTypes, QuickHackSkillInstance skill, EQuickHackTargetType? hackType, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<EntityHandle> targets)
		{
			foreach (QuickHackConditionInfo quickHackConditionInfo in conditionTypes)
			{
				EQuickHackSkillCondition type = quickHackConditionInfo.Type;
				IQuickHackSkillCondition quickHackSkillCondition;
				if (this.ConditionMap.TryGetValue(type, out quickHackSkillCondition) && !quickHackSkillCondition.Check(skill, hackType, targets, quickHackConditionInfo.ExtraParams, 0))
				{
					return new QuickHackSkillConditionResult(false, new EQuickHackSkillCondition?(type));
				}
			}
			return new QuickHackSkillConditionResult(true, null);
		}

		// Token: 0x0603411B RID: 213275 RVA: 0x00C364FC File Offset: 0x00C346FC
		public void RegisterConditionsListener(IEnumerable<EQuickHackSkillCondition> conditionTypes, GenericEventHandler onReceiveEvent)
		{
			foreach (EQuickHackSkillCondition key in conditionTypes)
			{
				List<EEventName> list;
				if (this.ConditionEventMap.TryGetValue(key, out list))
				{
					foreach (EEventName name in list)
					{
						if (!EventSystem.Instance.Has(name, onReceiveEvent))
						{
							EventSystem.Instance.Add(name, onReceiveEvent);
						}
					}
				}
			}
		}

		// Token: 0x0603411C RID: 213276 RVA: 0x00C365A4 File Offset: 0x00C347A4
		public void UnRegisterConditionsListener(IEnumerable<EQuickHackSkillCondition> conditionTypes, GenericEventHandler onReceiveEvent)
		{
			foreach (EQuickHackSkillCondition key in conditionTypes)
			{
				List<EEventName> list;
				if (this.ConditionEventMap.TryGetValue(key, out list))
				{
					foreach (EEventName name in list)
					{
						if (EventSystem.Instance.Has(name, onReceiveEvent))
						{
							EventSystem.Instance.Remove(name, onReceiveEvent);
						}
					}
				}
			}
		}

		// Token: 0x0603411D RID: 213277 RVA: 0x00C3664C File Offset: 0x00C3484C
		[NullableContext(2)]
		public List<EQuickHackSkillCondition> GetTargetExtraConditions(EQuickHackTargetType type)
		{
			List<EQuickHackSkillCondition> result;
			this.TargetExtraConditionsMap.TryGetValue(type, out result);
			return result;
		}

		// Token: 0x0401BA9C RID: 113308
		private readonly Dictionary<EQuickHackSkillCondition, IQuickHackSkillCondition> ConditionMap = new Dictionary<EQuickHackSkillCondition, IQuickHackSkillCondition>
		{
			{
				EQuickHackSkillCondition.CheckTargetTypeMatch,
				new QuickHackSkillCheckTargetMatch()
			},
			{
				EQuickHackSkillCondition.CheckRamEnough,
				new QuickHackSkillCheckRamEnough()
			},
			{
				EQuickHackSkillCondition.CheckUsageCountEnough,
				new QuickHackSkillCheckUsageCountEnough()
			},
			{
				EQuickHackSkillCondition.CheckAnyMonsterTypeMatch,
				new QuickHackSkillCheckAnyMonsterTypeMatch()
			},
			{
				EQuickHackSkillCondition.CheckAnySceneItemCanHack,
				new QuickHackSkillCheckAnySceneItemCanHack()
			},
			{
				EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill,
				new QuickHackSkillCheckAnyTargetNotBeenUsedSkill()
			}
		};

		// Token: 0x0401BA9D RID: 113309
		private readonly Dictionary<EQuickHackSkillCondition, List<EEventName>> ConditionEventMap = new Dictionary<EQuickHackSkillCondition, List<EEventName>>
		{
			{
				EQuickHackSkillCondition.CheckTargetTypeMatch,
				new List<EEventName>
				{
					EEventName.OnQuickHackTargetChange
				}
			},
			{
				EQuickHackSkillCondition.CheckRamEnough,
				new List<EEventName>
				{
					EEventName.OnQuickHackCurrentRamChange
				}
			},
			{
				EQuickHackSkillCondition.CheckAnyMonsterTypeMatch,
				new List<EEventName>
				{
					EEventName.OnQuickHackTargetChange
				}
			},
			{
				EQuickHackSkillCondition.CheckAnySceneItemCanHack,
				new List<EEventName>
				{
					EEventName.OnQuickHackTargetChange,
					EEventName.OnQuickHackSceneItemStateChange
				}
			},
			{
				EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill,
				new List<EEventName>
				{
					EEventName.OnQuickHackTargetChange,
					EEventName.OnQuickHackCurrentRamChange
				}
			}
		};

		// Token: 0x0401BA9E RID: 113310
		private readonly Dictionary<EQuickHackTargetType, List<EQuickHackSkillCondition>> TargetExtraConditionsMap = new Dictionary<EQuickHackTargetType, List<EQuickHackSkillCondition>>
		{
			{
				EQuickHackTargetType.EnemyMonster,
				new List<EQuickHackSkillCondition>
				{
					EQuickHackSkillCondition.CheckAnyMonsterTypeMatch,
					EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill
				}
			},
			{
				EQuickHackTargetType.SceneItem,
				new List<EQuickHackSkillCondition>
				{
					EQuickHackSkillCondition.CheckAnySceneItemCanHack,
					EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill
				}
			},
			{
				EQuickHackTargetType.OwnerSelf,
				new List<EQuickHackSkillCondition>
				{
					EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill
				}
			}
		};
	}
}
