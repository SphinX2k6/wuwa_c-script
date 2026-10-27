using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D77 RID: 28023
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionRegData
	{
		// Token: 0x06044796 RID: 280470 RVA: 0x010E30BC File Offset: 0x010E12BC
		public LevelConditionRegData(LevelConditionGroupRegData owner, Condition conditionConfig, List<EEventName> eventNames)
		{
			this.Owner = owner;
			this.ConditionConfig = conditionConfig;
			this.EventNames = eventNames;
			string type = this.ConditionConfig.Type;
			if (type == ELevelGeneralCondition.PawnInRange.ToEnumString())
			{
				string limitParams = this.ConditionConfig.GetLimitParams("PawnId");
				float range = float.Parse(this.ConditionConfig.GetLimitParams("Distance"));
				LevelConditionRegistry.Instance.AddPawnInRangeMap(limitParams, range);
			}
			if (type == ELevelGeneralCondition.CheckRangeByPbDataId.ToEnumString())
			{
				string limitParams2 = this.ConditionConfig.GetLimitParams("PbDataId");
				float range2 = float.Parse(this.ConditionConfig.GetLimitParams("Distance"));
				LevelConditionRegistry.Instance.AddPbDataInRangeMap(int.Parse(limitParams2), range2);
			}
			if (type == ELevelGeneralCondition.CheckCharacterMotionState.ToEnumString())
			{
				LevelConditionCheckCharacterMotionState.RegisterEvents(new TMotionStateCallback(this.OnEventInvokeCheck));
				return;
			}
			if (type == ELevelGeneralCondition.CheckCharacterTagsRestrict.ToEnumString())
			{
				LevelConditionCheckCharacterTagsRestrict.RegisterEvents(this.ConditionConfig, new TTagChangedCallback(this.OnEventInvokeCheck));
				return;
			}
			for (int i = 0; i < this.EventNames.Count; i++)
			{
				EEventName eeventName = this.EventNames[i];
				if (eeventName == EEventName.OnGlobalGameplayTagChanged)
				{
					AbilityEvent.Instance.Add(SceneTeam.Scene, EAbilityEventName.OnGameplayTagChanged, (long)GameplayTagUtils.GetTagIdByName(this.ConditionConfig.GetLimitParams("Tag")), new Action<int, int, int, int>(this.OnGlobalGameplayTagChanged));
				}
				else if (eeventName == EEventName.OnEntityFightByBpType && type == ELevelGeneralCondition.FightWithMonster.ToEnumString())
				{
					string limitParams3 = this.ConditionConfig.GetLimitParams("MonsterId");
					if (limitParams3 == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.LevelCondition;
						ELogAuthor author = ELogAuthor.TL;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
						defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.ConditionConfig.Id);
						defaultInterpolatedStringHandler.AppendLiteral("的MonsterId参数不符合条件类型");
						defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.FightWithMonster);
						defaultInterpolatedStringHandler.AppendLiteral("的定义");
						instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						EventSystem.Instance.AddWithCondition<string>(EEventName.OnEntityFightByBpType, new Action<string>(this.OnEntityFightByBpType), limitParams3);
					}
				}
				else
				{
					EventSystem.Instance.Add(eeventName, new GenericEventHandler(this.OnEventInvokeCheck));
				}
			}
		}

		// Token: 0x06044797 RID: 280471 RVA: 0x010E330F File Offset: 0x010E150F
		private void OnGlobalGameplayTagChanged(int entityId, int gameplayTagId, int originTagCount, int newTagCount)
		{
			this.OnEventInvokeCheck(new object[]
			{
				entityId,
				gameplayTagId,
				originTagCount,
				newTagCount
			});
		}

		// Token: 0x06044798 RID: 280472 RVA: 0x010E3342 File Offset: 0x010E1542
		private void OnEntityFightByBpType(string blueprintType)
		{
			this.OnEventInvokeCheck(new object[]
			{
				blueprintType
			});
		}

		// Token: 0x06044799 RID: 280473 RVA: 0x010E3354 File Offset: 0x010E1554
		public void Destroy()
		{
			if (this.ConditionConfig.Type == ELevelGeneralCondition.PawnInRange.ToEnumString())
			{
				string limitParams = this.ConditionConfig.GetLimitParams("PawnId");
				LevelConditionRegistry.Instance.RemovePawnInRangeMap(limitParams);
			}
			if (this.ConditionConfig.Type == ELevelGeneralCondition.CheckRangeByPbDataId.ToEnumString())
			{
				string limitParams2 = this.ConditionConfig.GetLimitParams("PbDataId");
				LevelConditionRegistry.Instance.RemovePbDataInRangeMap(int.Parse(limitParams2));
			}
			if (this.ConditionConfig.Type == ELevelGeneralCondition.CheckCharacterMotionState.ToEnumString())
			{
				LevelConditionCheckCharacterMotionState.UnRegisterEvents(new TMotionStateCallback(this.OnEventInvokeCheck));
				return;
			}
			if (this.ConditionConfig.Type == ELevelGeneralCondition.CheckCharacterTagsRestrict.ToEnumString())
			{
				LevelConditionCheckCharacterTagsRestrict.UnRegisterEvents(this.ConditionConfig, new TTagChangedCallback(this.OnEventInvokeCheck));
				return;
			}
			for (int i = 0; i < this.EventNames.Count; i++)
			{
				EEventName eeventName = this.EventNames[i];
				if (eeventName == EEventName.OnGlobalGameplayTagChanged)
				{
					AbilityEvent.Instance.Remove(SceneTeam.Scene, EAbilityEventName.OnGameplayTagChanged, (long)GameplayTagUtils.GetTagIdByName(this.ConditionConfig.GetLimitParams("Tag")), new Action<int, int, int, int>(this.OnGlobalGameplayTagChanged));
				}
				else if (eeventName == EEventName.OnEntityFightByBpType && this.ConditionConfig.Type == ELevelGeneralCondition.FightWithMonster.ToEnumString())
				{
					string limitParams3 = this.ConditionConfig.GetLimitParams("MonsterId");
					if (limitParams3 == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.LevelCondition;
						ELogAuthor author = ELogAuthor.TL;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
						defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.ConditionConfig.Id);
						defaultInterpolatedStringHandler.AppendLiteral("的MonsterId参数不符合条件类型");
						defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.FightWithMonster);
						defaultInterpolatedStringHandler.AppendLiteral("的定义");
						instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						EventSystem.Instance.RemoveWithCondition<string>(EEventName.OnEntityFightByBpType, new Action<string>(this.OnEntityFightByBpType), limitParams3);
					}
				}
				else
				{
					EventSystem.Instance.Remove(eeventName, new GenericEventHandler(this.OnEventInvokeCheck));
				}
			}
		}

		// Token: 0x0604479A RID: 280474 RVA: 0x010E357C File Offset: 0x010E177C
		private void OnEventInvokeCheck(params object[] eventArgs)
		{
			if (this.OnEventInvokeCheckStat == null)
			{
				this.OnEventInvokeCheckStat = Stat.CreateNoFlameGraph("OnEventInvokeCheckStat_" + this.ConditionConfig.Type, "", "");
			}
			try
			{
				bool conditionReached = this.ConditionReached;
				bool flag = LevelGeneralController.Instance.HandleCondition(this.ConditionConfig, null, this.Owner.ConditionGroupId.ToString(), eventArgs);
				if (conditionReached != flag)
				{
					this.ConditionReached = flag;
					if (flag)
					{
						this.Owner.CheckReached();
					}
				}
			}
			finally
			{
			}
		}

		// Token: 0x040239DF RID: 145887
		public LevelConditionGroupRegData Owner;

		// Token: 0x040239E0 RID: 145888
		public Condition ConditionConfig;

		// Token: 0x040239E1 RID: 145889
		public List<EEventName> EventNames;

		// Token: 0x040239E2 RID: 145890
		public bool ConditionReached;

		// Token: 0x040239E3 RID: 145891
		[Nullable(2)]
		private Stat OnEventInvokeCheckStat;
	}
}
