using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D15 RID: 7445
[NullableContext(2)]
[Nullable(0)]
public class SpringManorMainHudPanel : BattleChildViewPanel
{
	// Token: 0x0600E0FF RID: 57599 RVA: 0x0034C430 File Offset: 0x0034A630
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIArtText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickExit)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickSetting)),
			new ValueTuple<int, Delegate>(19, new Action(this.OnClickAtmosphere)),
			new ValueTuple<int, Delegate>(24, new Action(this.OnClickOpenPhotograph)),
			new ValueTuple<int, Delegate>(25, new Action(this.OnClickRoleSwitch))
		};
	}

	// Token: 0x0600E100 RID: 57600 RVA: 0x0034C778 File Offset: 0x0034A978
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorMainHudPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorMainHudPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E101 RID: 57601 RVA: 0x0034C7BC File Offset: 0x0034A9BC
	protected override void OnStart()
	{
		this.InitializeBattleViewPanel();
		this.InitializeFunctionButtonMap();
		this.TimeTipsItem = base.GetItem(15);
		this.TimeTipsText = base.GetText(16);
		this.AtmosphereProgressBar = base.GetSlider(8);
		this.AtmosphereSeqPlayer = new LevelSequencePlayer(base.GetItem(20));
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600E102 RID: 57602 RVA: 0x0034C822 File Offset: 0x0034AA22
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer atmosphereSeqPlayer = this.AtmosphereSeqPlayer;
		if (atmosphereSeqPlayer == null)
		{
			return;
		}
		atmosphereSeqPlayer.Clear();
	}

	// Token: 0x0600E103 RID: 57603 RVA: 0x0034C834 File Offset: 0x0034AA34
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.SpringManorFunctionOpenNotify, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add(EEventName.SpringManorAtmosphereUpdate, new Action(this.OnAtmosphereUpdate));
		EventSystem.Instance.Add(EEventName.SpringManorTaskUpdateNotify, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add<TQuest>(EEventName.OnAddNewQuest, new Action<TQuest>(this.AddNewQuest));
		RedDotController.Instance.BindRedDot(ERedDotName.FurnitureEntranceRedDot, base.GetItem(22), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.SpringManorGameEntrance, base.GetItem(21), null, 0);
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		if (childViewData != null)
		{
			childViewData.AddCallback(EBattleUiChild.SpringManorHud, new Action(this.OnBattleViewChildVisibleChanged));
		}
		BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
		if (childViewData2 == null)
		{
			return;
		}
		childViewData2.AddCallback(EBattleUiChild.Mission, new Action(this.RefreshMissionRootPanelVisible));
	}

	// Token: 0x0600E104 RID: 57604 RVA: 0x0034C928 File Offset: 0x0034AB28
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SpringManorFunctionOpenNotify, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove(EEventName.SpringManorAtmosphereUpdate, new Action(this.OnAtmosphereUpdate));
		EventSystem.Instance.Remove(EEventName.SpringManorTaskUpdateNotify, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove(EEventName.OnAddNewQuest, new Action<TQuest>(this.AddNewQuest));
		RedDotController.Instance.UnBindRedDot(ERedDotName.FurnitureEntranceRedDot);
		RedDotController.Instance.UnBindRedDot(ERedDotName.SpringManorGameEntrance);
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		if (childViewData != null)
		{
			childViewData.RemoveCallback(EBattleUiChild.SpringManorHud, new Action(this.OnBattleViewChildVisibleChanged));
		}
		BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
		if (childViewData2 == null)
		{
			return;
		}
		childViewData2.RemoveCallback(EBattleUiChild.Mission, new Action(this.RefreshMissionRootPanelVisible));
	}

	// Token: 0x0600E105 RID: 57605 RVA: 0x0034CA08 File Offset: 0x0034AC08
	private void OnBattleViewChildVisibleChanged()
	{
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		bool? flag = (childViewData != null) ? new bool?(childViewData.GetChildVisible(EBattleUiChild.SpringManorHud)) : null;
		UUIItem item = base.GetItem(27);
		if (item != null)
		{
			item.SetUIActive(flag.GetValueOrDefault());
		}
		UUIItem item2 = base.GetItem(28);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(flag.GetValueOrDefault());
	}

	// Token: 0x0600E106 RID: 57606 RVA: 0x0034CA70 File Offset: 0x0034AC70
	private void RefreshMissionRootPanelVisible()
	{
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		bool? flag = (childViewData != null) ? new bool?(childViewData.GetChildVisible(EBattleUiChild.Mission)) : null;
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(flag.GetValueOrDefault());
	}

	// Token: 0x0600E107 RID: 57607 RVA: 0x0034CABB File Offset: 0x0034ACBB
	private void OnAtmosphereUpdate()
	{
		this.RefreshAtmosphere();
		this.RefreshRedDot();
	}

	// Token: 0x0600E108 RID: 57608 RVA: 0x0034CAC9 File Offset: 0x0034ACC9
	[NullableContext(1)]
	private void AddNewQuest(TQuest quest)
	{
		this.OnActivityUpdate();
	}

	// Token: 0x0600E109 RID: 57609 RVA: 0x0034CAD1 File Offset: 0x0034ACD1
	private void OnActivityUpdate()
	{
		this.RefreshAtmosphere();
		this.RefreshFunctionButtonVisible();
		this.RefreshRedDot();
	}

	// Token: 0x0600E10A RID: 57610 RVA: 0x0034CAE8 File Offset: 0x0034ACE8
	private void RefreshRedDot()
	{
		SpringManorModel instance = SpringManorModel.Instance;
		bool? flag;
		if (instance == null)
		{
			flag = null;
		}
		else
		{
			SpringManorData activityData = instance.ActivityData;
			flag = ((activityData != null) ? new bool?(activityData.HasAtmosphereRedDot()) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault = flag2.GetValueOrDefault();
		UUIItem item = base.GetItem(26);
		if (item != null)
		{
			item.SetUIActive(valueOrDefault);
		}
		SpringManorModel instance2 = SpringManorModel.Instance;
		bool? flag3;
		if (instance2 == null)
		{
			flag3 = null;
		}
		else
		{
			SpringManorData activityData2 = instance2.ActivityData;
			flag3 = ((activityData2 != null) ? new bool?(activityData2.HasRewardRedDot()) : null);
		}
		flag2 = flag3;
		bool valueOrDefault2 = flag2.GetValueOrDefault();
		UUIItem item2 = base.GetItem(23);
		if (item2 != null)
		{
			item2.SetUIActive(valueOrDefault2);
		}
		SpringManorQuestButton questButton = this.QuestButton;
		if (questButton == null)
		{
			return;
		}
		questButton.RefreshRedDot();
	}

	// Token: 0x0600E10B RID: 57611 RVA: 0x0034CBA3 File Offset: 0x0034ADA3
	private void InitializeBattleViewPanel()
	{
		this.Visible = true;
		base.ShowBattleChildViewPanel();
	}

	// Token: 0x0600E10C RID: 57612 RVA: 0x0034CBB4 File Offset: 0x0034ADB4
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		TrackedMarksView trackPanel = this.TrackPanel;
		if (trackPanel != null)
		{
			trackPanel.OnShowBattleChildViewPanel();
		}
		MissionPanel missionPanel = this.MissionPanel;
		if (missionPanel != null)
		{
			missionPanel.ShowBattleChildViewPanel();
		}
		this.RefreshMissionRootPanelVisible();
		this.SetBattleChildViewPanelVisible(true);
		SpringManorModel instance = SpringManorModel.Instance;
		if (((instance != null) ? instance.ActivityData : null) != null)
		{
			this.OnActivityUpdate();
		}
		else
		{
			EventSystem.Instance.Once(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 != null)
		{
			seqPlayer2.PlaySequencePurely(isFirst ? "Start" : "ShowView", false, false, null, null, false);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFurnitureEntranceRedDot);
		this.AddEventListener();
	}

	// Token: 0x0600E10D RID: 57613 RVA: 0x0034CC80 File Offset: 0x0034AE80
	protected override void OnHideBattleChildViewPanel()
	{
		TrackedMarksView trackPanel = this.TrackPanel;
		if (trackPanel != null)
		{
			trackPanel.OnHideBattleChildViewPanel();
		}
		MissionPanel missionPanel = this.MissionPanel;
		if (missionPanel != null)
		{
			missionPanel.HideBattleChildViewPanel();
		}
		this.SetBattleChildViewPanelVisible(false);
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 != null)
		{
			seqPlayer2.PlaySequencePurely("Close", false, false, null, null, false);
		}
		this.ClearTweener();
		this.RemoveEventListener();
	}

	// Token: 0x0600E10E RID: 57614 RVA: 0x0034CCF8 File Offset: 0x0034AEF8
	public override void OnTickBattleChildViewPanel(float delta)
	{
		this.CheckMissionTrack();
		MissionPanel missionPanel = this.MissionPanel;
		if (missionPanel != null)
		{
			missionPanel.OnTickBattleChildViewPanel(delta);
		}
		this.RefreshTimeText();
	}

	// Token: 0x0600E10F RID: 57615 RVA: 0x0034CD18 File Offset: 0x0034AF18
	public override void Reset()
	{
		MissionPanel missionPanel = this.MissionPanel;
		if (missionPanel == null)
		{
			return;
		}
		missionPanel.Reset();
	}

	// Token: 0x0600E110 RID: 57616 RVA: 0x0034CD2A File Offset: 0x0034AF2A
	public override void OnAfterTickBattleChildViewPanel(float delta)
	{
		TrackedMarksView trackPanel = this.TrackPanel;
		if (trackPanel == null)
		{
			return;
		}
		trackPanel.Update(delta);
	}

	// Token: 0x0600E111 RID: 57617 RVA: 0x0034CD40 File Offset: 0x0034AF40
	private void SetBattleChildViewPanelVisible(bool visible)
	{
		foreach (EBattleUiChild childType in SpringManorMainHudPanel.controlBattleChildUiChildList)
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Default, childType, visible, true, 0);
			}
		}
	}

	// Token: 0x0600E112 RID: 57618 RVA: 0x0034CD80 File Offset: 0x0034AF80
	private UniTask NewFullScreenPanel()
	{
		SpringManorMainHudPanel.<NewFullScreenPanel>d__32 <NewFullScreenPanel>d__;
		<NewFullScreenPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewFullScreenPanel>d__.<>4__this = this;
		<NewFullScreenPanel>d__.<>1__state = -1;
		<NewFullScreenPanel>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewFullScreenPanel>d__32>(ref <NewFullScreenPanel>d__);
		return <NewFullScreenPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E113 RID: 57619 RVA: 0x0034CDC4 File Offset: 0x0034AFC4
	private UniTask NewTrackedMarksView()
	{
		SpringManorMainHudPanel.<NewTrackedMarksView>d__33 <NewTrackedMarksView>d__;
		<NewTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewTrackedMarksView>d__.<>4__this = this;
		<NewTrackedMarksView>d__.<>1__state = -1;
		<NewTrackedMarksView>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewTrackedMarksView>d__33>(ref <NewTrackedMarksView>d__);
		return <NewTrackedMarksView>d__.<>t__builder.Task;
	}

	// Token: 0x0600E114 RID: 57620 RVA: 0x0034CE08 File Offset: 0x0034B008
	private UniTask NewMissionPanel()
	{
		SpringManorMainHudPanel.<NewMissionPanel>d__34 <NewMissionPanel>d__;
		<NewMissionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewMissionPanel>d__.<>4__this = this;
		<NewMissionPanel>d__.<>1__state = -1;
		<NewMissionPanel>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewMissionPanel>d__34>(ref <NewMissionPanel>d__);
		return <NewMissionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E115 RID: 57621 RVA: 0x0034CE4B File Offset: 0x0034B04B
	public void SetTipsVisible(bool visible)
	{
		UUIItem timeTipsItem = this.TimeTipsItem;
		if (timeTipsItem == null)
		{
			return;
		}
		timeTipsItem.SetUIActive(visible);
	}

	// Token: 0x0600E116 RID: 57622 RVA: 0x0034CE60 File Offset: 0x0034B060
	[NullableContext(1)]
	public void SetTipsText(string str)
	{
		string newText = StringUtils.Format(this.TimeLimitString, new string[]
		{
			str
		});
		UUIText timeTipsText = this.TimeTipsText;
		if (timeTipsText == null)
		{
			return;
		}
		timeTipsText.SetText(newText, true);
	}

	// Token: 0x0600E117 RID: 57623 RVA: 0x0034CE98 File Offset: 0x0034B098
	private void RefreshTimeText()
	{
		if (this.CurrentTraceMainQuestId != 0 || SpringManorModel.Instance.CheckMainQuestIsFinished())
		{
			this.SetTipsVisible(false);
			return;
		}
		int needTraceMainQuestId = this.GetNeedTraceMainQuestId();
		string mainQuestRemainTimeText = SpringManorModel.Instance.GetMainQuestRemainTimeText(needTraceMainQuestId, null);
		this.SetTipsVisible(mainQuestRemainTimeText != null);
		if (mainQuestRemainTimeText != null)
		{
			this.SetTipsText(mainQuestRemainTimeText);
		}
	}

	// Token: 0x0600E118 RID: 57624 RVA: 0x0034CEEC File Offset: 0x0034B0EC
	private int GetNeedTraceMainQuestId()
	{
		return SpringManorModel.Instance.GetMainQuestId().GetValueOrDefault();
	}

	// Token: 0x0600E119 RID: 57625 RVA: 0x0034CF0C File Offset: 0x0034B10C
	public void CheckMissionTrack()
	{
		int needTraceMainQuestId = this.GetNeedTraceMainQuestId();
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		int num = needTraceMainQuestId;
		int? num2 = (curTrackedQuest != null) ? new int?(curTrackedQuest.Id) : null;
		if (num == num2.GetValueOrDefault() & num2 != null)
		{
			this.CurrentTraceMainQuestId = needTraceMainQuestId;
			return;
		}
		global::Quest quest = QuestNewModel.Instance.GetQuest(needTraceMainQuestId);
		if (quest == null || quest.IsSuspend())
		{
			if (curTrackedQuest != null)
			{
				QuestNewController.Instance.RequestTrackQuest(curTrackedQuest.Id, false, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
			}
			this.CurrentTraceMainQuestId = 0;
			return;
		}
		this.CurrentTraceMainQuestId = needTraceMainQuestId;
		QuestNewController.Instance.RequestTrackQuest(needTraceMainQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
		EventSystem.Instance.Emit<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, quest.Tree.BtType, new long?(quest.Tree.TreeIncId));
	}

	// Token: 0x0600E11A RID: 57626 RVA: 0x0034CFDC File Offset: 0x0034B1DC
	private void PlayAtmosphereStageUpAnimation()
	{
		if (this.AtmosphereStageUpParam == null)
		{
			return;
		}
		SpringManorModel instance = SpringManorModel.Instance;
		int atmosphere = instance.ActivityData.GetAtmosphere();
		int nextLevel = instance.GetNextLevel();
		int levelNeedExp = instance.GetLevelNeedExp(nextLevel);
		this.RefreshAtmosphereProgressText(this.AtmosphereStageUpParam.OldLevel, atmosphere, levelNeedExp);
		int oldLevel = this.AtmosphereStageUpParam.OldLevel;
		AtmosphereLevel? levelConfigById = SpringManorConfig.Instance.GetLevelConfigById(oldLevel);
		if (levelConfigById == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SpringManor;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("获取不到等级配置！");
			defaultInterpolatedStringHandler.AppendFormatted<int>(oldLevel);
			instance2.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float startValue = MathUtils.Instance.Clamp((float)((this.AtmosphereStageUpParam.OldAtmosphere - levelConfigById.Value.AtmosphereNeed) / levelConfigById.Value.AtmosphereNext), 0f, 1f);
		this.AtmosphereTweener = ULTweenBPLibrary.FloatTo(this.RootActor, DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnAtmosphereStageUpAnimationChange)), startValue, 1f, 1f, 0f, LTweenEase.OutCubic);
		this.AtmosphereTweener.OnCompleteCallBack.Bind(new Action(this.OnAtmosphereStageUpAnimationCompleted));
	}

	// Token: 0x0600E11B RID: 57627 RVA: 0x0034D11B File Offset: 0x0034B31B
	private void OnAtmosphereStageUpAnimationChange(float value)
	{
		UUISliderComponent atmosphereProgressBar = this.AtmosphereProgressBar;
		if (atmosphereProgressBar == null)
		{
			return;
		}
		atmosphereProgressBar.SetValue(value, true);
	}

	// Token: 0x0600E11C RID: 57628 RVA: 0x0034D130 File Offset: 0x0034B330
	private void OnAtmosphereStageUpAnimationCompleted()
	{
		this.ClearTweener();
		SpringManorModel instance = SpringManorModel.Instance;
		int atmosphereLevel = instance.GetAtmosphereLevel();
		UUIArtText artText = base.GetArtText(6);
		if (artText != null)
		{
			artText.SetText(atmosphereLevel.ToString());
		}
		this.PlayAtmosphereStageUpBgAnimation(this.AtmosphereStageUpParam.Stage);
		int atmosphere = instance.ActivityData.GetAtmosphere();
		SpringManorConfig instance2 = SpringManorConfig.Instance;
		AtmosphereLevel? atmosphereLevel2 = (instance2 != null) ? instance2.GetLevelConfigById(atmosphereLevel) : null;
		if (atmosphereLevel2 == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module = ELogModule.SpringManor;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("获取不到等级配置！");
			defaultInterpolatedStringHandler.AppendFormatted<int>(atmosphereLevel);
			instance3.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float endValue = MathUtils.Instance.Clamp((float)((atmosphere - atmosphereLevel2.Value.AtmosphereNeed) / atmosphereLevel2.Value.AtmosphereNext), 0f, 1f);
		this.AtmosphereTweener = ULTweenBPLibrary.FloatTo(this.RootActor, DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnAtmosphereStageUpAnimationChange)), 0f, endValue, 1f, 0f, LTweenEase.OutCubic);
		this.AtmosphereTweener.OnCompleteCallBack.Bind(new Action(this.ClearTweener));
	}

	// Token: 0x0600E11D RID: 57629 RVA: 0x0034D274 File Offset: 0x0034B474
	private void PlayAtmosphereStageUpBgAnimation(int stage)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(stage == 1 || stage == 2);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(stage == 2 || stage == 3);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(stage == 3);
		}
		if (stage > 1)
		{
			string sequenceName = SpringManorDefine.atmosphereLevelUpSeqName[stage - 2];
			LevelSequencePlayer atmosphereSeqPlayer = this.AtmosphereSeqPlayer;
			if (atmosphereSeqPlayer != null)
			{
				atmosphereSeqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer atmosphereSeqPlayer2 = this.AtmosphereSeqPlayer;
			if (atmosphereSeqPlayer2 != null)
			{
				atmosphereSeqPlayer2.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
		}
		LevelSequencePlayer atmosphereSeqPlayer3 = this.AtmosphereSeqPlayer;
		if (atmosphereSeqPlayer3 == null)
		{
			return;
		}
		atmosphereSeqPlayer3.PlaySequencePurely("NumChange", false, false, null, null, false);
	}

	// Token: 0x0600E11E RID: 57630 RVA: 0x0034D337 File Offset: 0x0034B537
	private void ClearTweener()
	{
		if (this.AtmosphereTweener != null)
		{
			this.AtmosphereTweener.Kill(false);
			this.AtmosphereTweener = null;
		}
	}

	// Token: 0x0600E11F RID: 57631 RVA: 0x0034D354 File Offset: 0x0034B554
	public void RefreshAtmosphere()
	{
		if (this.AtmosphereTweener != null)
		{
			this.ClearTweener();
		}
		AtmosphereStageUpParam atmosphereStageUpParam = SpringManorModel.Instance.GetAtmosphereStageUpParam();
		if (atmosphereStageUpParam != null)
		{
			this.AtmosphereStageUpParam = atmosphereStageUpParam;
			this.PlayAtmosphereStageUpAnimation();
			return;
		}
		SpringManorModel instance = SpringManorModel.Instance;
		int atmosphereLevel = instance.GetAtmosphereLevel();
		int atmosphere = instance.ActivityData.GetAtmosphere();
		int nextLevel = instance.GetNextLevel();
		int levelNeedExp = instance.GetLevelNeedExp(nextLevel);
		int atmosphereLevelStage = instance.GetAtmosphereLevelStage(atmosphereLevel);
		this.RefreshPassBg(atmosphereLevelStage);
		this.RefreshAtmosphereProgressText(atmosphereLevel, atmosphere, levelNeedExp);
		SpringManorConfig instance2 = SpringManorConfig.Instance;
		AtmosphereLevel? atmosphereLevel2 = (instance2 != null) ? instance2.GetLevelConfigById(atmosphereLevel) : null;
		if (atmosphereLevel2 == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module = ELogModule.SpringManor;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("获取不到等级配置！");
			defaultInterpolatedStringHandler.AppendFormatted<int>(atmosphereLevel);
			instance3.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float inValue = MathUtils.Instance.Clamp((float)((atmosphere - atmosphereLevel2.Value.AtmosphereNeed) / atmosphereLevel2.Value.AtmosphereNext), 0f, 1f);
		UUISliderComponent atmosphereProgressBar = this.AtmosphereProgressBar;
		if (atmosphereProgressBar == null)
		{
			return;
		}
		atmosphereProgressBar.SetValue(inValue, true);
	}

	// Token: 0x0600E120 RID: 57632 RVA: 0x0034D484 File Offset: 0x0034B684
	public void RefreshPassBg(int stage)
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(stage == 1);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(stage == 2);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(stage == 3);
	}

	// Token: 0x0600E121 RID: 57633 RVA: 0x0034D4D4 File Offset: 0x0034B6D4
	public void RefreshAtmosphereProgressText(int curLevel, int curProgress, int targetProgress)
	{
		UUIArtText artText = base.GetArtText(6);
		if (artText != null)
		{
			artText.SetText(curLevel.ToString());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Spring26_MainHud_PassProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			curProgress,
			targetProgress
		}));
	}

	// Token: 0x0600E122 RID: 57634 RVA: 0x0034D52E File Offset: 0x0034B72E
	private void OnClickAtmosphere()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x0600E123 RID: 57635 RVA: 0x0034D544 File Offset: 0x0034B744
	private UniTask InitializeFunctionButton()
	{
		SpringManorMainHudPanel.<InitializeFunctionButton>d__52 <InitializeFunctionButton>d__;
		<InitializeFunctionButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFunctionButton>d__.<>4__this = this;
		<InitializeFunctionButton>d__.<>1__state = -1;
		<InitializeFunctionButton>d__.<>t__builder.Start<SpringManorMainHudPanel.<InitializeFunctionButton>d__52>(ref <InitializeFunctionButton>d__);
		return <InitializeFunctionButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600E124 RID: 57636 RVA: 0x0034D587 File Offset: 0x0034B787
	private void InitializeFunctionButtonMap()
	{
		this.FunctionButtonMap[ESpringFunctionType.Gameplay] = base.GetItem(12);
		this.FunctionButtonMap[ESpringFunctionType.DIY] = base.GetItem(14);
	}

	// Token: 0x0600E125 RID: 57637 RVA: 0x0034D5B4 File Offset: 0x0034B7B4
	private void RefreshFunctionButtonVisible()
	{
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		foreach (KeyValuePair<ESpringFunctionType, UUIItem> keyValuePair in this.FunctionButtonMap)
		{
			bool uiactive = activityData.IsFunctionUnlocked(keyValuePair.Key);
			keyValuePair.Value.SetUIActive(uiactive);
		}
	}

	// Token: 0x0600E126 RID: 57638 RVA: 0x0034D628 File Offset: 0x0034B828
	private void OnClickExit()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattleViewLeaveInstance);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			SpringManorController.Instance.LeaveInstanceDungeonRequest();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600E127 RID: 57639 RVA: 0x0034D673 File Offset: 0x0034B873
	private void OnClickSetting()
	{
		UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
	}

	// Token: 0x0600E128 RID: 57640 RVA: 0x0034D686 File Offset: 0x0034B886
	private void OnClickQuest()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorQuestView, null, null);
	}

	// Token: 0x0600E129 RID: 57641 RVA: 0x0034D699 File Offset: 0x0034B899
	private void OnClickGameplay()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorGameplayEntryView, null, null);
	}

	// Token: 0x0600E12A RID: 57642 RVA: 0x0034D6AC File Offset: 0x0034B8AC
	private void OnClickDiy()
	{
		FurnitureController.Instance.OpenFurnitureAreaSelectView();
	}

	// Token: 0x0600E12B RID: 57643 RVA: 0x0034D6B8 File Offset: 0x0034B8B8
	private void OnClickReward()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorRewardView, null, null);
	}

	// Token: 0x0600E12C RID: 57644 RVA: 0x0034D6CB File Offset: 0x0034B8CB
	private void OnClickOpenPhotograph()
	{
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Photograph);
	}

	// Token: 0x0600E12D RID: 57645 RVA: 0x0034D6DC File Offset: 0x0034B8DC
	private void OnClickRoleSwitch()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorRoleSwitchView, null, null);
	}

	// Token: 0x040067EF RID: 26607
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly EBattleUiChild[] controlBattleChildUiChildList = new EBattleUiChild[]
	{
		EBattleUiChild.BattleFloat,
		EBattleUiChild.InteractionHint,
		EBattleUiChild.SpringManorHud,
		EBattleUiChild.ScreenEffect
	};

	// Token: 0x040067F0 RID: 26608
	private MissionPanel MissionPanel;

	// Token: 0x040067F1 RID: 26609
	[Nullable(1)]
	private readonly Dictionary<ESpringFunctionType, UUIItem> FunctionButtonMap = new Dictionary<ESpringFunctionType, UUIItem>();

	// Token: 0x040067F2 RID: 26610
	private TrackedMarksView TrackPanel;

	// Token: 0x040067F3 RID: 26611
	private FullScreenPanel FullScreenPanel;

	// Token: 0x040067F4 RID: 26612
	private UUIItem TimeTipsItem;

	// Token: 0x040067F5 RID: 26613
	private UUIText TimeTipsText;

	// Token: 0x040067F6 RID: 26614
	[Nullable(1)]
	private readonly string TimeLimitString = ConfigMultiTextLang.GetLocalTextNew("Spring26_MainHud_MissionRemain", null) ?? "";

	// Token: 0x040067F7 RID: 26615
	private LevelSequencePlayer AtmosphereSeqPlayer;

	// Token: 0x040067F8 RID: 26616
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040067F9 RID: 26617
	private UUISliderComponent AtmosphereProgressBar;

	// Token: 0x040067FA RID: 26618
	private SpringManorQuestButton QuestButton;

	// Token: 0x040067FB RID: 26619
	private int CurrentTraceMainQuestId;

	// Token: 0x040067FC RID: 26620
	private ULTweener AtmosphereTweener;

	// Token: 0x040067FD RID: 26621
	private AtmosphereStageUpParam AtmosphereStageUpParam;

	// Token: 0x020082FF RID: 33535
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x0402AB97 RID: 174999
		public const int BtnExit = 0;

		// Token: 0x0402AB98 RID: 175000
		public const int BtnSetting = 1;

		// Token: 0x0402AB99 RID: 175001
		public const int CostRoot = 2;

		// Token: 0x0402AB9A RID: 175002
		public const int PassBg1 = 3;

		// Token: 0x0402AB9B RID: 175003
		public const int PassBg2 = 4;

		// Token: 0x0402AB9C RID: 175004
		public const int PassBg3 = 5;

		// Token: 0x0402AB9D RID: 175005
		public const int PassLevel = 6;

		// Token: 0x0402AB9E RID: 175006
		public const int PassName = 7;

		// Token: 0x0402AB9F RID: 175007
		public const int PassSliderBar = 8;

		// Token: 0x0402ABA0 RID: 175008
		public const int PassProgress = 9;

		// Token: 0x0402ABA1 RID: 175009
		public const int BtnQuest = 10;

		// Token: 0x0402ABA2 RID: 175010
		public const int QuestContentLayout = 11;

		// Token: 0x0402ABA3 RID: 175011
		public const int BtnGameplay = 12;

		// Token: 0x0402ABA4 RID: 175012
		public const int BtnReward = 13;

		// Token: 0x0402ABA5 RID: 175013
		public const int BtnDIY = 14;

		// Token: 0x0402ABA6 RID: 175014
		public const int TimeTips = 15;

		// Token: 0x0402ABA7 RID: 175015
		public const int TimeTipsText = 16;

		// Token: 0x0402ABA8 RID: 175016
		public const int BtnTimeTips = 17;

		// Token: 0x0402ABA9 RID: 175017
		public const int TrackItem = 18;

		// Token: 0x0402ABAA RID: 175018
		public const int BtnAtmosphere = 19;

		// Token: 0x0402ABAB RID: 175019
		public const int AtmospherePanel = 20;

		// Token: 0x0402ABAC RID: 175020
		public const int BtnGameplayRedDotItem = 21;

		// Token: 0x0402ABAD RID: 175021
		public const int BtnDIYRedDotItem = 22;

		// Token: 0x0402ABAE RID: 175022
		public const int BtnRewardRedDotItem = 23;

		// Token: 0x0402ABAF RID: 175023
		public const int BtnCamera = 24;

		// Token: 0x0402ABB0 RID: 175024
		public const int BtnSwitch = 25;

		// Token: 0x0402ABB1 RID: 175025
		public const int BtnAtmosphereRedDotItem = 26;

		// Token: 0x0402ABB2 RID: 175026
		public const int HideLeft = 27;

		// Token: 0x0402ABB3 RID: 175027
		public const int HideRight = 28;

		// Token: 0x0402ABB4 RID: 175028
		public const int FullScreenPanel = 29;
	}
}
