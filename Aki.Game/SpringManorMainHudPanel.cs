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

// Token: 0x020011D7 RID: 4567
[NullableContext(2)]
[Nullable(0)]
public class SpringManorMainHudPanel : BattleChildViewPanel
{
	// Token: 0x0600B51C RID: 46364 RVA: 0x00357E60 File Offset: 0x00356060
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

	// Token: 0x0600B51D RID: 46365 RVA: 0x003581A8 File Offset: 0x003563A8
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorMainHudPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorMainHudPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B51E RID: 46366 RVA: 0x003581EC File Offset: 0x003563EC
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

	// Token: 0x0600B51F RID: 46367 RVA: 0x00358252 File Offset: 0x00356452
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer atmosphereSeqPlayer = this.AtmosphereSeqPlayer;
		if (atmosphereSeqPlayer == null)
		{
			return;
		}
		atmosphereSeqPlayer.Clear();
	}

	// Token: 0x0600B520 RID: 46368 RVA: 0x00358264 File Offset: 0x00356464
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

	// Token: 0x0600B521 RID: 46369 RVA: 0x00358358 File Offset: 0x00356558
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

	// Token: 0x0600B522 RID: 46370 RVA: 0x00358438 File Offset: 0x00356638
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

	// Token: 0x0600B523 RID: 46371 RVA: 0x003584A0 File Offset: 0x003566A0
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

	// Token: 0x0600B524 RID: 46372 RVA: 0x003584EB File Offset: 0x003566EB
	private void OnAtmosphereUpdate()
	{
		this.RefreshAtmosphere();
		this.RefreshRedDot();
	}

	// Token: 0x0600B525 RID: 46373 RVA: 0x003584F9 File Offset: 0x003566F9
	[NullableContext(1)]
	private void AddNewQuest(TQuest quest)
	{
		this.OnActivityUpdate();
	}

	// Token: 0x0600B526 RID: 46374 RVA: 0x00358501 File Offset: 0x00356701
	private void OnActivityUpdate()
	{
		this.RefreshAtmosphere();
		this.RefreshFunctionButtonVisible();
		this.RefreshRedDot();
	}

	// Token: 0x0600B527 RID: 46375 RVA: 0x00358518 File Offset: 0x00356718
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

	// Token: 0x0600B528 RID: 46376 RVA: 0x003585D3 File Offset: 0x003567D3
	private void InitializeBattleViewPanel()
	{
		this.Visible = true;
		base.ShowBattleChildViewPanel();
	}

	// Token: 0x0600B529 RID: 46377 RVA: 0x003585E4 File Offset: 0x003567E4
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

	// Token: 0x0600B52A RID: 46378 RVA: 0x003586B0 File Offset: 0x003568B0
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

	// Token: 0x0600B52B RID: 46379 RVA: 0x00358728 File Offset: 0x00356928
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

	// Token: 0x0600B52C RID: 46380 RVA: 0x00358748 File Offset: 0x00356948
	public override void Reset()
	{
		MissionPanel missionPanel = this.MissionPanel;
		if (missionPanel == null)
		{
			return;
		}
		missionPanel.Reset();
	}

	// Token: 0x0600B52D RID: 46381 RVA: 0x0035875A File Offset: 0x0035695A
	public override void OnAfterTickBattleChildViewPanel(float delta)
	{
		TrackedMarksView trackPanel = this.TrackPanel;
		if (trackPanel == null)
		{
			return;
		}
		trackPanel.Update(delta);
	}

	// Token: 0x0600B52E RID: 46382 RVA: 0x00358770 File Offset: 0x00356970
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

	// Token: 0x0600B52F RID: 46383 RVA: 0x003587B0 File Offset: 0x003569B0
	private UniTask NewFullScreenPanel()
	{
		SpringManorMainHudPanel.<NewFullScreenPanel>d__32 <NewFullScreenPanel>d__;
		<NewFullScreenPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewFullScreenPanel>d__.<>4__this = this;
		<NewFullScreenPanel>d__.<>1__state = -1;
		<NewFullScreenPanel>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewFullScreenPanel>d__32>(ref <NewFullScreenPanel>d__);
		return <NewFullScreenPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B530 RID: 46384 RVA: 0x003587F4 File Offset: 0x003569F4
	private UniTask NewTrackedMarksView()
	{
		SpringManorMainHudPanel.<NewTrackedMarksView>d__33 <NewTrackedMarksView>d__;
		<NewTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewTrackedMarksView>d__.<>4__this = this;
		<NewTrackedMarksView>d__.<>1__state = -1;
		<NewTrackedMarksView>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewTrackedMarksView>d__33>(ref <NewTrackedMarksView>d__);
		return <NewTrackedMarksView>d__.<>t__builder.Task;
	}

	// Token: 0x0600B531 RID: 46385 RVA: 0x00358838 File Offset: 0x00356A38
	private UniTask NewMissionPanel()
	{
		SpringManorMainHudPanel.<NewMissionPanel>d__34 <NewMissionPanel>d__;
		<NewMissionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewMissionPanel>d__.<>4__this = this;
		<NewMissionPanel>d__.<>1__state = -1;
		<NewMissionPanel>d__.<>t__builder.Start<SpringManorMainHudPanel.<NewMissionPanel>d__34>(ref <NewMissionPanel>d__);
		return <NewMissionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B532 RID: 46386 RVA: 0x0035887B File Offset: 0x00356A7B
	public void SetTipsVisible(bool visible)
	{
		UUIItem timeTipsItem = this.TimeTipsItem;
		if (timeTipsItem == null)
		{
			return;
		}
		timeTipsItem.SetUIActive(visible);
	}

	// Token: 0x0600B533 RID: 46387 RVA: 0x00358890 File Offset: 0x00356A90
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

	// Token: 0x0600B534 RID: 46388 RVA: 0x003588C8 File Offset: 0x00356AC8
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

	// Token: 0x0600B535 RID: 46389 RVA: 0x0035891C File Offset: 0x00356B1C
	private int GetNeedTraceMainQuestId()
	{
		return SpringManorModel.Instance.GetMainQuestId().GetValueOrDefault();
	}

	// Token: 0x0600B536 RID: 46390 RVA: 0x0035893C File Offset: 0x00356B3C
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

	// Token: 0x0600B537 RID: 46391 RVA: 0x00358A0C File Offset: 0x00356C0C
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

	// Token: 0x0600B538 RID: 46392 RVA: 0x00358B4B File Offset: 0x00356D4B
	private void OnAtmosphereStageUpAnimationChange(float value)
	{
		UUISliderComponent atmosphereProgressBar = this.AtmosphereProgressBar;
		if (atmosphereProgressBar == null)
		{
			return;
		}
		atmosphereProgressBar.SetValue(value, true);
	}

	// Token: 0x0600B539 RID: 46393 RVA: 0x00358B60 File Offset: 0x00356D60
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

	// Token: 0x0600B53A RID: 46394 RVA: 0x00358CA4 File Offset: 0x00356EA4
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

	// Token: 0x0600B53B RID: 46395 RVA: 0x00358D67 File Offset: 0x00356F67
	private void ClearTweener()
	{
		if (this.AtmosphereTweener != null)
		{
			this.AtmosphereTweener.Kill(false);
			this.AtmosphereTweener = null;
		}
	}

	// Token: 0x0600B53C RID: 46396 RVA: 0x00358D84 File Offset: 0x00356F84
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

	// Token: 0x0600B53D RID: 46397 RVA: 0x00358EB4 File Offset: 0x003570B4
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

	// Token: 0x0600B53E RID: 46398 RVA: 0x00358F04 File Offset: 0x00357104
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

	// Token: 0x0600B53F RID: 46399 RVA: 0x00358F5E File Offset: 0x0035715E
	private void OnClickAtmosphere()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x0600B540 RID: 46400 RVA: 0x00358F74 File Offset: 0x00357174
	private UniTask InitializeFunctionButton()
	{
		SpringManorMainHudPanel.<InitializeFunctionButton>d__52 <InitializeFunctionButton>d__;
		<InitializeFunctionButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFunctionButton>d__.<>4__this = this;
		<InitializeFunctionButton>d__.<>1__state = -1;
		<InitializeFunctionButton>d__.<>t__builder.Start<SpringManorMainHudPanel.<InitializeFunctionButton>d__52>(ref <InitializeFunctionButton>d__);
		return <InitializeFunctionButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600B541 RID: 46401 RVA: 0x00358FB7 File Offset: 0x003571B7
	private void InitializeFunctionButtonMap()
	{
		this.FunctionButtonMap[ESpringFunctionType.Gameplay] = base.GetItem(12);
		this.FunctionButtonMap[ESpringFunctionType.DIY] = base.GetItem(14);
	}

	// Token: 0x0600B542 RID: 46402 RVA: 0x00358FE4 File Offset: 0x003571E4
	private void RefreshFunctionButtonVisible()
	{
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		foreach (KeyValuePair<ESpringFunctionType, UUIItem> keyValuePair in this.FunctionButtonMap)
		{
			bool uiactive = activityData.IsFunctionUnlocked(keyValuePair.Key);
			keyValuePair.Value.SetUIActive(uiactive);
		}
	}

	// Token: 0x0600B543 RID: 46403 RVA: 0x00359058 File Offset: 0x00357258
	private void OnClickExit()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattleViewLeaveInstance);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			SpringManorController.Instance.LeaveInstanceDungeonRequest();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600B544 RID: 46404 RVA: 0x003590A3 File Offset: 0x003572A3
	private void OnClickSetting()
	{
		UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
	}

	// Token: 0x0600B545 RID: 46405 RVA: 0x003590B6 File Offset: 0x003572B6
	private void OnClickQuest()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorQuestView, null, null);
	}

	// Token: 0x0600B546 RID: 46406 RVA: 0x003590C9 File Offset: 0x003572C9
	private void OnClickGameplay()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorGameplayEntryView, null, null);
	}

	// Token: 0x0600B547 RID: 46407 RVA: 0x003590DC File Offset: 0x003572DC
	private void OnClickDiy()
	{
		FurnitureController.Instance.OpenFurnitureAreaSelectView();
	}

	// Token: 0x0600B548 RID: 46408 RVA: 0x003590E8 File Offset: 0x003572E8
	private void OnClickReward()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorRewardView, null, null);
	}

	// Token: 0x0600B549 RID: 46409 RVA: 0x003590FB File Offset: 0x003572FB
	private void OnClickOpenPhotograph()
	{
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Photograph);
	}

	// Token: 0x0600B54A RID: 46410 RVA: 0x0035910C File Offset: 0x0035730C
	private void OnClickRoleSwitch()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorRoleSwitchView, null, null);
	}

	// Token: 0x040068CE RID: 26830
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly EBattleUiChild[] controlBattleChildUiChildList = new EBattleUiChild[]
	{
		EBattleUiChild.BattleFloat,
		EBattleUiChild.InteractionHint,
		EBattleUiChild.SpringManorHud,
		EBattleUiChild.ScreenEffect
	};

	// Token: 0x040068CF RID: 26831
	private MissionPanel MissionPanel;

	// Token: 0x040068D0 RID: 26832
	[Nullable(1)]
	private readonly Dictionary<ESpringFunctionType, UUIItem> FunctionButtonMap = new Dictionary<ESpringFunctionType, UUIItem>();

	// Token: 0x040068D1 RID: 26833
	private TrackedMarksView TrackPanel;

	// Token: 0x040068D2 RID: 26834
	private FullScreenPanel FullScreenPanel;

	// Token: 0x040068D3 RID: 26835
	private UUIItem TimeTipsItem;

	// Token: 0x040068D4 RID: 26836
	private UUIText TimeTipsText;

	// Token: 0x040068D5 RID: 26837
	[Nullable(1)]
	private readonly string TimeLimitString = ConfigMultiTextLang.GetLocalTextNew("Spring26_MainHud_MissionRemain", null) ?? "";

	// Token: 0x040068D6 RID: 26838
	private LevelSequencePlayer AtmosphereSeqPlayer;

	// Token: 0x040068D7 RID: 26839
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040068D8 RID: 26840
	private UUISliderComponent AtmosphereProgressBar;

	// Token: 0x040068D9 RID: 26841
	private SpringManorQuestButton QuestButton;

	// Token: 0x040068DA RID: 26842
	private int CurrentTraceMainQuestId;

	// Token: 0x040068DB RID: 26843
	private ULTweener AtmosphereTweener;

	// Token: 0x040068DC RID: 26844
	private AtmosphereStageUpParam AtmosphereStageUpParam;

	// Token: 0x02007488 RID: 29832
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x04025EBF RID: 155327
		public const int BtnExit = 0;

		// Token: 0x04025EC0 RID: 155328
		public const int BtnSetting = 1;

		// Token: 0x04025EC1 RID: 155329
		public const int CostRoot = 2;

		// Token: 0x04025EC2 RID: 155330
		public const int PassBg1 = 3;

		// Token: 0x04025EC3 RID: 155331
		public const int PassBg2 = 4;

		// Token: 0x04025EC4 RID: 155332
		public const int PassBg3 = 5;

		// Token: 0x04025EC5 RID: 155333
		public const int PassLevel = 6;

		// Token: 0x04025EC6 RID: 155334
		public const int PassName = 7;

		// Token: 0x04025EC7 RID: 155335
		public const int PassSliderBar = 8;

		// Token: 0x04025EC8 RID: 155336
		public const int PassProgress = 9;

		// Token: 0x04025EC9 RID: 155337
		public const int BtnQuest = 10;

		// Token: 0x04025ECA RID: 155338
		public const int QuestContentLayout = 11;

		// Token: 0x04025ECB RID: 155339
		public const int BtnGameplay = 12;

		// Token: 0x04025ECC RID: 155340
		public const int BtnReward = 13;

		// Token: 0x04025ECD RID: 155341
		public const int BtnDIY = 14;

		// Token: 0x04025ECE RID: 155342
		public const int TimeTips = 15;

		// Token: 0x04025ECF RID: 155343
		public const int TimeTipsText = 16;

		// Token: 0x04025ED0 RID: 155344
		public const int BtnTimeTips = 17;

		// Token: 0x04025ED1 RID: 155345
		public const int TrackItem = 18;

		// Token: 0x04025ED2 RID: 155346
		public const int BtnAtmosphere = 19;

		// Token: 0x04025ED3 RID: 155347
		public const int AtmospherePanel = 20;

		// Token: 0x04025ED4 RID: 155348
		public const int BtnGameplayRedDotItem = 21;

		// Token: 0x04025ED5 RID: 155349
		public const int BtnDIYRedDotItem = 22;

		// Token: 0x04025ED6 RID: 155350
		public const int BtnRewardRedDotItem = 23;

		// Token: 0x04025ED7 RID: 155351
		public const int BtnCamera = 24;

		// Token: 0x04025ED8 RID: 155352
		public const int BtnSwitch = 25;

		// Token: 0x04025ED9 RID: 155353
		public const int BtnAtmosphereRedDotItem = 26;

		// Token: 0x04025EDA RID: 155354
		public const int HideLeft = 27;

		// Token: 0x04025EDB RID: 155355
		public const int HideRight = 28;

		// Token: 0x04025EDC RID: 155356
		public const int FullScreenPanel = 29;
	}
}
