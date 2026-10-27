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
	// Token: 0x02005D69 RID: 23913
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionPanelChildStep : StepWithStatusItem, IStaticVariableResetter
	{
		// Token: 0x0603CB6B RID: 248683 RVA: 0x00E94060 File Offset: 0x00E92260
		public MissionPanelChildStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
		{
		}

		// Token: 0x0603CB6C RID: 248684 RVA: 0x00E940C3 File Offset: 0x00E922C3
		static MissionPanelChildStep()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MissionPanelChildStep.CreateStaticDefaultValue), new Action(MissionPanelChildStep.ResetStaticDefaultValue));
		}

		// Token: 0x0603CB6D RID: 248685 RVA: 0x00E940E2 File Offset: 0x00E922E2
		public static void CreateStaticDefaultValue()
		{
			MissionPanelChildStep.UnlockAnimEventPlayTag = 0;
		}

		// Token: 0x0603CB6E RID: 248686 RVA: 0x00E940EA File Offset: 0x00E922EA
		public static void ResetStaticDefaultValue()
		{
			MissionPanelChildStep.UnlockAnimEventPlayTag = 0;
		}

		// Token: 0x0603CB6F RID: 248687 RVA: 0x00E940F4 File Offset: 0x00E922F4
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
		}

		// Token: 0x0603CB70 RID: 248688 RVA: 0x00E94158 File Offset: 0x00E92358
		protected override UniTask OnBeforeStartAsync()
		{
			MissionPanelChildStep.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionPanelChildStep.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB71 RID: 248689 RVA: 0x00E9419C File Offset: 0x00E9239C
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

		// Token: 0x0603CB72 RID: 248690 RVA: 0x00E94276 File Offset: 0x00E92476
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			if (this.DeferHideForCompleteAnimDelayHandle != null)
			{
				TimerSystem.Instance.Remove(this.DeferHideForCompleteAnimDelayHandle);
				this.DeferHideForCompleteAnimDelayHandle = null;
			}
		}

		// Token: 0x0603CB73 RID: 248691 RVA: 0x00E942B4 File Offset: 0x00E924B4
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.ResumeSequence();
			}
			this.UpdateRootVisibleByTextVisible();
		}

		// Token: 0x0603CB74 RID: 248692 RVA: 0x00E942CD File Offset: 0x00E924CD
		protected override void OnAfterHide()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PauseSequence();
		}

		// Token: 0x17008E1A RID: 36378
		// (get) Token: 0x0603CB75 RID: 248693 RVA: 0x00E942DF File Offset: 0x00E924DF
		public override bool IsDescribeTextVisible
		{
			get
			{
				return this.IsDeferHideForCompleteAnim || base.IsDescribeTextVisible;
			}
		}

		// Token: 0x0603CB76 RID: 248694 RVA: 0x00E942F4 File Offset: 0x00E924F4
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

		// Token: 0x0603CB77 RID: 248695 RVA: 0x00E94340 File Offset: 0x00E92540
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

		// Token: 0x0603CB78 RID: 248696 RVA: 0x00E9438B File Offset: 0x00E9258B
		public override bool CheckVisible()
		{
			bool result = base.CheckVisible();
			this.UpdateRootVisibleByTextVisible();
			return result;
		}

		// Token: 0x0603CB79 RID: 248697 RVA: 0x00E9439C File Offset: 0x00E9259C
		public override UniTask OnReset()
		{
			MissionPanelChildStep.<OnReset>d__36 <OnReset>d__;
			<OnReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnReset>d__.<>4__this = this;
			<OnReset>d__.<>1__state = -1;
			<OnReset>d__.<>t__builder.Start<MissionPanelChildStep.<OnReset>d__36>(ref <OnReset>d__);
			return <OnReset>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB7A RID: 248698 RVA: 0x00E943E0 File Offset: 0x00E925E0
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

		// Token: 0x0603CB7B RID: 248699 RVA: 0x00E94445 File Offset: 0x00E92645
		private void UpdateProgressBar()
		{
		}

		// Token: 0x0603CB7C RID: 248700 RVA: 0x00E94447 File Offset: 0x00E92647
		private void UpdateRootVisibleByTextVisible()
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsDescribeTextVisible);
		}

		// Token: 0x0603CB7D RID: 248701 RVA: 0x00E94460 File Offset: 0x00E92660
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

		// Token: 0x0603CB7E RID: 248702 RVA: 0x00E944F0 File Offset: 0x00E926F0
		public UniTask PlayUnlockAnim()
		{
			MissionPanelChildStep.<PlayUnlockAnim>d__41 <PlayUnlockAnim>d__;
			<PlayUnlockAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAnim>d__.<>4__this = this;
			<PlayUnlockAnim>d__.<>1__state = -1;
			<PlayUnlockAnim>d__.<>t__builder.Start<MissionPanelChildStep.<PlayUnlockAnim>d__41>(ref <PlayUnlockAnim>d__);
			return <PlayUnlockAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB7F RID: 248703 RVA: 0x00E94533 File Offset: 0x00E92733
		protected override bool CheckCanShowStatusRoot()
		{
			if (!this.IsMeetPreCondition)
			{
				return this.UnlockAnimEventPlay;
			}
			return base.CheckCanShowStatusRoot();
		}

		// Token: 0x0603CB80 RID: 248704 RVA: 0x00E9454A File Offset: 0x00E9274A
		protected override bool CheckCanUpdateStatusNode()
		{
			return this.IsMeetPreCondition;
		}

		// Token: 0x0603CB81 RID: 248705 RVA: 0x00E94554 File Offset: 0x00E92754
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

		// Token: 0x0603CB82 RID: 248706 RVA: 0x00E94624 File Offset: 0x00E92824
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

		// Token: 0x0603CB83 RID: 248707 RVA: 0x00E94914 File Offset: 0x00E92B14
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

		// Token: 0x0603CB84 RID: 248708 RVA: 0x00E949F0 File Offset: 0x00E92BF0
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

		// Token: 0x0603CB85 RID: 248709 RVA: 0x00E94A44 File Offset: 0x00E92C44
		private bool CheckOriginalTextVisible()
		{
			StepControllerBase stepControllerBase;
			return (!this.StepControllers.TryGetValue(EStepControllerType.MotionArtText, out stepControllerBase) || !stepControllerBase.Enable) && this.ShowData != null && this.Config != null && !StringUtils.IsBlank(MissionViewStepTextUtil.GetStepTextByConfig(this.ShowData.Id, this.Config));
		}

		// Token: 0x0603CB86 RID: 248710 RVA: 0x00E94AA0 File Offset: 0x00E92CA0
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

		// Token: 0x0603CB87 RID: 248711 RVA: 0x00E94C16 File Offset: 0x00E92E16
		private void OnActivitySequenceEmitEvent(string sequenceName)
		{
			this.OnSequencePlayEvent(sequenceName, null);
		}

		// Token: 0x0603CB88 RID: 248712 RVA: 0x00E94C20 File Offset: 0x00E92E20
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

		// Token: 0x0401F9FC RID: 129532
		private const string UNLOCK_ANIM = "Unlock";

		// Token: 0x0401F9FD RID: 129533
		private readonly FColor WhiteColor = FColor.FromHex("ECE5D8FF");

		// Token: 0x0401F9FE RID: 129534
		private readonly FColor GrayColor = FColor.FromHex("ADADADFF");

		// Token: 0x0401F9FF RID: 129535
		private readonly FColor GreenColor = FColor.FromHex("C9F797FF");

		// Token: 0x0401FA00 RID: 129536
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FA01 RID: 129537
		[Nullable(2)]
		private CustomPromise<bool> StartSequencePromise;

		// Token: 0x0401FA02 RID: 129538
		[Nullable(2)]
		private CustomPromise<bool> CloseSequencePromise;

		// Token: 0x0401FA03 RID: 129539
		[Nullable(2)]
		private CustomPromise<bool> UnlockSequenceEndPromise;

		// Token: 0x0401FA04 RID: 129540
		[Nullable(2)]
		private CustomPromise<bool> UnlockSequenceEventPromise;

		// Token: 0x0401FA05 RID: 129541
		private FColor? CompletedColor;

		// Token: 0x0401FA06 RID: 129542
		private FColor? FailedColor;

		// Token: 0x0401FA07 RID: 129543
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private OneOf<string, EQuestScheduleType> CurType = EQuestScheduleType.None;

		// Token: 0x0401FA08 RID: 129544
		private bool IsMeetPreCondition = true;

		// Token: 0x0401FA09 RID: 129545
		private bool IsUnlockAnimPlaying;

		// Token: 0x0401FA0A RID: 129546
		private bool UnlockAnimEventPlay;

		// Token: 0x0401FA0B RID: 129547
		private bool IsDeferHideForCompleteAnim;

		// Token: 0x0401FA0C RID: 129548
		[Nullable(2)]
		private TimerHandle DeferHideForCompleteAnimDelayHandle;

		// Token: 0x0401FA0D RID: 129549
		private string LastValidDescribeText = string.Empty;

		// Token: 0x0401FA0E RID: 129550
		private static int UnlockAnimEventPlayTag;

		// Token: 0x0401FA0F RID: 129551
		private int CurUnlockAnimEventTag;

		// Token: 0x0200C01C RID: 49180
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04039F82 RID: 237442
			Root = 5,
			// Token: 0x04039F83 RID: 237443
			LockIcon,
			// Token: 0x04039F84 RID: 237444
			ProgressBar
		}
	}
}
