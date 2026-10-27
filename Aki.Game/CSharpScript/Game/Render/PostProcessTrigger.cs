using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D1 RID: 17873
	[NullableContext(2)]
	[Nullable(0)]
	public class PostProcessTrigger
	{
		// Token: 0x0602E12C RID: 188716 RVA: 0x00A9EF00 File Offset: 0x00A9D100
		[NullableContext(1)]
		public void Init(UBoxComponent innerBoxCollision, UBoxComponent outerBoxCollision, UKuroPostProcessComponent postProcess, double transitionTime, EWuYinQuState wuYinQuBattleState, string wuYinQuActorKey)
		{
			this.WuYinQuActorKey = wuYinQuActorKey;
			this.WuYinQuBattleState = new EWuYinQuState?(wuYinQuBattleState);
			this.StateMachine = new StateMachine<PostProcessTrigger, EPostProcessTriggerState>(this, null);
			this.StateMachine.AddState<PostProcessTriggerStateInside>(EPostProcessTriggerState.Inside, null);
			this.StateMachine.AddState<PostProcessTriggerStateOutside>(EPostProcessTriggerState.Outside, null);
			this.StateMachine.AddState<PostProcessTriggerStateInsideToOutside>(EPostProcessTriggerState.InsideToOutSide, null);
			this.StateMachine.AddState<PostProcessTriggerStateOutsideToInside>(EPostProcessTriggerState.OutsideToInside, null);
			this.StateMachine.Start(EPostProcessTriggerState.Outside);
			this.InnerBox = innerBoxCollision;
			this.OuterBox = outerBoxCollision;
			this.PostProcess = postProcess;
			this.TransitionTime = transitionTime;
			this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Outside);
			this.PostProcess.BlendWeight = 0f;
			this.PostProcess.bUnbound = true;
			this.InnerBox.OnComponentBeginOverlapNoGcAlloc.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent>(this.OnInnerComponentBeginOverlap));
			this.OuterBox.OnComponentEndOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnOuterComponentEndOverlap));
			TArray<AActor> tarray = new TArray<AActor>();
			this.InnerBox.GetOverlappingActors(ref tarray, default(TSubclassOf<AActor>));
			if (tarray == null)
			{
				return;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				if (this.IsRelativeActor(tarray.Get(i)))
				{
					this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Inside);
				}
			}
		}

		// Token: 0x0602E12D RID: 188717 RVA: 0x00A9F039 File Offset: 0x00A9D239
		[NullableContext(1)]
		public string GetWuYinQuBattleKey()
		{
			return this.WuYinQuActorKey;
		}

		// Token: 0x0602E12E RID: 188718 RVA: 0x00A9F041 File Offset: 0x00A9D241
		public EWuYinQuState? GetWuYinQuBattleState()
		{
			return this.WuYinQuBattleState;
		}

		// Token: 0x0602E12F RID: 188719 RVA: 0x00A9F049 File Offset: 0x00A9D249
		public UKuroPostProcessComponent GetPostProcessComponent()
		{
			return this.PostProcess;
		}

		// Token: 0x0602E130 RID: 188720 RVA: 0x00A9F051 File Offset: 0x00A9D251
		private void OnInnerComponentBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp)
		{
			if (!this.IsRelativeActor(otherActor))
			{
				return;
			}
			this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Inside);
		}

		// Token: 0x0602E131 RID: 188721 RVA: 0x00A9F06C File Offset: 0x00A9D26C
		private bool IsRelativeActor(AActor otherActor)
		{
			if (otherActor == null || !otherActor.IsValid())
			{
				return false;
			}
			AActor myRoleTrigger = RoleTriggerController.Instance.GetMyRoleTrigger();
			return otherActor == myRoleTrigger;
		}

		// Token: 0x0602E132 RID: 188722 RVA: 0x00A9F09E File Offset: 0x00A9D29E
		private void OnOuterComponentEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
		{
			if (!this.IsRelativeActor(otherActor))
			{
				return;
			}
			this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Outside);
		}

		// Token: 0x0602E133 RID: 188723 RVA: 0x00A9F0B8 File Offset: 0x00A9D2B8
		public void Tick(float deltaTime)
		{
			EPostProcessTriggerState? currentState = this.StateMachine.CurrentState;
			EPostProcessTriggerState? epostProcessTriggerState = this.TargetState;
			if (!(currentState.GetValueOrDefault() == epostProcessTriggerState.GetValueOrDefault() & currentState != null == (epostProcessTriggerState != null)))
			{
				epostProcessTriggerState = this.StateMachine.CurrentState;
				EPostProcessTriggerState epostProcessTriggerState2 = EPostProcessTriggerState.Inside;
				if (epostProcessTriggerState.GetValueOrDefault() == epostProcessTriggerState2 & epostProcessTriggerState != null)
				{
					this.StateMachine.Switch(EPostProcessTriggerState.InsideToOutSide);
				}
				else if (this.StateMachine.CurrentState.GetValueOrDefault() == EPostProcessTriggerState.Outside)
				{
					this.StateMachine.Switch(EPostProcessTriggerState.OutsideToInside);
				}
			}
			this.StateMachine.Update(deltaTime);
		}

		// Token: 0x0602E134 RID: 188724 RVA: 0x00A9F15B File Offset: 0x00A9D35B
		public void Dispose()
		{
			this.InnerBox.OnComponentBeginOverlapNoGcAlloc.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent>(this.OnInnerComponentBeginOverlap));
			this.OuterBox.OnComponentEndOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnOuterComponentEndOverlap));
		}

		// Token: 0x04018B01 RID: 101121
		private UBoxComponent InnerBox;

		// Token: 0x04018B02 RID: 101122
		private UBoxComponent OuterBox;

		// Token: 0x04018B03 RID: 101123
		private UKuroPostProcessComponent PostProcess;

		// Token: 0x04018B04 RID: 101124
		public double TransitionTime;

		// Token: 0x04018B05 RID: 101125
		private EPostProcessTriggerState? TargetState;

		// Token: 0x04018B06 RID: 101126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private StateMachine<PostProcessTrigger, EPostProcessTriggerState> StateMachine;

		// Token: 0x04018B07 RID: 101127
		private EWuYinQuState? WuYinQuBattleState;

		// Token: 0x04018B08 RID: 101128
		[Nullable(1)]
		private string WuYinQuActorKey = "";
	}
}
