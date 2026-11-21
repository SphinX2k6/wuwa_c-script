using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using CSharpScript.Typing;
using UnrealEngine.Extension;

// Token: 0x02002658 RID: 9816
[NullableContext(1)]
[Nullable(0)]
public class MoveToLocationController : IStaticVariableResetter
{
	// Token: 0x060188BD RID: 100541 RVA: 0x00771CFA File Offset: 0x0076FEFA
	static MoveToLocationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoveToLocationController.CreateStaticDefaultValue), new Action(MoveToLocationController.ResetStaticDefaultValue));
	}

	// Token: 0x060188BE RID: 100542 RVA: 0x00771D1C File Offset: 0x0076FF1C
	public MoveToLocationController(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.StateComp = entity.GetComponent<BaseUnifiedStateComponent>();
	}

	// Token: 0x170026AD RID: 9901
	// (get) Token: 0x060188BF RID: 100543 RVA: 0x00771D77 File Offset: 0x0076FF77
	private BaseMoveCharacter MoveAlongPathLogic
	{
		get
		{
			if (this.MoveAlongPathLogicInternal == null)
			{
				this.MoveAlongPathLogicInternal = new BaseMoveCharacter();
				this.MoveAlongPathLogicInternal.Init(this.ActorComp.Entity);
			}
			return this.MoveAlongPathLogicInternal;
		}
	}

	// Token: 0x170026AE RID: 9902
	// (get) Token: 0x060188C0 RID: 100544 RVA: 0x00771DA8 File Offset: 0x0076FFA8
	private MoveToLocation MoveToLocationLogic
	{
		get
		{
			if (this.MoveToLocationLogicInternal == null)
			{
				this.MoveToLocationLogicInternal = new MoveToLocation();
				this.MoveToLocationLogicInternal.Init(this.ActorComp.Entity);
			}
			return this.MoveToLocationLogicInternal;
		}
	}

	// Token: 0x170026AF RID: 9903
	// (get) Token: 0x060188C1 RID: 100545 RVA: 0x00771DD9 File Offset: 0x0076FFD9
	private KeepFollowingMoveLogic KeepFollowingMoveLogic
	{
		get
		{
			if (this.KeepFollowingMoveLogicInternal == null)
			{
				this.KeepFollowingMoveLogicInternal = new KeepFollowingMoveLogic();
				this.KeepFollowingMoveLogicInternal.Init(this.ActorComp.Entity);
			}
			return this.KeepFollowingMoveLogicInternal;
		}
	}

	// Token: 0x060188C2 RID: 100546 RVA: 0x00771E0C File Offset: 0x0077000C
	public void UpdateMove(float deltaSeconds)
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		if (moveAlongPathLogic != null && moveAlongPathLogic.IsRunning)
		{
			BaseMoveCharacter moveAlongPathLogic2 = this.MoveAlongPathLogic;
			if (moveAlongPathLogic2 != null)
			{
				moveAlongPathLogic2.UpdateMove(deltaSeconds);
			}
		}
		else
		{
			MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
			if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null)
			{
				MoveToLocation moveToLocationLogic2 = this.MoveToLocationLogic;
				if (moveToLocationLogic2 != null)
				{
					moveToLocationLogic2.UpdateMove(deltaSeconds);
				}
			}
			else if (this.KeepFollowingMoveLogic.IsMoving())
			{
				this.KeepFollowingMoveLogic.UpdateMove(deltaSeconds);
			}
			else
			{
				AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
				if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
				{
					this.AttachMoveLogicInternal.UpdateMove(deltaSeconds);
				}
			}
		}
		this.UpdateAutoSync(deltaSeconds);
	}

	// Token: 0x060188C3 RID: 100547 RVA: 0x00771EAC File Offset: 0x007700AC
	public bool IsMoving()
	{
		if (!this.KeepFollowingMoveLogic.IsMoving())
		{
			AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
			if (attachMoveLogicInternal == null || !attachMoveLogicInternal.IsMoving())
			{
				BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
				if (moveAlongPathLogic == null || !moveAlongPathLogic.IsRunning)
				{
					MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
					return ((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null;
				}
			}
		}
		return true;
	}

	// Token: 0x060188C4 RID: 100548 RVA: 0x00771F08 File Offset: 0x00770108
	[NullableContext(2)]
	public void StopMoveWithCallback(ELevelEventState result, string context = null)
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		if (moveAlongPathLogic != null && moveAlongPathLogic.IsRunning)
		{
			this.MoveAlongPathLogic.MoveEnd(result);
		}
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null)
		{
			this.MoveToLocationLogic.MoveEnd(result);
		}
		if (this.KeepFollowingMoveLogic.IsMoving())
		{
			this.KeepFollowingMoveLogic.MoveEnd(result);
		}
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
		{
			this.AttachMoveLogicInternal.StopMoveWithCallback(result);
		}
		this.ClearCurrentMoveHandle(context);
	}

	// Token: 0x060188C5 RID: 100549 RVA: 0x00771F98 File Offset: 0x00770198
	[NullableContext(2)]
	public void StopMove(string context = null)
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		if (moveAlongPathLogic != null && moveAlongPathLogic.IsRunning)
		{
			this.MoveAlongPathLogic.StopMove();
		}
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null)
		{
			this.MoveToLocationLogic.StopMove(null);
		}
		if (this.KeepFollowingMoveLogic.IsMoving())
		{
			this.KeepFollowingMoveLogic.StopMove();
		}
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
		{
			this.AttachMoveLogicInternal.StopMove();
		}
		this.ClearCurrentMoveHandle(context);
	}

	// Token: 0x060188C6 RID: 100550 RVA: 0x00772024 File Offset: 0x00770224
	public void Dispose()
	{
		BaseMoveCharacter moveAlongPathLogicInternal = this.MoveAlongPathLogicInternal;
		if (moveAlongPathLogicInternal != null)
		{
			moveAlongPathLogicInternal.Dispose();
		}
		MoveToLocation moveToLocationLogicInternal = this.MoveToLocationLogicInternal;
		if (moveToLocationLogicInternal != null)
		{
			moveToLocationLogicInternal.Dispose();
		}
		KeepFollowingMoveLogic keepFollowingMoveLogicInternal = this.KeepFollowingMoveLogicInternal;
		if (keepFollowingMoveLogicInternal != null)
		{
			keepFollowingMoveLogicInternal.Dispose();
		}
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null)
		{
			attachMoveLogicInternal.Dispose();
		}
		this.DisableAutoSync();
		this.ClearCurrentMoveHandle("Dispose");
	}

	// Token: 0x060188C7 RID: 100551 RVA: 0x00772088 File Offset: 0x00770288
	[NullableContext(2)]
	public global::Vector GetCurrentToLocation()
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		if (moveAlongPathLogic != null && moveAlongPathLogic.IsRunning)
		{
			return this.MoveAlongPathLogic.CurrentToLocation;
		}
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetLastMoveToLocation() : null) != null)
		{
			return this.MoveToLocationLogic.GetLastMoveToLocation();
		}
		return null;
	}

	// Token: 0x060188C8 RID: 100552 RVA: 0x007720D6 File Offset: 0x007702D6
	public void EnableAutoSync(int interval = 5, float ratio = 0.01f)
	{
		this.AutoSyncEnabled = true;
		this.AutoSyncInterval = interval;
		this.AutoSyncRatio = ratio;
		this.AutoSyncTimer = (float)interval;
		this.AutoSyncLastLocationValid = false;
	}

	// Token: 0x060188C9 RID: 100553 RVA: 0x007720FC File Offset: 0x007702FC
	public void DisableAutoSync()
	{
		this.AutoSyncEnabled = false;
		this.AutoSyncTimer = 0f;
		this.AutoSyncLastLocationValid = false;
	}

	// Token: 0x060188CA RID: 100554 RVA: 0x00772118 File Offset: 0x00770318
	private void UpdateAutoSync(float deltaSeconds)
	{
		if (!this.AutoSyncEnabled)
		{
			return;
		}
		if (this.AutoSyncTimer < 0f)
		{
			this.PushMoveInfo();
			this.AutoSyncTimer = (float)this.AutoSyncInterval;
			return;
		}
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		float num = 0f;
		if (this.AutoSyncLastLocationValid && deltaSeconds > 0f)
		{
			MoveToLocationController.CacheVector.DeepCopy(actorLocationProxy);
			MoveToLocationController.CacheVector.SubtractionEqual(this.AutoSyncLastLocation);
			num = (float)(MoveToLocationController.CacheVector.Size() / (double)deltaSeconds);
		}
		this.AutoSyncLastLocation.DeepCopy(actorLocationProxy);
		this.AutoSyncLastLocationValid = true;
		float num2 = Math.Min((float)this.AutoSyncInterval / 0.25f, Math.Max(1f, num * this.AutoSyncRatio));
		this.AutoSyncTimer -= deltaSeconds * num2;
	}

	// Token: 0x060188CB RID: 100555 RVA: 0x007721E5 File Offset: 0x007703E5
	public void PushMoveInfo()
	{
		int entityTypeByEntity = WorldFunctionLibrary.GetEntityTypeByEntity(this.ActorComp.Entity.Id);
		if (entityTypeByEntity == 1)
		{
			this.PushNpcMoveInfoWithPointPos();
		}
		if (entityTypeByEntity == 2)
		{
			this.PushMonsterMoveInfoWithPointPos();
		}
	}

	// Token: 0x060188CC RID: 100556 RVA: 0x00772210 File Offset: 0x00770410
	private void PushNpcMoveInfoWithPointPos()
	{
		EntitySimplyMoveInfo entitySimplyMoveInfo = EntitySimplyMoveInfo.Create();
		entitySimplyMoveInfo.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
		entitySimplyMoveInfo.Location = Aki.Protocol.Vector.Create();
		entitySimplyMoveInfo.Location.X = (float)this.ActorComp.ActorLocationProxy.X;
		entitySimplyMoveInfo.Location.Y = (float)this.ActorComp.ActorLocationProxy.Y;
		entitySimplyMoveInfo.Location.Z = (float)this.ActorComp.ActorLocationProxy.Z;
		entitySimplyMoveInfo.Rotation = Aki.Protocol.Rotator.Create();
		entitySimplyMoveInfo.Rotation.Pitch = this.ActorComp.ActorRotationProxy.Pitch;
		entitySimplyMoveInfo.Rotation.Yaw = this.ActorComp.ActorRotationProxy.Yaw;
		entitySimplyMoveInfo.Rotation.Roll = this.ActorComp.ActorRotationProxy.Roll;
		EntitySimplyMoveInfoPackagePush entitySimplyMoveInfoPackagePush = EntitySimplyMoveInfoPackagePush.Create();
		entitySimplyMoveInfoPackagePush.MoveInfos.Add(entitySimplyMoveInfo);
		Net.Instance.Send(EPushMessageId.EntitySimplyMoveInfoPackagePush, entitySimplyMoveInfoPackagePush);
	}

	// Token: 0x060188CD RID: 100557 RVA: 0x00772324 File Offset: 0x00770524
	private void PushMonsterMoveInfoWithPointPos()
	{
		CharacterMovementSyncComponent component = this.ActorComp.Entity.GetComponent<CharacterMovementSyncComponent>();
		MoveReplaySample currentMoveSample = component.GetCurrentMoveSample();
		currentMoveSample.Location = Aki.Protocol.Vector.Create();
		currentMoveSample.Location.X = (float)this.ActorComp.ActorLocationProxy.X;
		currentMoveSample.Location.Y = (float)this.ActorComp.ActorLocationProxy.Y;
		currentMoveSample.Location.Z = (float)this.ActorComp.ActorLocationProxy.Z;
		component.PendingMoveInfos.Add(currentMoveSample);
		MovePackagePush movePackagePush = MovePackagePush.Create();
		movePackagePush.SceneOwnerId = (GameModeModel.Instance.IsMulti ? OnlineModel.Instance.OwnerId : CreatureModel.Instance.GetPlayerId());
		movePackagePush.MovingEntities.Add(component.CollectPendingMoveInfos());
		Net.Instance.Send(EPushMessageId.MovePackagePush, movePackagePush);
	}

	// Token: 0x060188CE RID: 100558 RVA: 0x00772403 File Offset: 0x00770603
	public void GetFollowingPosition(global::Vector out_, CharacterActorComponent leader)
	{
		KeepFollowingMoveLogic keepFollowingMoveLogic = this.KeepFollowingMoveLogic;
		if (keepFollowingMoveLogic == null)
		{
			return;
		}
		keepFollowingMoveLogic.GetTargetFollowingPosition(out_, leader);
	}

	// Token: 0x060188CF RID: 100559 RVA: 0x00772418 File Offset: 0x00770618
	[NullableContext(2)]
	private int CreateMoveHandle(MoveToLocationController.EMoveHandleKind kind, string context = null)
	{
		this.CheckStopMontage();
		int currentMoveHandleId = this.CurrentMoveHandleId;
		MoveToLocationController.EMoveHandleKind currentMoveKind = this.CurrentMoveKind;
		this.LastMoveHandleId++;
		this.CurrentMoveHandleId = this.LastMoveHandleId;
		this.CurrentMoveKind = kind;
		return this.CurrentMoveHandleId;
	}

	// Token: 0x060188D0 RID: 100560 RVA: 0x00772455 File Offset: 0x00770655
	public int GetCurrentMoveHandleId()
	{
		return this.CurrentMoveHandleId;
	}

	// Token: 0x060188D1 RID: 100561 RVA: 0x0077245D File Offset: 0x0077065D
	[NullableContext(2)]
	public bool StopMoveByHandleId(int handleId, string context = null)
	{
		if (handleId <= 0)
		{
			return false;
		}
		if (this.CurrentMoveHandleId != handleId)
		{
			return false;
		}
		this.StopMove(context);
		return true;
	}

	// Token: 0x060188D2 RID: 100562 RVA: 0x00772478 File Offset: 0x00770678
	[NullableContext(2)]
	private void ClearCurrentMoveHandle(string reason = null)
	{
		if (this.CurrentMoveHandleId == 0)
		{
			return;
		}
		this.CurrentMoveHandleId = 0;
		this.CurrentMoveKind = MoveToLocationController.EMoveHandleKind.None;
	}

	// Token: 0x060188D3 RID: 100563 RVA: 0x00772491 File Offset: 0x00770691
	public int StartKeepFollowingWithDataAsset(CharacterActorComponent leader, BP_KeepFollowingConfig_C da, EHandType? handType = null, bool followingOnce = false, [Nullable(2)] Action<ELevelEventState> onFinish = null, [TupleElementNames(new string[]
	{
		"X",
		"Y"
	})] [Nullable(0)] ValueTuple<double, double>? walkOffset = null)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.KeepFollowing, null);
		this.KeepFollowingMoveLogic.StartKeepFollowingWithDataAsset(leader, da, handType, followingOnce, onFinish, walkOffset);
		return result;
	}

	// Token: 0x060188D4 RID: 100564 RVA: 0x007724AF File Offset: 0x007706AF
	public int StartKeepFollowingWithDataAssetPath(CharacterActorComponent leader, string daPath, EHandType? handType = null, bool followingOnce = false, [Nullable(2)] Action<ELevelEventState> onFinish = null, [TupleElementNames(new string[]
	{
		"X",
		"Y"
	})] [Nullable(0)] ValueTuple<double, double>? walkOffset = null)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.KeepFollowing, null);
		this.KeepFollowingMoveLogic.StartKeepFollowingWithDataAssetPath(leader, daPath, handType, followingOnce, onFinish, walkOffset);
		return result;
	}

	// Token: 0x060188D5 RID: 100565 RVA: 0x007724D0 File Offset: 0x007706D0
	public int StartSplineKeepFollowingWithDataAssetPath(CharacterActorComponent leader, string daPath, SplineDistanceParams param, [Nullable(2)] Action<ELevelEventState> onFinish = null)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.KeepFollowingSpline, null);
		this.KeepFollowingMoveLogic.StartKeepFollowingWithDataAssetPath(leader, daPath, null, false, onFinish, null);
		this.KeepFollowingMoveLogic.SetSplineDistanceParam(param);
		return result;
	}

	// Token: 0x060188D6 RID: 100566 RVA: 0x00772513 File Offset: 0x00770713
	public void StopKeepHoldingHands()
	{
		this.KeepFollowingMoveLogic.StopMove();
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.KeepFollowing || this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.KeepFollowingSpline)
		{
			this.ClearCurrentMoveHandle("StopKeepHoldingHands");
		}
	}

	// Token: 0x060188D7 RID: 100567 RVA: 0x0077253D File Offset: 0x0077073D
	public bool IsAttachMoving()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		return attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving();
	}

	// Token: 0x060188D8 RID: 100568 RVA: 0x00772550 File Offset: 0x00770750
	public int StartAttachMoveWithData(CharacterActorComponent leader, BP_AttachMoveConfig_C data, [Nullable(2)] Action endCallback = null)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.AttachMove, null);
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
		{
			this.AttachMoveLogicInternal.StopMove();
		}
		this.AttachMoveLogicInternal = new AttachMoveLogic();
		this.AttachMoveLogicInternal.StartHelpedAttachMoveWithData(this.ActorComp.Entity, leader, data, endCallback);
		return result;
	}

	// Token: 0x060188D9 RID: 100569 RVA: 0x007725A8 File Offset: 0x007707A8
	public void StopAttachMove()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null)
		{
			attachMoveLogicInternal.StopMove();
		}
		this.AttachMoveLogicInternal = null;
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.AttachMove)
		{
			this.ClearCurrentMoveHandle("StopAttachMove");
		}
	}

	// Token: 0x060188DA RID: 100570 RVA: 0x007725D6 File Offset: 0x007707D6
	public void StartAssistedWalk()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.StartAssistedWalk();
	}

	// Token: 0x060188DB RID: 100571 RVA: 0x007725E8 File Offset: 0x007707E8
	public void EnterAssistedWalkIdle()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.EnterAssistedWalkIdle();
	}

	// Token: 0x060188DC RID: 100572 RVA: 0x007725FA File Offset: 0x007707FA
	public void EnterAssistedWalking()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.EnterAssistedWalking();
	}

	// Token: 0x060188DD RID: 100573 RVA: 0x0077260C File Offset: 0x0077080C
	public void LeftAssistedWalking()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.LeftAssistedWalking();
	}

	// Token: 0x060188DE RID: 100574 RVA: 0x00772620 File Offset: 0x00770820
	public int StartAssistedWalkWithData(CharacterActorComponent leader, BP_AssistedWalkConfig_C data, [Nullable(2)] Action endCallback = null, bool waitAnim = true)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.AttachMove, null);
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
		{
			this.AttachMoveLogicInternal.StopMove();
		}
		AssistedWalkFollowerLogic assistedWalkFollowerLogic = new AssistedWalkFollowerLogic();
		this.AttachMoveLogicInternal = assistedWalkFollowerLogic;
		assistedWalkFollowerLogic.StartHelpedAssistedWalkWithData(this.ActorComp.Entity, leader, data, endCallback, waitAnim);
		return result;
	}

	// Token: 0x060188DF RID: 100575 RVA: 0x00772678 File Offset: 0x00770878
	public int StartLeaderAssistedWalkWithData(BP_AssistedWalkConfig_C data, [Nullable(2)] Action endCallback = null, bool waitAnim = true)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.AttachMove, null);
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving())
		{
			this.AttachMoveLogicInternal.StopMove();
		}
		AssistedWalkLeaderLogic assistedWalkLeaderLogic = new AssistedWalkLeaderLogic();
		this.AttachMoveLogicInternal = assistedWalkLeaderLogic;
		assistedWalkLeaderLogic.StartLeaderAssistedWalkWithData(this.ActorComp.Entity, data, endCallback, waitAnim);
		return result;
	}

	// Token: 0x060188E0 RID: 100576 RVA: 0x007726CD File Offset: 0x007708CD
	public void StopAssistedWalk()
	{
		this.StopAttachMove();
	}

	// Token: 0x060188E1 RID: 100577 RVA: 0x007726D8 File Offset: 0x007708D8
	public unsafe int MoveAlongPath(MoveCharacterConfig config, [Nullable(2)] string context = null)
	{
		if (this.IsMoving())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[BaseMoveComponent.MoveAlongPath]正在移动中，停止当前移动";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "Actor";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? actorComp2.Owner : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsRunning", this.IsMovingAlongPath());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.StopMove(context);
		}
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.MoveAlongPath, context);
		this.MoveAlongPathLogic.MoveAlongPath(config);
		return result;
	}

	// Token: 0x060188E2 RID: 100578 RVA: 0x007727B9 File Offset: 0x007709B9
	public bool IsMovingAlongPath()
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		return moveAlongPathLogic != null && moveAlongPathLogic.IsRunning;
	}

	// Token: 0x060188E3 RID: 100579 RVA: 0x007727CC File Offset: 0x007709CC
	public void StopMoveAlongPath()
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		if (moveAlongPathLogic != null)
		{
			moveAlongPathLogic.StopMove();
		}
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.MoveAlongPath)
		{
			this.ClearCurrentMoveHandle("StopMoveAlongPath");
		}
	}

	// Token: 0x060188E4 RID: 100580 RVA: 0x007727F3 File Offset: 0x007709F3
	public bool IsMovingToLocation()
	{
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		return ((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null;
	}

	// Token: 0x060188E5 RID: 100581 RVA: 0x0077280A File Offset: 0x00770A0A
	[NullableContext(2)]
	public void StopMoveToLocation(string context = null)
	{
		this.MoveToLocationLogic.StopMove(context);
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.MoveToLocation || this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.NavigateMoveToLocation)
		{
			this.ClearCurrentMoveHandle(context);
		}
	}

	// Token: 0x060188E6 RID: 100582 RVA: 0x00772831 File Offset: 0x00770A31
	[NullableContext(2)]
	public MoveToLocation GetMoveToLocationLogic()
	{
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null)
		{
			return this.MoveToLocationLogic;
		}
		return null;
	}

	// Token: 0x060188E7 RID: 100583 RVA: 0x0077284F File Offset: 0x00770A4F
	public void PullbackMoveToLocation()
	{
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null)
		{
			MoveToLocation moveToLocationLogic2 = this.MoveToLocationLogic;
			if (moveToLocationLogic2 == null)
			{
				return;
			}
			moveToLocationLogic2.ResetPullbackLocation();
		}
	}

	// Token: 0x060188E8 RID: 100584 RVA: 0x00772878 File Offset: 0x00770A78
	public bool MoveToLocation(IMoveToPointConfig moveConfig, bool stopMove = true, [Nullable(2)] string context = null)
	{
		if (this.MoveToLocationLogic == null)
		{
			return false;
		}
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		double num = moveConfig.Distance ?? ((double)MoveToPointConfig.DefaultDistance);
		if (GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, actorLocationProxy, moveConfig.Position) >= num * num)
		{
			if (stopMove)
			{
				this.ClearLastMove();
			}
			bool flag = this.MoveToLocationLogic.SetMoveToLocation(moveConfig);
			if (flag)
			{
				this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.MoveToLocation, context);
			}
			return flag;
		}
		if (moveConfig.CallbackList == null || moveConfig.CallbackList.Count == 0)
		{
			return true;
		}
		foreach (Action<ELevelEventState> action in moveConfig.CallbackList)
		{
			if (action != null)
			{
				action(ELevelEventState.Success);
			}
		}
		return true;
	}

	// Token: 0x060188E9 RID: 100585 RVA: 0x0077295C File Offset: 0x00770B5C
	public bool NavigateMoveToLocation(IMoveToPointConfig moveConfig, bool? navFailReturn = null, bool clear = true, [Nullable(2)] string context = null)
	{
		if (this.MoveToLocationLogic == null)
		{
			return false;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.WanderDirectionType == EWanderDirectionType.LR)
		{
			moveConfig.MoveState = new global::ECharMoveState?(global::ECharMoveState.Walk);
		}
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		double num = moveConfig.Distance ?? ((double)MoveToPointConfig.DefaultDistance);
		if (GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, actorLocationProxy, moveConfig.Position) < num * num)
		{
			if (moveConfig.CallbackList == null || moveConfig.CallbackList.Count == 0)
			{
				return true;
			}
			foreach (Action<ELevelEventState> action in moveConfig.CallbackList)
			{
				if (action != null)
				{
					action(ELevelEventState.Success);
				}
			}
			return true;
		}
		else
		{
			BaseUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp != null && stateComp.PositionState == global::ECharPositionState.Ground)
			{
				MoveToLocationController.CacheVector.DeepCopy(this.ActorComp.FloorLocation);
			}
			else
			{
				MoveToLocationController.CacheVector.DeepCopy(actorLocationProxy);
			}
			bool navigateMoveToLocationQueue = MoveToLocationController.GetNavigateMoveToLocationQueue(this.ActorComp, MoveToLocationController.CacheVector, moveConfig.Position, this.CacheQueue, num);
			if (navFailReturn.GetValueOrDefault() && !navigateMoveToLocationQueue)
			{
				return false;
			}
			if (clear)
			{
				this.ClearLastMove();
			}
			if (!this.CacheQueue.Empty)
			{
				moveConfig.Position.DeepCopy(this.CacheQueue.Pop());
				moveConfig.NextMovePointConfig = this.CacheQueue;
			}
			bool flag = this.MoveToLocationLogic.SetMoveToLocation(moveConfig);
			if (flag)
			{
				this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.NavigateMoveToLocation, context);
			}
			return flag;
		}
	}

	// Token: 0x060188EA RID: 100586 RVA: 0x00772AF8 File Offset: 0x00770CF8
	private unsafe void ClearLastMove()
	{
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		if (((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) == null)
		{
			return;
		}
		this.MoveToLocationLogic.StopMove(null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "正在移动中，停止移动。";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", this.ActorComp.Entity.Id);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.MoveToLocation || this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.NavigateMoveToLocation)
		{
			this.ClearCurrentMoveHandle("ClearLastMove");
		}
	}

	// Token: 0x060188EB RID: 100587 RVA: 0x00772BC0 File Offset: 0x00770DC0
	private string GetMoveKindDesc(MoveToLocationController.EMoveHandleKind kind)
	{
		switch (kind)
		{
		case MoveToLocationController.EMoveHandleKind.None:
			return "无";
		case MoveToLocationController.EMoveHandleKind.MoveAlongPath:
			return "MoveAlongPath";
		case MoveToLocationController.EMoveHandleKind.MoveToLocation:
			return "MoveToLocation";
		case MoveToLocationController.EMoveHandleKind.NavigateMoveToLocation:
			return "NavigateMoveToLocation";
		case MoveToLocationController.EMoveHandleKind.KeepFollowing:
			return "KeepFollowing";
		case MoveToLocationController.EMoveHandleKind.KeepFollowingSpline:
			return "KeepFollowingSpline";
		case MoveToLocationController.EMoveHandleKind.AttachMove:
			return "AttachMove";
		default:
			return string.Empty;
		}
	}

	// Token: 0x060188EC RID: 100588 RVA: 0x00772C20 File Offset: 0x00770E20
	private string GetPointsDebugText([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<MoveCharacterPoint, IList<MoveCharacterPoint>> points)
	{
		if (!points.HasValue)
		{
			return string.Empty;
		}
		global::Vector vector = null;
		if (points.IsT2)
		{
			IList<MoveCharacterPoint> asT = points.AsT2;
			if (asT.Count > 0)
			{
				IList<MoveCharacterPoint> list = asT;
				vector = list[list.Count - 1].Position;
			}
		}
		else
		{
			vector = points.AsT1.Position;
		}
		return ((vector != null) ? vector.ToString() : null) ?? string.Empty;
	}

	// Token: 0x060188ED RID: 100589 RVA: 0x00772C90 File Offset: 0x00770E90
	private void CheckStopMontage()
	{
		Entity entity = this.Entity;
		CharacterAnimationComponent characterAnimationComponent = (entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent != null)
		{
			characterAnimationComponent.MontageManager.StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0.5f)
			});
		}
	}

	// Token: 0x060188EE RID: 100590 RVA: 0x00772CE0 File Offset: 0x00770EE0
	private static bool GetNavigateMoveToLocationQueue(CharacterActorComponent actor, global::Vector start, global::Vector target, Queue<global::Vector> queue, double minDistance)
	{
		queue.Clear();
		MoveToLocationController.CacheMovePath.Clear();
		global::Vector actorLocationProxy = actor.ActorLocationProxy;
		if (!AiControllerLibrary.NavigationFindPath(actor.Owner.GetWorld(), start.ToUeVector(false), target.ToUeVector(false), MoveToLocationController.CacheMovePath, new bool?(true), new bool?(true)) || MoveToLocationController.CacheMovePath.Count == 0)
		{
			return false;
		}
		if (MoveToLocationController.CacheMovePath.Count > 0)
		{
			if (global::Vector.Dist2D(MoveToLocationController.CacheMovePath[0], actorLocationProxy) > minDistance)
			{
				queue.Push(MoveToLocationController.CacheMovePath[0]);
			}
			for (int i = 1; i < MoveToLocationController.CacheMovePath.Count; i++)
			{
				queue.Push(MoveToLocationController.CacheMovePath[i]);
			}
		}
		return true;
	}

	// Token: 0x060188EF RID: 100591 RVA: 0x00772DA0 File Offset: 0x00770FA0
	public static void CreateStaticDefaultValue()
	{
		MoveToLocationController.IS_WITH_EDITOR = (KuroApplication.IsWithEditor() ? new int?(1) : null);
		MoveToLocationController.CacheMovePath = new List<global::Vector>();
		MoveToLocationController.CacheVector = global::Vector.Create();
	}

	// Token: 0x060188F0 RID: 100592 RVA: 0x00772DDE File Offset: 0x00770FDE
	public static void ResetStaticDefaultValue()
	{
		MoveToLocationController.IS_WITH_EDITOR = null;
		MoveToLocationController.DebugDraw = false;
		MoveToLocationController.CacheMovePath = null;
		MoveToLocationController.CacheVector = null;
	}

	// Token: 0x0400D4D7 RID: 54487
	private static int? IS_WITH_EDITOR;

	// Token: 0x0400D4D8 RID: 54488
	private const int ASYNC_INTERVAL = 5;

	// Token: 0x0400D4D9 RID: 54489
	private const float ASYNC_RATIO = 0.01f;

	// Token: 0x0400D4DA RID: 54490
	private const float ASYNC_MIN_INTERVAL = 0.25f;

	// Token: 0x0400D4DB RID: 54491
	public static bool DebugDraw;

	// Token: 0x0400D4DC RID: 54492
	private readonly Queue<global::Vector> CacheQueue = new Queue<global::Vector>(4);

	// Token: 0x0400D4DD RID: 54493
	[Nullable(2)]
	private MoveToLocation MoveToLocationLogicInternal;

	// Token: 0x0400D4DE RID: 54494
	[Nullable(2)]
	private BaseMoveCharacter MoveAlongPathLogicInternal;

	// Token: 0x0400D4DF RID: 54495
	[Nullable(2)]
	private KeepFollowingMoveLogic KeepFollowingMoveLogicInternal;

	// Token: 0x0400D4E0 RID: 54496
	[Nullable(2)]
	private AttachMoveLogic AttachMoveLogicInternal;

	// Token: 0x0400D4E1 RID: 54497
	[Nullable(2)]
	private readonly Entity Entity;

	// Token: 0x0400D4E2 RID: 54498
	[Nullable(2)]
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400D4E3 RID: 54499
	[Nullable(2)]
	private readonly BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D4E4 RID: 54500
	private int LastMoveHandleId;

	// Token: 0x0400D4E5 RID: 54501
	private int CurrentMoveHandleId;

	// Token: 0x0400D4E6 RID: 54502
	private MoveToLocationController.EMoveHandleKind CurrentMoveKind;

	// Token: 0x0400D4E7 RID: 54503
	private static global::Vector CacheVector;

	// Token: 0x0400D4E8 RID: 54504
	private bool AutoSyncEnabled;

	// Token: 0x0400D4E9 RID: 54505
	private int AutoSyncInterval = 5;

	// Token: 0x0400D4EA RID: 54506
	private float AutoSyncRatio = 0.01f;

	// Token: 0x0400D4EB RID: 54507
	private float AutoSyncTimer;

	// Token: 0x0400D4EC RID: 54508
	private readonly global::Vector AutoSyncLastLocation = global::Vector.Create();

	// Token: 0x0400D4ED RID: 54509
	private bool AutoSyncLastLocationValid;

	// Token: 0x0400D4EE RID: 54510
	private static List<global::Vector> CacheMovePath;

	// Token: 0x020088AE RID: 34990
	[NullableContext(0)]
	private enum EMoveHandleKind
	{
		// Token: 0x0402BABF RID: 178879
		None,
		// Token: 0x0402BAC0 RID: 178880
		MoveAlongPath,
		// Token: 0x0402BAC1 RID: 178881
		MoveToLocation,
		// Token: 0x0402BAC2 RID: 178882
		NavigateMoveToLocation,
		// Token: 0x0402BAC3 RID: 178883
		KeepFollowing,
		// Token: 0x0402BAC4 RID: 178884
		KeepFollowingSpline,
		// Token: 0x0402BAC5 RID: 178885
		AttachMove
	}
}
