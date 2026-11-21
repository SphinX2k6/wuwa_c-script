using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034FA RID: 13562
	[NullableContext(2)]
	[Nullable(0)]
	public class PostProcessTrigger
	{
		// Token: 0x06022820 RID: 141344 RVA: 0x009CB5D0 File Offset: 0x009C97D0
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

		// Token: 0x06022821 RID: 141345 RVA: 0x009CB709 File Offset: 0x009C9909
		[NullableContext(1)]
		public string GetWuYinQuBattleKey()
		{
			return this.WuYinQuActorKey;
		}

		// Token: 0x06022822 RID: 141346 RVA: 0x009CB711 File Offset: 0x009C9911
		public EWuYinQuState? GetWuYinQuBattleState()
		{
			return this.WuYinQuBattleState;
		}

		// Token: 0x06022823 RID: 141347 RVA: 0x009CB719 File Offset: 0x009C9919
		public UKuroPostProcessComponent GetPostProcessComponent()
		{
			return this.PostProcess;
		}

		// Token: 0x06022824 RID: 141348 RVA: 0x009CB721 File Offset: 0x009C9921
		private void OnInnerComponentBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp)
		{
			if (!this.IsRelativeActor(otherActor))
			{
				return;
			}
			this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Inside);
		}

		// Token: 0x06022825 RID: 141349 RVA: 0x009CB73C File Offset: 0x009C993C
		private bool IsRelativeActor(AActor otherActor)
		{
			if (otherActor == null || !otherActor.IsValid())
			{
				return false;
			}
			AActor myRoleTrigger = RoleTriggerController.Instance.GetMyRoleTrigger();
			return otherActor == myRoleTrigger;
		}

		// Token: 0x06022826 RID: 141350 RVA: 0x009CB76E File Offset: 0x009C996E
		private void OnOuterComponentEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
		{
			if (!this.IsRelativeActor(otherActor))
			{
				return;
			}
			this.TargetState = new EPostProcessTriggerState?(EPostProcessTriggerState.Outside);
		}

		// Token: 0x06022827 RID: 141351 RVA: 0x009CB788 File Offset: 0x009C9988
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

		// Token: 0x06022828 RID: 141352 RVA: 0x009CB82B File Offset: 0x009C9A2B
		public void Dispose()
		{
			this.InnerBox.OnComponentBeginOverlapNoGcAlloc.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent>(this.OnInnerComponentBeginOverlap));
			this.OuterBox.OnComponentEndOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnOuterComponentEndOverlap));
		}

		// Token: 0x0401313F RID: 78143
		private UBoxComponent InnerBox;

		// Token: 0x04013140 RID: 78144
		private UBoxComponent OuterBox;

		// Token: 0x04013141 RID: 78145
		private UKuroPostProcessComponent PostProcess;

		// Token: 0x04013142 RID: 78146
		public double TransitionTime;

		// Token: 0x04013143 RID: 78147
		private EPostProcessTriggerState? TargetState;

		// Token: 0x04013144 RID: 78148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private StateMachine<PostProcessTrigger, EPostProcessTriggerState> StateMachine;

		// Token: 0x04013145 RID: 78149
		private EWuYinQuState? WuYinQuBattleState;

		// Token: 0x04013146 RID: 78150
		[Nullable(1)]
		private string WuYinQuActorKey = "";
	}
}
