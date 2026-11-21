using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200559D RID: 21917
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingShipData
	{
		// Token: 0x0603656C RID: 222572 RVA: 0x00F2B160 File Offset: 0x00F29360
		public void RefreshData(FishingShipInfo info)
		{
			this.CurrentSkinId = info.SkinId;
			this.IsSailingInternal = info.IsSailing;
			this.IsInPortInternal = info.IsInPort;
			this.CreatureDataId = info.EntityId;
			this.LastPortId = info.LastPortId;
			this.RefreshShipEntity(this.CreatureDataId);
		}

		// Token: 0x0603656D RID: 222573 RVA: 0x00F2B1B5 File Offset: 0x00F293B5
		public void SetLastPortId(int portId)
		{
			this.LastPortId = portId;
		}

		// Token: 0x0603656E RID: 222574 RVA: 0x00F2B1BE File Offset: 0x00F293BE
		public void SetIsInPortInternal(bool isInPortInternal)
		{
			this.IsInPortInternal = isInPortInternal;
		}

		// Token: 0x0603656F RID: 222575 RVA: 0x00F2B1C8 File Offset: 0x00F293C8
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

		// Token: 0x06036570 RID: 222576 RVA: 0x00F2B35C File Offset: 0x00F2955C
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

		// Token: 0x06036571 RID: 222577 RVA: 0x00F2B418 File Offset: 0x00F29618
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

		// Token: 0x06036572 RID: 222578 RVA: 0x00F2B53A File Offset: 0x00F2973A
		private void OnEnterVehicle(VehiclePassengerInfo _, bool byChangeRole)
		{
			this.RefreshDriveFishingShipState(true);
		}

		// Token: 0x06036573 RID: 222579 RVA: 0x00F2B543 File Offset: 0x00F29743
		private void OnLeaveVehicle(VehiclePassengerInfo _, bool byChangeRole)
		{
			this.RefreshDriveFishingShipState(false);
		}

		// Token: 0x06036574 RID: 222580 RVA: 0x00F2B54C File Offset: 0x00F2974C
		private void RefreshDriveFishingShipState(bool isDriving)
		{
			this.IsDrivingInternal = isDriving;
			EventSystem.Instance.Emit<bool>(EEventName.DriveFishingShipStateChanged, isDriving);
		}

		// Token: 0x06036575 RID: 222581 RVA: 0x00F2B566 File Offset: 0x00F29766
		public long GetCreatureDataId()
		{
			return this.CreatureDataId;
		}

		// Token: 0x06036576 RID: 222582 RVA: 0x00F2B570 File Offset: 0x00F29770
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

		// Token: 0x06036577 RID: 222583 RVA: 0x00F2B592 File Offset: 0x00F29792
		public float GetCurrentHp()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(EAttributeType.Life);
		}

		// Token: 0x06036578 RID: 222584 RVA: 0x00F2B5AA File Offset: 0x00F297AA
		public float GetMaxHp()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(EAttributeType.LifeMax);
		}

		// Token: 0x06036579 RID: 222585 RVA: 0x00F2B5C2 File Offset: 0x00F297C2
		public int GetCurrentSkinId()
		{
			return this.CurrentSkinId;
		}

		// Token: 0x0603657A RID: 222586 RVA: 0x00F2B5CA File Offset: 0x00F297CA
		public void AddAttributeListener(EAttributeType attrId, Action<EAttributeType, float, float> callback)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return;
			}
			attributeComp.AddListener(attrId, callback, null);
		}

		// Token: 0x0603657B RID: 222587 RVA: 0x00F2B5DF File Offset: 0x00F297DF
		public void RemoveAttributeListener(EAttributeType attrId, Action<EAttributeType, float, float> callback)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return;
			}
			attributeComp.RemoveListener(attrId, callback);
		}

		// Token: 0x0603657C RID: 222588 RVA: 0x00F2B5F4 File Offset: 0x00F297F4
		public float GetAttributeValue(EAttributeType attrId)
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp == null)
			{
				return 0f;
			}
			return attributeComp.GetCurrentValue(attrId);
		}

		// Token: 0x0603657D RID: 222589 RVA: 0x00F2B60C File Offset: 0x00F2980C
		public bool IsShipInPort()
		{
			return this.IsInPortInternal;
		}

		// Token: 0x0603657E RID: 222590 RVA: 0x00F2B614 File Offset: 0x00F29814
		public bool IsShipSailing()
		{
			return this.IsSailingInternal;
		}

		// Token: 0x0603657F RID: 222591 RVA: 0x00F2B61C File Offset: 0x00F2981C
		public bool IsShipDriving()
		{
			return this.IsDrivingInternal;
		}

		// Token: 0x06036580 RID: 222592 RVA: 0x00F2B624 File Offset: 0x00F29824
		public int GetLastPortId()
		{
			return this.LastPortId;
		}

		// Token: 0x0401CACE RID: 117454
		private int CurrentSkinId = 1;

		// Token: 0x0401CACF RID: 117455
		private bool IsInPortInternal;

		// Token: 0x0401CAD0 RID: 117456
		private bool IsSailingInternal;

		// Token: 0x0401CAD1 RID: 117457
		private bool IsDrivingInternal;

		// Token: 0x0401CAD2 RID: 117458
		private long CreatureDataId;

		// Token: 0x0401CAD3 RID: 117459
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x0401CAD4 RID: 117460
		[Nullable(2)]
		private BaseAttributeComponent AttributeComp;

		// Token: 0x0401CAD5 RID: 117461
		private int LastPortId;
	}
}
