using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265F RID: 9823
[NullableContext(1)]
[Nullable(0)]
public class QuestItem : UiPanelBase
{
	// Token: 0x06014195 RID: 82325 RVA: 0x00511330 File Offset: 0x0050F530
	[NullableContext(2)]
	public QuestItem(TQuestItemSelectHandle toggleSelectHandle)
	{
		this.ToggleSelectHandle = toggleSelectHandle;
	}

	// Token: 0x06014196 RID: 82326 RVA: 0x00511340 File Offset: 0x0050F540
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014197 RID: 82327 RVA: 0x005115A4 File Offset: 0x0050F7A4
	protected override void OnStart()
	{
		this.ToggleSpriteComponent = (base.GetItem(7).GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition);
		this.ToggleSpriteComponent.SetEnable(false);
		base.GetItem(7).SetColor(this.ToggleSpriteComponent.TransitionState.CheckedHoverState.Color);
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014198 RID: 82328 RVA: 0x0051161C File Offset: 0x0050F81C
	public void OnTick(float delta)
	{
		if (this.QuestId == 0)
		{
			return;
		}
		if (this.TickTime > 1000f)
		{
			this.TickTime -= 1000f;
			this.UpdateCountDownText(this.QuestId, true);
		}
		this.TickTime += delta;
	}

	// Token: 0x06014199 RID: 82329 RVA: 0x0051166C File Offset: 0x0050F86C
	public void UpdateItem(int inQuestId, int inQuestType)
	{
		this.QuestId = inQuestId;
		this.QuestType = inQuestType;
		this.UpdateToggle();
		this.UpdateTrackIconActive();
		global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
		if (quest == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "任务界面任务Item更新时找不到任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务Id", this.QuestId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.TreeId = quest.TreeId.GetValueOrDefault();
		this.SetColorSprite(quest);
		this.SetCircleSprite(quest);
		this.SetLockIcon();
		this.SetTrackIcon(quest);
		this.UpdateQuestName(quest);
		this.UpdateDistance(quest);
		this.UpdateFunctionIcon(quest);
		this.SetConditionText(quest);
		this.SetQuestTag(quest);
		bool uiactive = QuestNewModel.Instance.IsInFocusOnQuest(this.QuestId);
		UUISprite sprite = base.GetSprite(14);
		if (sprite != null)
		{
			sprite.SetUIActive(uiactive);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.QuestViewItem, base.GetItem(6), null, this.QuestId);
	}

	// Token: 0x0601419A RID: 82330 RVA: 0x0051176A File Offset: 0x0050F96A
	public void SetActiveItem(bool value)
	{
		this.SetActive(value);
		if (!value)
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.QuestViewItem);
		}
	}

	// Token: 0x0601419B RID: 82331 RVA: 0x00511784 File Offset: 0x0050F984
	private void SetColorSprite(TQuest quest)
	{
		string questTypeColor = QuestNewConfig.Instance.GetQuestTypeColor((int)quest.Type);
		UUISprite sprite = base.GetSprite(5);
		if (StringUtils.IsEmpty(questTypeColor))
		{
			sprite.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		sprite.SetColor(FColor.FromHex(questTypeColor));
	}

	// Token: 0x0601419C RID: 82332 RVA: 0x005117D0 File Offset: 0x0050F9D0
	private void SetCircleSprite(TQuest quest)
	{
		UUISprite sprite = base.GetSprite(15);
		if (!QuestNewModel.Instance.IsQuestUnlock(this.QuestId))
		{
			sprite.SetUIActive(false);
			return;
		}
		string questMainTypeCircleColor = QuestNewConfig.Instance.GetQuestMainTypeCircleColor((int)quest.Type);
		if (StringUtils.IsEmpty(questMainTypeCircleColor))
		{
			sprite.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		sprite.SetColor(FColor.FromHex(questMainTypeCircleColor));
	}

	// Token: 0x0601419D RID: 82333 RVA: 0x00511834 File Offset: 0x0050FA34
	private void SetLockIcon()
	{
		string questLockIconPath = QuestNewModel.Instance.GetQuestLockIconPath(this.QuestId);
		UUISprite sprite = base.GetSprite(1);
		if (StringUtils.IsEmpty(questLockIconPath))
		{
			sprite.SetUIActive(false);
			return;
		}
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		int? num = (curTrackedQuest != null) ? new int?(curTrackedQuest.Id) : null;
		int questId = this.QuestId;
		if (num.GetValueOrDefault() == questId & num != null)
		{
			sprite.SetUIActive(false);
			return;
		}
		this.SetSpriteByPath(questLockIconPath, sprite, true, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x0601419E RID: 82334 RVA: 0x005118D0 File Offset: 0x0050FAD0
	private void SetTrackIcon(global::Quest quest)
	{
		this.SetSpriteByPath(QuestNewConfig.Instance.GetQuestTypeMark(quest.QuestMarkId), base.GetSprite(0), false, null, null);
	}

	// Token: 0x0601419F RID: 82335 RVA: 0x00511908 File Offset: 0x0050FB08
	private void SetTrackBgSprite()
	{
		UUISprite sprite = base.GetSprite(16);
		global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
		if (quest == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		string questMainTypeTrackBgColor = QuestNewConfig.Instance.GetQuestMainTypeTrackBgColor((int)quest.Type);
		if (StringUtils.IsEmpty(questMainTypeTrackBgColor))
		{
			sprite.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		sprite.SetColor(FColor.FromHex(questMainTypeTrackBgColor));
	}

	// Token: 0x060141A0 RID: 82336 RVA: 0x00511970 File Offset: 0x0050FB70
	public void UpdateTrackIconActive()
	{
		EToggleState toggleState = base.GetExtendToggle(4).ToggleState;
		int questId = this.QuestId;
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		int? num = (curTrackedQuest != null) ? new int?(curTrackedQuest.Id) : null;
		bool uiactive = questId == num.GetValueOrDefault() & num != null;
		this.RefreshYellowItemShowState(toggleState);
		base.GetSprite(0).SetUIActive(uiactive);
		this.SetTrackBgSprite();
	}

	// Token: 0x060141A1 RID: 82337 RVA: 0x005119E0 File Offset: 0x0050FBE0
	private void UpdateToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		extendToggle.OnStateChange.Clear();
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x060141A2 RID: 82338 RVA: 0x00511A0A File Offset: 0x0050FC0A
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleSelectHandle(this.QuestId);
		}
	}

	// Token: 0x060141A3 RID: 82339 RVA: 0x00511A21 File Offset: 0x0050FC21
	private void UpdateQuestName(global::Quest quest)
	{
		base.GetText(2).SetText(quest.Name, true);
	}

	// Token: 0x060141A4 RID: 82340 RVA: 0x00511A38 File Offset: 0x0050FC38
	private void UpdateDistance(global::Quest quest)
	{
		UUIText text = base.GetText(3);
		if (quest.IsSuspend())
		{
			text.SetUIActive(false);
			return;
		}
		BehaviorNodeBase currentActiveChildQuestNode = quest.GetCurrentActiveChildQuestNode();
		if (currentActiveChildQuestNode == null)
		{
			text.SetUIActive(false);
			return;
		}
		if (!GeneralLogicTreeController.Instance.IsShowNodeTrackDistance(quest.TreeId.Value, currentActiveChildQuestNode.NodeId))
		{
			text.SetUIActive(false);
			return;
		}
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(quest.TreeId.Value), false);
		if (behaviorTree == null)
		{
			text.SetUIActive(false);
			return;
		}
		if (MapUtil.GetDungeonsRelation(CreatureModel.Instance.GetInstanceId(), behaviorTree.DungeonId) == EDungeonRelationType.DifferentWorld)
		{
			text.SetUIActive(false);
			return;
		}
		double? trackDistance = quest.GetTrackDistance(currentActiveChildQuestNode.NodeId);
		if (!quest.IsInTrackRange() && trackDistance != null)
		{
			double? num = trackDistance;
			double num2 = 0.0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				LguiUtil.Instance.SetLocalText(text, "Meter", new <>z__ReadOnlySingleElementList<object>(trackDistance));
				text.SetUIActive(true);
				return;
			}
		}
		text.SetUIActive(false);
	}

	// Token: 0x060141A5 RID: 82341 RVA: 0x00511B54 File Offset: 0x0050FD54
	public void UpdateFunctionIcon(global::Quest quest)
	{
		UUITexture texture = base.GetTexture(8);
		UUISprite sprite = base.GetSprite(9);
		if (quest != null && quest.Type == EQuest.Guide && quest.FunctionId != null)
		{
			int? functionId = quest.FunctionId;
			int num = 0;
			if (!(functionId.GetValueOrDefault() == num & functionId != null))
			{
				FunctionCondition? config = ConfigFunctionConditionByFunctionId.GetConfig(quest.FunctionId.Value, true);
				if (config == null)
				{
					texture.SetUIActive(false);
					sprite.SetUIActive(false);
					return;
				}
				if (!StringUtils.IsBlank(config.Value.Icon))
				{
					base.SetTextureByPath(config.Value.Icon, texture, null, null);
					texture.SetUIActive(true);
					sprite.SetUIActive(false);
					return;
				}
				if (!StringUtils.IsBlank(config.Value.IconSprite))
				{
					this.SetSpriteByPath(config.Value.IconSprite, sprite, false, null, null);
					sprite.SetUIActive(true);
					texture.SetUIActive(false);
					return;
				}
				texture.SetUIActive(false);
				sprite.SetUIActive(false);
				return;
			}
		}
		texture.SetUIActive(false);
		sprite.SetUIActive(false);
	}

	// Token: 0x060141A6 RID: 82342 RVA: 0x00511C84 File Offset: 0x0050FE84
	private void SetConditionText(global::Quest quest)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		this.IsNeedCountDown = false;
		UUIText text = base.GetText(10);
		EQuestSpecialState questSpecialState = instance.GetQuestSpecialState(quest);
		string text2 = null;
		string text3 = null;
		switch (questSpecialState)
		{
		case EQuestSpecialState.PreShow:
			text2 = QuestNewModel.Instance.GetShowQuestConditionDescribe(quest.Id);
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		case EQuestSpecialState.LockByLackResource:
			text2 = (ConfigMultiTextLang.GetLocalTextNew("DownloadResource", null) ?? "DownloadResource");
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		case EQuestSpecialState.Suspend:
		{
			string suspendText = quest.GetSuspendText();
			text2 = ((suspendText != null) ? suspendText.Split('，', StringSplitOptions.None)[0] : null);
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		}
		case EQuestSpecialState.LockQuestSuspendByOnline:
			text2 = (TextConfig.Instance.GetTextById("SuspendByOnline") ?? "SuspendByOnline");
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		case EQuestSpecialState.HasRecommendQuest:
		{
			List<int> recommendPreQuest = quest.GetRecommendPreQuest();
			string item = "";
			if (recommendPreQuest != null && recommendPreQuest.Count > 0)
			{
				global::Quest quest2 = QuestNewModel.Instance.GetQuest(recommendPreQuest[0]);
				item = (((quest2 != null) ? quest2.Name : null) ?? "");
			}
			LguiUtil.Instance.SetLocalText(text, "QuestRecommendTip", new <>z__ReadOnlySingleElementList<object>(item));
			text3 = (ConfigCommonParamById.GetStringConfig("TaskRemindColor") ?? "");
			break;
		}
		case EQuestSpecialState.RefOccupiedEntity:
		{
			string refOccupiedEntityText = quest.GetRefOccupiedEntityText();
			text2 = ((refOccupiedEntityText != null) ? refOccupiedEntityText.Split('，', StringSplitOptions.None)[0] : null);
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		}
		case EQuestSpecialState.LockByFocusMode:
			text2 = (ConfigMultiTextLang.GetLocalTextNew("Task_Focus_Tips01", null) ?? "Task_Focus_Tips01");
			text3 = (ConfigCommonParamById.GetStringConfig("TaskUnableColor") ?? "");
			break;
		case EQuestSpecialState.ActivityGuideQuest:
		case EQuestSpecialState.ActivityQuest:
			this.IsNeedCountDown = true;
			this.UpdateCountDownText(quest.Id, false);
			text3 = (ConfigCommonParamById.GetStringConfig("TaskCountDownColor") ?? "");
			break;
		}
		if (text3 != null && !StringUtils.IsBlank(text3))
		{
			FColor color = FColor.FromHex(text3);
			text.SetColor(color);
		}
		if (text2 != null && !StringUtils.IsBlank(text2))
		{
			text.SetText(text2, true);
			text.SetUIActive(true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060141A7 RID: 82343 RVA: 0x00511EE4 File Offset: 0x005100E4
	private void UpdateCountDownText(int questId, bool bSendEvent)
	{
		if (!this.IsNeedCountDown)
		{
			return;
		}
		if (QuestNewModel.Instance.GetQuest(this.QuestId) == null)
		{
			if (bSendEvent)
			{
				EventSystem.Instance.Emit<int>(EEventName.ActivityQuestCountdownEnd, questId);
				this.IsNeedCountDown = false;
			}
			return;
		}
		UUIText text = base.GetText(10);
		int num = QuestNewModel.Instance.GetQuestBindingActivityId(questId);
		ActivityBaseData activityById;
		if (num != 0)
		{
			activityById = ActivityModel.Instance.GetActivityById(num);
			if (activityById != null)
			{
				ActivityBaseData activityBaseData = activityById;
				if (activityBaseData.LocalConfig != null && activityBaseData.LocalConfig.GetValueOrDefault().IfShowQuestLeftTime)
				{
					goto IL_BD;
				}
			}
			text.SetUIActive(false);
			return;
		}
		num = QuestNewModel.Instance.GetQuestActivityId(questId);
		activityById = ActivityModel.Instance.GetActivityById(num);
		if (activityById == null || !QuestNewModel.Instance.GetQuestShowQuestLeftTime(questId))
		{
			text.SetUIActive(false);
			return;
		}
		IL_BD:
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		if (localTextNew == null)
		{
			text.SetUIActive(false);
			return;
		}
		if (!activityById.CheckIfInOpenTime())
		{
			if (bSendEvent)
			{
				EventSystem.Instance.Emit<int>(EEventName.ActivityQuestCountdownEnd, questId);
				this.IsNeedCountDown = false;
			}
			return;
		}
		if (activityById.EndOpenTime == 0L)
		{
			text.SetUIActive(false);
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = (double)activityById.EndOpenTime - serverTime;
		string activityGuideQuestRemainTimeText = QuestNewModel.Instance.GetActivityGuideQuestRemainTimeText(remainTime, localTextNew);
		text.SetText(activityGuideQuestRemainTimeText, true);
	}

	// Token: 0x060141A8 RID: 82344 RVA: 0x0051202C File Offset: 0x0051022C
	private unsafe void SetQuestTag(global::Quest quest)
	{
		QuestItem.<>c__DisplayClass29_0 CS$<>8__locals1 = new QuestItem.<>c__DisplayClass29_0();
		CS$<>8__locals1.questTagRoot = base.GetItem(11);
		if (CS$<>8__locals1.questTagRoot == null)
		{
			return;
		}
		int num = this.IsOnlineDisabledByQuestId(this.QuestId) ? 9 : quest.TagId;
		if (num == 0)
		{
			CS$<>8__locals1.questTagRoot.SetUIActive(false);
			return;
		}
		CS$<>8__locals1.questTagConfig = ConfigQuestTagById.GetConfig(num, true);
		if (CS$<>8__locals1.questTagConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到任务标签配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", quest.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagId", num);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		CS$<>8__locals1.tagText = base.GetText(13);
		UUIText tagText = CS$<>8__locals1.tagText;
		if (tagText != null)
		{
			tagText.SetText("", true);
		}
		UUISprite sprite = base.GetSprite(12);
		if (sprite != null)
		{
			this.SetSpriteByPath(CS$<>8__locals1.questTagConfig.Value.BgSpritePath, sprite, CS$<>8__locals1.questTagConfig.Value.UseOriginalSize, null, delegate(bool success)
			{
				if (success && CS$<>8__locals1.questTagConfig.Value.UseOriginalSize)
				{
					base.<SetQuestTag>g__DoSetTextAndShow|0();
				}
			});
		}
		if (!CS$<>8__locals1.questTagConfig.Value.UseOriginalSize)
		{
			CS$<>8__locals1.<SetQuestTag>g__DoSetTextAndShow|0();
		}
	}

	// Token: 0x060141A9 RID: 82345 RVA: 0x00512190 File Offset: 0x00510390
	private bool IsOnlineDisabledByQuestId(int questId)
	{
		IReadOnlyDictionary<DisableOnlineSource, EDisableOnlineType> onlineDisabledSource = OnlineModel.Instance.GetOnlineDisabledSource();
		if (onlineDisabledSource == null)
		{
			return false;
		}
		foreach (KeyValuePair<DisableOnlineSource, EDisableOnlineType> keyValuePair in onlineDisabledSource)
		{
			DisableOnlineSource disableOnlineSource;
			EDisableOnlineType edisableOnlineType;
			keyValuePair.Deconstruct(out disableOnlineSource, out edisableOnlineType);
			DisableOnlineSource disableOnlineSource2 = disableOnlineSource;
			if (disableOnlineSource2.Type == EDisableOnlineType.NonOnlineQuest && disableOnlineSource2.TreeId == questId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060141AA RID: 82346 RVA: 0x0051220C File Offset: 0x0051040C
	public void SetSelected(bool value)
	{
		EToggleState state = value ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(4).SetToggleState(state, false, false, false);
		if (value)
		{
			this.ClickHandle();
		}
		this.RefreshYellowItemShowState(state);
	}

	// Token: 0x060141AB RID: 82347 RVA: 0x00512244 File Offset: 0x00510444
	private void RefreshYellowItemShowState(EToggleState state)
	{
		UUIItem item = base.GetItem(7);
		if (state == EToggleState.ETT_Checked)
		{
			int questId = this.QuestId;
			global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
			int? num = (curTrackedQuest != null) ? new int?(curTrackedQuest.Id) : null;
			if (!(questId == num.GetValueOrDefault() & num != null))
			{
				item.SetUIActive(true);
			}
			else
			{
				item.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(1);
			if (item != null)
			{
				UUIItem parentAsUIItem = item.GetParentAsUIItem();
				if (parentAsUIItem == null)
				{
					return;
				}
				parentAsUIItem.SetUIActive(!sprite.bIsUIActive);
				return;
			}
		}
		else
		{
			item.SetUIActive(false);
		}
	}

	// Token: 0x060141AC RID: 82348 RVA: 0x005122D8 File Offset: 0x005104D8
	public void SetNotAllowNoneSelect()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetRaycastTarget(extendToggle.ToggleState != EToggleState.ETT_Checked);
	}

	// Token: 0x060141AD RID: 82349 RVA: 0x00512311 File Offset: 0x00510511
	private void ClickHandle()
	{
		EventSystem.Instance.Emit<int, bool>(EEventName.UpdateQuestDetails, this.QuestId, true);
	}

	// Token: 0x060141AE RID: 82350 RVA: 0x0051232A File Offset: 0x0051052A
	public UUIItem GetTaskToggleItem()
	{
		return base.GetExtendToggle(4).RootUIComp;
	}

	// Token: 0x060141AF RID: 82351 RVA: 0x0051233D File Offset: 0x0051053D
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x04009782 RID: 38786
	private const int TICK_INTERVAL = 1000;

	// Token: 0x04009783 RID: 38787
	private const int ONLINE_LIMIT_TAG_ID = 9;

	// Token: 0x04009784 RID: 38788
	public int QuestId;

	// Token: 0x04009785 RID: 38789
	public long TreeId;

	// Token: 0x04009786 RID: 38790
	public int QuestType;

	// Token: 0x04009787 RID: 38791
	private bool IsNeedCountDown;

	// Token: 0x04009788 RID: 38792
	private float TickTime;

	// Token: 0x04009789 RID: 38793
	[Nullable(2)]
	private readonly TQuestItemSelectHandle ToggleSelectHandle;

	// Token: 0x0400978A RID: 38794
	[Nullable(2)]
	private UUIExtendToggleSpriteTransition ToggleSpriteComponent;

	// Token: 0x02008C9A RID: 35994
	[NullableContext(0)]
	private class EQuestItemComponent
	{
		// Token: 0x0402DA24 RID: 186916
		public const int TrackIcon = 0;

		// Token: 0x0402DA25 RID: 186917
		public const int LockIcon = 1;

		// Token: 0x0402DA26 RID: 186918
		public const int QuestNameText1 = 2;

		// Token: 0x0402DA27 RID: 186919
		public const int QuestDistanceText1 = 3;

		// Token: 0x0402DA28 RID: 186920
		public const int Toggle = 4;

		// Token: 0x0402DA29 RID: 186921
		public const int ColorSprite = 5;

		// Token: 0x0402DA2A RID: 186922
		public const int RedDot = 6;

		// Token: 0x0402DA2B RID: 186923
		public const int YellowDot = 7;

		// Token: 0x0402DA2C RID: 186924
		public const int FunctionIcon = 8;

		// Token: 0x0402DA2D RID: 186925
		public const int FunctionSpriteIcon = 9;

		// Token: 0x0402DA2E RID: 186926
		public const int ConditionText = 10;

		// Token: 0x0402DA2F RID: 186927
		public const int QuestTagRoot = 11;

		// Token: 0x0402DA30 RID: 186928
		public const int QuestTagBgSprite = 12;

		// Token: 0x0402DA31 RID: 186929
		public const int QuestTagText = 13;

		// Token: 0x0402DA32 RID: 186930
		public const int FocusModeSprite = 14;

		// Token: 0x0402DA33 RID: 186931
		public const int CircleSprite = 15;

		// Token: 0x0402DA34 RID: 186932
		public const int TrackBgSprite = 16;
	}
}
