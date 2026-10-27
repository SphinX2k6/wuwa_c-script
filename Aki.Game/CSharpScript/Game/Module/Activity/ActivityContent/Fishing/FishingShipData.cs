using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200661F RID: 26143
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingShipData
	{
		// Token: 0x060418A7 RID: 268455 RVA: 0x00FE40F0 File Offset: 0x00FE22F0
		public void RefreshData(FishingShipInfo info)
		{
			this.CurrentSkinId = info.SkinId;
			this.IsSailingInternal = info.IsSailing;
			this.IsInPortInternal = info.IsInPort;
			this.CreatureDataId = info.EntityId;
			this.LastPortId = info.LastPortId;
			this.RefreshShipEntity(this.CreatureDataId);
		}

		// Token: 0x060418A8 RID: 268456 RVA: 0x00FE4145 File Offset: 0x00FE2345
		public void SetLastPortId(int portId)
		{
			this.LastPortId = portId;
		}

		// Token: 0x060418A9 RID: 268457 RVA: 0x00FE414E File Offset: 0x00FE234E
		public void SetIsInPortInternal(bool isInPortInternal)
		{
			this.IsInPortInternal = isInPortInternal;
		}

		// Token: 0x060418AA RID: 268458 RVA: 0x00FE4158 File Offset: 0x00FE2358
		public void RefreshShipEntity(long creatureDataId)
		{
			if (creatureDataId != this.CreatureDataId)
			{
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.CreatureDataId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (entity != null && entity.Valid)
			{
				int id = entity.Id;
				if (worldEntity != null && worldEntity.IsStart)
				{
					int num = id;
					EntityHandle entityHandle = this.EntityHandle;
					int? num2 = (entityHandle != null) ? new int?(entityHandle.Id) : null;
					if (!(num == num2.GetValueOrDefault() & num2 != null))
					{
						this.ClearShipEntity(ERemoveEntityType.RemoveTypeForce, null);
						this.EntityHandle = entity;
						this.AttributeComp = worldEntity.GetComponent<BaseAttributeComponent>();
						BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
						AActor aactor = (component != null) ? component.Owner : null;
						if (aactor != null && aactor.IsValid())
						{
							GlobalData.BpEventManager.当捕鱼船创建时.Broadcast(aactor);
						}
						EventSystem.Instance.Emit(EEventName.FishingShipDataRefresh);
						BaseVehiclePerformComponent component2 = worldEntity.GetComponent<BaseVehiclePerformComponent>();
						EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
						WorldEntity worldEntity2 = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
						bool isDriving = false;
						if (component2 != null && worldEntity2 != null)
						{
							isDriving = component2.IsDriver(worldEntity2);
						}
						this.RefreshDriveFishingShipState(isDriving);
						EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ClearShipEntity));
						EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(worldEntity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
						EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(worldEntity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
						this.CreateShipMark(this.EntityHandle);
					}
				}
			}
		}

		// Token: 0x060418AB RID: 268459 RVA: 0x00FE42EC File Offset: 0x00FE24EC
		private void CreateShipMark(EntityHandle entityHandle)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int ownerId = OnlineModel.Instance.OwnerId;
				if (!(id.GetValueOrDefault() == ownerId & id != null))
				{
					return;
				}
			}
			FishingShipMarkCreateInfo info = new FishingShipMarkCreateInfo(new DynamicMarkCreateParams
			{
				TrackTarget = entityHandle.Id,
				MarkConfigId = 8,
				MarkType = EMarkType.FishingShip,
				TrackSource = new ETrackSource?(ETrackSource.MapMark),
				EntityConfigId = new int?(entityHandle.PbDataId),
				MapAndDungeonInfo = new MapAndDungeonInfo
				{
					MapConfigId = new int?(8)
				}
			});
			MapModel.Instance.RemoveMapMarkByType(EMarkType.FishingShip);
			MapModel.Instance.CreateMapMark(info);
		}

		// Token: 0x060418AC RID: 268460 RVA: 0x00FE43A8 File Offset: 0x00FE25A8
		private void ClearShipEntity(ERemoveEntityType _1 = ERemoveEntityType.RemoveTypeForce, EntityHandle _2 = null)
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(entityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ClearShipEntity)))
			{
				EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(entityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.ClearShipEntity));
				MapModel.Instance.SyncLocalShipLocationToCacheInfo();
				MapModel.Instance.RemoveMapMarkByType(EMarkType.FishingShip);
				MapModel.Instance.TryRecreateShipMark();
			}
			if (entityHandle != null && entityHandle.Entity != null)
			{
				if (EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(entityHandle.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle)))
				{
					EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(entityHandle.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
				}
				if (EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(entityHandle.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle)))
				{
					EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(entityHandle.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
				}
			}
			this.RefreshDriveFishingShipState(false);
			this.EntityHandle = null;
			this.AttributeComp = null;
		}

		// Token: 0x060418AD RID: 268461 RVA: 0x00FE44CA File Offset: 0x00FE26CA
		private void OnEnterVehicle(VehiclePassengerInfo _, bool byChangeRole)
		{
			this.RefreshDriveFishingShipState(true);
		}

		// Token: 0x060418AE RID: 268462 RVA: 0x00FE44D3 File Offset: 0x00FE26D3
		private void OnLeaveVehicle(VehiclePassengerInfo _, bool byChangeRole)
		{
			this.RefreshDriveFishingShipState(false);
		}

		// Token: 0x060418AF RID: 268463 RVA: 0x00FE44DC File Offset: 0x00FE26DC
		private void RefreshDriveFishingShipState(bool isDriving)
		{
			this.IsDrivingInternal = isDriving;
			EventSystem.Instance.Emit<bool>(EEventName.DriveFishingShipStateChanged, isDriving);
		}

		// Token: 0x060418B0 RID: 268464 RVA: 0x00FE44F6 File Offset: 0x00FE26F6
		public long GetCreatureDataId()
		{
			return this.CreatureDataId;
		}

		// Token: 0x060418B1 RID: 268465 RVA: 0x00FE4500 File Offset: 0x00FE2700
		[NullableContext(2)]
		public EntityHandle GetEntityHandle()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				return entityHandle;
			}
			return null;
		}

		// Token: 0x060418B2 RID: 268466 RVA: 0x00FE4522 File Offset: 0x00FE2722
		public float GetCurrentHp()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(EAttributeType.Life);
		}

		// Token: 0x060418B3 RID: 268467 RVA: 0x00FE453A File Offset: 0x00FE273A
		public float GetMaxHp()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(EAttributeType.LifeMax);
		}

		// Token: 0x060418B4 RID: 268468 RVA: 0x00FE4552 File Offset: 0x00FE2752
		public int GetCurrentSkinId()
		{
			return this.CurrentSkinId;
		}

		// Token: 0x060418B5 RID: 268469 RVA: 0x00FE455A File Offset: 0x00FE275A
		public void AddAttributeListener(EAttributeType attrId, Action<EAttributeType, float, float> callback)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return;
			}
			attributeComp.AddListener(attrId, callback, null);
		}

		// Token: 0x060418B6 RID: 268470 RVA: 0x00FE456F File Offset: 0x00FE276F
		public void RemoveAttributeListener(EAttributeType attrId, Action<EAttributeType, float, float> callback)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return;
			}
			attributeComp.RemoveListener(attrId, callback);
		}

		// Token: 0x060418B7 RID: 268471 RVA: 0x00FE4584 File Offset: 0x00FE2784
		public float GetAttributeValue(EAttributeType attrId)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(attrId);
		}

		// Token: 0x060418B8 RID: 268472 RVA: 0x00FE459C File Offset: 0x00FE279C
		public bool IsShipInPort()
		{
			return this.IsInPortInternal;
		}

		// Token: 0x060418B9 RID: 268473 RVA: 0x00FE45A4 File Offset: 0x00FE27A4
		public bool IsShipSailing()
		{
			return this.IsSailingInternal;
		}

		// Token: 0x060418BA RID: 268474 RVA: 0x00FE45AC File Offset: 0x00FE27AC
		public bool IsShipDriving()
		{
			return this.IsDrivingInternal;
		}

		// Token: 0x060418BB RID: 268475 RVA: 0x00FE45B4 File Offset: 0x00FE27B4
		public int GetLastPortId()
		{
			return this.LastPortId;
		}

		// Token: 0x0402219D RID: 139677
		private int CurrentSkinId = 1;

		// Token: 0x0402219E RID: 139678
		private bool IsInPortInternal;

		// Token: 0x0402219F RID: 139679
		private bool IsSailingInternal;

		// Token: 0x040221A0 RID: 139680
		private bool IsDrivingInternal;

		// Token: 0x040221A1 RID: 139681
		private long CreatureDataId;

		// Token: 0x040221A2 RID: 139682
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x040221A3 RID: 139683
		[Nullable(2)]
		private BaseAttributeComponent AttributeComp;

		// Token: 0x040221A4 RID: 139684
		private int LastPortId;
	}
}
