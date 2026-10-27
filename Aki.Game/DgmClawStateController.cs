using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState;
using UnrealEngine;

// Token: 0x02000EDD RID: 3805
[NullableContext(2)]
[Nullable(0)]
public class DgmClawStateController
{
	// Token: 0x1700074C RID: 1868
	// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x0011B128 File Offset: 0x00119328
	public AKuroLevelSequenceActor ClawAnimSeqActor
	{
		get
		{
			return this.ClawAnimSeqActorInternal;
		}
	}

	// Token: 0x06005EF2 RID: 24306 RVA: 0x0011B130 File Offset: 0x00119330
	[NullableContext(1)]
	public DgmClawStateController(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootCtrlActor, AActor clawChainActor, FTransformDouble clawTransform)
	{
		this.Owner = owner;
		this.ClawActorInternal = clawActor;
		this.IdleState = new DgmClawIdleState(this.Owner, clawActor, clawRootCtrlActor, clawTransform);
		this.MovingDownState = new DgmClawMovingDownState(this.Owner, clawActor, clawRootCtrlActor, clawChainActor, clawTransform);
		this.MovingUpState = new DgmClawMovingUpState(this.Owner, clawActor, clawRootCtrlActor, clawChainActor, clawTransform);
		this.GrabState = new DgmClawGrabState(this.Owner, clawActor, clawRootCtrlActor, clawTransform);
		this.ReleaseState = new DgmClawReleaseState(this.Owner, clawActor, clawRootCtrlActor, clawTransform);
		this.ResetState = new DgmClawResetState(this.Owner, clawActor, clawRootCtrlActor, clawTransform);
		EventSystem.Instance.AddWithTarget(this.Owner.Entity, EEventName.OnDollGrabMachineClawStateEnd, new Action(this.OnStateExit));
	}

	// Token: 0x06005EF3 RID: 24307 RVA: 0x0011B21C File Offset: 0x0011941C
	public void Init()
	{
		foreach (FName key in this.ClawActorInternal.Tags)
		{
			if (key.ToString().StartsWith("Claw_"))
			{
				this.ClawPartMap.Add(key, this.ClawActorInternal);
				this.ClawPartActorList.Add(this.ClawActorInternal);
				break;
			}
		}
		this.CollectClawPart(this.ClawActorInternal);
		AKuroLevelSequenceActor akuroLevelSequenceActor = ActorSystem.Instance.Get<AKuroLevelSequenceActor>(AKuroLevelSequenceActor.StaticClass(), this.Owner.ActorTransform, null, false);
		if (akuroLevelSequenceActor != null)
		{
			akuroLevelSequenceActor.SetSequence(DollGrabModel.Instance.DollGrabClawSequence);
			foreach (FName fname in this.ClawPartMap.Keys)
			{
				ALevelSequenceActor alevelSequenceActor = akuroLevelSequenceActor;
				FName bindingTag = fname;
				TArray<AActor> tarray = new TArray<AActor>
				{
					this.ClawPartMap[fname]
				};
				alevelSequenceActor.SetBindingByTag(bindingTag, tarray, false, false);
			}
			this.ClawAnimSeqActorInternal = akuroLevelSequenceActor;
		}
	}

	// Token: 0x06005EF4 RID: 24308 RVA: 0x0011B350 File Offset: 0x00119550
	public void Dispose()
	{
		EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnDollGrabMachineClawStateEnd, new Action(this.OnStateExit));
		if (this.ClawAnimSeqActorInternal != null && this.ClawAnimSeqActorInternal.IsValid())
		{
			ActorSystem.Instance.Put("DgmClawStateController.Dispose", this.ClawAnimSeqActorInternal, null);
		}
		this.ClawAnimSeqActorInternal = null;
		this.ClawPartMap.Clear();
		this.ClawPartActorList.Clear();
	}

	// Token: 0x06005EF5 RID: 24309 RVA: 0x0011B3D0 File Offset: 0x001195D0
	public void SetTargetState(EDollGrabMachineClawState targetState)
	{
		DgmClawBaseMoveState currentStateInternal = this.CurrentStateInternal;
		EDollGrabMachineClawState? edollGrabMachineClawState = (currentStateInternal != null) ? new EDollGrabMachineClawState?(currentStateInternal.ClawState) : null;
		if (targetState == edollGrabMachineClawState.GetValueOrDefault() & edollGrabMachineClawState != null)
		{
			return;
		}
		this.TargetStateList.Add(targetState);
		if (this.TargetStateList.Count != 1)
		{
			DgmClawBaseMoveState currentStateInternal2 = this.CurrentStateInternal;
			if (currentStateInternal2 == null || currentStateInternal2.ClawState != EDollGrabMachineClawState.Idle)
			{
				return;
			}
		}
		this.ChangeState();
	}

	// Token: 0x06005EF6 RID: 24310 RVA: 0x0011B44C File Offset: 0x0011964C
	public void ChangeState()
	{
		if (this.TargetStateList.Count == 0)
		{
			return;
		}
		EDollGrabMachineClawState? edollGrabMachineClawState = null;
		if (this.CurrentStateInternal == null)
		{
			edollGrabMachineClawState = new EDollGrabMachineClawState?(this.TargetStateList[0]);
		}
		else
		{
			DgmClawBaseMoveState currentStateInternal = this.CurrentStateInternal;
			edollGrabMachineClawState = ((currentStateInternal != null) ? currentStateInternal.TargetState : null);
		}
		if (edollGrabMachineClawState != null)
		{
			if (this.CurrentStateInternal != null)
			{
				this.CurrentStateInternal.Exit();
				this.LastStateInternal = new EDollGrabMachineClawState?(this.CurrentStateInternal.ClawState);
			}
			if (edollGrabMachineClawState != null)
			{
				switch (edollGrabMachineClawState.GetValueOrDefault())
				{
				case EDollGrabMachineClawState.Idle:
					this.CurrentStateInternal = this.IdleState;
					break;
				case EDollGrabMachineClawState.MovingDown:
					this.CurrentStateInternal = this.MovingDownState;
					break;
				case EDollGrabMachineClawState.MovingUp:
					this.CurrentStateInternal = this.MovingUpState;
					break;
				case EDollGrabMachineClawState.Grabbing:
					this.CurrentStateInternal = this.GrabState;
					break;
				case EDollGrabMachineClawState.Release:
					this.CurrentStateInternal = this.ReleaseState;
					break;
				case EDollGrabMachineClawState.Reset:
					this.CurrentStateInternal = this.ResetState;
					break;
				default:
					goto IL_108;
				}
				if (this.CurrentStateInternal != null)
				{
					this.CurrentStateInternal.Enter();
					EventSystem.Instance.Emit<EDollGrabMachineClawState>(EEventName.OnDollGrabMachineClawStateStart, this.CurrentStateInternal.ClawState);
				}
				DgmClawBaseMoveState currentStateInternal2 = this.CurrentStateInternal;
				EDollGrabMachineClawState? edollGrabMachineClawState2 = (currentStateInternal2 != null) ? new EDollGrabMachineClawState?(currentStateInternal2.ClawState) : null;
				EDollGrabMachineClawState edollGrabMachineClawState3 = this.TargetStateList[0];
				if (edollGrabMachineClawState2.GetValueOrDefault() == edollGrabMachineClawState3 & edollGrabMachineClawState2 != null)
				{
					this.TargetStateList.Shift<EDollGrabMachineClawState>();
					return;
				}
				return;
			}
			IL_108:
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DollGrabMachine;
			ELogAuthor author = ELogAuthor.FJH;
			string message = "[DgmClawStateController] 无效的钩爪状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("nextState", edollGrabMachineClawState);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x0011B60D File Offset: 0x0011980D
	private void OnStateExit()
	{
		this.ChangeState();
	}

	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x06005EF8 RID: 24312 RVA: 0x0011B615 File Offset: 0x00119815
	public EDollGrabMachineClawState? LastState
	{
		get
		{
			return this.LastStateInternal;
		}
	}

	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x06005EF9 RID: 24313 RVA: 0x0011B61D File Offset: 0x0011981D
	public DgmClawBaseMoveState CurrentState
	{
		get
		{
			return this.CurrentStateInternal;
		}
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x0011B628 File Offset: 0x00119828
	[NullableContext(1)]
	private void CollectClawPart(AActor actor)
	{
		TArray<AActor> tarray = new TArray<AActor>();
		actor.GetAttachedActors(ref tarray, true);
		foreach (AActor aactor in tarray)
		{
			foreach (FName key in aactor.Tags)
			{
				if (key.ToString().StartsWith("Claw_"))
				{
					this.ClawPartMap.Add(key, aactor);
					this.ClawPartActorList.Add(aactor);
					break;
				}
			}
			this.CollectClawPart(aactor);
		}
	}

	// Token: 0x06005EFB RID: 24315 RVA: 0x0011B6EC File Offset: 0x001198EC
	[NullableContext(1)]
	public bool CheckActorInClawPart(AActor actor)
	{
		return this.ClawPartActorList.Contains(actor);
	}

	// Token: 0x04002B1C RID: 11036
	private SceneItemDollGrabMachineComponent Owner;

	// Token: 0x04002B1D RID: 11037
	private DgmClawBaseMoveState CurrentStateInternal;

	// Token: 0x04002B1E RID: 11038
	private EDollGrabMachineClawState? LastStateInternal;

	// Token: 0x04002B1F RID: 11039
	[Nullable(1)]
	private readonly List<EDollGrabMachineClawState> TargetStateList = new List<EDollGrabMachineClawState>();

	// Token: 0x04002B20 RID: 11040
	private DgmClawIdleState IdleState;

	// Token: 0x04002B21 RID: 11041
	private DgmClawMovingDownState MovingDownState;

	// Token: 0x04002B22 RID: 11042
	private DgmClawMovingUpState MovingUpState;

	// Token: 0x04002B23 RID: 11043
	private DgmClawGrabState GrabState;

	// Token: 0x04002B24 RID: 11044
	private DgmClawReleaseState ReleaseState;

	// Token: 0x04002B25 RID: 11045
	private DgmClawResetState ResetState;

	// Token: 0x04002B26 RID: 11046
	private AActor ClawActorInternal;

	// Token: 0x04002B27 RID: 11047
	[Nullable(1)]
	private Dictionary<FName, AActor> ClawPartMap = new Dictionary<FName, AActor>();

	// Token: 0x04002B28 RID: 11048
	[Nullable(1)]
	private readonly List<AActor> ClawPartActorList = new List<AActor>();

	// Token: 0x04002B29 RID: 11049
	private AKuroLevelSequenceActor ClawAnimSeqActorInternal;
}
