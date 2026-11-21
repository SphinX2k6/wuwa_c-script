using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;

// Token: 0x02001B1D RID: 6941
[NullableContext(1)]
[Nullable(0)]
public class DailyQuestAssistant : ControllerAssistantBase
{
	// Token: 0x060114C2 RID: 70850 RVA: 0x005169F9 File Offset: 0x00514BF9
	protected override void OnDestroy()
	{
	}

	// Token: 0x060114C3 RID: 70851 RVA: 0x005169FC File Offset: 0x00514BFC
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.OnEnterDailyQuestNotifyRange, new Action<int, int, EEnterDailyQuestRangeParam>(this.OnEnterDailyQuestRange));
		EventSystem.Instance.Add(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x060114C4 RID: 70852 RVA: 0x00516A7C File Offset: 0x00514C7C
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnEnterDailyQuestNotifyRange, new Action<int, int, EEnterDailyQuestRangeParam>(this.OnEnterDailyQuestRange));
		EventSystem.Instance.Remove(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x060114C5 RID: 70853 RVA: 0x00516AFC File Offset: 0x00514CFC
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

	// Token: 0x060114C6 RID: 70854 RVA: 0x00516BF8 File Offset: 0x00514DF8
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

	// Token: 0x060114C7 RID: 70855 RVA: 0x00516C7D File Offset: 0x00514E7D
	private void OnAddNewQuest(TQuest quest)
	{
		if (quest.Type != EQuest.Daily)
		{
			return;
		}
		DailyTaskModel.Instance.AddDailyQuest(quest as DailyQuest);
	}

	// Token: 0x060114C8 RID: 70856 RVA: 0x00516C99 File Offset: 0x00514E99
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		if (state - QuestState.Finish <= 1)
		{
			DailyTaskModel.Instance.RemoveDailyQuest(questId);
		}
	}

	// Token: 0x060114C9 RID: 70857 RVA: 0x00516CAC File Offset: 0x00514EAC
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

	// Token: 0x060114CA RID: 70858 RVA: 0x00516D24 File Offset: 0x00514F24
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

	// Token: 0x060114CB RID: 70859 RVA: 0x00516D9C File Offset: 0x00514F9C
	private void TryShowQuestUpdateTips(DailyQuest quest)
	{
		if (quest == null || quest.Type != EQuest.Daily || quest.TriggerQuestTips)
		{
			return;
		}
		GeneralLogicTreeModel.Instance.SaveUpdateInfo(quest.TreeId.GetValueOrDefault(), quest.GetCurrentActiveChildQuestNode().NodeId);
	}

	// Token: 0x060114CC RID: 70860 RVA: 0x00516DE4 File Offset: 0x00514FE4
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

	// Token: 0x04009820 RID: 38944
	private bool WorldDoneOnce;
}
