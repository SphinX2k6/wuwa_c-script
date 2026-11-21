using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D4B RID: 19787
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionPanelChildStep : StepWithStatusItem, IStaticVariableResetter
	{
		// Token: 0x06031AC7 RID: 203463 RVA: 0x00DE48A8 File Offset: 0x00DE2AA8
		public MissionPanelChildStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
		{
		}

		// Token: 0x06031AC8 RID: 203464 RVA: 0x00DE490B File Offset: 0x00DE2B0B
		static MissionPanelChildStep()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MissionPanelChildStep.CreateStaticDefaultValue), new Action(MissionPanelChildStep.ResetStaticDefaultValue));
		}

		// Token: 0x06031AC9 RID: 203465 RVA: 0x00DE492A File Offset: 0x00DE2B2A
		public static void CreateStaticDefaultValue()
		{
			MissionPanelChildStep.UnlockAnimEventPlayTag = 0;
		}

		// Token: 0x06031ACA RID: 203466 RVA: 0x00DE4932 File Offset: 0x00DE2B32
		public static void ResetStaticDefaultValue()
		{
			MissionPanelChildStep.UnlockAnimEventPlayTag = 0;
		}

		// Token: 0x06031ACB RID: 203467 RVA: 0x00DE493C File Offset: 0x00DE2B3C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
		}

		// Token: 0x06031ACC RID: 203468 RVA: 0x00DE49A0 File Offset: 0x00DE2BA0
		protected override UniTask OnBeforeStartAsync()
		{
			MissionPanelChildStep.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionPanelChildStep.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031ACD RID: 203469 RVA: 0x00DE49E4 File Offset: 0x00DE2BE4
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUISizeControlByOther uuisizeControlByOther = this.RootActor.GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther;
			if (uuisizeControlByOther != null)
			{
				uuisizeControlByOther.bSizeZeroWhenNotActive = true;
			}
			else
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.XDW, "MissionPanelChildStep 无法获取UISizeControlByOther", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.UpdateRootVisibleByTextVisible();
		}

		// Token: 0x06031ACE RID: 203470 RVA: 0x00DE4ABE File Offset: 0x00DE2CBE
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			if (this.DeferHideForCompleteAnimDelayHandle != null)
			{
				TimerSystem.Instance.Remove(this.DeferHideForCompleteAnimDelayHandle);
				this.DeferHideForCompleteAnimDelayHandle = null;
			}
		}

		// Token: 0x06031ACF RID: 203471 RVA: 0x00DE4AFC File Offset: 0x00DE2CFC
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.ResumeSequence();
			}
			this.UpdateRootVisibleByTextVisible();
		}

		// Token: 0x06031AD0 RID: 203472 RVA: 0x00DE4B15 File Offset: 0x00DE2D15
		protected override void OnAfterHide()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PauseSequence();
		}

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x06031AD1 RID: 203473 RVA: 0x00DE4B27 File Offset: 0x00DE2D27
		public override bool IsDescribeTextVisible
		{
			get
			{
				return this.IsDeferHideForCompleteAnim || base.IsDescribeTextVisible;
			}
		}

		// Token: 0x06031AD2 RID: 203474 RVA: 0x00DE4B3C File Offset: 0x00DE2D3C
		public UniTask StartShow(bool bSkipAnim)
		{
			MissionPanelChildStep.<StartShow>d__33 <StartShow>d__;
			<StartShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartShow>d__.<>4__this = this;
			<StartShow>d__.bSkipAnim = bSkipAnim;
			<StartShow>d__.<>1__state = -1;
			<StartShow>d__.<>t__builder.Start<MissionPanelChildStep.<StartShow>d__33>(ref <StartShow>d__);
			return <StartShow>d__.<>t__builder.Task;
		}

		// Token: 0x06031AD3 RID: 203475 RVA: 0x00DE4B88 File Offset: 0x00DE2D88
		public UniTask EndShow(bool bSkipAnim)
		{
			MissionPanelChildStep.<EndShow>d__34 <EndShow>d__;
			<EndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndShow>d__.<>4__this = this;
			<EndShow>d__.bSkipAnim = bSkipAnim;
			<EndShow>d__.<>1__state = -1;
			<EndShow>d__.<>t__builder.Start<MissionPanelChildStep.<EndShow>d__34>(ref <EndShow>d__);
			return <EndShow>d__.<>t__builder.Task;
		}

		// Token: 0x06031AD4 RID: 203476 RVA: 0x00DE4BD3 File Offset: 0x00DE2DD3
		public override bool CheckVisible()
		{
			bool result = base.CheckVisible();
			this.UpdateRootVisibleByTextVisible();
			return result;
		}

		// Token: 0x06031AD5 RID: 203477 RVA: 0x00DE4BE4 File Offset: 0x00DE2DE4
		public override UniTask OnReset()
		{
			MissionPanelChildStep.<OnReset>d__36 <OnReset>d__;
			<OnReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnReset>d__.<>4__this = this;
			<OnReset>d__.<>1__state = -1;
			<OnReset>d__.<>t__builder.Start<MissionPanelChildStep.<OnReset>d__36>(ref <OnReset>d__);
			return <OnReset>d__.<>t__builder.Task;
		}

		// Token: 0x06031AD6 RID: 203478 RVA: 0x00DE4C28 File Offset: 0x00DE2E28
		protected override void UpdateStepInfo()
		{
			this.UpdateSpriteAndColor();
			this.UpdatePreCondition();
			base.UpdateStepInfo();
			if (this.DescribeTextVisible)
			{
				this.LastValidDescribeText = this.DescribeTextComp.GetText();
			}
			if (this.IsDeferHideForCompleteAnim)
			{
				this.DescribeTextComp.SetText(this.LastValidDescribeText, true);
				this.DescribeTextVisible = true;
			}
			this.UpdateRootVisibleByTextVisible();
			this.UpdateProgressBar();
		}

		// Token: 0x06031AD7 RID: 203479 RVA: 0x00DE4C8D File Offset: 0x00DE2E8D
		private void UpdateProgressBar()
		{
		}

		// Token: 0x06031AD8 RID: 203480 RVA: 0x00DE4C8F File Offset: 0x00DE2E8F
		private void UpdateRootVisibleByTextVisible()
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsDescribeTextVisible);
		}

		// Token: 0x06031AD9 RID: 203481 RVA: 0x00DE4CA8 File Offset: 0x00DE2EA8
		private void UpdatePreCondition()
		{
			if (this.IsUnlockAnimPlaying)
			{
				return;
			}
			bool flag = this.CheckMeetPreCondition();
			if (this.IsMeetPreCondition != flag)
			{
				if (flag)
				{
					this.PlayUnlockAnim().Forget();
					return;
				}
				this.IsMeetPreCondition = false;
				this.DescribeTextComp.SetColor(this.GrayColor);
				UUISprite sprite = base.GetSprite(6);
				if (sprite != null)
				{
					sprite.SetAlpha(1f);
				}
				UUISprite sprite2 = base.GetSprite(6);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(true);
				}
				BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = this.Config as BehaviorTreeStepTextInfo;
				if (behaviorTreeStepTextInfo != null)
				{
					behaviorTreeStepTextInfo.UsePreStateText = true;
				}
			}
		}

		// Token: 0x06031ADA RID: 203482 RVA: 0x00DE4D38 File Offset: 0x00DE2F38
		public UniTask PlayUnlockAnim()
		{
			MissionPanelChildStep.<PlayUnlockAnim>d__41 <PlayUnlockAnim>d__;
			<PlayUnlockAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAnim>d__.<>4__this = this;
			<PlayUnlockAnim>d__.<>1__state = -1;
			<PlayUnlockAnim>d__.<>t__builder.Start<MissionPanelChildStep.<PlayUnlockAnim>d__41>(ref <PlayUnlockAnim>d__);
			return <PlayUnlockAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06031ADB RID: 203483 RVA: 0x00DE4D7B File Offset: 0x00DE2F7B
		protected override bool CheckCanShowStatusRoot()
		{
			if (!this.IsMeetPreCondition)
			{
				return this.UnlockAnimEventPlay;
			}
			return base.CheckCanShowStatusRoot();
		}

		// Token: 0x06031ADC RID: 203484 RVA: 0x00DE4D92 File Offset: 0x00DE2F92
		protected override bool CheckCanUpdateStatusNode()
		{
			return this.IsMeetPreCondition;
		}

		// Token: 0x06031ADD RID: 203485 RVA: 0x00DE4D9C File Offset: 0x00DE2F9C
		protected bool CheckMeetPreCondition()
		{
			BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = this.Config as BehaviorTreeStepTextInfo;
			if (behaviorTreeStepTextInfo == null)
			{
				return true;
			}
			GeneralLogicTreeModel instance = GeneralLogicTreeModel.Instance;
			IMissionItemViewShowData showData = this.ShowData;
			BaseBehaviorTree behaviorTree = instance.GetBehaviorTree(new long?(((showData != null) ? new long?(showData.Id) : null).Value), false);
			if (behaviorTree == null || behaviorTree.BtType == BtType.Quest)
			{
				return true;
			}
			IQuestScheduleType questScheduleType = behaviorTreeStepTextInfo.QuestScheduleType;
			if (questScheduleType.Type == EQuestScheduleType.ChildQuestCompleted)
			{
				IQuestScheduleChildQuestCompleted questScheduleChildQuestCompleted = questScheduleType as IQuestScheduleChildQuestCompleted;
				ITitlePreState titlePreState = (questScheduleChildQuestCompleted != null) ? questScheduleChildQuestCompleted.TitlePreState : null;
				if (titlePreState != null)
				{
					GeneralLogicTreeContext context = GeneralLogicTreeContext.Create(behaviorTree.BtType, behaviorTree.TreeIncId, behaviorTree.TreeConfigId, 0, null);
					return LevelGeneralController.Instance.CheckConditionNew(titlePreState.SwitchConditions, null, context, null);
				}
			}
			return true;
		}

		// Token: 0x06031ADE RID: 203486 RVA: 0x00DE4E6C File Offset: 0x00DE306C
		private void UpdateSpriteAndColor()
		{
			if (this.Config == null)
			{
				return;
			}
			OneOf<string, EQuestScheduleType> oneOf = EQuestScheduleType.None;
			FishingEntrustStepTextInfo fishingEntrustStepTextInfo = this.Config as FishingEntrustStepTextInfo;
			if (fishingEntrustStepTextInfo != null)
			{
				oneOf = fishingEntrustStepTextInfo.QuestScheduleType;
			}
			else
			{
				BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = this.Config as BehaviorTreeStepTextInfo;
				if (behaviorTreeStepTextInfo != null && behaviorTreeStepTextInfo.QuestScheduleType != null)
				{
					oneOf = behaviorTreeStepTextInfo.QuestScheduleType.Type;
				}
			}
			if (this.CurType == oneOf)
			{
				return;
			}
			this.CurType = oneOf;
			if (oneOf.IsT1)
			{
				if (oneOf.AsT1 == "FishingEntrust")
				{
					this.CompletedColor = new FColor?(this.GreenColor);
					this.FailedColor = new FColor?(this.GrayColor);
					string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MissionState");
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_MissionComplete");
					string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("SP_MissionLose");
					this.SetSpriteByPath(resourcePath, this.StepStatusNode, true, null, null);
					this.SetSpriteByPath(resourcePath2, this.StepSuccess, true, null, null);
					this.SetSpriteByPath(resourcePath3, this.StepLose, true, null, null);
					return;
				}
			}
			else
			{
				EQuestScheduleType asT = oneOf.AsT2;
				if (asT == EQuestScheduleType.ChildQuestCompleted)
				{
					this.CompletedColor = new FColor?(this.GreenColor);
					this.FailedColor = new FColor?(this.GrayColor);
					string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("SP_MissionState");
					string resourcePath5 = UiResourceConfig.Instance.GetResourcePath("SP_MissionComplete");
					string resourcePath6 = UiResourceConfig.Instance.GetResourcePath("SP_MissionLose");
					this.SetSpriteByPath(resourcePath4, this.StepStatusNode, true, null, null);
					this.SetSpriteByPath(resourcePath5, this.StepSuccess, true, null, null);
					this.SetSpriteByPath(resourcePath6, this.StepLose, true, null, null);
					return;
				}
				if (asT - EQuestScheduleType.TimeLeft > 1)
				{
					return;
				}
				object obj = (oneOf == EQuestScheduleType.Condition) ? ((IQuestScheduleMeetCondition)((BehaviorTreeStepTextInfo)this.Config).QuestScheduleType).IconType : ((IQuestScheduleTimeLeft)((BehaviorTreeStepTextInfo)this.Config).QuestScheduleType).IconType;
				this.CompletedColor = new FColor?(this.WhiteColor);
				this.FailedColor = new FColor?(this.GrayColor);
				object obj2 = obj;
				string resourceId = (obj2 == 1) ? "SP_DailyTowerStarBg" : "SP_ComStateOffline";
				string resourcePath7 = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath7, this.StepStatusNode, true, null, null);
				string resourceId2 = (obj2 == 1) ? "SP_DailyTowerStar" : "SP_ComStateOnline";
				string resourcePath8 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
				this.SetSpriteByPath(resourcePath8, this.StepSuccess, true, null, null);
				this.SetSpriteByPath(resourcePath7, this.StepLose, true, null, null);
			}
		}

		// Token: 0x06031ADF RID: 203487 RVA: 0x00DE515C File Offset: 0x00DE335C
		protected override void OnStatusChanged(EStatusType status, EStepStatusRefreshReason reason)
		{
			string text = null;
			switch (status)
			{
			case EStatusType.None:
				this.DescribeTextComp.SetColor(this.WhiteColor);
				break;
			case EStatusType.Success:
				text = "Success";
				break;
			case EStatusType.Fail:
				text = "Fail";
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.LevelSequencePlayer.StopCurrentSequence(true, true);
				this.LevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
				if (reason == EStepStatusRefreshReason.StatusChange)
				{
					this.IsDeferHideForCompleteAnim = !this.CheckOriginalTextVisible();
					return;
				}
				this.LevelSequencePlayer.EndSequenceLastFrame(text);
				this.IsDeferHideForCompleteAnim = !this.CheckOriginalTextVisible();
				if (this.IsDeferHideForCompleteAnim)
				{
					this.DeferHideForCompleteAnimDelayHandle = TimerSystem.Instance.Delay(delegate(float _)
					{
						this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
						this.DeferHideForCompleteAnimDelayHandle = null;
					}, 1000f, null, null, true, 1f);
					return;
				}
			}
			else
			{
				this.IsDeferHideForCompleteAnim = false;
			}
		}

		// Token: 0x06031AE0 RID: 203488 RVA: 0x00DE5238 File Offset: 0x00DE3438
		protected override UniTask OnConfigRefresh(IMissionItemViewShowData showData, [Nullable(2)] MissionViewStepTextInfoBase config)
		{
			MissionPanelChildStep.<OnConfigRefresh>d__47 <OnConfigRefresh>d__;
			<OnConfigRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnConfigRefresh>d__.<>4__this = this;
			<OnConfigRefresh>d__.showData = showData;
			<OnConfigRefresh>d__.config = config;
			<OnConfigRefresh>d__.<>1__state = -1;
			<OnConfigRefresh>d__.<>t__builder.Start<MissionPanelChildStep.<OnConfigRefresh>d__47>(ref <OnConfigRefresh>d__);
			return <OnConfigRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x06031AE1 RID: 203489 RVA: 0x00DE528C File Offset: 0x00DE348C
		private bool CheckOriginalTextVisible()
		{
			StepControllerBase stepControllerBase;
			return (!this.StepControllers.TryGetValue(EStepControllerType.MotionArtText, out stepControllerBase) || !stepControllerBase.Enable) && this.ShowData != null && this.Config != null && !StringUtils.IsBlank(MissionViewStepTextUtil.GetStepTextByConfig(this.ShowData.Id, this.Config));
		}

		// Token: 0x06031AE2 RID: 203490 RVA: 0x00DE52E8 File Offset: 0x00DE34E8
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Success")
			{
				UUIText describeTextComp = this.DescribeTextComp;
				if (describeTextComp != null)
				{
					describeTextComp.SetColor(this.CompletedColor.Value);
				}
				if (this.IsDeferHideForCompleteAnim && this.DeferHideForCompleteAnimDelayHandle == null)
				{
					this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
					return;
				}
			}
			else if (sequenceName == "Fail")
			{
				UUIText describeTextComp2 = this.DescribeTextComp;
				if (describeTextComp2 != null)
				{
					describeTextComp2.SetColor(this.FailedColor.Value);
				}
				if (this.IsDeferHideForCompleteAnim && this.DeferHideForCompleteAnimDelayHandle == null)
				{
					this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
					return;
				}
			}
			else if (sequenceName == "Start")
			{
				CustomPromise<bool> startSequencePromise = this.StartSequencePromise;
				if (startSequencePromise != null && startSequencePromise.IsPending)
				{
					this.StartSequencePromise.SetResult(true);
					return;
				}
			}
			else if (sequenceName == "Close")
			{
				CustomPromise<bool> closeSequencePromise = this.CloseSequencePromise;
				if (closeSequencePromise != null && closeSequencePromise.IsPending)
				{
					this.CloseSequencePromise.SetResult(true);
				}
				this.IsDeferHideForCompleteAnim = false;
				if (this.DeferHideForCompleteAnimDelayHandle != null)
				{
					TimerSystem.Instance.Remove(this.DeferHideForCompleteAnimDelayHandle);
					this.DeferHideForCompleteAnimDelayHandle = null;
					return;
				}
			}
			else if (sequenceName == "Unlock")
			{
				CustomPromise<bool> unlockSequenceEndPromise = this.UnlockSequenceEndPromise;
				if (unlockSequenceEndPromise != null && unlockSequenceEndPromise.IsPending)
				{
					this.UnlockSequenceEndPromise.SetResult(true);
				}
			}
		}

		// Token: 0x06031AE3 RID: 203491 RVA: 0x00DE545E File Offset: 0x00DE365E
		private void OnActivitySequenceEmitEvent(string sequenceName)
		{
			this.OnSequencePlayEvent(sequenceName, null);
		}

		// Token: 0x06031AE4 RID: 203492 RVA: 0x00DE5468 File Offset: 0x00DE3668
		private void OnSequencePlayEvent(string sequenceName, string _)
		{
			if (sequenceName == "Unlock")
			{
				if (this.CurUnlockAnimEventTag == MissionPanelChildStep.UnlockAnimEventPlayTag)
				{
					CustomPromise<bool> unlockSequenceEventPromise = this.UnlockSequenceEventPromise;
					if (unlockSequenceEventPromise != null && unlockSequenceEventPromise.IsPending)
					{
						this.UnlockSequenceEventPromise.SetResult(true);
					}
				}
				MissionPanelChildStep.UnlockAnimEventPlayTag++;
			}
		}

		// Token: 0x0401A4B4 RID: 107700
		private const string UNLOCK_ANIM = "Unlock";

		// Token: 0x0401A4B5 RID: 107701
		private readonly FColor WhiteColor = FColor.FromHex("ECE5D8FF");

		// Token: 0x0401A4B6 RID: 107702
		private readonly FColor GrayColor = FColor.FromHex("ADADADFF");

		// Token: 0x0401A4B7 RID: 107703
		private readonly FColor GreenColor = FColor.FromHex("C9F797FF");

		// Token: 0x0401A4B8 RID: 107704
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A4B9 RID: 107705
		[Nullable(2)]
		private CustomPromise<bool> StartSequencePromise;

		// Token: 0x0401A4BA RID: 107706
		[Nullable(2)]
		private CustomPromise<bool> CloseSequencePromise;

		// Token: 0x0401A4BB RID: 107707
		[Nullable(2)]
		private CustomPromise<bool> UnlockSequenceEndPromise;

		// Token: 0x0401A4BC RID: 107708
		[Nullable(2)]
		private CustomPromise<bool> UnlockSequenceEventPromise;

		// Token: 0x0401A4BD RID: 107709
		private FColor? CompletedColor;

		// Token: 0x0401A4BE RID: 107710
		private FColor? FailedColor;

		// Token: 0x0401A4BF RID: 107711
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private OneOf<string, EQuestScheduleType> CurType = EQuestScheduleType.None;

		// Token: 0x0401A4C0 RID: 107712
		private bool IsMeetPreCondition = true;

		// Token: 0x0401A4C1 RID: 107713
		private bool IsUnlockAnimPlaying;

		// Token: 0x0401A4C2 RID: 107714
		private bool UnlockAnimEventPlay;

		// Token: 0x0401A4C3 RID: 107715
		private bool IsDeferHideForCompleteAnim;

		// Token: 0x0401A4C4 RID: 107716
		[Nullable(2)]
		private TimerHandle DeferHideForCompleteAnimDelayHandle;

		// Token: 0x0401A4C5 RID: 107717
		private string LastValidDescribeText = string.Empty;

		// Token: 0x0401A4C6 RID: 107718
		private static int UnlockAnimEventPlayTag;

		// Token: 0x0401A4C7 RID: 107719
		private int CurUnlockAnimEventTag;

		// Token: 0x0200AA22 RID: 43554
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034945 RID: 215365
			Root = 5,
			// Token: 0x04034946 RID: 215366
			LockIcon,
			// Token: 0x04034947 RID: 215367
			ProgressBar
		}
	}
}
