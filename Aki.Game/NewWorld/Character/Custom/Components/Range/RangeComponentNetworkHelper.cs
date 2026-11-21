using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using Google.Protobuf;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F72 RID: 12146
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeComponentNetworkHelper
	{
		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0601CC32 RID: 117810 RVA: 0x008C76C9 File Offset: 0x008C58C9
		[Nullable(2)]
		private Entity OwnerEntity
		{
			[NullableContext(2)]
			get
			{
				RangeComponent owner = this.Owner;
				if (owner == null)
				{
					return null;
				}
				return owner.Entity;
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0601CC33 RID: 117811 RVA: 0x008C76DC File Offset: 0x008C58DC
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp
		{
			[NullableContext(2)]
			get
			{
				Entity ownerEntity = this.OwnerEntity;
				if (ownerEntity == null)
				{
					return null;
				}
				return ownerEntity.GetComponent<CreatureDataComponent>();
			}
		}

		// Token: 0x0601CC34 RID: 117812 RVA: 0x008C76EF File Offset: 0x008C58EF
		public void Init(RangeComponent owner, bool needReqEntityAccessRange, bool needReqPlayerAccessRange, CancellationToken lifecycleToken)
		{
			this.Owner = owner;
			this.NeedReqEntityAccessRange = needReqEntityAccessRange;
			this.NeedReqPlayerAccessRange = needReqPlayerAccessRange;
			this.LifecycleToken = lifecycleToken;
			this.EntitiesInRangeOnline.Clear();
			this.PlayerInRangeOnline.Clear();
			this.EntitiesInRangeOnlineNeedWait.Clear();
		}

		// Token: 0x0601CC35 RID: 117813 RVA: 0x008C7730 File Offset: 0x008C5930
		public void Clear()
		{
			this.Owner = null;
			this.LifecycleToken = default(CancellationToken);
			this.EntitiesInRangeOnline.Clear();
			this.PlayerInRangeOnline.Clear();
			this.EntitiesInRangeOnlineNeedWait.Clear();
			this.NeedReqEntityAccessRange = false;
			this.NeedReqPlayerAccessRange = false;
		}

		// Token: 0x0601CC36 RID: 117814 RVA: 0x008C777F File Offset: 0x008C597F
		public IReadOnlyDictionary<int, EntityHandle> GetEntitiesInRangeOnline()
		{
			return this.EntitiesInRangeOnline;
		}

		// Token: 0x0601CC37 RID: 117815 RVA: 0x008C7787 File Offset: 0x008C5987
		public IReadOnlyCollection<int> GetPlayerInRangeOnline()
		{
			return this.PlayerInRangeOnline;
		}

		// Token: 0x0601CC38 RID: 117816 RVA: 0x008C7790 File Offset: 0x008C5990
		public void OnAddEntity(EntityHandle handle)
		{
			WorldEntity entity = handle.Entity;
			long? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
			}
			long? num2 = num;
			if (num2 != null)
			{
				long? num3 = num2;
				long num4 = 0L;
				bool isEnter;
				if (!(num3.GetValueOrDefault() == num4 & num3 != null) && this.EntitiesInRangeOnlineNeedWait.TryGetValue(num2.Value, out isEnter))
				{
					this.UpdateEntitiesInRangeOnline(isEnter, num2.Value);
				}
			}
		}

		// Token: 0x0601CC39 RID: 117817 RVA: 0x008C7818 File Offset: 0x008C5A18
		public unsafe void UpdateEntitiesInRangeOnline(bool isEnter, long accessEntityCreatureDataId)
		{
			int num = 1;
			List<long> list = new List<long>(num);
			CollectionsMarshal.SetCount<long>(list, num);
			Span<long> span = CollectionsMarshal.AsSpan<long>(list);
			int index = 0;
			*span[index] = accessEntityCreatureDataId;
			this.UpdateEntitiesInRangeOnline(isEnter, list);
		}

		// Token: 0x0601CC3A RID: 117818 RVA: 0x008C7850 File Offset: 0x008C5A50
		public void UpdateEntitiesInRangeOnline(bool isEnter, IList<long> accessEntityCreatureDataIds)
		{
			foreach (long num in accessEntityCreatureDataIds)
			{
				this.EntitiesInRangeOnlineNeedWait.Remove(num);
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity == null)
				{
					this.EntitiesInRangeOnlineNeedWait[num] = isEnter;
				}
				else
				{
					if (isEnter)
					{
						this.EntitiesInRangeOnline[entity.Id] = entity;
					}
					else
					{
						this.EntitiesInRangeOnline.Remove(entity.Id);
					}
					RangeComponent owner = this.Owner;
					if (owner != null)
					{
						owner.HandleEntityInRangeOnlineUpdated(entity, isEnter);
					}
				}
			}
		}

		// Token: 0x0601CC3B RID: 117819 RVA: 0x008C78F8 File Offset: 0x008C5AF8
		public void UpdatePlayerInRangeOnline(bool isEnter, int accessPlayerId)
		{
			this.UpdatePlayerInRangeOnline(isEnter, new int[]
			{
				accessPlayerId
			});
		}

		// Token: 0x0601CC3C RID: 117820 RVA: 0x008C790C File Offset: 0x008C5B0C
		public void UpdatePlayerInRangeOnline(bool isEnter, int[] accessPlayerIds)
		{
			foreach (int num in accessPlayerIds)
			{
				if (isEnter)
				{
					this.PlayerInRangeOnline.Add(num);
				}
				else
				{
					this.PlayerInRangeOnline.Remove(num);
				}
				RangeComponent owner = this.Owner;
				if (owner != null)
				{
					owner.HandlePlayerInRangeOnlineUpdated(num, isEnter);
				}
			}
		}

		// Token: 0x0601CC3D RID: 117821 RVA: 0x008C7960 File Offset: 0x008C5B60
		public unsafe void RequestPlayerAccessRange(bool isEnter, EntityHandle accessPlayerEntity)
		{
			if (!this.NeedReqPlayerAccessRange || this.CreatureDataComp == null)
			{
				return;
			}
			WorldEntity entity = accessPlayerEntity.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
			if (num == null)
			{
				return;
			}
			WorldEntity entity2 = accessPlayerEntity.Entity;
			CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent != null)
			{
				characterActorComponent.ResetLocationCachedTime();
			}
			WorldEntity entity3 = accessPlayerEntity.Entity;
			CharacterMovementSyncComponent characterMovementSyncComponent = (entity3 != null) ? entity3.GetComponent<CharacterMovementSyncComponent>() : null;
			if (characterMovementSyncComponent != null && characterMovementSyncComponent.GetEnableMovementSync())
			{
				characterMovementSyncComponent.CollectSampleAndSend(true);
			}
			WorldEntity entity4 = accessPlayerEntity.Entity;
			BaseActorComponent baseActorComponent = (entity4 != null) ? entity4.GetComponent<BaseActorComponent>() : null;
			AActor myRoleTriggerOrUndefined = RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined();
			UCapsuleComponent myRoleCapsuleComponent = RoleTriggerController.Instance.GetMyRoleCapsuleComponent();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[RangeComp] 本机玩家进出:(发起PlayerAccessRange)";
			<>y__InlineArray12<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray12<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.CreatureDataComp.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataComp.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsEnter", isEnter);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "RangeCompTransformList";
			RangeComponent owner = this.Owner;
			ptr = new ValueTuple<string, object>(item, (owner != null) ? owner.GetRangeTransformDebugString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("OtherPbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("OtherCreatureId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("OtherLocation", (baseActorComponent != null) ? baseActorComponent.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("RoleTriggerTransform", (myRoleTriggerOrUndefined != null) ? new FTransformDouble?(myRoleTriggerOrUndefined.D_GetTransform()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("RoleTriggerCapsuleHalfHeight", (myRoleCapsuleComponent != null) ? new float?(myRoleCapsuleComponent.CapsuleHalfHeight) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("RoleTriggerCapsuleRadius", (myRoleCapsuleComponent != null) ? new float?(myRoleCapsuleComponent.CapsuleRadius) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("RoleTriggerCapsuleCollisionEnabled", (myRoleCapsuleComponent != null) ? new TEnumAsByte<ECollisionEnabled>?(myRoleCapsuleComponent.GetCollisionEnabled()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("RoleTriggerCapsuleCollisionProfileName", (myRoleCapsuleComponent != null) ? myRoleCapsuleComponent.GetCollisionProfileName().ToString() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 12));
			PlayerAccessRangeRequest playerAccessRangeRequest = PlayerAccessRangeRequest.Create();
			playerAccessRangeRequest.RangeEntityId = this.CreatureDataComp.GetCreatureDataId();
			playerAccessRangeRequest.AccessRangeType = (isEnter ? AccessRangeType.RangeEnter : AccessRangeType.RangeLeave);
			CancellationToken requestToken = this.LifecycleToken;
			Net.Instance.Call(ERequestMessageId.PlayerAccessRangeRequest, playerAccessRangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if (requestToken.IsCancellationRequested)
				{
					return;
				}
				PlayerAccessRangeResponse playerAccessRangeResponse = (PlayerAccessRangeResponse)msg;
				if (playerAccessRangeResponse == null || playerAccessRangeResponse.ErrorCode != ErrorCode.Success)
				{
					return;
				}
				EntityHandle entity5 = CreatureModel.Instance.GetEntity(playerAccessRangeResponse.RangeEntityId);
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				Entity entity6;
				if (baseCharacter == null)
				{
					entity6 = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent2 = baseCharacter.CharacterActorComponent;
					entity6 = ((characterActorComponent2 != null) ? characterActorComponent2.Entity : null);
				}
				Entity entity7 = entity6;
				if (entity5 != null && entity5.Valid)
				{
					WorldEntity entity8 = entity5.Entity;
					if (entity8 != null && entity8.Valid && (entity7 != null && entity7.Valid))
					{
						foreach (KeyValuePair<int, ErrorCode> keyValuePair in playerAccessRangeResponse.AccessRangeResult.AccessRangeResults)
						{
							int num2;
							ErrorCode errorCode;
							keyValuePair.Deconstruct(out num2, out errorCode);
							int accessRangeResultType = num2;
							ErrorCode errorCode2 = errorCode;
							RangeComponentMessageManager.Instance.EmitMessage(entity5.Entity, playerAccessRangeResponse.AccessRangeResult.AccessRangeType, (AccessRangeResultType)accessRangeResultType, entity7, errorCode2);
						}
						return;
					}
				}
			}, 0);
		}

		// Token: 0x0601CC3E RID: 117822 RVA: 0x008C7CC2 File Offset: 0x008C5EC2
		public void RequestEntityAccessRange(bool isEnter, EntityHandle accessEntityHandle)
		{
			this.RequestEntityAccessRange(isEnter, new <>z__ReadOnlySingleElementList<EntityHandle>(accessEntityHandle));
		}

		// Token: 0x0601CC3F RID: 117823 RVA: 0x008C7CD4 File Offset: 0x008C5ED4
		public unsafe void RequestEntityAccessRange(bool isEnter, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<EntityHandle> accessEntityHandles)
		{
			if (!this.NeedReqEntityAccessRange || this.CreatureDataComp == null || accessEntityHandles == null || accessEntityHandles.Count == 0)
			{
				return;
			}
			List<long> list = new List<long>();
			foreach (EntityHandle entityHandle in accessEntityHandles)
			{
				WorldEntity entity = entityHandle.Entity;
				CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
				long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
				if ((num ?? 0L) != 0L)
				{
					list.Add(num.Value);
					if (SundryModel.Instance.GetModuleDebugLevel("RangeComponent") > 0)
					{
						WorldEntity entity2 = entityHandle.Entity;
						BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SceneItem;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "[RangeComp] 实体进出:(加入EntityAccessRange队列)";
						<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.CreatureDataComp.GetPbDataId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataComp.GetCreatureDataId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsEnter", isEnter);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("OtherPbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("OtherCreatureId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("OtherPos", (baseActorComponent != null) ? baseActorComponent.ActorLocationProxy : null);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
					}
					WorldEntity entity3 = entityHandle.Entity;
					BaseActorComponent baseActorComponent2 = (entity3 != null) ? entity3.GetComponent<BaseActorComponent>() : null;
					if (baseActorComponent2 != null)
					{
						baseActorComponent2.ResetLocationCachedTime();
					}
					WorldEntity entity4 = entityHandle.Entity;
					BaseMovementSyncComponent baseMovementSyncComponent = (entity4 != null) ? entity4.GetComponent<BaseMovementSyncComponent>() : null;
					if (baseMovementSyncComponent != null && baseMovementSyncComponent.GetEnableMovementSync())
					{
						baseMovementSyncComponent.CollectSampleAndSend(true);
					}
				}
			}
			EntityAccessRangeRequest entityAccessRangeRequest = EntityAccessRangeRequest.Create();
			entityAccessRangeRequest.RangeEntityId = this.CreatureDataComp.GetCreatureDataId();
			entityAccessRangeRequest.AccessEntityIds.Add(list);
			entityAccessRangeRequest.AccessRangeType = (isEnter ? AccessRangeType.RangeEnter : AccessRangeType.RangeLeave);
			CancellationToken requestToken = this.LifecycleToken;
			Net.Instance.Call(ERequestMessageId.EntityAccessRangeRequest, entityAccessRangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if (requestToken.IsCancellationRequested)
				{
					return;
				}
				EntityAccessRangeResponse entityAccessRangeResponse = (EntityAccessRangeResponse)msg;
				if (entityAccessRangeResponse == null || entityAccessRangeResponse.ErrorCode != ErrorCode.Success)
				{
					return;
				}
				EntityHandle entity5 = CreatureModel.Instance.GetEntity(entityAccessRangeResponse.RangeEntityId);
				if (entity5 != null && entity5.Valid)
				{
					WorldEntity entity6 = entity5.Entity;
					if (entity6 != null && entity6.Valid)
					{
						foreach (AccessRangeResultMessage accessRangeResultMessage in entityAccessRangeResponse.EntitiesAccessRangeResult)
						{
							EntityHandle entity7 = CreatureModel.Instance.GetEntity(accessRangeResultMessage.AccessEntityId);
							if (entity7 != null && entity7.Valid)
							{
								WorldEntity entity8 = entity7.Entity;
								if (entity8 != null && entity8.Valid)
								{
									foreach (KeyValuePair<int, ErrorCode> keyValuePair in accessRangeResultMessage.AccessRangeResults)
									{
										int num2;
										ErrorCode errorCode;
										keyValuePair.Deconstruct(out num2, out errorCode);
										int accessRangeResultType = num2;
										ErrorCode errorCode2 = errorCode;
										RangeComponentMessageManager.Instance.EmitMessage(entity5.Entity, accessRangeResultMessage.AccessRangeType, (AccessRangeResultType)accessRangeResultType, entity7.Entity, errorCode2);
									}
								}
							}
						}
						return;
					}
				}
			}, 0);
		}

		// Token: 0x0601CC40 RID: 117824 RVA: 0x008C7F8C File Offset: 0x008C618C
		public void RequestInitRange(IReadOnlyList<long> inRangeEntityIds, bool isPlayerInRange, [Nullable(2)] Action<InitRangeResponse> callback = null)
		{
			if (this.CreatureDataComp != null)
			{
				InitRangeRequest initRangeRequest = InitRangeRequest.Create();
				initRangeRequest.RangeEntityId = this.CreatureDataComp.GetCreatureDataId();
				initRangeRequest.InRangeEntityIds.Add(inRangeEntityIds);
				initRangeRequest.IsPlayerInRange = isPlayerInRange;
				CancellationToken requestToken = this.LifecycleToken;
				Net.Instance.Call(ERequestMessageId.InitRangeRequest, initRangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					if (!requestToken.IsCancellationRequested)
					{
						Action<InitRangeResponse> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3((InitRangeResponse)msg);
					}
				}, 0);
				return;
			}
			Action<InitRangeResponse> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(null);
		}

		// Token: 0x0601CC41 RID: 117825 RVA: 0x008C8014 File Offset: 0x008C6214
		public unsafe void RequestInitRangeAndDispatch(IReadOnlyList<long> inRangeEntityIds, bool isPlayerInRange, Action onValidatedSuccess)
		{
			if (this.CreatureDataComp == null || this.OwnerEntity == null)
			{
				return;
			}
			Entity requestOwner = this.OwnerEntity;
			long creatureDataId = this.CreatureDataComp.GetCreatureDataId();
			int pbDataId = this.CreatureDataComp.GetPbDataId();
			int playerId = this.CreatureDataComp.GetPlayerId();
			this.RequestInitRange(inRangeEntityIds, isPlayerInRange, delegate(InitRangeResponse response)
			{
				if (response == null || response.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[RangeComponent] ReqInitRange出错";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", pbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PlayerId", playerId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ErrorCode", (response != null) ? new ErrorCode?(response.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return;
				}
				long rangeEntityId = response.RangeEntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(rangeEntityId);
				CreatureDataComponent component = requestOwner.GetComponent<CreatureDataComponent>();
				if (creatureDataId == rangeEntityId && entity != null && entity.Valid)
				{
					WorldEntity entity2 = entity.Entity;
					if (entity2 != null && entity2.Valid && (component == null || !component.GetRemoveState()) && requestOwner.Id == entity.Id)
					{
						onValidatedSuccess();
						RangeComponentNetworkHelper.DispatchInitRangeResults(entity, response);
						return;
					}
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[RangeComponent] ReqInitRange服务器返回时，范围实体已销毁";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", pbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PlayerId", playerId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			});
		}

		// Token: 0x0601CC42 RID: 117826 RVA: 0x008C8094 File Offset: 0x008C6294
		private static void DispatchInitRangeResults(EntityHandle handle, InitRangeResponse response)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity;
			if (baseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			if (entity2 != null && entity2.Valid)
			{
				foreach (KeyValuePair<int, ErrorCode> keyValuePair in response.PlayerAccessRangeResult.AccessRangeResults)
				{
					int num;
					ErrorCode errorCode;
					keyValuePair.Deconstruct(out num, out errorCode);
					int accessRangeResultType = num;
					ErrorCode errorCode2 = errorCode;
					RangeComponentMessageManager.Instance.EmitMessage(handle.Entity, response.PlayerAccessRangeResult.AccessRangeType, (AccessRangeResultType)accessRangeResultType, entity2, errorCode2);
				}
			}
			foreach (AccessRangeResultMessage accessRangeResultMessage in response.EntitiesAccessRangeResult)
			{
				EntityHandle entity3 = CreatureModel.Instance.GetEntity(accessRangeResultMessage.AccessEntityId);
				if (entity3 != null && entity3.Valid)
				{
					WorldEntity entity4 = entity3.Entity;
					if (entity4 != null && entity4.Valid)
					{
						foreach (KeyValuePair<int, ErrorCode> keyValuePair in accessRangeResultMessage.AccessRangeResults)
						{
							int num;
							ErrorCode errorCode;
							keyValuePair.Deconstruct(out num, out errorCode);
							int accessRangeResultType2 = num;
							ErrorCode errorCode3 = errorCode;
							RangeComponentMessageManager.Instance.EmitMessage(handle.Entity, accessRangeResultMessage.AccessRangeType, (AccessRangeResultType)accessRangeResultType2, entity3.Entity, errorCode3);
						}
					}
				}
			}
		}

		// Token: 0x0400F262 RID: 62050
		private const string DEBUG_DETAIL_KEY = "RangeComponent";

		// Token: 0x0400F263 RID: 62051
		private const bool ENABLE_PLAYER_ACCESS_RANGE_LOG = true;

		// Token: 0x0400F264 RID: 62052
		[Nullable(2)]
		private RangeComponent Owner;

		// Token: 0x0400F265 RID: 62053
		private CancellationToken LifecycleToken;

		// Token: 0x0400F266 RID: 62054
		private readonly Dictionary<int, EntityHandle> EntitiesInRangeOnline = new Dictionary<int, EntityHandle>();

		// Token: 0x0400F267 RID: 62055
		private readonly HashSet<int> PlayerInRangeOnline = new HashSet<int>();

		// Token: 0x0400F268 RID: 62056
		private readonly Dictionary<long, bool> EntitiesInRangeOnlineNeedWait = new Dictionary<long, bool>();

		// Token: 0x0400F269 RID: 62057
		private bool NeedReqEntityAccessRange;

		// Token: 0x0400F26A RID: 62058
		private bool NeedReqPlayerAccessRange;
	}
}
