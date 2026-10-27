using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007170 RID: 29040
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBuffProducerComponent : EntityComponent
	{
		// Token: 0x06046E6F RID: 290415 RVA: 0x011E5CC8 File Offset: 0x011E3EC8
		protected override bool OnInitData(IEntityArgs args = null)
		{
			BuffProducerComponent buffProducerComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemBuffProducerComponent>() as BuffProducerComponent;
			this.Config = buffProducerComponent;
			this.BuffId = buffProducerComponent.BuffId;
			switch (buffProducerComponent.AddBuffMode.Type)
			{
			case EBuffProducerMode.Adsorb:
				this.Direction = global::Vector.Create();
				this.LocationCache = global::Vector.Create();
				break;
			case EBuffProducerMode.FireBullet:
			{
				IFireBulletAddBuff fireBulletAddBuff = buffProducerComponent.AddBuffMode as IFireBulletAddBuff;
				this.BulletId = fireBulletAddBuff.BulletId.ToString();
				this.BulletOffset = global::Vector.Create((double)fireBulletAddBuff.BulletOffset.X.GetValueOrDefault(), (double)fireBulletAddBuff.BulletOffset.Y.GetValueOrDefault(), (double)fireBulletAddBuff.BulletOffset.Z.GetValueOrDefault());
				break;
			}
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			EntityComponentPb entityComponentPb = (component != null) ? component.ComponentDataMap.GetValueOrDefault("BuffProducerComponentPb") : null;
			long? contextMessageId;
			if (entityComponentPb == null)
			{
				contextMessageId = null;
			}
			else
			{
				BuffProducerComponentPb buffProducerComponentPb = entityComponentPb.BuffProducerComponentPb;
				contextMessageId = ((buffProducerComponentPb != null) ? new long?(buffProducerComponentPb.ContextId) : null);
			}
			this.ContextMessageId = contextMessageId;
			return true;
		}

		// Token: 0x06046E70 RID: 290416 RVA: 0x011E5DF8 File Offset: 0x011E3FF8
		protected unsafe override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.CJH, "[BuffProducerComp] 组件初始化失败 Actor Component Undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.ConfigId = this.ActorComp.CreatureData.GetPbDataId();
			this.CommonTagComp = base.Entity.GetComponent<LevelTagComponent>();
			if (this.CommonTagComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "[BuffProducerComp] 组件初始化失败 实体缺少LevelTagComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			if (this.StateComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneGameplay;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[BuffProducerComp] 组件初始化失败 实体缺少SceneItemStateComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return false;
			}
			this.IsInRange = true;
			this.WorldOwner = true;
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int worldOwner = CreatureModel.Instance.GetWorldOwner();
				if (!(id.GetValueOrDefault() == worldOwner & id != null))
				{
					this.WorldOwner = false;
					return true;
				}
			}
			this.RangeComp = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
			if (this.RangeComp != null)
			{
				this.IsInRange = false;
				this.RangeComp.AddOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerTriggerCallback));
			}
			this.SelfState = this.StateComp.State;
			this.AddEvents();
			return true;
		}

		// Token: 0x06046E71 RID: 290417 RVA: 0x011E6066 File Offset: 0x011E4266
		protected override void OnActivate()
		{
			if (!this.StateComp.IsInState(SceneItemStateComponent.ESceneItemState.Born))
			{
				this.OnSceneItemStateChange();
			}
		}

		// Token: 0x06046E72 RID: 290418 RVA: 0x011E607C File Offset: 0x011E427C
		protected override void OnTick(float delta)
		{
			if (!this.WorldOwner || this.SelfState != SceneItemStateComponent.ESceneItemState.Active)
			{
				return;
			}
			if (this.IsInPerformance)
			{
				this.OnPerformanceUpdate(delta);
				return;
			}
			if (!this.IsInRange)
			{
				this.UndoApplyBuffToPlayer();
			}
		}

		// Token: 0x06046E73 RID: 290419 RVA: 0x011E60AE File Offset: 0x011E42AE
		protected override bool OnEnd()
		{
			if (this.RangeComp != null)
			{
				this.RangeComp.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerTriggerCallback));
			}
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06046E74 RID: 290420 RVA: 0x011E60D6 File Offset: 0x011E42D6
		private void AddEvents()
		{
			if (this.EventsInited)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			this.EventsInited = true;
		}

		// Token: 0x06046E75 RID: 290421 RVA: 0x011E610A File Offset: 0x011E430A
		private void RemoveEvents()
		{
			if (!this.EventsInited)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			this.EventsInited = false;
		}

		// Token: 0x06046E76 RID: 290422 RVA: 0x011E613E File Offset: 0x011E433E
		private void OnPlayerTriggerCallback(bool isEnter)
		{
			this.IsInRange = isEnter;
			if (!this.WorldOwner || this.SelfState != SceneItemStateComponent.ESceneItemState.Active)
			{
				return;
			}
			if (!this.IsInRange)
			{
				this.UndoApplyBuffToPlayer();
			}
		}

		// Token: 0x06046E77 RID: 290423 RVA: 0x011E6167 File Offset: 0x011E4367
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.OnSceneItemStateChange();
		}

		// Token: 0x06046E78 RID: 290424 RVA: 0x011E6170 File Offset: 0x011E4370
		private void OnSceneItemStateChange()
		{
			if (!this.WorldOwner)
			{
				return;
			}
			this.SelfState = this.StateComp.State;
			SceneItemStateComponent.ESceneItemState state = this.StateComp.State;
			if (state != SceneItemStateComponent.ESceneItemState.Normal)
			{
				if (state == SceneItemStateComponent.ESceneItemState.Active && !this.CheckPlayerHasBuff())
				{
					this.IsInPerformance = true;
					return;
				}
			}
			else
			{
				this.UndoApplyBuffToPlayer();
			}
		}

		// Token: 0x06046E79 RID: 290425 RVA: 0x011E61C4 File Offset: 0x011E43C4
		private void OnPerformanceUpdate(float delta)
		{
			BuffProducerComponent config = this.Config;
			EBuffProducerMode? ebuffProducerMode = (config != null) ? new EBuffProducerMode?(config.AddBuffMode.Type) : null;
			if (ebuffProducerMode != null)
			{
				switch (ebuffProducerMode.GetValueOrDefault())
				{
				case EBuffProducerMode.Immediate:
					this.OnPerformanceComplete();
					return;
				case EBuffProducerMode.Adsorb:
					this.FlyToPlayer(delta);
					return;
				case EBuffProducerMode.FireBullet:
					this.CreateBullet(delta);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06046E7A RID: 290426 RVA: 0x011E6230 File Offset: 0x011E4430
		private void OnPerformanceComplete()
		{
			this.IsInPerformance = false;
			this.ApplyBuffToPlayer();
		}

		// Token: 0x06046E7B RID: 290427 RVA: 0x011E6240 File Offset: 0x011E4440
		private bool CheckPlayerHasBuff()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return false;
			}
			Entity entity = baseCharacter.CharacterActorComponent.Entity;
			CharacterBuffComponent characterBuffComponent = entity.CheckGetComponent<CharacterBuffComponent>();
			if (characterBuffComponent == null)
			{
				return false;
			}
			bool flag = characterBuffComponent.GetBuffTotalStackById(this.BuffId, false) > 0;
			RoleBuffComponent roleBuffComponent = entity.CheckGetComponent<RoleBuffComponent>();
			if (roleBuffComponent != null)
			{
				bool flag2;
				if (!flag)
				{
					PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
					flag2 = (((formationBuffComp != null) ? formationBuffComp.GetBuffTotalStackById(this.BuffId, false) : 0) > 0);
				}
				else
				{
					flag2 = true;
				}
				flag = flag2;
			}
			return flag;
		}

		// Token: 0x06046E7C RID: 290428 RVA: 0x011E62B2 File Offset: 0x011E44B2
		private void UndoApplyBuffToPlayer()
		{
			if (this.IsBusyOperatingBuff || !this.CheckPlayerHasBuff())
			{
				return;
			}
			this.IsBusyOperatingBuff = true;
			SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.UndoBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
		}

		// Token: 0x06046E7D RID: 290429 RVA: 0x011E62EE File Offset: 0x011E44EE
		private void ApplyBuffToPlayer()
		{
			if (this.IsBusyOperatingBuff || this.CheckPlayerHasBuff())
			{
				return;
			}
			this.IsBusyOperatingBuff = true;
			SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.AddBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
		}

		// Token: 0x06046E7E RID: 290430 RVA: 0x011E632A File Offset: 0x011E452A
		private void OnBuffOperateCallBack(BuffOperateType type, bool isSuccess)
		{
			this.IsBusyOperatingBuff = false;
		}

		// Token: 0x06046E7F RID: 290431 RVA: 0x011E6334 File Offset: 0x011E4534
		private void FlyToPlayer(float delta)
		{
			if (Global.BaseCharacter == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
			AActor owner = this.ActorComp.Owner;
			if (owner != null && owner.IsValid())
			{
				AActor owner2 = characterActorComponent.Owner;
				if (owner2 != null && owner2.IsValid())
				{
					float num = delta * 0.001f;
					global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
					characterActorComponent.ActorLocationProxy.Subtraction(actorLocationProxy, this.Direction);
					if (this.Direction.SizeSquared() < 100.0)
					{
						Aki.Protocol.Vector initLocation = this.ActorComp.CreatureData.GetInitLocation();
						this.LocationCache.X = (double)initLocation.X;
						this.LocationCache.Y = (double)initLocation.Y;
						this.LocationCache.Z = (double)initLocation.Z;
						this.ActorComp.SetActorLocation(this.LocationCache.ToUeVector(false), "unknown", true);
						this.Direction.DeepCopy(global::Vector.ZeroVectorProxy);
						this.LocationCache.DeepCopy(global::Vector.ZeroVectorProxy);
						this.OnPerformanceComplete();
						return;
					}
					this.Direction.Normalize(0.009999999776482582);
					this.Direction.MultiplyEqual((double)(600f * num));
					this.LocationCache.DeepCopy(this.ActorComp.ActorLocationProxy);
					this.LocationCache.AdditionEqual(this.Direction);
					this.ActorComp.SetActorLocation(this.LocationCache.ToUeVector(false), "unknown", true);
					return;
				}
			}
		}

		// Token: 0x06046E80 RID: 290432 RVA: 0x011E64C4 File Offset: 0x011E46C4
		private void CreateBullet(float delta)
		{
			if (string.IsNullOrEmpty(this.BulletId))
			{
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			FTransformDouble actorTransform = this.ActorComp.ActorTransform;
			FQuat rotation = actorTransform.GetRotation();
			FVectorDouble fvectorDouble = actorTransform.GetTranslation();
			FVector scale3D = actorTransform.GetScale3D();
			FTransformDouble value = new FTransformDouble(ref rotation, ref fvectorDouble, ref scale3D);
			global::Vector vector = global::Vector.Create();
			global::Vector vector2 = vector;
			rotation = actorTransform.GetRotation();
			fvectorDouble = this.BulletOffset.ToUeVector(false);
			FVectorDouble fvectorDouble2 = rotation.RotateVectorDouble(fvectorDouble);
			vector2.DeepCopy(fvectorDouble2);
			fvectorDouble = vector.ToUeVector(false);
			value.AddToTranslation(fvectorDouble);
			this.BulletEntity = BulletController.Instance.CreateBulletCustomTarget(characterActorComponent.Actor, this.BulletId, new FTransformDouble?(value), new BulletController.BulletCreateParams(), this.ContextMessageId, global::EBulletCreateSource.Others);
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnBulletTimeOut), 5000f, null, null, true, 1f);
			EventSystem.Instance.AddWithTarget<global::HitInformation, IAttributeSet>(this.BulletEntity, EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit));
			this.IsInPerformance = false;
		}

		// Token: 0x06046E81 RID: 290433 RVA: 0x011E65E8 File Offset: 0x011E47E8
		[NullableContext(1)]
		private void OnBulletHit(global::HitInformation hitData, [Nullable(2)] IAttributeSet attackerAttribute)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			Entity entity = baseCharacter.CharacterActorComponent.Entity;
			if (hitData.Target == entity)
			{
				if (this.TimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.TimerHandle);
					this.TimerHandle = null;
				}
				EventSystem.Instance.RemoveWithTarget<global::HitInformation, IAttributeSet>(this.BulletEntity, EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit));
				this.BulletEntity = null;
				this.OnPerformanceComplete();
			}
		}

		// Token: 0x06046E82 RID: 290434 RVA: 0x011E6664 File Offset: 0x011E4864
		private void OnBulletTimeOut(float delta)
		{
			if (EventSystem.Instance.HasWithTarget<global::HitInformation, IAttributeSet>(this.BulletEntity, EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit)))
			{
				EventSystem.Instance.RemoveWithTarget<global::HitInformation, IAttributeSet>(this.BulletEntity, EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnBulletHit));
			}
			this.TimerHandle = null;
			this.BulletEntity = null;
			this.OnPerformanceComplete();
		}

		// Token: 0x06046E83 RID: 290435 RVA: 0x011E66CC File Offset: 0x011E48CC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBuffProducerComponent sceneItemBuffProducerComponent = (SceneItemBuffProducerComponent)componentTemplate;
			if (base.CanResetComponentProperty("ConfigId"))
			{
				this.ConfigId = sceneItemBuffProducerComponent.ConfigId;
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemBuffProducerComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CommonTagComp"))
			{
				if (sceneItemBuffProducerComponent.CommonTagComp == null)
				{
					this.CommonTagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.CommonTagComp), "CommonTagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (sceneItemBuffProducerComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (sceneItemBuffProducerComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInPerformance"))
			{
				this.IsInPerformance = sceneItemBuffProducerComponent.IsInPerformance;
			}
			if (base.CanResetComponentProperty("IsBusyOperatingBuff"))
			{
				this.IsBusyOperatingBuff = sceneItemBuffProducerComponent.IsBusyOperatingBuff;
			}
			if (base.CanResetComponentProperty("SelfState"))
			{
				this.SelfState = sceneItemBuffProducerComponent.SelfState;
			}
			if (base.CanResetComponentProperty("IsInRange"))
			{
				this.IsInRange = sceneItemBuffProducerComponent.IsInRange;
			}
			if (base.CanResetComponentProperty("EventsInited"))
			{
				this.EventsInited = sceneItemBuffProducerComponent.EventsInited;
			}
			if (base.CanResetComponentProperty("WorldOwner"))
			{
				this.WorldOwner = sceneItemBuffProducerComponent.WorldOwner;
			}
			if (base.CanResetComponentProperty("BuffId"))
			{
				this.BuffId = sceneItemBuffProducerComponent.BuffId;
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemBuffProducerComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BuffProducerComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ContextMessageId"))
			{
				this.ContextMessageId = sceneItemBuffProducerComponent.ContextMessageId;
			}
			if (base.CanResetComponentProperty("Direction"))
			{
				if (sceneItemBuffProducerComponent.Direction == null)
				{
					this.Direction = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.Direction), "Direction"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LocationCache"))
			{
				if (sceneItemBuffProducerComponent.LocationCache == null)
				{
					this.LocationCache = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LocationCache), "LocationCache"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BulletOffset"))
			{
				if (sceneItemBuffProducerComponent.BulletOffset == null)
				{
					this.BulletOffset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.BulletOffset), "BulletOffset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BulletId"))
			{
				this.BulletId = sceneItemBuffProducerComponent.BulletId;
			}
			if (base.CanResetComponentProperty("BulletEntity"))
			{
				if (sceneItemBuffProducerComponent.BulletEntity == null)
				{
					this.BulletEntity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.BulletEntity), "BulletEntity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TimerHandle"))
			{
				if (sceneItemBuffProducerComponent.TimerHandle == null)
				{
					this.TimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TimerHandle), "TimerHandle"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0402538A RID: 152458
		private const float DISTANCE_THRESHOLD = 100f;

		// Token: 0x0402538B RID: 152459
		private const float NORMALIZE = 0.01f;

		// Token: 0x0402538C RID: 152460
		private const float SPEED = 600f;

		// Token: 0x0402538D RID: 152461
		private const int MAX_BULLET_HIT_TIME = 5000;

		// Token: 0x0402538E RID: 152462
		private int ConfigId;

		// Token: 0x0402538F RID: 152463
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025390 RID: 152464
		private LevelTagComponent CommonTagComp;

		// Token: 0x04025391 RID: 152465
		private SceneItemStateComponent StateComp;

		// Token: 0x04025392 RID: 152466
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x04025393 RID: 152467
		private bool IsInPerformance;

		// Token: 0x04025394 RID: 152468
		private bool IsBusyOperatingBuff;

		// Token: 0x04025395 RID: 152469
		private SceneItemStateComponent.ESceneItemState SelfState = SceneItemStateComponent.ESceneItemState.Normal;

		// Token: 0x04025396 RID: 152470
		private bool IsInRange = true;

		// Token: 0x04025397 RID: 152471
		private bool EventsInited;

		// Token: 0x04025398 RID: 152472
		private bool WorldOwner;

		// Token: 0x04025399 RID: 152473
		private long BuffId;

		// Token: 0x0402539A RID: 152474
		private BuffProducerComponent Config;

		// Token: 0x0402539B RID: 152475
		private long? ContextMessageId;

		// Token: 0x0402539C RID: 152476
		private global::Vector Direction;

		// Token: 0x0402539D RID: 152477
		private global::Vector LocationCache;

		// Token: 0x0402539E RID: 152478
		private global::Vector BulletOffset;

		// Token: 0x0402539F RID: 152479
		[Nullable(1)]
		private string BulletId = "";

		// Token: 0x040253A0 RID: 152480
		private Entity BulletEntity;

		// Token: 0x040253A1 RID: 152481
		private TimerHandle TimerHandle;
	}
}
