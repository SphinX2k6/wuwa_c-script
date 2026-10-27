using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;

// Token: 0x02002632 RID: 9778
[NullableContext(1)]
[Nullable(0)]
public class DailyQuestAssistant : ControllerAssistantBase
{
	// Token: 0x06013FE0 RID: 81888 RVA: 0x00507B19 File Offset: 0x00505D19
	protected override void OnDestroy()
	{
	}

	// Token: 0x06013FE1 RID: 81889 RVA: 0x00507B1C File Offset: 0x00505D1C
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.OnEnterDailyQuestNotifyRange, new Action<int, int, EEnterDailyQuestRangeParam>(this.OnEnterDailyQuestRange));
		EventSystem.Instance.Add(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x06013FE2 RID: 81890 RVA: 0x00507B9C File Offset: 0x00505D9C
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnEnterDailyQuestNotifyRange, new Action<int, int, EEnterDailyQuestRangeParam>(this.OnEnterDailyQuestRange));
		EventSystem.Instance.Remove(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x06013FE3 RID: 81891 RVA: 0x00507C1C File Offset: 0x00505E1C
	private void OnWorldDoneAndCloseLoading()
	{
		if (!LoginModel.Instance.GetTodayFirstTimeLogin() || this.WorldDoneOnce)
		{
			return;
		}
		this.WorldDoneOnce = true;
		foreach (int pbDataId in DailyTaskModel.Instance.GetDailyTaskCorrelativeEntities())
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (this.DetectPlayerDistanceSquared(entityByPbDataId))
			{
				return;
			}
		}
		foreach (DailyQuest dailyQuest in DailyTaskModel.Instance.GetAllDailyQuest().Values)
		{
			BehaviorNodeBase currentActiveChildQuestNode = dailyQuest.GetCurrentActiveChildQuestNode();
			if (currentActiveChildQuestNode != null)
			{
				GeneralLogicTreeModel.Instance.SaveUpdateInfo(dailyQuest.TreeId.GetValueOrDefault(), currentActiveChildQuestNode.NodeId);
			}
		}
	}

	// Token: 0x06013FE4 RID: 81892 RVA: 0x00507D18 File Offset: 0x00505F18
	private void OnEnterDailyQuestRange(int questId, int nodeId, EEnterDailyQuestRangeParam type)
	{
		global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
		if (quest != null && quest.Type == EQuest.Daily)
		{
			DailyQuest dailyQuest = quest as DailyQuest;
			if (dailyQuest != null)
			{
				if (dailyQuest.OnlineType == EQuestOnlineType.SingleHangUpOnline && GameModeModel.Instance.IsMulti)
				{
					return;
				}
				if (type == EEnterDailyQuestRangeParam.Enter)
				{
					if (dailyQuest.IsRangeTrack(nodeId))
					{
						dailyQuest.StartTextExpress(ETreeTextExpressReason.InRange);
					}
					else
					{
						this.TryShowQuestUpdateTips(dailyQuest);
					}
					this.TryShowDailyQuestPrompt(dailyQuest);
					dailyQuest.TriggerQuestTips = true;
					return;
				}
				if (type != EEnterDailyQuestRangeParam.Leave)
				{
					return;
				}
				if (dailyQuest.IsRangeTrack(nodeId))
				{
					dailyQuest.EndTextExpress(ETreeTextExpressReason.InRange);
				}
				return;
			}
		}
	}

	// Token: 0x06013FE5 RID: 81893 RVA: 0x00507D9D File Offset: 0x00505F9D
	private void OnAddNewQuest(TQuest quest)
	{
		if (quest.Type != EQuest.Daily)
		{
			return;
		}
		DailyTaskModel.Instance.AddDailyQuest(quest as DailyQuest);
	}

	// Token: 0x06013FE6 RID: 81894 RVA: 0x00507DB9 File Offset: 0x00505FB9
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		if (state - QuestState.Finish <= 1)
		{
			DailyTaskModel.Instance.RemoveDailyQuest(questId);
		}
	}

	// Token: 0x06013FE7 RID: 81895 RVA: 0x00507DCC File Offset: 0x00505FCC
	private bool DetectPlayerDistanceSquared(EntityHandle handle)
	{
		if (handle == null)
		{
			return false;
		}
		BaseActorComponent component = handle.Entity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			return false;
		}
		double num = global::Vector.Distance(component.ActorLocationProxy, GeneralLogicTreeUtil.Instance.GetPlayerLocation());
		int? intConfig = ConfigCommonParamById.GetIntConfig("dailyquest_trackinfo_mini");
		double? num2 = (intConfig != null) ? new double?((double)intConfig.GetValueOrDefault()) : null;
		return num < num2.GetValueOrDefault() & num2 != null;
	}

	// Token: 0x06013FE8 RID: 81896 RVA: 0x00507E44 File Offset: 0x00506044
	private void TryShowDailyQuestPrompt(DailyQuest quest)
	{
		if (quest == null || quest.Type != EQuest.Daily || quest.TriggerQuestTips)
		{
			return;
		}
		string questName = QuestNewModel.Instance.GetQuestName(quest.Id);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("TriggerMission"), null);
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.TaskBeginPrompt, null, null, new <>z__ReadOnlySingleElementList<object>(questName), new <>z__ReadOnlySingleElementList<object>(localTextNew), null, null, null, null, false, null);
	}

	// Token: 0x06013FE9 RID: 81897 RVA: 0x00507EBC File Offset: 0x005060BC
	private void TryShowQuestUpdateTips(DailyQuest quest)
	{
		if (quest == null || quest.Type != EQuest.Daily || quest.TriggerQuestTips)
		{
			return;
		}
		GeneralLogicTreeModel.Instance.SaveUpdateInfo(quest.TreeId.GetValueOrDefault(), quest.GetCurrentActiveChildQuestNode().NodeId);
	}

	// Token: 0x06013FEA RID: 81898 RVA: 0x00507F04 File Offset: 0x00506104
	public void CreateMarksOnWakeUp()
	{
		Dictionary<int, DailyQuest> allDailyQuest = DailyTaskModel.Instance.GetAllDailyQuest();
		if (allDailyQuest == null)
		{
			return;
		}
		foreach (DailyQuest dailyQuest in allDailyQuest.Values)
		{
			dailyQuest.CreateMapMarks();
		}
	}

	// Token: 0x040096C8 RID: 38600
	private bool WorldDoneOnce;
}
