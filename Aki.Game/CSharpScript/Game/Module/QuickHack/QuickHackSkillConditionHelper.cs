using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2C RID: 16172
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillConditionHelper
	{
		// Token: 0x06028F88 RID: 167816 RVA: 0x00B7FC0C File Offset: 0x00B7DE0C
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

		// Token: 0x06028F89 RID: 167817 RVA: 0x00B7FC9C File Offset: 0x00B7DE9C
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

		// Token: 0x06028F8A RID: 167818 RVA: 0x00B7FD44 File Offset: 0x00B7DF44
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

		// Token: 0x06028F8B RID: 167819 RVA: 0x00B7FDEC File Offset: 0x00B7DFEC
		[NullableContext(2)]
		public List<EQuickHackSkillCondition> GetTargetExtraConditions(EQuickHackTargetType type)
		{
			List<EQuickHackSkillCondition> result;
			this.TargetExtraConditionsMap.TryGetValue(type, out result);
			return result;
		}

		// Token: 0x04016471 RID: 91249
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

		// Token: 0x04016472 RID: 91250
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

		// Token: 0x04016473 RID: 91251
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
