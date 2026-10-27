using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Core.Common;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using CSharpScript.Game.Utils;
using CSharpScript.Typing;
using UnrealEngine.Extension;

// Token: 0x02003100 RID: 12544
[NullableContext(1)]
[Nullable(0)]
public class MoveToLocationController : IStaticVariableResetter
{
	// Token: 0x0601AE8A RID: 110218 RVA: 0x0074BDB6 File Offset: 0x00749FB6
	static MoveToLocationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoveToLocationController.CreateStaticDefaultValue), new Action(MoveToLocationController.ResetStaticDefaultValue));
	}

	// Token: 0x0601AE8B RID: 110219 RVA: 0x0074BDD8 File Offset: 0x00749FD8
	public MoveToLocationController(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.StateComp = entity.GetComponent<BaseUnifiedStateComponent>();
	}

	// Token: 0x17002518 RID: 9496
	// (get) Token: 0x0601AE8C RID: 110220 RVA: 0x0074BE33 File Offset: 0x0074A033
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

	// Token: 0x17002519 RID: 9497
	// (get) Token: 0x0601AE8D RID: 110221 RVA: 0x0074BE64 File Offset: 0x0074A064
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

	// Token: 0x1700251A RID: 9498
	// (get) Token: 0x0601AE8E RID: 110222 RVA: 0x0074BE95 File Offset: 0x0074A095
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

	// Token: 0x0601AE8F RID: 110223 RVA: 0x0074BEC8 File Offset: 0x0074A0C8
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

	// Token: 0x0601AE90 RID: 110224 RVA: 0x0074BF68 File Offset: 0x0074A168
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

	// Token: 0x0601AE91 RID: 110225 RVA: 0x0074BFC4 File Offset: 0x0074A1C4
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

	// Token: 0x0601AE92 RID: 110226 RVA: 0x0074C054 File Offset: 0x0074A254
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

	// Token: 0x0601AE93 RID: 110227 RVA: 0x0074C0E0 File Offset: 0x0074A2E0
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

	// Token: 0x0601AE94 RID: 110228 RVA: 0x0074C144 File Offset: 0x0074A344
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

	// Token: 0x0601AE95 RID: 110229 RVA: 0x0074C192 File Offset: 0x0074A392
	public void EnableAutoSync(int interval = 5, float ratio = 0.01f)
	{
		this.AutoSyncEnabled = true;
		this.AutoSyncInterval = interval;
		this.AutoSyncRatio = ratio;
		this.AutoSyncTimer = (float)interval;
		this.AutoSyncLastLocationValid = false;
	}

	// Token: 0x0601AE96 RID: 110230 RVA: 0x0074C1B8 File Offset: 0x0074A3B8
	public void DisableAutoSync()
	{
		this.AutoSyncEnabled = false;
		this.AutoSyncTimer = 0f;
		this.AutoSyncLastLocationValid = false;
	}

	// Token: 0x0601AE97 RID: 110231 RVA: 0x0074C1D4 File Offset: 0x0074A3D4
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

	// Token: 0x0601AE98 RID: 110232 RVA: 0x0074C2A1 File Offset: 0x0074A4A1
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

	// Token: 0x0601AE99 RID: 110233 RVA: 0x0074C2CC File Offset: 0x0074A4CC
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

	// Token: 0x0601AE9A RID: 110234 RVA: 0x0074C3E0 File Offset: 0x0074A5E0
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
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"scene_id",
					CreatureModel.Instance.GetSceneId()
				},
				{
					"instance_id",
					CreatureModel.Instance.GetInstanceId()
				},
				{
					"msg_id",
					24756
				},
				{
					"immediately",
					true
				},
				{
					"sub_count",
					movePackagePush.MovingEntities.Count
				},
				{
					"is_multi",
					GameModeModel.Instance.IsMulti
				},
				{
					"ed",
					MoveToLocationController.IS_WITH_EDITOR
				},
				{
					"br",
					LogAnalyzer.Instance.GetBranch()
				}
			}, null);
			CombatDebugController.Instance.DataReport("COMBAT_MESSAGE_COUNT", data);
		}
	}

	// Token: 0x0601AE9B RID: 110235 RVA: 0x0074C59E File Offset: 0x0074A79E
	public void GetFollowingPosition(global::Vector out_, CharacterActorComponent leader)
	{
		KeepFollowingMoveLogic keepFollowingMoveLogic = this.KeepFollowingMoveLogic;
		if (keepFollowingMoveLogic == null)
		{
			return;
		}
		keepFollowingMoveLogic.GetTargetFollowingPosition(out_, leader);
	}

	// Token: 0x0601AE9C RID: 110236 RVA: 0x0074C5B3 File Offset: 0x0074A7B3
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

	// Token: 0x0601AE9D RID: 110237 RVA: 0x0074C5F0 File Offset: 0x0074A7F0
	public int GetCurrentMoveHandleId()
	{
		return this.CurrentMoveHandleId;
	}

	// Token: 0x0601AE9E RID: 110238 RVA: 0x0074C5F8 File Offset: 0x0074A7F8
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

	// Token: 0x0601AE9F RID: 110239 RVA: 0x0074C613 File Offset: 0x0074A813
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

	// Token: 0x0601AEA0 RID: 110240 RVA: 0x0074C62C File Offset: 0x0074A82C
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

	// Token: 0x0601AEA1 RID: 110241 RVA: 0x0074C64A File Offset: 0x0074A84A
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

	// Token: 0x0601AEA2 RID: 110242 RVA: 0x0074C668 File Offset: 0x0074A868
	public int StartSplineKeepFollowingWithDataAssetPath(CharacterActorComponent leader, string daPath, SplineDistanceParams param, [Nullable(2)] Action<ELevelEventState> onFinish = null)
	{
		int result = this.CreateMoveHandle(MoveToLocationController.EMoveHandleKind.KeepFollowingSpline, null);
		this.KeepFollowingMoveLogic.StartKeepFollowingWithDataAssetPath(leader, daPath, null, false, onFinish, null);
		this.KeepFollowingMoveLogic.SetSplineDistanceParam(param);
		return result;
	}

	// Token: 0x0601AEA3 RID: 110243 RVA: 0x0074C6AB File Offset: 0x0074A8AB
	public void StopKeepHoldingHands()
	{
		this.KeepFollowingMoveLogic.StopMove();
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.KeepFollowing || this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.KeepFollowingSpline)
		{
			this.ClearCurrentMoveHandle("StopKeepHoldingHands");
		}
	}

	// Token: 0x0601AEA4 RID: 110244 RVA: 0x0074C6D5 File Offset: 0x0074A8D5
	public bool IsAttachMoving()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		return attachMoveLogicInternal != null && attachMoveLogicInternal.IsMoving();
	}

	// Token: 0x0601AEA5 RID: 110245 RVA: 0x0074C6E8 File Offset: 0x0074A8E8
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

	// Token: 0x0601AEA6 RID: 110246 RVA: 0x0074C740 File Offset: 0x0074A940
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

	// Token: 0x0601AEA7 RID: 110247 RVA: 0x0074C76E File Offset: 0x0074A96E
	public void StartAssistedWalk()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.StartAssistedWalk();
	}

	// Token: 0x0601AEA8 RID: 110248 RVA: 0x0074C780 File Offset: 0x0074A980
	public void EnterAssistedWalkIdle()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.EnterAssistedWalkIdle();
	}

	// Token: 0x0601AEA9 RID: 110249 RVA: 0x0074C792 File Offset: 0x0074A992
	public void EnterAssistedWalking()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.EnterAssistedWalking();
	}

	// Token: 0x0601AEAA RID: 110250 RVA: 0x0074C7A4 File Offset: 0x0074A9A4
	public void LeftAssistedWalking()
	{
		AttachMoveLogic attachMoveLogicInternal = this.AttachMoveLogicInternal;
		if (attachMoveLogicInternal == null)
		{
			return;
		}
		attachMoveLogicInternal.LeftAssistedWalking();
	}

	// Token: 0x0601AEAB RID: 110251 RVA: 0x0074C7B8 File Offset: 0x0074A9B8
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

	// Token: 0x0601AEAC RID: 110252 RVA: 0x0074C810 File Offset: 0x0074AA10
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

	// Token: 0x0601AEAD RID: 110253 RVA: 0x0074C865 File Offset: 0x0074AA65
	public void StopAssistedWalk()
	{
		this.StopAttachMove();
	}

	// Token: 0x0601AEAE RID: 110254 RVA: 0x0074C870 File Offset: 0x0074AA70
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

	// Token: 0x0601AEAF RID: 110255 RVA: 0x0074C951 File Offset: 0x0074AB51
	public bool IsMovingAlongPath()
	{
		BaseMoveCharacter moveAlongPathLogic = this.MoveAlongPathLogic;
		return moveAlongPathLogic != null && moveAlongPathLogic.IsRunning;
	}

	// Token: 0x0601AEB0 RID: 110256 RVA: 0x0074C964 File Offset: 0x0074AB64
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

	// Token: 0x0601AEB1 RID: 110257 RVA: 0x0074C98B File Offset: 0x0074AB8B
	public bool IsMovingToLocation()
	{
		MoveToLocation moveToLocationLogic = this.MoveToLocationLogic;
		return ((moveToLocationLogic != null) ? moveToLocationLogic.GetCurrentMoveToLocation() : null) != null;
	}

	// Token: 0x0601AEB2 RID: 110258 RVA: 0x0074C9A2 File Offset: 0x0074ABA2
	[NullableContext(2)]
	public void StopMoveToLocation(string context = null)
	{
		this.MoveToLocationLogic.StopMove(context);
		if (this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.MoveToLocation || this.CurrentMoveKind == MoveToLocationController.EMoveHandleKind.NavigateMoveToLocation)
		{
			this.ClearCurrentMoveHandle(context);
		}
	}

	// Token: 0x0601AEB3 RID: 110259 RVA: 0x0074C9C9 File Offset: 0x0074ABC9
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

	// Token: 0x0601AEB4 RID: 110260 RVA: 0x0074C9E7 File Offset: 0x0074ABE7
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

	// Token: 0x0601AEB5 RID: 110261 RVA: 0x0074CA10 File Offset: 0x0074AC10
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

	// Token: 0x0601AEB6 RID: 110262 RVA: 0x0074CAF4 File Offset: 0x0074ACF4
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

	// Token: 0x0601AEB7 RID: 110263 RVA: 0x0074CC90 File Offset: 0x0074AE90
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

	// Token: 0x0601AEB8 RID: 110264 RVA: 0x0074CD58 File Offset: 0x0074AF58
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

	// Token: 0x0601AEB9 RID: 110265 RVA: 0x0074CDB8 File Offset: 0x0074AFB8
	private string GetPointsDebugText([Nullable(2)] object points)
	{
		if (points == null)
		{
			return string.Empty;
		}
		IList list = points as IList;
		if (list == null)
		{
			return this.GetPointPositionDebugText(points);
		}
		if (list.Count <= 0)
		{
			return string.Empty;
		}
		return this.GetPointPositionDebugText(list[list.Count - 1]);
	}

	// Token: 0x0601AEBA RID: 110266 RVA: 0x0074CE04 File Offset: 0x0074B004
	private string GetPointPositionDebugText([Nullable(2)] object point)
	{
		if (point == null)
		{
			return string.Empty;
		}
		PropertyInfo property = point.GetType().GetProperty("Position");
		global::Vector vector = ((property != null) ? property.GetValue(point) : null) as global::Vector;
		return ((vector != null) ? vector.ToString() : null) ?? string.Empty;
	}

	// Token: 0x0601AEBB RID: 110267 RVA: 0x0074CE54 File Offset: 0x0074B054
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

	// Token: 0x0601AEBC RID: 110268 RVA: 0x0074CEA4 File Offset: 0x0074B0A4
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

	// Token: 0x0601AEBD RID: 110269 RVA: 0x0074CF64 File Offset: 0x0074B164
	public static void CreateStaticDefaultValue()
	{
		MoveToLocationController.IS_WITH_EDITOR = (KuroApplication.IsWithEditor() ? new int?(1) : null);
		MoveToLocationController.CacheMovePath = new List<global::Vector>();
		MoveToLocationController.CacheVector = global::Vector.Create();
	}

	// Token: 0x0601AEBE RID: 110270 RVA: 0x0074CFA2 File Offset: 0x0074B1A2
	public static void ResetStaticDefaultValue()
	{
		MoveToLocationController.IS_WITH_EDITOR = null;
		MoveToLocationController.DebugDraw = false;
		MoveToLocationController.CacheMovePath = null;
		MoveToLocationController.CacheVector = null;
	}

	// Token: 0x0400D0C9 RID: 53449
	private static int? IS_WITH_EDITOR;

	// Token: 0x0400D0CA RID: 53450
	private const int ASYNC_INTERVAL = 5;

	// Token: 0x0400D0CB RID: 53451
	private const float ASYNC_RATIO = 0.01f;

	// Token: 0x0400D0CC RID: 53452
	private const float ASYNC_MIN_INTERVAL = 0.25f;

	// Token: 0x0400D0CD RID: 53453
	public static bool DebugDraw;

	// Token: 0x0400D0CE RID: 53454
	private readonly Queue<global::Vector> CacheQueue = new Queue<global::Vector>(4);

	// Token: 0x0400D0CF RID: 53455
	[Nullable(2)]
	private MoveToLocation MoveToLocationLogicInternal;

	// Token: 0x0400D0D0 RID: 53456
	[Nullable(2)]
	private BaseMoveCharacter MoveAlongPathLogicInternal;

	// Token: 0x0400D0D1 RID: 53457
	[Nullable(2)]
	private KeepFollowingMoveLogic KeepFollowingMoveLogicInternal;

	// Token: 0x0400D0D2 RID: 53458
	[Nullable(2)]
	private AttachMoveLogic AttachMoveLogicInternal;

	// Token: 0x0400D0D3 RID: 53459
	[Nullable(2)]
	private readonly Entity Entity;

	// Token: 0x0400D0D4 RID: 53460
	[Nullable(2)]
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400D0D5 RID: 53461
	[Nullable(2)]
	private readonly BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D0D6 RID: 53462
	private int LastMoveHandleId;

	// Token: 0x0400D0D7 RID: 53463
	private int CurrentMoveHandleId;

	// Token: 0x0400D0D8 RID: 53464
	private MoveToLocationController.EMoveHandleKind CurrentMoveKind;

	// Token: 0x0400D0D9 RID: 53465
	private static global::Vector CacheVector;

	// Token: 0x0400D0DA RID: 53466
	private bool AutoSyncEnabled;

	// Token: 0x0400D0DB RID: 53467
	private int AutoSyncInterval = 5;

	// Token: 0x0400D0DC RID: 53468
	private float AutoSyncRatio = 0.01f;

	// Token: 0x0400D0DD RID: 53469
	private float AutoSyncTimer;

	// Token: 0x0400D0DE RID: 53470
	private readonly global::Vector AutoSyncLastLocation = global::Vector.Create();

	// Token: 0x0400D0DF RID: 53471
	private bool AutoSyncLastLocationValid;

	// Token: 0x0400D0E0 RID: 53472
	private static List<global::Vector> CacheMovePath;

	// Token: 0x0200968C RID: 38540
	[NullableContext(0)]
	private enum EMoveHandleKind
	{
		// Token: 0x04030431 RID: 197681
		None,
		// Token: 0x04030432 RID: 197682
		MoveAlongPath,
		// Token: 0x04030433 RID: 197683
		MoveToLocation,
		// Token: 0x04030434 RID: 197684
		NavigateMoveToLocation,
		// Token: 0x04030435 RID: 197685
		KeepFollowing,
		// Token: 0x04030436 RID: 197686
		KeepFollowingSpline,
		// Token: 0x04030437 RID: 197687
		AttachMove
	}
}
