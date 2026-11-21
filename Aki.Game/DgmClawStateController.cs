using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState;
using UnrealEngine;

// Token: 0x02000392 RID: 914
[NullableContext(2)]
[Nullable(0)]
public class DgmClawStateController
{
	// Token: 0x1700076F RID: 1903
	// (get) Token: 0x06003287 RID: 12935 RVA: 0x00122E64 File Offset: 0x00121064
	public AKuroLevelSequenceActor ClawAnimSeqActor
	{
		get
		{
			return this.ClawAnimSeqActorInternal;
		}
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x00122E6C File Offset: 0x0012106C
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

	// Token: 0x06003289 RID: 12937 RVA: 0x00122F58 File Offset: 0x00121158
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

	// Token: 0x0600328A RID: 12938 RVA: 0x00123094 File Offset: 0x00121294
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

	// Token: 0x0600328B RID: 12939 RVA: 0x00123114 File Offset: 0x00121314
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

	// Token: 0x0600328C RID: 12940 RVA: 0x00123190 File Offset: 0x00121390
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

	// Token: 0x0600328D RID: 12941 RVA: 0x00123351 File Offset: 0x00121551
	private void OnStateExit()
	{
		this.ChangeState();
	}

	// Token: 0x17000770 RID: 1904
	// (get) Token: 0x0600328E RID: 12942 RVA: 0x00123359 File Offset: 0x00121559
	public EDollGrabMachineClawState? LastState
	{
		get
		{
			return this.LastStateInternal;
		}
	}

	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x0600328F RID: 12943 RVA: 0x00123361 File Offset: 0x00121561
	public DgmClawBaseMoveState CurrentState
	{
		get
		{
			return this.CurrentStateInternal;
		}
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x0012336C File Offset: 0x0012156C
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

	// Token: 0x06003291 RID: 12945 RVA: 0x0012343C File Offset: 0x0012163C
	[NullableContext(1)]
	public bool CheckActorInClawPart(AActor actor)
	{
		return this.ClawPartActorList.Contains(actor);
	}

	// Token: 0x04002BB6 RID: 11190
	private SceneItemDollGrabMachineComponent Owner;

	// Token: 0x04002BB7 RID: 11191
	private DgmClawBaseMoveState CurrentStateInternal;

	// Token: 0x04002BB8 RID: 11192
	private EDollGrabMachineClawState? LastStateInternal;

	// Token: 0x04002BB9 RID: 11193
	[Nullable(1)]
	private readonly List<EDollGrabMachineClawState> TargetStateList = new List<EDollGrabMachineClawState>();

	// Token: 0x04002BBA RID: 11194
	private DgmClawIdleState IdleState;

	// Token: 0x04002BBB RID: 11195
	private DgmClawMovingDownState MovingDownState;

	// Token: 0x04002BBC RID: 11196
	private DgmClawMovingUpState MovingUpState;

	// Token: 0x04002BBD RID: 11197
	private DgmClawGrabState GrabState;

	// Token: 0x04002BBE RID: 11198
	private DgmClawReleaseState ReleaseState;

	// Token: 0x04002BBF RID: 11199
	private DgmClawResetState ResetState;

	// Token: 0x04002BC0 RID: 11200
	private AActor ClawActorInternal;

	// Token: 0x04002BC1 RID: 11201
	[Nullable(1)]
	private Dictionary<FName, AActor> ClawPartMap = new Dictionary<FName, AActor>();

	// Token: 0x04002BC2 RID: 11202
	[Nullable(1)]
	private readonly List<AActor> ClawPartActorList = new List<AActor>();

	// Token: 0x04002BC3 RID: 11203
	private AKuroLevelSequenceActor ClawAnimSeqActorInternal;
}
