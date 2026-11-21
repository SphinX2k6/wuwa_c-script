using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D4D RID: 19789
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionPanelStep : StepBaseItem
	{
		// Token: 0x06031AEE RID: 203502 RVA: 0x00DE550D File Offset: 0x00DE370D
		public MissionPanelStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
		{
		}

		// Token: 0x06031AEF RID: 203503 RVA: 0x00DE5522 File Offset: 0x00DE3722
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		}

		// Token: 0x06031AF0 RID: 203504 RVA: 0x00DE5560 File Offset: 0x00DE3760
		protected override UniTask OnBeforeStartAsync()
		{
			MissionPanelStep.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionPanelStep.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031AF1 RID: 203505 RVA: 0x00DE55A4 File Offset: 0x00DE37A4
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

		// Token: 0x06031AF2 RID: 203506 RVA: 0x00DE5618 File Offset: 0x00DE3818
		protected override void OnAfterShow()
		{
			this.TitleSequencePlayer.ResumeSequence();
			foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
			{
				missionPanelChildStep.Show(null);
			}
		}

		// Token: 0x06031AF3 RID: 203507 RVA: 0x00DE5674 File Offset: 0x00DE3874
		protected override void OnAfterHide()
		{
			this.TitleSequencePlayer.PauseSequence();
			foreach (MissionPanelChildStep missionPanelChildStep in this.ChildSteps)
			{
				missionPanelChildStep.Hide(null);
			}
		}

		// Token: 0x06031AF4 RID: 203508 RVA: 0x00DE56D0 File Offset: 0x00DE38D0
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

		// Token: 0x06031AF5 RID: 203509 RVA: 0x00DE5734 File Offset: 0x00DE3934
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

		// Token: 0x06031AF6 RID: 203510 RVA: 0x00DE5788 File Offset: 0x00DE3988
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

		// Token: 0x06031AF7 RID: 203511 RVA: 0x00DE57DC File Offset: 0x00DE39DC
		public override UniTask OnReset()
		{
			MissionPanelStep.<OnReset>d__14 <OnReset>d__;
			<OnReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnReset>d__.<>4__this = this;
			<OnReset>d__.<>1__state = -1;
			<OnReset>d__.<>t__builder.Start<MissionPanelStep.<OnReset>d__14>(ref <OnReset>d__);
			return <OnReset>d__.<>t__builder.Task;
		}

		// Token: 0x06031AF8 RID: 203512 RVA: 0x00DE5820 File Offset: 0x00DE3A20
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

		// Token: 0x06031AF9 RID: 203513 RVA: 0x00DE587C File Offset: 0x00DE3A7C
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

		// Token: 0x06031AFA RID: 203514 RVA: 0x00DE58C8 File Offset: 0x00DE3AC8
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

		// Token: 0x06031AFB RID: 203515 RVA: 0x00DE5914 File Offset: 0x00DE3B14
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

		// Token: 0x06031AFC RID: 203516 RVA: 0x00DE5960 File Offset: 0x00DE3B60
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

		// Token: 0x06031AFD RID: 203517 RVA: 0x00DE59B4 File Offset: 0x00DE3BB4
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

		// Token: 0x06031AFE RID: 203518 RVA: 0x00DE5A2C File Offset: 0x00DE3C2C
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

		// Token: 0x06031AFF RID: 203519 RVA: 0x00DE5A78 File Offset: 0x00DE3C78
		private UniTask UpdateChildSteps()
		{
			MissionPanelStep.<UpdateChildSteps>d__22 <UpdateChildSteps>d__;
			<UpdateChildSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateChildSteps>d__.<>4__this = this;
			<UpdateChildSteps>d__.<>1__state = -1;
			<UpdateChildSteps>d__.<>t__builder.Start<MissionPanelStep.<UpdateChildSteps>d__22>(ref <UpdateChildSteps>d__);
			return <UpdateChildSteps>d__.<>t__builder.Task;
		}

		// Token: 0x06031B00 RID: 203520 RVA: 0x00DE5ABC File Offset: 0x00DE3CBC
		private UniTask DisableAllChildSteps()
		{
			MissionPanelStep.<DisableAllChildSteps>d__23 <DisableAllChildSteps>d__;
			<DisableAllChildSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DisableAllChildSteps>d__.<>4__this = this;
			<DisableAllChildSteps>d__.<>1__state = -1;
			<DisableAllChildSteps>d__.<>t__builder.Start<MissionPanelStep.<DisableAllChildSteps>d__23>(ref <DisableAllChildSteps>d__);
			return <DisableAllChildSteps>d__.<>t__builder.Task;
		}

		// Token: 0x06031B01 RID: 203521 RVA: 0x00DE5AFF File Offset: 0x00DE3CFF
		public override bool CheckVisible()
		{
			return this.Config != null && !string.IsNullOrEmpty(PublicUtil.Instance.GetConfigTextByKey(this.Config.TidTitle)) && base.CheckVisible();
		}

		// Token: 0x06031B02 RID: 203522 RVA: 0x00DE5B30 File Offset: 0x00DE3D30
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

		// Token: 0x06031B03 RID: 203523 RVA: 0x00DE5BAC File Offset: 0x00DE3DAC
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

		// Token: 0x0401A4C8 RID: 107720
		private readonly List<MissionPanelChildStep> ChildSteps = new List<MissionPanelChildStep>();

		// Token: 0x0401A4C9 RID: 107721
		[Nullable(2)]
		protected LevelSequencePlayer TitleSequencePlayer;

		// Token: 0x0401A4CA RID: 107722
		[Nullable(2)]
		private CustomPromise<bool> TitleSequenceStartPromise;

		// Token: 0x0401A4CB RID: 107723
		[Nullable(2)]
		private CustomPromise<bool> TitleSequenceClosePromise;

		// Token: 0x0200AA29 RID: 43561
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034968 RID: 215400
			ChildStep = 2,
			// Token: 0x04034969 RID: 215401
			TitleNode
		}
	}
}
