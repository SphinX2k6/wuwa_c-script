using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200622B RID: 25131
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDropItemComponent : EntityComponent
	{
		// Token: 0x17007236 RID: 29238
		// (get) Token: 0x0603C753 RID: 247635 RVA: 0x011459B0 File Offset: 0x01143BB0
		public DropItemData DropItemConfig
		{
			get
			{
				return this.ItemData;
			}
		}

		// Token: 0x0603C754 RID: 247636 RVA: 0x011459B8 File Offset: 0x01143BB8
		protected override bool OnClear()
		{
			if (EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				EffectSystem.Instance.StopEffectById(this.ProgressEffect, "[SceneItemDropItemComponent.OnClear]", true, null);
				this.ProgressEffect = 0;
			}
			if (this.DelayHandler != null)
			{
				TimerSystem.Instance.Remove(this.DelayHandler);
				this.DelayHandler = null;
			}
			if (this.OnEntityDieAnimationEnd != null)
			{
				if (EventSystem.Instance.Has<int>(EEventName.DropItemStarted, this.OnEntityDieAnimationEnd))
				{
					EventSystem.Instance.Remove<int>(EEventName.DropItemStarted, this.OnEntityDieAnimationEnd);
				}
				this.OnEntityDieAnimationEnd = null;
			}
			return true;
		}

		// Token: 0x0603C755 RID: 247637 RVA: 0x01145A5C File Offset: 0x01143C5C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureData = base.Entity.GetComponent<CreatureDataComponent>();
			EntityComponentPb valueOrDefault = this.CreatureData.ComponentDataMap.GetValueOrDefault("DropComponentPb");
			if (valueOrDefault == null)
			{
				return false;
			}
			this.InitBaseInfo(valueOrDefault.DropComponentPb);
			if (this.ItemData == null)
			{
				return false;
			}
			if (this.CheckCanStartDropDown(valueOrDefault.DropComponentPb))
			{
				this.DropDownIsStarted = true;
			}
			return true;
		}

		// Token: 0x0603C756 RID: 247638 RVA: 0x01145AC1 File Offset: 0x01143CC1
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.InitDropStateFunction();
			return true;
		}

		// Token: 0x0603C757 RID: 247639 RVA: 0x01145ADC File Offset: 0x01143CDC
		protected override void OnActivate()
		{
			DropItemData itemData = this.ItemData;
			this.DropDownCanRun = (itemData == null || itemData.ItemType != InventoryDefine.EItemDataType.HonamiStoryItem);
			if (this.DropDownIsStarted)
			{
				this.StartDropDown();
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					AActor owner = actorComp.Owner;
					if (owner != null)
					{
						owner.SetActorHiddenInGame(false);
					}
				}
			}
			if (this.DropDownCanRun && !Info.Instance.EnableForceTick && base.Active)
			{
				ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.ForceTickInternal));
			}
			EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnOnSceneInteractionShowCompleted));
		}

		// Token: 0x0603C758 RID: 247640 RVA: 0x01145B88 File Offset: 0x01143D88
		protected override void OnEnable()
		{
			if (this.DropDownCanRun && !Info.Instance.EnableForceTick)
			{
				Entity entity = base.Entity;
				if (entity != null && entity.IsInit)
				{
					ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.ForceTickInternal));
				}
			}
		}

		// Token: 0x0603C759 RID: 247641 RVA: 0x01145BD4 File Offset: 0x01143DD4
		protected override void OnDisable(string reason)
		{
			if (this.DropDownCanRun && !Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
			}
		}

		// Token: 0x0603C75A RID: 247642 RVA: 0x01145BF5 File Offset: 0x01143DF5
		protected override bool OnEnd()
		{
			if (this.DropDownCanRun && !Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
			}
			return true;
		}

		// Token: 0x0603C75B RID: 247643 RVA: 0x01145C18 File Offset: 0x01143E18
		private void InitBaseInfo(DropComponentPb data)
		{
			int itemId = data.ItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "掉落配置查询数据为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("道具id", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
			if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.HonamiStoryItem && string.IsNullOrEmpty(itemConfigData.Mesh))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.World;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "掉落配置查询Mesh字段配置为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("道具id", itemId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.ItemData = new DropItemData();
			this.ItemData.ItemType = itemDataTypeByConfigId;
			this.ItemData.ConfigId = itemId;
			this.ItemData.Config = itemConfigData;
			this.ItemData.ItemCount = data.ItemCount;
			this.ItemData.ShowPlanId = data.ShowPlanId;
			CSharpScript.Game.Module.Reward.RewardConfig instance3 = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
			DropShowPlan? dropShowPlan = instance3.GetDropShowPlan(data.ShowPlanId);
			DropItemData itemData = this.ItemData;
			int? num = (dropShowPlan != null) ? new int?(dropShowPlan.GetValueOrDefault().Adsorption) : null;
			itemData.AdsorptionType = ((num != null) ? new EDropAdsorptionType?((EDropAdsorptionType)num.GetValueOrDefault()) : null);
			this.ItemData.StartSpeed = (float)instance3.GetSpeed();
			this.ItemData.RotationProtectTime = (float)instance3.GetDropRotationProtectTime();
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.DangoAbyssItem)
			{
				AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(itemConfigData.QualityId);
				this.ItemData.BornEffectPath = abyssQualityById.Value.AbyssSpecialEffects;
				this.ItemData.TailEffectPath = abyssQualityById.Value.AbyssTailEffects;
				this.ItemData.DestroyEffectPath = abyssQualityById.Value.AbyssDissipateEffects;
				return;
			}
			if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.HonamiStoryItem)
			{
				QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(itemConfigData.QualityId);
				int num2 = (((((qualityConfig != null) ? new int?(qualityConfig.GetValueOrDefault().Id) : null) ?? 0) != 0) ? qualityConfig.Value.Id : 1) - 1;
				this.ItemData.BornEffectPath = SceneItemDropItemComponent.BORN_EFFECTS[num2];
				this.ItemData.TailEffectPath = SceneItemDropItemComponent.TRAIL_EFFECTS[num2];
				this.ItemData.DestroyEffectPath = SceneItemDropItemComponent.DESTROY_EFFECTS[num2];
				return;
			}
			HonamiStoryItemQuality? honamiStoryQuality = HonamiStoryConfig.Instance.GetHonamiStoryQuality(itemConfigData.QualityId);
			this.ItemData.BornEffectPath = honamiStoryQuality.Value.SpecialEffects;
		}

		// Token: 0x0603C75C RID: 247644 RVA: 0x01145EDC File Offset: 0x011440DC
		private bool CheckCanStartDropDown(DropComponentPb data)
		{
			DropItemData itemData = this.ItemData;
			if (itemData != null && itemData.ItemType == InventoryDefine.EItemDataType.HonamiStoryItem)
			{
				return false;
			}
			if (data.EntityConfigId == 0)
			{
				return true;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(data.EntityConfigId);
			if (entityByPbDataId == null)
			{
				return true;
			}
			if (entityByPbDataId.Entity.GetComponent<CreatureDataComponent>().GetEntityType() != EEntityType.Monster)
			{
				return true;
			}
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("drop_item_show_time");
			if (floatConfig != null && floatConfig.GetValueOrDefault() != 0f)
			{
				this.DelayHandler = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.DelayHandler = null;
					this.HandleDieAnimationEnd();
				}, floatConfig.Value * 1000f, null, null, true, 1f);
			}
			int sourceEntityId = entityByPbDataId.Id;
			this.OnEntityDieAnimationEnd = delegate(int entityId)
			{
				if (sourceEntityId != entityId)
				{
					return;
				}
				this.HandleDieAnimationEnd();
			};
			EventSystem.Instance.Add<int>(EEventName.DropItemStarted, this.OnEntityDieAnimationEnd);
			return false;
		}

		// Token: 0x0603C75D RID: 247645 RVA: 0x01145FD0 File Offset: 0x011441D0
		private void HandleDieAnimationEnd()
		{
			if (this.DelayHandler != null)
			{
				TimerSystem.Instance.Remove(this.DelayHandler);
				this.DelayHandler = null;
			}
			if (EventSystem.Instance.Has<int>(EEventName.DropItemStarted, this.OnEntityDieAnimationEnd))
			{
				EventSystem.Instance.Remove<int>(EEventName.DropItemStarted, this.OnEntityDieAnimationEnd);
				this.OnEntityDieAnimationEnd = null;
			}
			if (this.DropDownIsStarted)
			{
				return;
			}
			this.DropDownIsStarted = true;
			if (this.DropDownCanRun)
			{
				this.StartDropDown();
				Entity entity = base.Entity;
				if (entity != null && entity.IsInit)
				{
					SceneItemActorComponent actorComp = this.ActorComp;
					if (((actorComp != null) ? actorComp.Owner : null) != null)
					{
						this.ActorComp.Owner.SetActorHiddenInGame(false);
					}
				}
			}
		}

		// Token: 0x0603C75E RID: 247646 RVA: 0x01146088 File Offset: 0x01144288
		private void StartDropDown()
		{
			this.InitPhysics();
			this.InitEffects();
			this.StartInteraction();
		}

		// Token: 0x0603C75F RID: 247647 RVA: 0x0114609C File Offset: 0x0114429C
		private unsafe void CheckGround()
		{
			FVector zeroVector = FVector.ZeroVector;
			FVector zeroVector2 = FVector.ZeroVector;
			this.ActorComp.Owner.GetActorBounds(false, ref zeroVector, ref zeroVector2, false);
			global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			int dropChestOffsetZ = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropChestOffsetZ();
			float num = zeroVector2.Size();
			bool flag = RewardModel.Instance.CheckGroundHit(actorLocationProxy, num, (float)dropChestOffsetZ);
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			commonTempVector.FromUeVector(actorLocationProxy);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "掉落初始位置修正前";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Location", commonTempVector);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Radius", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (flag)
			{
				commonTempVector.Z += (double)dropChestOffsetZ;
				this.ActorComp.SetActorLocation(commonTempVector.ToUeVector(false), base.GetType().Name, false);
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.World;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "掉落初始位置修正后";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Location", commonTempVector);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("zOffset", dropChestOffsetZ);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			}
		}

		// Token: 0x0603C760 RID: 247648 RVA: 0x01146290 File Offset: 0x01144490
		private void InitPhysics()
		{
			DropItemData itemData = this.ItemData;
			string value;
			if (itemData == null)
			{
				value = null;
			}
			else
			{
				CSharpScript.Game.Module.Inventory.ItemConfig config = itemData.Config;
				value = ((config != null) ? config.Mesh : null);
			}
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<UObject>(this.ItemData.Config.Mesh, delegate([Nullable(2)] UObject mesh, string path)
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				UStaticMeshComponent ustaticMeshComponent = (actorComp != null) ? actorComp.StaticMesh : null;
				if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid() || (mesh == null || !mesh.IsValid()))
				{
					return;
				}
				this.CheckGround();
				this.ItemData.MeshIsInited = true;
				UStaticMesh ustaticMesh = mesh as UStaticMesh;
				if (ustaticMesh != null)
				{
					ustaticMeshComponent.SetStaticMesh(ustaticMesh);
					ustaticMeshComponent.SetReceivesDecals(false);
				}
				ustaticMeshComponent.SetLinearDamping(0f);
				ustaticMeshComponent.SetAngularDamping(0f);
				ustaticMeshComponent.SetEnableGravity(true);
				global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				commonTempVector.Set(MathUtils.Instance.GetRandomRange(-1.0, 1.0), MathUtils.Instance.GetRandomRange(-1.0, 1.0), MathUtils.Instance.GetRandomRange(-1.0, 1.0));
				UPrimitiveComponent uprimitiveComponent = ustaticMeshComponent;
				FVectorDouble fvectorDouble = commonTempVector.ToUeVector(false);
				uprimitiveComponent.SetCenterOfMass(fvectorDouble, FNameUtil.NONE);
				ustaticMeshComponent.SetCollisionEnabled(ECollisionEnabled.PhysicsOnly);
				ustaticMeshComponent.SetSimulatePhysics(true);
				ustaticMeshComponent.SetCollisionProfileName(SceneItemDropItemComponent.COLLISION_PROFILE_NAME, true);
				float yaw = this.CreatureData.GetRotation().Yaw;
				global::Vector randomForce = this.GetRandomForce(yaw);
				UPrimitiveComponent uprimitiveComponent2 = ustaticMeshComponent;
				fvectorDouble = randomForce.ToUeVector(false);
				uprimitiveComponent2.AddImpulse(fvectorDouble, FNameUtil.NONE, true);
				ustaticMeshComponent.BodyInstance.bLockXRotation = true;
				ustaticMeshComponent.BodyInstance.bLockYRotation = true;
				ustaticMeshComponent.SetConstraintMode(EDOFMode.None);
				ustaticMeshComponent.SetUseCCD(true, default(FName));
			}, 100, "js_undefined");
			ResourceSystem.Instance.LoadAsync<UPhysicalMaterial>("/Game/Aki/Scene/PhysMaterial/PM_DropItem.PM_DropItem", delegate([Nullable(2)] UPhysicalMaterial material, string path)
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				UStaticMeshComponent ustaticMeshComponent = (actorComp != null) ? actorComp.StaticMesh : null;
				if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid() || (material == null || !material.IsValid()))
				{
					return;
				}
				if (material != null)
				{
					material.Restitution = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetRestitution();
					material.Friction = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetFriction();
					ustaticMeshComponent.SetPhysMaterialOverride(material);
				}
			}, 100, "js_undefined");
		}

		// Token: 0x0603C761 RID: 247649 RVA: 0x01146314 File Offset: 0x01144514
		private void InitEffects()
		{
			FTransformDouble value = this.ActorComp.StaticMesh.D_GetRelativeTransform();
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			this.ProgressEffect = instance.SpawnUnloopedEffect(world, ftransformDouble, "/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_Xingxing_001.DA_Fx_Xingxing_001", "[SceneItemDropItemComponent.InitEffects]", null, global::EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				return;
			}
			EffectSystem.Instance.GetEffectActor(this.ProgressEffect).K2_AttachToComponent(this.ActorComp.StaticMesh, new FName?(FNameUtil.NONE), EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true);
		}

		// Token: 0x0603C762 RID: 247650 RVA: 0x011463A4 File Offset: 0x011445A4
		private void StartInteraction()
		{
			PawnInteractNewComponent component = base.Entity.GetComponent<PawnInteractNewComponent>();
			if (component != null)
			{
				PawnInteractController interactController = component.GetInteractController();
				if (interactController != null)
				{
					interactController.AddClientInteractOption(new ActionPickupDropItem
					{
						EntityId = base.Entity.Id
					}, null, new EDoInteract?(EDoInteract.Option), null, null, new ECustomOptionType?(ECustomOptionType.None), null, null);
				}
			}
		}

		// Token: 0x0603C763 RID: 247651 RVA: 0x0114640B File Offset: 0x0114460B
		protected override void OnForceTick(float delta)
		{
			this.ForceTickInternal(delta);
		}

		// Token: 0x0603C764 RID: 247652 RVA: 0x01146414 File Offset: 0x01144614
		private void ForceTickInternal(float delta)
		{
			if (this.ItemData == null || this.ItemData.DropFinished)
			{
				return;
			}
			if (!this.ItemData.MeshIsInited)
			{
				return;
			}
			float num = delta / 1000f;
			this.CheckDropRotation(num);
			this.DropTick(num);
		}

		// Token: 0x0603C765 RID: 247653 RVA: 0x0114645C File Offset: 0x0114465C
		protected void InitDropStateFunction()
		{
			this.DropStateFunctionMap = new Dictionary<EDropStateType, Action<float>>();
			this.DropStateFunctionMap.Add(EDropStateType.Up, new Action<float>(this.UpProcess));
			this.DropStateFunctionMap.Add(EDropStateType.Down, new Action<float>(this.DownProcess));
			this.DropStateFunctionMap.Add(EDropStateType.DownStill, new Action<float>(this.DownStillProcess));
			this.DropStateFunctionMap.Add(EDropStateType.AutoAttach, new Action<float>(this.AutoAttachProcess));
			this.DropStateFunctionMap.Add(EDropStateType.WaitToManualPickUp, new Action<float>(this.WaitToManualPickUpProcess));
		}

		// Token: 0x0603C766 RID: 247654 RVA: 0x011464EC File Offset: 0x011446EC
		public global::Vector GetRandomForce(float yaw)
		{
			int showPlanId = this.ItemData.ShowPlanId;
			DropShowPlan? dropShowPlan = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropShowPlan(showPlanId);
			if (dropShowPlan == null)
			{
				return global::Vector.UpVectorProxy;
			}
			global::Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
			commonTempRotator.Pitch = 0f;
			int num = dropShowPlan.Value.Angle(0);
			int num2 = dropShowPlan.Value.Angle(1);
			commonTempRotator.Roll = (float)MathUtils.Instance.GetRandomRange((double)num, (double)num2);
			int num3 = dropShowPlan.Value.VerticalAngle(0);
			int num4 = dropShowPlan.Value.VerticalAngle(1);
			commonTempRotator.Yaw = (float)MathUtils.Instance.GetRandomRange((double)num3, (double)num4);
			commonTempRotator.Yaw += yaw;
			global::Vector vector = global::Vector.Create(global::Vector.UpVectorProxy);
			commonTempRotator.Quaternion(null).RotateVector(vector, vector);
			int num5 = dropShowPlan.Value.Force(0);
			int num6 = dropShowPlan.Value.Force(1);
			return vector.MultiplyEqual(MathUtils.Instance.GetRandomRange((double)num5, (double)num6));
		}

		// Token: 0x0603C767 RID: 247655 RVA: 0x01146614 File Offset: 0x01144814
		private void DropTick(float deltaTimes)
		{
			BaseActorComponent actorComp = this.ActorComp;
			FVector fvector = this.ActorComp.StaticMesh.K2_GetComponentLocation();
			actorComp.SetActorLocation(fvector, "unknown", true);
			if (this.CheckOutofProtectedHeight())
			{
				this.ExecuteAutoPickup();
				return;
			}
			Action<float> action;
			if (this.DropStateFunctionMap.TryGetValue(this.ItemData.DropState, out action))
			{
				action(deltaTimes);
			}
		}

		// Token: 0x0603C768 RID: 247656 RVA: 0x0114667C File Offset: 0x0114487C
		private void CreateAutoAttachEffect()
		{
			this.ActorComp.StaticMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			if (EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				EffectSystem.Instance.StopEffectById(this.ProgressEffect, "[SceneItemDropItemComponent.CreateAutoAttachEffect]", true, null);
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComp.ActorTransform);
			this.ProgressEffect = instance.SpawnEffect(world, ftransformDouble, this.ItemData.TailEffectPath, "[SceneItemDropItemComponent.CreateAutoAttachEffect]", new EffectContext(new int?(base.Entity.Id), null, false), global::EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.GetEffectActor(this.ProgressEffect).K2_AttachToComponent(this.ActorComp.StaticMesh, new FName?(FNameUtil.NONE), EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepRelative, true);
		}

		// Token: 0x0603C769 RID: 247657 RVA: 0x01146750 File Offset: 0x01144950
		private void UpProcess(float deltaTimes)
		{
			if ((double)this.ActorComp.StaticMesh.GetComponentVelocity().Z >= 0.0)
			{
				return;
			}
			this.ItemData.DropState = EDropStateType.Down;
			this.PreFrameLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.ActorComp.StaticMesh.SetNotifyRigidBodyCollision(false);
		}

		// Token: 0x0603C76A RID: 247658 RVA: 0x011467B4 File Offset: 0x011449B4
		private void DownProcess(float deltaTimes)
		{
			FVector componentVelocity = this.ActorComp.StaticMesh.GetComponentVelocity();
			int fallToGroundSpeed = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetFallToGroundSpeed();
			if (!this.CheckIsUnderWater())
			{
				this.PreFrameLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				if ((double)componentVelocity.Size() >= Math.Pow((double)fallToGroundSpeed, 2.0))
				{
					return;
				}
			}
			this.ActorComp.StaticMesh.SetSimulatePhysics(false);
			this.ActorComp.StaticMesh.SetUseCCD(false, default(FName));
			if (EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				EffectSystem.Instance.StopEffectById(this.ProgressEffect, "[SceneItemDropItemComponent.DownProcess]", true, null);
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComp.ActorTransform);
			this.ProgressEffect = instance.SpawnEffect(world, ftransformDouble, this.ItemData.BornEffectPath, "[SceneItemDropItemComponent.DownProcess]", new EffectContext(new int?(base.Entity.Id), null, false), global::EEffectType.Scene, null, null, null, false, false);
			if (EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				EffectSystem.Instance.GetEffectActor(this.ProgressEffect).K2_AttachToComponent(this.ActorComp.StaticMesh, new FName?(FNameUtil.NONE), EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepRelative, true);
			}
			this.ItemData.DropState = EDropStateType.DownStill;
		}

		// Token: 0x0603C76B RID: 247659 RVA: 0x01146918 File Offset: 0x01144B18
		protected void CheckDropRotation(float deltaTime)
		{
			if (this.ItemData.RotationProtectTime > 0f)
			{
				this.ItemData.RotationProtectTime -= deltaTime;
				if (this.ItemData.RotationProtectTime <= 0f)
				{
					this.ActorComp.StaticMesh.SetConstraintMode(EDOFMode.Default);
				}
			}
		}

		// Token: 0x0603C76C RID: 247660 RVA: 0x01146970 File Offset: 0x01144B70
		private void DownStillProcess(float deltaSeconds)
		{
			EDropAdsorptionType? adsorptionType = this.ItemData.AdsorptionType;
			EDropAdsorptionType edropAdsorptionType = EDropAdsorptionType.Manual;
			if (adsorptionType.GetValueOrDefault() == edropAdsorptionType & adsorptionType != null)
			{
				this.ItemData.DropState = EDropStateType.WaitToManualPickUp;
				return;
			}
			this.ItemData.AdsorptionProtectTime -= deltaSeconds;
			if (this.ItemData.AdsorptionProtectTime > 0f)
			{
				return;
			}
			this.CreateAutoAttachEffect();
			this.ItemData.DropState = EDropStateType.AutoAttach;
		}

		// Token: 0x0603C76D RID: 247661 RVA: 0x011469E4 File Offset: 0x01144BE4
		private void AutoAttachProcess(float deltaTimes)
		{
			this.ItemData.AdsorptionTime += deltaTimes;
			int maxAdsorption = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetMaxAdsorption();
			if (this.ItemData.AdsorptionTime > (float)maxAdsorption)
			{
				this.ExecuteAutoPickup();
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			global::Vector tempVector = SceneItemDropItemComponent.TempVector;
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			commonTempVector.FromUeVector(baseCharacter.CharacterActorComponent.ActorLocationProxy);
			commonTempVector.Subtraction(this.ActorComp.ActorLocationProxy, tempVector);
			double num = tempVector.SizeSquared();
			int pickUpInBagRange = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetPickUpInBagRange();
			if (num < Math.Pow((double)pickUpInBagRange, 2.0))
			{
				this.ExecuteAutoPickup();
				return;
			}
			if (num > Math.Pow((double)(this.ItemData.StartSpeed * deltaTimes), 2.0))
			{
				tempVector.Normalize(9.99999993922529E-09);
				tempVector.MultiplyEqual((double)(this.ItemData.StartSpeed * deltaTimes));
				tempVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
				USceneComponent staticMesh = this.ActorComp.StaticMesh;
				FVectorDouble fvectorDouble = tempVector.ToUeVector(false);
				staticMesh.K2_SetWorldLocation(fvectorDouble, false, ref WorldGlobal.SweepHitResult, false);
				int dropItemAcceleration = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropItemAcceleration();
				this.ItemData.StartSpeed = this.ItemData.StartSpeed + (float)dropItemAcceleration;
			}
		}

		// Token: 0x0603C76E RID: 247662 RVA: 0x01146B38 File Offset: 0x01144D38
		private void WaitToManualPickUpProcess(float deltaTimes)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			global::Vector tempVector = SceneItemDropItemComponent.TempVector;
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			commonTempVector.FromUeVector(baseCharacter.CharacterActorComponent.ActorLocationProxy);
			commonTempVector.Subtraction(this.ActorComp.ActorLocationProxy, tempVector);
			int dropItemPickUpRange = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropItemPickUpRange();
			if (tempVector.SizeSquared() > Math.Pow((double)dropItemPickUpRange, 2.0))
			{
				this.ExecuteAutoPickup();
			}
		}

		// Token: 0x0603C76F RID: 247663 RVA: 0x01146BAC File Offset: 0x01144DAC
		private bool CheckOutofProtectedHeight()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return false;
			}
			ref FVectorDouble actorLocation = baseCharacter.CharacterActorComponent.ActorLocation;
			int heightProtect = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetHeightProtect();
			return Math.Abs(actorLocation.Z - this.ActorComp.ActorLocationProxy.Z) >= (double)heightProtect && this.ActorComp.StaticMesh.GetComponentVelocity().Z <= 0f;
		}

		// Token: 0x0603C770 RID: 247664 RVA: 0x01146C1C File Offset: 0x01144E1C
		private bool CheckIsUnderWater()
		{
			global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			FVector zeroVector = FVector.ZeroVector;
			FVector zeroVector2 = FVector.ZeroVector;
			this.ActorComp.Owner.GetActorBounds(false, ref zeroVector2, ref zeroVector, false);
			if (RewardModel.Instance.CheckWaterHit(this.PreFrameLocation, actorLocationProxy, 10f, zeroVector.Size()))
			{
				this.ItemData.DropFinished = true;
				this.ItemData.DropState = EDropStateType.WaitToAutoPickUp;
				UStaticMeshComponent staticMesh = this.ActorComp.StaticMesh;
				staticMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				staticMesh.SetConstraintMode(EDOFMode.None);
				staticMesh.SetEnableGravity(false);
				staticMesh.SetSimulatePhysics(false);
				staticMesh.SetUseCCD(false, default(FName));
				return true;
			}
			return false;
		}

		// Token: 0x0603C771 RID: 247665 RVA: 0x01146CC8 File Offset: 0x01144EC8
		public void DestroyWithEffect()
		{
			DropItemData itemData = this.ItemData;
			if (itemData != null && itemData.ItemType == InventoryDefine.EItemDataType.HonamiStoryItem)
			{
				base.Entity.GetComponent<SceneItemStateComponent>().HandleDestroyState(null);
				return;
			}
			this.ActorComp.StaticMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			InteractionModel.Instance.HandleInteractionHint(false, this.ActorComp.Entity.Id, null);
			if (EffectSystem.Instance.IsValid(this.ProgressEffect))
			{
				EffectSystem.Instance.StopEffectById(this.ProgressEffect, "[SceneItemDropItemComponent.DestroyWithEffect]", true, null);
				this.ProgressEffect = 0;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComp.ActorTransform);
			int id = instance.SpawnEffect(world, ftransformDouble, this.ItemData.DestroyEffectPath, "[SceneItemDropItemComponent.DestroyWithEffect]", new EffectContext(new int?(base.Entity.Id), null, false), global::EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.GetEffectActor(id).K2_AttachToComponent(this.ActorComp.StaticMesh, new FName?(FNameUtil.NONE), EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepRelative, true);
			AudioSystem.Instance.PostEvent("play_ui_fb_pickup");
			base.Entity.Disable("[SceneItemDropItemComponent.DestroyWithEffect] 播放销毁特效");
			CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
		}

		// Token: 0x0603C772 RID: 247666 RVA: 0x01146E17 File Offset: 0x01145017
		private void ExecuteAutoPickup()
		{
			this.ItemData.DropState = EDropStateType.WaitToAutoPickUp;
			RewardController.Instance.PickUpFightDrop(this.CreatureData.GetCreatureDataId(), this.CreatureData.GetPbDataId(), null);
			this.ItemData.DropFinished = true;
		}

		// Token: 0x0603C773 RID: 247667 RVA: 0x01146E53 File Offset: 0x01145053
		private void OnOnSceneInteractionShowCompleted()
		{
			this.FixBornLocation();
		}

		// Token: 0x0603C774 RID: 247668 RVA: 0x01146E5C File Offset: 0x0114505C
		public unsafe bool FixBornLocation()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.CapsuleComponent : null) == null)
			{
				return false;
			}
			bool flag = CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?(this.CreatureData.GetEntityType()));
			ValueTuple<bool, global::Vector> valueTuple = this.FixActorLocation(-3060f, flag);
			if (valueTuple.Item1)
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.SetActorLocation(valueTuple.Item2.ToUeVector(false), "SceneItemDropItemComponent.FixBornLocation", true);
				}
				if (flag)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "[SceneItemDropItemComponent.FixBornLocation] 实体地面修正:后";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
					string item = "K2_GetActorLocation";
					SceneItemActorComponent actorComp2 = this.ActorComp;
					FVector? fvector;
					if (actorComp2 == null)
					{
						fvector = null;
					}
					else
					{
						AActor owner = actorComp2.Owner;
						fvector = ((owner != null) ? new FVector?(owner.K2_GetActorLocation()) : null);
					}
					ptr = new ValueTuple<string, object>(item, fvector);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				return true;
			}
			return false;
		}

		// Token: 0x0603C775 RID: 247669 RVA: 0x01146FA4 File Offset: 0x011451A4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private unsafe ValueTuple<bool, global::Vector> FixActorLocation(float offset, bool showLog = true)
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[SceneItemDropItemComponent.FixBornLocation] ActorComp为空。";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return new ValueTuple<bool, global::Vector>(false, null);
			}
			global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			TraceElementModel.Instance.CommonStartLocation.Reset();
			TraceElementModel.Instance.CommonEndLocation.Reset();
			global::Vector commonStartLocation = TraceElementModel.Instance.CommonStartLocation;
			global::Vector commonEndLocation = TraceElementModel.Instance.CommonEndLocation;
			this.ActorComp.ActorUpProxy.Multiply(60.0, commonStartLocation);
			this.ActorComp.ActorUpProxy.Multiply((double)offset, commonEndLocation);
			commonStartLocation.AdditionEqual(actorLocationProxy);
			commonEndLocation.AdditionEqual(actorLocationProxy);
			return this.FixBornLocationInternal(actorLocationProxy, commonStartLocation, commonEndLocation, false, showLog);
		}

		// Token: 0x0603C776 RID: 247670 RVA: 0x011470CC File Offset: 0x011452CC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected unsafe ValueTuple<bool, global::Vector> FixBornLocationInternal(global::Vector position, global::Vector start, global::Vector end, bool allowStartPenetrating, bool showLog = true)
		{
			if (showLog)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[SceneItemDropItemComponent.FixBornLocation] 实体地面修正:前";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "K2_GetActorLocation";
				SceneItemActorComponent actorComp = this.ActorComp;
				FVector? fvector;
				if (actorComp == null)
				{
					fvector = null;
				}
				else
				{
					AActor owner = actorComp.Owner;
					fvector = ((owner != null) ? new FVector?(owner.K2_GetActorLocation()) : null);
				}
				ptr = new ValueTuple<string, object>(item, fvector);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ActorLocationProxy", position);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("InitLocation", this.CreatureData.GetInitLocation());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("射线开始位置", start);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("射线结束位置", end);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			}
			UTraceLineElement lineTrace = TraceElementModel.Instance.GetLineTrace();
			UTraceBaseElement utraceBaseElement = lineTrace;
			SceneItemActorComponent actorComp2 = this.ActorComp;
			utraceBaseElement.WorldContextObject = ((actorComp2 != null) ? actorComp2.Owner : null);
			TraceElementCommon.Instance.SetStartLocation(lineTrace, start);
			TraceElementCommon.Instance.SetEndLocation(lineTrace, end);
			lineTrace.ActorsToIgnore.Empty(true);
			foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
			{
				lineTrace.ActorsToIgnore.Add(value);
			}
			bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "SceneItemDropItemComponent_FixBornLocation");
			UKuroHitResult hitResult = lineTrace.HitResult;
			if (showLog)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "[SceneItemDropItemComponent.FixBornLocation] 实体地面修正:检测地面结果";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("isHit", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("hitResult.bBlockingHit", hitResult.bBlockingHit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("allowStartPenetrating", allowStartPenetrating);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("hitResult.bStartPenetrating", hitResult.bStartPenetrating);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			}
			if (!flag || !hitResult.bBlockingHit)
			{
				TraceElementModel.Instance.ClearLineTrace();
				return new ValueTuple<bool, global::Vector>(false, null);
			}
			if (!allowStartPenetrating && hitResult.bStartPenetrating)
			{
				return new ValueTuple<bool, global::Vector>(false, null);
			}
			global::Vector commonHitLocation = TraceElementModel.Instance.CommonHitLocation;
			string text = "";
			int num = hitResult.Actors.Num();
			int num2 = -1;
			string item2 = "";
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, commonHitLocation);
			for (int i = 0; i < num; i++)
			{
				AActor aactor = hitResult.Actors.Get(i).Get();
				if (aactor != null && aactor.IsValid())
				{
					if (showLog)
					{
						text = text + aactor.GetName() + ", ";
					}
					if (!(aactor is ACharacter))
					{
						if (!allowStartPenetrating && (double)hitResult.TimeArray.Get(i) < 1E-08)
						{
							if (showLog)
							{
								global::Log instance3 = global::Log.Instance;
								ELogModule module3 = ELogModule.Entity;
								ELogAuthor author3 = ELogAuthor.YSQ;
								string message3 = "[SceneItemDropItemComponent.FixBornLocation] 实体地面修正:起始碰撞";
								<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray7<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("isHit", flag);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("hitResult.bBlockingHit", hitResult.bBlockingHit);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("allowStartPenetrating", allowStartPenetrating);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("hitResult.bStartPenetrating", hitResult.bStartPenetrating);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("hitResult.time", hitResult.TimeArray.Get(i));
								instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 7));
							}
							return new ValueTuple<bool, global::Vector>(false, null);
						}
						num2 = i;
						item2 = aactor.GetName();
						TraceElementCommon.Instance.GetHitLocation(hitResult, i, commonHitLocation);
						break;
					}
				}
			}
			if (showLog)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.Entity;
				ELogAuthor author4 = ELogAuthor.YSQ;
				string message4 = "[SceneItemDropItemComponent.FixBornLocation] 实体地面修正:射线碰到地面";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Actors", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("HitLocationIndex", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("HitLocationName", item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 5) = new ValueTuple<string, object>("经过修正的位置", commonHitLocation);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 6));
			}
			TraceElementModel.Instance.ClearLineTrace();
			return new ValueTuple<bool, global::Vector>(true, commonHitLocation);
		}

		// Token: 0x0603C777 RID: 247671 RVA: 0x011476EC File Offset: 0x011458EC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDropItemComponent sceneItemDropItemComponent = (SceneItemDropItemComponent)componentTemplate;
			if (sceneItemDropItemComponent.CreatureData == null)
			{
				this.CreatureData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureData), "CreatureData"))
			{
				return false;
			}
			if (sceneItemDropItemComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			this.DropDownIsStarted = sceneItemDropItemComponent.DropDownIsStarted;
			this.DropDownCanRun = sceneItemDropItemComponent.DropDownCanRun;
			this.ProgressEffect = sceneItemDropItemComponent.ProgressEffect;
			if (sceneItemDropItemComponent.ItemData == null)
			{
				this.ItemData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ItemData), "ItemData"))
			{
				return false;
			}
			if (sceneItemDropItemComponent.DropStateFunctionMap == null)
			{
				this.DropStateFunctionMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DropStateFunctionMap), "DropStateFunctionMap"))
			{
				return false;
			}
			if (sceneItemDropItemComponent.OnEntityDieAnimationEnd == null)
			{
				this.OnEntityDieAnimationEnd = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnEntityDieAnimationEnd), "OnEntityDieAnimationEnd"))
			{
				return false;
			}
			if (sceneItemDropItemComponent.DelayHandler == null)
			{
				this.DelayHandler = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelayHandler), "DelayHandler"))
			{
				return false;
			}
			return sceneItemDropItemComponent.PreFrameLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.PreFrameLocation), "PreFrameLocation");
		}

		// Token: 0x17007237 RID: 29239
		// (get) Token: 0x0603C778 RID: 247672 RVA: 0x01147854 File Offset: 0x01145A54
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007238 RID: 29240
		// (get) Token: 0x0603C779 RID: 247673 RVA: 0x01147857 File Offset: 0x01145A57
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007239 RID: 29241
		// (get) Token: 0x0603C77A RID: 247674 RVA: 0x0114785A File Offset: 0x01145A5A
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700723A RID: 29242
		// (get) Token: 0x0603C77B RID: 247675 RVA: 0x0114785D File Offset: 0x01145A5D
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700723B RID: 29243
		// (get) Token: 0x0603C77C RID: 247676 RVA: 0x01147860 File Offset: 0x01145A60
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700723C RID: 29244
		// (get) Token: 0x0603C77D RID: 247677 RVA: 0x01147863 File Offset: 0x01145A63
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700723D RID: 29245
		// (get) Token: 0x0603C77E RID: 247678 RVA: 0x01147866 File Offset: 0x01145A66
		public override bool NeedForceTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020075 RID: 131189
		private const float FIX_SPAWN_TRACE_HEIGHT = -60f;

		// Token: 0x04020076 RID: 131190
		private const string PROFILE_KEY = "SceneItemDropItemComponent_FixBornLocation";

		// Token: 0x04020077 RID: 131191
		private const float LINEARDAMPING = 0f;

		// Token: 0x04020078 RID: 131192
		private const float ANGULARDAMPING = 0f;

		// Token: 0x04020079 RID: 131193
		private const float CHECK_WATER_OFFSET_Z = 10f;

		// Token: 0x0402007A RID: 131194
		private static readonly FName COLLISION_PROFILE_NAME = new FName("DropItem");

		// Token: 0x0402007B RID: 131195
		private const string PICKUP_AUDIO_EVENT_NAME = "play_ui_fb_pickup";

		// Token: 0x0402007C RID: 131196
		private const string PHYSICAL_MATERIAL_PATH = "/Game/Aki/Scene/PhysMaterial/PM_DropItem.PM_DropItem";

		// Token: 0x0402007D RID: 131197
		private const string PARABOLIC_EFFECT = "/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_Xingxing_001.DA_Fx_Xingxing_001";

		// Token: 0x0402007E RID: 131198
		[StaticVariableRuleIgnore]
		private static readonly string[] BORN_EFFECTS = new string[]
		{
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Diaoluo_001.DA_Fx_UI_Sence_Diaoluo_001",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Diaoluo_002.DA_Fx_UI_Sence_Diaoluo_002",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Diaoluo_003.DA_Fx_UI_Sence_Diaoluo_003",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Diaoluo_004.DA_Fx_UI_Sence_Diaoluo_004",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Diaoluo_005.DA_Fx_UI_Sence_Diaoluo_005"
		};

		// Token: 0x0402007F RID: 131199
		[StaticVariableRuleIgnore]
		private static readonly string[] TRAIL_EFFECTS = new string[]
		{
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Trail_001.DA_Fx_UI_Sence_Trail_001",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Trail_002.DA_Fx_UI_Sence_Trail_002",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Trail_003.DA_Fx_UI_Sence_Trail_003",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Trail_004.DA_Fx_UI_Sence_Trail_004",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Trail_005.DA_Fx_UI_Sence_Trail_005"
		};

		// Token: 0x04020080 RID: 131200
		[StaticVariableRuleIgnore]
		private static readonly string[] DESTROY_EFFECTS = new string[]
		{
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Xiaosan_001.DA_Fx_UI_Sence_Xiaosan_001",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Xiaosan_002.DA_Fx_UI_Sence_Xiaosan_002",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Xiaosan_003.DA_Fx_UI_Sence_Xiaosan_003",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Xiaosan_004.DA_Fx_UI_Sence_Xiaosan_004",
			"/Game/Aki/Effect/DataAsset/Niagara/BigWorld/DA_Fx_UI_Sence_Xiaosan_005.DA_Fx_UI_Sence_Xiaosan_005"
		};

		// Token: 0x04020081 RID: 131201
		[Nullable(2)]
		private CreatureDataComponent CreatureData;

		// Token: 0x04020082 RID: 131202
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x04020083 RID: 131203
		private bool DropDownIsStarted;

		// Token: 0x04020084 RID: 131204
		private bool DropDownCanRun;

		// Token: 0x04020085 RID: 131205
		private int ProgressEffect;

		// Token: 0x04020086 RID: 131206
		[Nullable(2)]
		private DropItemData ItemData;

		// Token: 0x04020087 RID: 131207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EDropStateType, Action<float>> DropStateFunctionMap;

		// Token: 0x04020088 RID: 131208
		[Nullable(2)]
		private Action<int> OnEntityDieAnimationEnd;

		// Token: 0x04020089 RID: 131209
		[Nullable(2)]
		private TimerHandle DelayHandler;

		// Token: 0x0402008A RID: 131210
		[StaticVariableRuleIgnore]
		private static readonly global::Vector TempVector = global::Vector.Create();

		// Token: 0x0402008B RID: 131211
		private readonly global::Vector PreFrameLocation = global::Vector.Create();
	}
}
