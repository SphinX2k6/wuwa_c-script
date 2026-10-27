using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D6B RID: 23915
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionPanelStep : StepBaseItem
	{
		// Token: 0x0603CB92 RID: 248722 RVA: 0x00E94CC5 File Offset: 0x00E92EC5
		public MissionPanelStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
		{
		}

		// Token: 0x0603CB93 RID: 248723 RVA: 0x00E94CDA File Offset: 0x00E92EDA
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		}

		// Token: 0x0603CB94 RID: 248724 RVA: 0x00E94D18 File Offset: 0x00E92F18
		protected override UniTask OnBeforeStartAsync()
		{
			MissionPanelStep.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionPanelStep.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB95 RID: 248725 RVA: 0x00E94D5C File Offset: 0x00E92F5C
		protected override void OnBeforeDestroy()
		{
			if (this.ChildSteps != null)
			{
				foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
				{
					missionPanelChildStep.Destroy(null);
				}
			}
			LevelSequencePlayer titleSequencePlayer = this.TitleSequencePlayer;
			if (titleSequencePlayer != null)
			{
				titleSequencePlayer.Clear();
			}
			this.TitleSequencePlayer = null;
		}

		// Token: 0x0603CB96 RID: 248726 RVA: 0x00E94DD0 File Offset: 0x00E92FD0
		protected override void OnAfterShow()
		{
			this.TitleSequencePlayer.ResumeSequence();
			foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
			{
				missionPanelChildStep.Show(null);
			}
		}

		// Token: 0x0603CB97 RID: 248727 RVA: 0x00E94E2C File Offset: 0x00E9302C
		protected override void OnAfterHide()
		{
			this.TitleSequencePlayer.PauseSequence();
			foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
			{
				missionPanelChildStep.Hide(null);
			}
		}

		// Token: 0x0603CB98 RID: 248728 RVA: 0x00E94E88 File Offset: 0x00E93088
		public override void OnTick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			base.OnTick(delta);
			foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
			{
				missionPanelChildStep.OnTick(delta);
			}
		}

		// Token: 0x0603CB99 RID: 248729 RVA: 0x00E94EEC File Offset: 0x00E930EC
		public void Update()
		{
			base.UpdateByConfig();
			if (this.ShowData != null && this.ShowData.SubStepInfos != null)
			{
				for (int i = 0; i < this.ShowData.SubStepInfos.Count; i++)
				{
					this.ChildSteps[i].UpdateByConfig();
				}
			}
		}

		// Token: 0x0603CB9A RID: 248730 RVA: 0x00E94F40 File Offset: 0x00E93140
		public UniTask StartShow(IMissionItemViewShowData showData, bool bSkipAnim)
		{
			MissionPanelStep.<StartShow>d__13 <StartShow>d__;
			<StartShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartShow>d__.<>4__this = this;
			<StartShow>d__.showData = showData;
			<StartShow>d__.bSkipAnim = bSkipAnim;
			<StartShow>d__.<>1__state = -1;
			<StartShow>d__.<>t__builder.Start<MissionPanelStep.<StartShow>d__13>(ref <StartShow>d__);
			return <StartShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB9B RID: 248731 RVA: 0x00E94F94 File Offset: 0x00E93194
		public override UniTask OnReset()
		{
			MissionPanelStep.<OnReset>d__14 <OnReset>d__;
			<OnReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnReset>d__.<>4__this = this;
			<OnReset>d__.<>1__state = -1;
			<OnReset>d__.<>t__builder.Start<MissionPanelStep.<OnReset>d__14>(ref <OnReset>d__);
			return <OnReset>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB9C RID: 248732 RVA: 0x00E94FD8 File Offset: 0x00E931D8
		public UniTask ExecuteSequenceOnUpdate(IMissionItemViewShowData showData, Action<IMissionItemViewShowData> updateParentData, bool bSkipAnim)
		{
			MissionPanelStep.<ExecuteSequenceOnUpdate>d__15 <ExecuteSequenceOnUpdate>d__;
			<ExecuteSequenceOnUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteSequenceOnUpdate>d__.<>4__this = this;
			<ExecuteSequenceOnUpdate>d__.showData = showData;
			<ExecuteSequenceOnUpdate>d__.updateParentData = updateParentData;
			<ExecuteSequenceOnUpdate>d__.bSkipAnim = bSkipAnim;
			<ExecuteSequenceOnUpdate>d__.<>1__state = -1;
			<ExecuteSequenceOnUpdate>d__.<>t__builder.Start<MissionPanelStep.<ExecuteSequenceOnUpdate>d__15>(ref <ExecuteSequenceOnUpdate>d__);
			return <ExecuteSequenceOnUpdate>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB9D RID: 248733 RVA: 0x00E95034 File Offset: 0x00E93234
		private UniTask PlayStartSequence(bool bSkipAnim)
		{
			MissionPanelStep.<PlayStartSequence>d__16 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.bSkipAnim = bSkipAnim;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MissionPanelStep.<PlayStartSequence>d__16>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB9E RID: 248734 RVA: 0x00E95080 File Offset: 0x00E93280
		[NullableContext(0)]
		private UniTask<bool> PlayCloseSequence(bool bSkipAnim)
		{
			MissionPanelStep.<PlayCloseSequence>d__17 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.bSkipAnim = bSkipAnim;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MissionPanelStep.<PlayCloseSequence>d__17>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB9F RID: 248735 RVA: 0x00E950CC File Offset: 0x00E932CC
		private UniTask PlayChildStepStartSequence(bool bSkipAnim)
		{
			MissionPanelStep.<PlayChildStepStartSequence>d__18 <PlayChildStepStartSequence>d__;
			<PlayChildStepStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayChildStepStartSequence>d__.<>4__this = this;
			<PlayChildStepStartSequence>d__.bSkipAnim = bSkipAnim;
			<PlayChildStepStartSequence>d__.<>1__state = -1;
			<PlayChildStepStartSequence>d__.<>t__builder.Start<MissionPanelStep.<PlayChildStepStartSequence>d__18>(ref <PlayChildStepStartSequence>d__);
			return <PlayChildStepStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBA0 RID: 248736 RVA: 0x00E95118 File Offset: 0x00E93318
		private UniTask PlayAllChildStepCloseSequence([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<MissionViewStepTextInfoBase> subTitles, bool bSkipAnim)
		{
			MissionPanelStep.<PlayAllChildStepCloseSequence>d__19 <PlayAllChildStepCloseSequence>d__;
			<PlayAllChildStepCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAllChildStepCloseSequence>d__.<>4__this = this;
			<PlayAllChildStepCloseSequence>d__.subTitles = subTitles;
			<PlayAllChildStepCloseSequence>d__.bSkipAnim = bSkipAnim;
			<PlayAllChildStepCloseSequence>d__.<>1__state = -1;
			<PlayAllChildStepCloseSequence>d__.<>t__builder.Start<MissionPanelStep.<PlayAllChildStepCloseSequence>d__19>(ref <PlayAllChildStepCloseSequence>d__);
			return <PlayAllChildStepCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBA1 RID: 248737 RVA: 0x00E9516C File Offset: 0x00E9336C
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				CustomPromise<bool> titleSequenceStartPromise = this.TitleSequenceStartPromise;
				if (titleSequenceStartPromise != null && titleSequenceStartPromise.IsPending)
				{
					this.TitleSequenceStartPromise.SetResult(true);
					return;
				}
			}
			else if (sequenceName == "Close" || sequenceName == "Finish")
			{
				CustomPromise<bool> titleSequenceClosePromise = this.TitleSequenceClosePromise;
				if (titleSequenceClosePromise != null && titleSequenceClosePromise.IsPending)
				{
					this.TitleSequenceClosePromise.SetResult(true);
				}
			}
		}

		// Token: 0x0603CBA2 RID: 248738 RVA: 0x00E951E4 File Offset: 0x00E933E4
		private UniTask UpdateSelfData(IMissionItemViewShowData showData)
		{
			MissionPanelStep.<UpdateSelfData>d__21 <UpdateSelfData>d__;
			<UpdateSelfData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateSelfData>d__.<>4__this = this;
			<UpdateSelfData>d__.showData = showData;
			<UpdateSelfData>d__.<>1__state = -1;
			<UpdateSelfData>d__.<>t__builder.Start<MissionPanelStep.<UpdateSelfData>d__21>(ref <UpdateSelfData>d__);
			return <UpdateSelfData>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBA3 RID: 248739 RVA: 0x00E95230 File Offset: 0x00E93430
		private UniTask UpdateChildSteps()
		{
			MissionPanelStep.<UpdateChildSteps>d__22 <UpdateChildSteps>d__;
			<UpdateChildSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateChildSteps>d__.<>4__this = this;
			<UpdateChildSteps>d__.<>1__state = -1;
			<UpdateChildSteps>d__.<>t__builder.Start<MissionPanelStep.<UpdateChildSteps>d__22>(ref <UpdateChildSteps>d__);
			return <UpdateChildSteps>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBA4 RID: 248740 RVA: 0x00E95274 File Offset: 0x00E93474
		private UniTask DisableAllChildSteps()
		{
			MissionPanelStep.<DisableAllChildSteps>d__23 <DisableAllChildSteps>d__;
			<DisableAllChildSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DisableAllChildSteps>d__.<>4__this = this;
			<DisableAllChildSteps>d__.<>1__state = -1;
			<DisableAllChildSteps>d__.<>t__builder.Start<MissionPanelStep.<DisableAllChildSteps>d__23>(ref <DisableAllChildSteps>d__);
			return <DisableAllChildSteps>d__.<>t__builder.Task;
		}

		// Token: 0x0603CBA5 RID: 248741 RVA: 0x00E952B7 File Offset: 0x00E934B7
		public override bool CheckVisible()
		{
			return this.Config != null && !string.IsNullOrEmpty(PublicUtil.Instance.GetConfigTextByKey(this.Config.TidTitle)) && base.CheckVisible();
		}

		// Token: 0x0603CBA6 RID: 248742 RVA: 0x00E952E8 File Offset: 0x00E934E8
		private bool CheckCurrentFinished()
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = this.ShowData as BehaviorTreeViewShowData;
			if (behaviorTreeViewShowData == null)
			{
				return true;
			}
			BehaviorTreeStepTextInfo mainStepInfo = behaviorTreeViewShowData.MainStepInfo;
			IQuestScheduleType questScheduleType = (mainStepInfo != null) ? mainStepInfo.QuestScheduleType : null;
			if (questScheduleType == null)
			{
				return true;
			}
			IQuestScheduleChildQuestCompleted questScheduleChildQuestCompleted = questScheduleType as IQuestScheduleChildQuestCompleted;
			if (questScheduleChildQuestCompleted != null)
			{
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.ShowData.Id), false);
				if (behaviorTree != null)
				{
					BehaviorNodeBase node = behaviorTree.GetNode(questScheduleChildQuestCompleted.ChildQuestId);
					if (node != null)
					{
						return node.IsSuccess;
					}
				}
			}
			return true;
		}

		// Token: 0x0603CBA7 RID: 248743 RVA: 0x00E95364 File Offset: 0x00E93564
		public UniTask ChildStepConditionIndexChange(int stepId, int? curConditionTextIndex)
		{
			MissionPanelStep.<ChildStepConditionIndexChange>d__26 <ChildStepConditionIndexChange>d__;
			<ChildStepConditionIndexChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChildStepConditionIndexChange>d__.<>4__this = this;
			<ChildStepConditionIndexChange>d__.stepId = stepId;
			<ChildStepConditionIndexChange>d__.curConditionTextIndex = curConditionTextIndex;
			<ChildStepConditionIndexChange>d__.<>1__state = -1;
			<ChildStepConditionIndexChange>d__.<>t__builder.Start<MissionPanelStep.<ChildStepConditionIndexChange>d__26>(ref <ChildStepConditionIndexChange>d__);
			return <ChildStepConditionIndexChange>d__.<>t__builder.Task;
		}

		// Token: 0x0401FA10 RID: 129552
		private readonly List<MissionPanelChildStep> ChildSteps = new List<MissionPanelChildStep>();

		// Token: 0x0401FA11 RID: 129553
		[Nullable(2)]
		protected LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x0401FA12 RID: 129554
		[Nullable(2)]
		private CustomPromise<bool> TitleSequenceStartPromise;

		// Token: 0x0401FA13 RID: 129555
		[Nullable(2)]
		private CustomPromise<bool> TitleSequenceClosePromise;

		// Token: 0x0200C023 RID: 49187
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04039FA5 RID: 237477
			ChildStep = 2,
			// Token: 0x04039FA6 RID: 237478
			TitleNode
		}
	}
}
