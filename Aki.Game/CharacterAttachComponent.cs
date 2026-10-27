using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200304E RID: 12366
[NullableContext(2)]
[Nullable(0)]
public class CharacterAttachComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601A46A RID: 107626 RVA: 0x006F2438 File Offset: 0x006F0638
	protected override bool OnStart()
	{
		this.FollowerList = new List<EntityHandle>();
		this.AttachTag = null;
		this.AttachTargetHandle = null;
		this.AttachState = EAttachState.Detach;
		this.MoveCompDisableHandle = null;
		this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.Initial = true;
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnEntityDead));
		return true;
	}

	// Token: 0x0601A46B RID: 107627 RVA: 0x006F24E4 File Offset: 0x006F06E4
	protected override void OnActivate()
	{
		this.InitAttachToTarget();
		this.InitAttachToThis();
	}

	// Token: 0x0601A46C RID: 107628 RVA: 0x006F24F4 File Offset: 0x006F06F4
	private void InitAttachToTarget()
	{
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		if (creatureDataComp == null || !creatureDataComp.Valid || this.CreatureDataComp.PbCombineTargetServerId == null)
		{
			return;
		}
		long value = this.CreatureDataComp.PbCombineTargetServerId.Value;
		int entityId = CreatureModel.Instance.GetEntityId(value);
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid || component.HasFollower(CharacterModel.Instance.GetHandleByEntity(base.Entity)))
		{
			return;
		}
		CombinePartInfo followerAttachInfo = component.GetFollowerAttachInfo(value);
		if (followerAttachInfo == null)
		{
			return;
		}
		CharacterPartComponent component2 = handleByEntity.Entity.GetComponent<CharacterPartComponent>();
		if (component2 == null || !component2.Valid)
		{
			return;
		}
		CharacterPart partByIndex = component2.GetPartByIndex(followerAttachInfo.PartId);
		if (partByIndex == null || FNameUtil.IsNothing(partByIndex.CombinePartSocketName))
		{
			return;
		}
		Aki.Protocol.Vector offsetPos = followerAttachInfo.OffsetPos;
		float inX = (offsetPos != null) ? offsetPos.X : 0f;
		Aki.Protocol.Vector offsetPos2 = followerAttachInfo.OffsetPos;
		float inY = (offsetPos2 != null) ? offsetPos2.Y : 0f;
		Aki.Protocol.Vector offsetPos3 = followerAttachInfo.OffsetPos;
		FVector socketOffset = new FVector(inX, inY, (offsetPos3 != null) ? offsetPos3.Z : 0f);
		this.StartAttachToTarget(handleByEntity, partByIndex.CombinePartSocketName.Value, socketOffset, followerAttachInfo.PartId, null);
		this.AttachToTarget(handleByEntity, null, false);
	}

	// Token: 0x0601A46D RID: 107629 RVA: 0x006F2680 File Offset: 0x006F0880
	private void InitAttachToThis()
	{
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		if (creatureDataComp == null || !creatureDataComp.Valid || this.CreatureDataComp.PbCombinePartInfoList == null)
		{
			return;
		}
		List<CombinePartInfo> pbCombinePartInfoList = this.CreatureDataComp.PbCombinePartInfoList;
		if (pbCombinePartInfoList == null)
		{
			return;
		}
		int i = 0;
		int count = pbCombinePartInfoList.Count;
		while (i < count)
		{
			CombinePartInfo combinePartInfo = pbCombinePartInfoList[i];
			int entityId = CreatureModel.Instance.GetEntityId(combinePartInfo.CombinerEntityId);
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity != null && entity.Valid)
			{
				EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
				CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
				if (component != null && component.Valid && !this.HasFollower(CharacterModel.Instance.GetHandleByEntity(entity)))
				{
					CharacterPartComponent component2 = entity.GetComponent<CharacterPartComponent>();
					if (component2 == null || !component2.Valid)
					{
						return;
					}
					CharacterPart partByIndex = component2.GetPartByIndex(combinePartInfo.PartId);
					if (partByIndex == null || FNameUtil.IsNothing(partByIndex.CombinePartSocketName))
					{
						return;
					}
					Aki.Protocol.Vector offsetPos = combinePartInfo.OffsetPos;
					float inX = (offsetPos != null) ? offsetPos.X : 0f;
					Aki.Protocol.Vector offsetPos2 = combinePartInfo.OffsetPos;
					float inY = (offsetPos2 != null) ? offsetPos2.Y : 0f;
					Aki.Protocol.Vector offsetPos3 = combinePartInfo.OffsetPos;
					FVector socketOffset = new FVector(inX, inY, (offsetPos3 != null) ? offsetPos3.Z : 0f);
					component.StartAttachToTarget(handleByEntity, partByIndex.CombinePartSocketName.Value, socketOffset, combinePartInfo.PartId, null);
					component.AttachToTarget(handleByEntity, null, false);
				}
			}
			i++;
		}
	}

	// Token: 0x0601A46E RID: 107630 RVA: 0x006F2824 File Offset: 0x006F0A24
	[NullableContext(1)]
	public void StartAttachToTarget(EntityHandle targetHandle, FName socketName, FVector socketOffset, int partInfoIndex, FGameplayTag? tag)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		if (!this.CheckValid())
		{
			return;
		}
		this.DetachFromHost(false, false, true, null);
		WorldEntity entity = targetHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return;
		}
		this.AttachTargetHandle = targetHandle;
		this.AttachTag = tag;
		this.AttachPartInfoIndex = partInfoIndex;
		this.AttachSocketName = socketName;
		global::Vector attachSocketOffset = this.AttachSocketOffset;
		FVectorDouble fvectorDouble = socketOffset;
		attachSocketOffset.DeepCopy(fvectorDouble);
		this.AttachState = EAttachState.Attaching;
		CharacterMoveComponent moveComp = this.MoveComp;
		this.MoveCompDisableHandle = ((moveComp != null) ? new int?(moveComp.Disable("CharacterAttachComponent Disable")) : null);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_None,
				Context = "[CharacterAttachComponent.StartAttachToTarget]"
			});
			this.ActorComp.Actor.CapsuleComponent.IgnoreActorWhenMoving(characterActorComponent.Actor, true);
			characterActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(this.ActorComp.Actor, true);
		}
		bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
	}

	// Token: 0x0601A46F RID: 107631 RVA: 0x006F2954 File Offset: 0x006F0B54
	[NullableContext(1)]
	public void AttachToTarget(EntityHandle targetHandle, long? preMessageId, bool isSendToServer)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		if (!this.CheckValid())
		{
			return;
		}
		WorldEntity entity = targetHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent == null || !characterActorComponent.Valid || characterActorComponent.SkeletalMesh == null)
		{
			return;
		}
		if (this.AttachState != EAttachState.Attaching || this.AttachTargetHandle != targetHandle)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LJM, "Attach到目标失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null && tagComp.Valid)
			{
				this.ActorComp.Owner.K2_AttachToComponent(characterActorComponent.SkeletalMesh, this.AttachSocketName, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
				if (this.AttachTag != null)
				{
					this.TagComp.AddTag(new int?(this.AttachTag.Value.TagId()));
				}
				this.AttachState = EAttachState.Attach;
				this.AttachToHost();
				if (isSendToServer)
				{
					this.ExecuteCombineEntitiesRequest(preMessageId.Value);
				}
				bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
				return;
			}
		}
	}

	// Token: 0x0601A470 RID: 107632 RVA: 0x006F2A6C File Offset: 0x006F0C6C
	public void DetachFromHost(bool isDetachFollower, bool isRecursion, bool isNotifyServer, long? preMessageId = null)
	{
		if (!this.CheckValid())
		{
			return;
		}
		if (this.AttachState == EAttachState.Attach)
		{
			bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Owner.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			}
			EntityHandle attachTargetHandle = this.AttachTargetHandle;
			CharacterActorComponent characterActorComponent;
			if (attachTargetHandle == null)
			{
				characterActorComponent = null;
			}
			else
			{
				WorldEntity entity = attachTargetHandle.Entity;
				characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
			}
			CharacterActorComponent characterActorComponent2 = characterActorComponent;
			if (characterActorComponent2 != null && characterActorComponent2.Valid)
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					AActor owner = actorComp2.Owner;
					if (owner != null)
					{
						owner.K2_SetActorRotation(characterActorComponent2.ActorRotation, true);
					}
				}
			}
			else
			{
				CharacterActorComponent actorComp3 = this.ActorComp;
				if (actorComp3 != null)
				{
					AActor owner2 = actorComp3.Owner;
					if (owner2 != null)
					{
						FRotator newRotation = new FRotator();
						CharacterActorComponent actorComp4 = this.ActorComp;
						newRotation.Yaw = ((actorComp4 != null) ? actorComp4.ActorRotationProxy.Yaw : 0f);
						owner2.K2_SetActorRotation(newRotation, true);
					}
				}
			}
			if (isNotifyServer)
			{
				this.ExecuteDissolveCombineRelationRequest(preMessageId);
			}
			bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
		}
		if (isDetachFollower)
		{
			this.DetachFollower(isRecursion, isNotifyServer, null);
		}
		this.ClearAttachState();
		this.RemoveFromHost();
	}

	// Token: 0x0601A471 RID: 107633 RVA: 0x006F2B78 File Offset: 0x006F0D78
	private void DetachFollower(bool isRecursion, bool isNotifyServer, long? preMessageId = null)
	{
		for (int i = this.FollowerList.Count - 1; i >= 0; i--)
		{
			EntityHandle entityHandle = this.FollowerList[i];
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Valid)
			{
				CharacterAttachComponent component = entityHandle.Entity.GetComponent<CharacterAttachComponent>();
				if (component != null && component.Valid)
				{
					component.DetachFromHost(isRecursion, isRecursion, isNotifyServer, preMessageId);
				}
			}
		}
		this.FollowerList.Clear();
	}

	// Token: 0x0601A472 RID: 107634 RVA: 0x006F2BF4 File Offset: 0x006F0DF4
	private void AttachToHost()
	{
		EntityHandle attachTargetHandle = this.AttachTargetHandle;
		if (attachTargetHandle == null || !attachTargetHandle.Valid)
		{
			return;
		}
		CharacterAttachComponent component = this.AttachTargetHandle.Entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.AddFollower(CharacterModel.Instance.GetHandleByEntity(base.Entity));
	}

	// Token: 0x0601A473 RID: 107635 RVA: 0x006F2C54 File Offset: 0x006F0E54
	private void RemoveFromHost()
	{
		EntityHandle attachTargetHandle = this.AttachTargetHandle;
		if (attachTargetHandle == null || !attachTargetHandle.Valid)
		{
			return;
		}
		CharacterAttachComponent component = this.AttachTargetHandle.Entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.RemoveFollower(CharacterModel.Instance.GetHandleByEntity(base.Entity));
	}

	// Token: 0x0601A474 RID: 107636 RVA: 0x006F2CB2 File Offset: 0x006F0EB2
	private void AddFollower(EntityHandle follower)
	{
		if (follower == null || !follower.Valid || this.FollowerList.Contains(follower))
		{
			return;
		}
		this.FollowerList.Add(follower);
	}

	// Token: 0x0601A475 RID: 107637 RVA: 0x006F2CE0 File Offset: 0x006F0EE0
	private void RemoveFollower(EntityHandle follower)
	{
		if (follower == null || !follower.Valid)
		{
			return;
		}
		int num = this.FollowerList.IndexOf(follower);
		if (num < 0)
		{
			return;
		}
		this.FollowerList.RemoveAt(num);
	}

	// Token: 0x0601A476 RID: 107638 RVA: 0x006F2D1D File Offset: 0x006F0F1D
	public bool HasFollower(EntityHandle follower)
	{
		return this.CheckValid() && (follower != null && follower.Valid) && this.FollowerList.Contains(follower);
	}

	// Token: 0x0601A477 RID: 107639 RVA: 0x006F2D48 File Offset: 0x006F0F48
	public CombinePartInfo GetFollowerAttachInfo(long followerServerId)
	{
		if (!this.CheckValid())
		{
			return null;
		}
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		if (creatureDataComp == null || !creatureDataComp.Valid || this.CreatureDataComp.PbCombinePartInfoList == null)
		{
			return null;
		}
		List<CombinePartInfo> pbCombinePartInfoList = this.CreatureDataComp.PbCombinePartInfoList;
		if (pbCombinePartInfoList == null || pbCombinePartInfoList.Count <= 0)
		{
			return null;
		}
		int i = 0;
		int count = pbCombinePartInfoList.Count;
		while (i < count)
		{
			CombinePartInfo combinePartInfo = pbCombinePartInfoList[i];
			if (combinePartInfo.CombinerEntityId != followerServerId)
			{
				return combinePartInfo;
			}
			i++;
		}
		return null;
	}

	// Token: 0x0601A478 RID: 107640 RVA: 0x006F2DC6 File Offset: 0x006F0FC6
	private bool CheckValid()
	{
		return this.Initial;
	}

	// Token: 0x0601A479 RID: 107641 RVA: 0x006F2DD0 File Offset: 0x006F0FD0
	private unsafe void ExecuteCombineEntitiesRequest(long preMessageId)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		CombineEntitiesRequest combineEntitiesRequest = new CombineEntitiesRequest();
		combineEntitiesRequest.CombinePartInfo = new CombinePartInfo
		{
			CombinerEntityId = CreatureModel.Instance.GetCreatureDataId(base.Entity.Id),
			OffsetPos = new Aki.Protocol.Vector
			{
				X = (float)this.AttachSocketOffset.X,
				Y = (float)this.AttachSocketOffset.Y,
				Z = (float)this.AttachSocketOffset.Z
			},
			OffsetRotate = new Aki.Protocol.Rotator
			{
				Pitch = 0f,
				Yaw = 0f,
				Roll = 0f
			},
			PartId = this.AttachPartInfoIndex
		};
		combineEntitiesRequest.TargetEntity = CreatureModel.Instance.GetCreatureDataId(this.AttachTargetHandle.Id);
		CombatNet.Instance.Call(ERequestMessageId.CombineEntitiesRequest, base.Entity, combineEntitiesRequest, delegate(IMessage msg)
		{
			CombineEntitiesResponse combineEntitiesResponse = (CombineEntitiesResponse)msg;
			if (combineEntitiesResponse.ErrorCode != ErrorCode.Success)
			{
				if (CharacterAttachComponent.IsShowDebugLog)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Request;
					Entity entity = base.Entity;
					string message = "执行合体失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ErrorCode", combineEntitiesResponse.ErrorCode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
					string item = "TargetEntityId";
					EntityHandle attachTargetHandle = this.AttachTargetHandle;
					ptr = new ValueTuple<string, object>(item, (attachTargetHandle != null) ? new int?(attachTargetHandle.Id) : null);
					instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				this.DetachFromHost(false, false, false, null);
				return;
			}
			bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
		}, new long?(preMessageId), null, null, null);
	}

	// Token: 0x0601A47A RID: 107642 RVA: 0x006F2EEC File Offset: 0x006F10EC
	[CombatListen(ENotifyMessageId.AddCombineEntitiesRelationNotify, true, false)]
	public static void AddCombineEntitiesRelationNotify(Entity entity, [Nullable(1)] AddCombineEntitiesRelationNotify data, CombatCommon combatCommon = null)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		if (entity == null)
		{
			return;
		}
		CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		CombinePartInfo combinePartInfo = data.CombinePartInfo;
		if (combinePartInfo == null)
		{
			return;
		}
		int entityId = CreatureModel.Instance.GetEntityId(data.TargetEntity);
		Entity entity2 = EntitySystem.Instance.Get(entityId);
		if (entity2 == null || !entity2.Valid)
		{
			Log.Instance.Info(ELogModule.Character, ELogAuthor.LJM, "同步合体失败，因为合体目标非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity2);
		CharacterPartComponent component2 = handleByEntity.Entity.GetComponent<CharacterPartComponent>();
		if (component2 == null || !component2.Valid)
		{
			return;
		}
		CharacterPart partByIndex = component2.GetPartByIndex(combinePartInfo.PartId);
		if (partByIndex == null || FNameUtil.IsNothing(partByIndex.CombinePartSocketName))
		{
			return;
		}
		Aki.Protocol.Vector offsetPos = combinePartInfo.OffsetPos;
		float inX = (offsetPos != null) ? offsetPos.X : 0f;
		Aki.Protocol.Vector offsetPos2 = combinePartInfo.OffsetPos;
		float inY = (offsetPos2 != null) ? offsetPos2.Y : 0f;
		Aki.Protocol.Vector offsetPos3 = combinePartInfo.OffsetPos;
		FVector socketOffset = new FVector(inX, inY, (offsetPos3 != null) ? offsetPos3.Z : 0f);
		component.StartAttachToTarget(handleByEntity, partByIndex.CombinePartSocketName.GetValueOrDefault(), socketOffset, combinePartInfo.PartId, null);
		component.AttachToTarget(handleByEntity, null, false);
		bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
	}

	// Token: 0x0601A47B RID: 107643 RVA: 0x006F304C File Offset: 0x006F124C
	private unsafe void ExecuteDissolveCombineRelationRequest(long? preMessageId)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		DissolveCombineRelationRequest dissolveCombineRelationRequest = new DissolveCombineRelationRequest();
		dissolveCombineRelationRequest.EntityA = CreatureModel.Instance.GetCreatureDataId(base.Entity.Id);
		dissolveCombineRelationRequest.EntityB = CreatureModel.Instance.GetCreatureDataId(this.AttachTargetHandle.Id);
		CombatNet.Instance.Call(ERequestMessageId.DissolveCombineRelationRequest, base.Entity, dissolveCombineRelationRequest, delegate(IMessage msg)
		{
			DissolveCombineRelationResponse dissolveCombineRelationResponse = (DissolveCombineRelationResponse)msg;
			if (dissolveCombineRelationResponse.ErrorCode != ErrorCode.Success)
			{
				bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Request;
				Entity entity = base.Entity;
				string message = "执行解体失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ErrorCode", dissolveCombineRelationResponse.ErrorCode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "TargetEntityId";
				EntityHandle attachTargetHandle = this.AttachTargetHandle;
				ptr = new ValueTuple<string, object>(item, (attachTargetHandle != null) ? new int?(attachTargetHandle.Id) : null);
				instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (CharacterAttachComponent.IsShowDebugLog)
			{
				bool isShowDebugLog3 = CharacterAttachComponent.IsShowDebugLog;
			}
		}, preMessageId, null, null, null);
	}

	// Token: 0x0601A47C RID: 107644 RVA: 0x006F30DC File Offset: 0x006F12DC
	[CombatListen(ENotifyMessageId.RemoveCombineRelationNotify, true, false)]
	public static void RemoveCombineRelationNotify(Entity entity, [Nullable(1)] RemoveCombineRelationNotify data, CombatCommon combatCommon = null)
	{
		bool isShowDebugLog = CharacterAttachComponent.IsShowDebugLog;
		if (entity == null)
		{
			return;
		}
		CharacterAttachComponent component = entity.GetComponent<CharacterAttachComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.DetachFromHost(false, false, false, null);
		bool isShowDebugLog2 = CharacterAttachComponent.IsShowDebugLog;
	}

	// Token: 0x0601A47D RID: 107645 RVA: 0x006F3124 File Offset: 0x006F1324
	public void SetEnableDebugLog(bool isShowDebugLog)
	{
		CharacterAttachComponent.IsShowDebugLog = isShowDebugLog;
	}

	// Token: 0x0601A47E RID: 107646 RVA: 0x006F312C File Offset: 0x006F132C
	private void ClearAttachState()
	{
		if (this.AttachTag != null)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTag(new int?(this.AttachTag.Value.TagId()));
			}
			this.AttachTag = null;
		}
		if (this.MoveCompDisableHandle != null)
		{
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.Enable(new int?(this.MoveCompDisableHandle.Value), "CharacterAttachComponent Enable");
			}
			this.MoveCompDisableHandle = null;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			this.ActorComp.Actor.CharacterMovement.SetDefaultMovementMode();
			EntityHandle attachTargetHandle = this.AttachTargetHandle;
			CharacterActorComponent characterActorComponent;
			if (attachTargetHandle == null)
			{
				characterActorComponent = null;
			}
			else
			{
				WorldEntity entity = attachTargetHandle.Entity;
				characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
			}
			CharacterActorComponent characterActorComponent2 = characterActorComponent;
			if (characterActorComponent2 != null && characterActorComponent2.Valid)
			{
				this.ActorComp.Actor.CapsuleComponent.IgnoreActorWhenMoving(characterActorComponent2.Actor, false);
				characterActorComponent2.Actor.CapsuleComponent.IgnoreActorWhenMoving(this.ActorComp.Actor, false);
			}
		}
		this.AttachTargetHandle = null;
		this.AttachSocketName = null;
		this.AttachState = EAttachState.Detach;
	}

	// Token: 0x0601A47F RID: 107647 RVA: 0x006F3260 File Offset: 0x006F1460
	private void OnEntityDead()
	{
		this.DetachFromHost(true, false, false, null);
	}

	// Token: 0x0601A480 RID: 107648 RVA: 0x006F3280 File Offset: 0x006F1480
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnEntityDead));
		this.DetachFromHost(true, false, false, null);
		this.ActorComp = null;
		this.MoveComp = null;
		this.TagComp = null;
		this.Initial = false;
		return true;
	}

	// Token: 0x0601A481 RID: 107649 RVA: 0x006F32DE File Offset: 0x006F14DE
	static CharacterAttachComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterAttachComponent.CreateStaticDefaultValue), new Action(CharacterAttachComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601A482 RID: 107650 RVA: 0x006F32FD File Offset: 0x006F14FD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A483 RID: 107651 RVA: 0x006F32FF File Offset: 0x006F14FF
	public static void ResetStaticDefaultValue()
	{
		CharacterAttachComponent.IsShowDebugLog = false;
	}

	// Token: 0x0601A484 RID: 107652 RVA: 0x006F3308 File Offset: 0x006F1508
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAttachComponent characterAttachComponent = (CharacterAttachComponent)componentTemplate;
		if (base.CanResetComponentProperty("AttachTargetHandle"))
		{
			if (characterAttachComponent.AttachTargetHandle == null)
			{
				this.AttachTargetHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.AttachTargetHandle), "AttachTargetHandle"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttachTag"))
		{
			this.AttachTag = characterAttachComponent.AttachTag;
		}
		if (base.CanResetComponentProperty("AttachPartInfoIndex"))
		{
			this.AttachPartInfoIndex = characterAttachComponent.AttachPartInfoIndex;
		}
		if (base.CanResetComponentProperty("AttachSocketName"))
		{
			this.AttachSocketName = characterAttachComponent.AttachSocketName;
		}
		if (base.CanResetComponentProperty("AttachSocketOffset") && characterAttachComponent.AttachSocketOffset != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.AttachSocketOffset), "AttachSocketOffset"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AttachState"))
		{
			this.AttachState = characterAttachComponent.AttachState;
		}
		if (base.CanResetComponentProperty("CreatureDataComp"))
		{
			if (characterAttachComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterAttachComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterAttachComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterAttachComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveCompDisableHandle"))
		{
			this.MoveCompDisableHandle = characterAttachComponent.MoveCompDisableHandle;
		}
		if (base.CanResetComponentProperty("FollowerList"))
		{
			if (characterAttachComponent.FollowerList == null)
			{
				this.FollowerList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<EntityHandle>>(this.FollowerList), "FollowerList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Initial"))
		{
			this.Initial = characterAttachComponent.Initial;
		}
		return true;
	}

	// Token: 0x0400C84C RID: 51276
	private static bool IsShowDebugLog;

	// Token: 0x0400C84D RID: 51277
	private EntityHandle AttachTargetHandle;

	// Token: 0x0400C84E RID: 51278
	private FGameplayTag? AttachTag;

	// Token: 0x0400C84F RID: 51279
	private int AttachPartInfoIndex;

	// Token: 0x0400C850 RID: 51280
	private FName AttachSocketName = FName.NAME_None;

	// Token: 0x0400C851 RID: 51281
	[Nullable(1)]
	private readonly global::Vector AttachSocketOffset = global::Vector.Create();

	// Token: 0x0400C852 RID: 51282
	private EAttachState AttachState = EAttachState.Detach;

	// Token: 0x0400C853 RID: 51283
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400C854 RID: 51284
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C855 RID: 51285
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400C856 RID: 51286
	private BaseTagComponent TagComp;

	// Token: 0x0400C857 RID: 51287
	private int? MoveCompDisableHandle;

	// Token: 0x0400C858 RID: 51288
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<EntityHandle> FollowerList;

	// Token: 0x0400C859 RID: 51289
	private bool Initial;
}
