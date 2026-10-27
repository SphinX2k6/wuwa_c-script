using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02004614 RID: 17940
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideGroupInfo
	{
		// Token: 0x170075C0 RID: 30144
		// (get) Token: 0x0602E3B9 RID: 189369 RVA: 0x00AB0DB8 File Offset: 0x00AAEFB8
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

		// Token: 0x0602E3BA RID: 189370 RVA: 0x00AB0DEC File Offset: 0x00AAEFEC
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

		// Token: 0x0602E3BB RID: 189371 RVA: 0x00AB0E74 File Offset: 0x00AAF074
		public bool GetIfPreExecute()
		{
			return this.StepInfoList.Count != 0 && Math.Abs(this.StepInfoList[0].Config.TimeScale - 1f) > 1E-08f;
		}

		// Token: 0x0602E3BC RID: 189372 RVA: 0x00AB0EBC File Offset: 0x00AAF0BC
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

		// Token: 0x0602E3BD RID: 189373 RVA: 0x00AB1014 File Offset: 0x00AAF214
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

		// Token: 0x0602E3BE RID: 189374 RVA: 0x00AB1158 File Offset: 0x00AAF358
		private void EndCurrentStep()
		{
			int currentStepIndex = this.CurrentStepIndex;
			if (currentStepIndex >= 0 && currentStepIndex < this.StepInfoList.Count)
			{
				this.StepInfoList[currentStepIndex].SwitchState(EGuideStepState.End);
			}
		}

		// Token: 0x0602E3BF RID: 189375 RVA: 0x00AB1190 File Offset: 0x00AAF390
		public void Reset()
		{
			this.EndCurrentStep();
			this.CurrentStepIndex = -1;
			this.SwitchState(EGuideGroupState.Init);
			EventSystem.Instance.Emit<int>(EEventName.GuideGroupRest, this.Id);
		}

		// Token: 0x0602E3C0 RID: 189376 RVA: 0x00AB11BC File Offset: 0x00AAF3BC
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

		// Token: 0x0602E3C1 RID: 189377 RVA: 0x00AB11F8 File Offset: 0x00AAF3F8
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

		// Token: 0x0602E3C2 RID: 189378 RVA: 0x00AB1260 File Offset: 0x00AAF460
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

		// Token: 0x0602E3C3 RID: 189379 RVA: 0x00AB12BC File Offset: 0x00AAF4BC
		public bool CheckIsGuideRunning()
		{
			EGuideGroupState? currentState = this.StateMachine.CurrentState;
			EGuideGroupState eguideGroupState = EGuideGroupState.Init;
			return !(currentState.GetValueOrDefault() == eguideGroupState & currentState != null);
		}

		// Token: 0x0602E3C4 RID: 189380 RVA: 0x00AB12EC File Offset: 0x00AAF4EC
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

		// Token: 0x04018D1A RID: 101658
		public readonly int Id;

		// Token: 0x04018D1B RID: 101659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly StateMachine<GuideGroupInfo, EGuideGroupState> StateMachine;

		// Token: 0x04018D1C RID: 101660
		[Nullable(1)]
		public readonly List<GuideStepInfo> StepInfoList = new List<GuideStepInfo>();

		// Token: 0x04018D1D RID: 101661
		public bool IsFake;

		// Token: 0x04018D1E RID: 101662
		public int CurrentStepIndex = -1;

		// Token: 0x04018D1F RID: 101663
		public CustomPromise FinishPromise;

		// Token: 0x04018D20 RID: 101664
		public HashSet<int> BreakExcludeStepIdSet;
	}
}
