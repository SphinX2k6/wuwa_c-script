using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020025A4 RID: 9636
[NullableContext(2)]
[Nullable(0)]
public class CharacterAttachComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06017DF6 RID: 97782 RVA: 0x00719758 File Offset: 0x00717958
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

	// Token: 0x06017DF7 RID: 97783 RVA: 0x00719804 File Offset: 0x00717A04
	protected override void OnActivate()
	{
		this.InitAttachToTarget();
		this.InitAttachToThis();
	}

	// Token: 0x06017DF8 RID: 97784 RVA: 0x00719814 File Offset: 0x00717A14
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

	// Token: 0x06017DF9 RID: 97785 RVA: 0x007199A0 File Offset: 0x00717BA0
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

	// Token: 0x06017DFA RID: 97786 RVA: 0x00719B44 File Offset: 0x00717D44
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

	// Token: 0x06017DFB RID: 97787 RVA: 0x00719C74 File Offset: 0x00717E74
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

	// Token: 0x06017DFC RID: 97788 RVA: 0x00719D8C File Offset: 0x00717F8C
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

	// Token: 0x06017DFD RID: 97789 RVA: 0x00719E98 File Offset: 0x00718098
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

	// Token: 0x06017DFE RID: 97790 RVA: 0x00719F14 File Offset: 0x00718114
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

	// Token: 0x06017DFF RID: 97791 RVA: 0x00719F74 File Offset: 0x00718174
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

	// Token: 0x06017E00 RID: 97792 RVA: 0x00719FD2 File Offset: 0x007181D2
	private void AddFollower(EntityHandle follower)
	{
		if (follower == null || !follower.Valid || this.FollowerList.Contains(follower))
		{
			return;
		}
		this.FollowerList.Add(follower);
	}

	// Token: 0x06017E01 RID: 97793 RVA: 0x0071A000 File Offset: 0x00718200
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

	// Token: 0x06017E02 RID: 97794 RVA: 0x0071A03D File Offset: 0x0071823D
	public bool HasFollower(EntityHandle follower)
	{
		return this.CheckValid() && (follower != null && follower.Valid) && this.FollowerList.Contains(follower);
	}

	// Token: 0x06017E03 RID: 97795 RVA: 0x0071A068 File Offset: 0x00718268
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

	// Token: 0x06017E04 RID: 97796 RVA: 0x0071A0E6 File Offset: 0x007182E6
	private bool CheckValid()
	{
		return this.Initial;
	}

	// Token: 0x06017E05 RID: 97797 RVA: 0x0071A0F0 File Offset: 0x007182F0
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

	// Token: 0x06017E06 RID: 97798 RVA: 0x0071A20C File Offset: 0x0071840C
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

	// Token: 0x06017E07 RID: 97799 RVA: 0x0071A36C File Offset: 0x0071856C
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

	// Token: 0x06017E08 RID: 97800 RVA: 0x0071A3FC File Offset: 0x007185FC
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

	// Token: 0x06017E09 RID: 97801 RVA: 0x0071A444 File Offset: 0x00718644
	public void SetEnableDebugLog(bool isShowDebugLog)
	{
		CharacterAttachComponent.IsShowDebugLog = isShowDebugLog;
	}

	// Token: 0x06017E0A RID: 97802 RVA: 0x0071A44C File Offset: 0x0071864C
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

	// Token: 0x06017E0B RID: 97803 RVA: 0x0071A580 File Offset: 0x00718780
	private void OnEntityDead()
	{
		this.DetachFromHost(true, false, false, null);
	}

	// Token: 0x06017E0C RID: 97804 RVA: 0x0071A5A0 File Offset: 0x007187A0
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

	// Token: 0x06017E0D RID: 97805 RVA: 0x0071A5FE File Offset: 0x007187FE
	static CharacterAttachComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterAttachComponent.CreateStaticDefaultValue), new Action(CharacterAttachComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06017E0E RID: 97806 RVA: 0x0071A61D File Offset: 0x0071881D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017E0F RID: 97807 RVA: 0x0071A61F File Offset: 0x0071881F
	public static void ResetStaticDefaultValue()
	{
		CharacterAttachComponent.IsShowDebugLog = false;
	}

	// Token: 0x06017E10 RID: 97808 RVA: 0x0071A628 File Offset: 0x00718828
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAttachComponent characterAttachComponent = (CharacterAttachComponent)componentTemplate;
		if (characterAttachComponent.AttachTargetHandle == null)
		{
			this.AttachTargetHandle = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttachTargetHandle), "AttachTargetHandle"))
		{
			return false;
		}
		this.AttachTag = characterAttachComponent.AttachTag;
		this.AttachPartInfoIndex = characterAttachComponent.AttachPartInfoIndex;
		this.AttachSocketName = characterAttachComponent.AttachSocketName;
		if (characterAttachComponent.AttachSocketOffset != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttachSocketOffset), "AttachSocketOffset"))
		{
			return false;
		}
		this.AttachState = characterAttachComponent.AttachState;
		if (characterAttachComponent.CreatureDataComp == null)
		{
			this.CreatureDataComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
		{
			return false;
		}
		if (characterAttachComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterAttachComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterAttachComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.MoveCompDisableHandle = characterAttachComponent.MoveCompDisableHandle;
		if (characterAttachComponent.FollowerList == null)
		{
			this.FollowerList = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FollowerList), "FollowerList"))
		{
			return false;
		}
		this.Initial = characterAttachComponent.Initial;
		return true;
	}

	// Token: 0x1700253A RID: 9530
	// (get) Token: 0x06017E11 RID: 97809 RVA: 0x0071A7B4 File Offset: 0x007189B4
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700253B RID: 9531
	// (get) Token: 0x06017E12 RID: 97810 RVA: 0x0071A7B7 File Offset: 0x007189B7
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700253C RID: 9532
	// (get) Token: 0x06017E13 RID: 97811 RVA: 0x0071A7BA File Offset: 0x007189BA
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CC25 RID: 52261
	private static bool IsShowDebugLog;

	// Token: 0x0400CC26 RID: 52262
	private EntityHandle AttachTargetHandle;

	// Token: 0x0400CC27 RID: 52263
	private FGameplayTag? AttachTag;

	// Token: 0x0400CC28 RID: 52264
	private int AttachPartInfoIndex;

	// Token: 0x0400CC29 RID: 52265
	private FName AttachSocketName = FName.NAME_None;

	// Token: 0x0400CC2A RID: 52266
	[Nullable(1)]
	private readonly global::Vector AttachSocketOffset = global::Vector.Create();

	// Token: 0x0400CC2B RID: 52267
	private EAttachState AttachState = EAttachState.Detach;

	// Token: 0x0400CC2C RID: 52268
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400CC2D RID: 52269
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CC2E RID: 52270
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CC2F RID: 52271
	private BaseTagComponent TagComp;

	// Token: 0x0400CC30 RID: 52272
	private int? MoveCompDisableHandle;

	// Token: 0x0400CC31 RID: 52273
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<EntityHandle> FollowerList;

	// Token: 0x0400CC32 RID: 52274
	private bool Initial;
}
