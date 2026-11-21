using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200353D RID: 13629
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideGroupInfo
	{
		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06022AAE RID: 141998 RVA: 0x009DD4AC File Offset: 0x009DB6AC
		public GuideStepInfo CurrentGuideStep
		{
			get
			{
				if (this.CurrentStepIndex < 0 || this.CurrentStepIndex >= this.StepInfoList.Count)
				{
					return null;
				}
				return this.StepInfoList[this.CurrentStepIndex];
			}
		}

		// Token: 0x06022AAF RID: 141999 RVA: 0x009DD4E0 File Offset: 0x009DB6E0
		public GuideGroupInfo(int groupId)
		{
			this.Id = groupId;
			this.StateMachine = new StateMachine<GuideGroupInfo, EGuideGroupState>(this, null);
			this.StateMachine.AddState<InitState>(EGuideGroupState.Init, null);
			this.StateMachine.AddState<OpeningState>(EGuideGroupState.Opening, null);
			this.StateMachine.AddState<ExecutingState>(EGuideGroupState.Executing, null);
			this.StateMachine.AddState<PendingState>(EGuideGroupState.Pending, null);
			this.StateMachine.AddState<FinishingState>(EGuideGroupState.Finishing, null);
			this.StateMachine.Start(EGuideGroupState.Init);
		}

		// Token: 0x06022AB0 RID: 142000 RVA: 0x009DD568 File Offset: 0x009DB768
		public bool GetIfPreExecute()
		{
			return this.StepInfoList.Count != 0 && Math.Abs(this.StepInfoList[0].Config.TimeScale - 1f) > 1E-08f;
		}

		// Token: 0x06022AB1 RID: 142001 RVA: 0x009DD5B0 File Offset: 0x009DB7B0
		public unsafe void SwitchState(EGuideGroupState groupState)
		{
			EGuideGroupState state = groupState;
			if (groupState == EGuideGroupState.Opening)
			{
				EGuideGroupState? currentState = this.StateMachine.CurrentState;
				EGuideGroupState eguideGroupState = EGuideGroupState.Init;
				if (!(currentState.GetValueOrDefault() == eguideGroupState & currentState != null))
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "引导组正在执行中, 不再重复执行", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
			if (groupState == EGuideGroupState.Executing && !this.CanEnterExecuting())
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "引导组暂时无法执行, 挂起", default(ReadOnlySpan<ValueTuple<string, object>>));
				state = EGuideGroupState.Pending;
			}
			if (groupState == EGuideGroupState.Finishing && !this.IsFake)
			{
				bool? flag = GuideModel.Instance.IsGroupFinished(this.Id);
				bool flag2 = GuideModel.Instance.IsGroupCanRepeat(this.Id);
				if (flag.GetValueOrDefault() && !flag2)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.TL;
					string message = "引导组未配置为可重复完成但重复请求完成, 跳过服务端完成步骤";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GroupId", this.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isFinish", flag);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("canRepeat", flag2);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					state = EGuideGroupState.Init;
				}
			}
			this.StateMachine.Switch(state);
		}

		// Token: 0x06022AB2 RID: 142002 RVA: 0x009DD708 File Offset: 0x009DB908
		public void PumpStep()
		{
			if (this.StepInfoList.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导组未配置当前平台的步骤, 执行失败, 中断当前引导组";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", this.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.Break();
				return;
			}
			this.EndCurrentStep();
			int num = this.CurrentStepIndex + 1;
			if (num >= this.StepInfoList.Count)
			{
				this.SwitchState(EGuideGroupState.Finishing);
				return;
			}
			this.CurrentStepIndex = num;
			GuideStepInfo guideStepInfo = this.StepInfoList[num];
			if (GuideConfig.Instance.GmMuteTutorial && guideStepInfo.Config.ContentType == 3)
			{
				guideStepInfo.SwitchState(EGuideStepState.Finish);
				return;
			}
			if (guideStepInfo.Config.BreakCondition != 0 && LevelGeneralController.Instance.CheckCondition(guideStepInfo.Config.BreakCondition.ToString(), null, false, Array.Empty<object>()))
			{
				guideStepInfo.SwitchState(EGuideStepState.Break);
				return;
			}
			if (guideStepInfo.Config.SkipCondition != 0 && LevelGeneralController.Instance.CheckCondition(guideStepInfo.Config.SkipCondition.ToString(), null, false, Array.Empty<object>()))
			{
				guideStepInfo.SwitchState(EGuideStepState.Finish);
				return;
			}
			guideStepInfo.SwitchState(EGuideStepState.Init);
			guideStepInfo.TryEnterExecuting();
		}

		// Token: 0x06022AB3 RID: 142003 RVA: 0x009DD84C File Offset: 0x009DBA4C
		private void EndCurrentStep()
		{
			int currentStepIndex = this.CurrentStepIndex;
			if (currentStepIndex >= 0 && currentStepIndex < this.StepInfoList.Count)
			{
				this.StepInfoList[currentStepIndex].SwitchState(EGuideStepState.End);
			}
		}

		// Token: 0x06022AB4 RID: 142004 RVA: 0x009DD884 File Offset: 0x009DBA84
		public void Reset()
		{
			this.EndCurrentStep();
			this.CurrentStepIndex = -1;
			this.SwitchState(EGuideGroupState.Init);
			EventSystem.Instance.Emit<int>(EEventName.GuideGroupRest, this.Id);
		}

		// Token: 0x06022AB5 RID: 142005 RVA: 0x009DD8B0 File Offset: 0x009DBAB0
		[NullableContext(1)]
		public bool HasAnyFinishedStep(HashSet<int> stepIdSet)
		{
			for (int i = 0; i < this.CurrentStepIndex; i++)
			{
				int id = this.StepInfoList[i].Id;
				if (stepIdSet.Contains(id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06022AB6 RID: 142006 RVA: 0x009DD8EC File Offset: 0x009DBAEC
		public void Break()
		{
			EGuideGroupState? currentState = this.StateMachine.CurrentState;
			EGuideGroupState eguideGroupState = EGuideGroupState.Init;
			if (currentState.GetValueOrDefault() == eguideGroupState & currentState != null)
			{
				return;
			}
			if (!GuideModel.Instance.IsGroupCanRepeat(this.Id))
			{
				this.SwitchState(EGuideGroupState.Finishing);
				return;
			}
			this.SwitchState(EGuideGroupState.Init);
			EventSystem.Instance.Emit<int>(EEventName.GuideGroupBreak, this.Id);
		}

		// Token: 0x06022AB7 RID: 142007 RVA: 0x009DD954 File Offset: 0x009DBB54
		public bool CanEnterExecuting()
		{
			if (LoadingModel.Instance.IsLoading || LoadingModel.Instance.IsLoadingView)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导组不能打开, 因为loading还没完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", this.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return true;
		}

		// Token: 0x06022AB8 RID: 142008 RVA: 0x009DD9B0 File Offset: 0x009DBBB0
		public bool CheckIsGuideRunning()
		{
			EGuideGroupState? currentState = this.StateMachine.CurrentState;
			EGuideGroupState eguideGroupState = EGuideGroupState.Init;
			return !(currentState.GetValueOrDefault() == eguideGroupState & currentState != null);
		}

		// Token: 0x06022AB9 RID: 142009 RVA: 0x009DD9E0 File Offset: 0x009DBBE0
		public bool CheckIsGuideRunningWithoutPending()
		{
			EGuideGroupState? currentState = this.StateMachine.CurrentState;
			GuideStepInfo currentGuideStep = this.CurrentGuideStep;
			EGuideStepState? eguideStepState;
			if (currentGuideStep == null)
			{
				eguideStepState = null;
			}
			else
			{
				StateMachine<GuideStepInfo, EGuideStepState> stateMachine = currentGuideStep.StateMachine;
				eguideStepState = ((stateMachine != null) ? stateMachine.CurrentState : null);
			}
			EGuideStepState? eguideStepState2 = eguideStepState;
			EGuideGroupState? eguideGroupState = currentState;
			EGuideGroupState eguideGroupState2 = EGuideGroupState.Init;
			if (!(eguideGroupState.GetValueOrDefault() == eguideGroupState2 & eguideGroupState != null) && currentState.GetValueOrDefault() != EGuideGroupState.Pending)
			{
				EGuideStepState? eguideStepState3 = eguideStepState2;
				EGuideStepState eguideStepState4 = EGuideStepState.Init;
				if (!(eguideStepState3.GetValueOrDefault() == eguideStepState4 & eguideStepState3 != null))
				{
					return eguideStepState2.GetValueOrDefault() != EGuideStepState.Pending;
				}
			}
			return false;
		}

		// Token: 0x04013359 RID: 78681
		public readonly int Id;

		// Token: 0x0401335A RID: 78682
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly StateMachine<GuideGroupInfo, EGuideGroupState> StateMachine;

		// Token: 0x0401335B RID: 78683
		[Nullable(1)]
		public readonly List<GuideStepInfo> StepInfoList = new List<GuideStepInfo>();

		// Token: 0x0401335C RID: 78684
		public bool IsFake;

		// Token: 0x0401335D RID: 78685
		public int CurrentStepIndex = -1;

		// Token: 0x0401335E RID: 78686
		public CustomPromise FinishPromise;

		// Token: 0x0401335F RID: 78687
		public HashSet<int> BreakExcludeStepIdSet;
	}
}
