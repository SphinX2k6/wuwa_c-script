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
	// Token: 0x02006224 RID: 25124
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBuffProducerComponent : EntityComponent
	{
		// Token: 0x0603C6CF RID: 247503 RVA: 0x01141318 File Offset: 0x0113F518
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

		// Token: 0x0603C6D0 RID: 247504 RVA: 0x01141448 File Offset: 0x0113F648
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

		// Token: 0x0603C6D1 RID: 247505 RVA: 0x011416B6 File Offset: 0x0113F8B6
		protected override void OnActivate()
		{
			if (!this.StateComp.IsInState(SceneItemStateComponent.ESceneItemState.Born))
			{
				this.OnSceneItemStateChange();
			}
		}

		// Token: 0x0603C6D2 RID: 247506 RVA: 0x011416CC File Offset: 0x0113F8CC
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

		// Token: 0x0603C6D3 RID: 247507 RVA: 0x011416FE File Offset: 0x0113F8FE
		protected override bool OnEnd()
		{
			if (this.RangeComp != null)
			{
				this.RangeComp.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerTriggerCallback));
			}
			this.RemoveEvents();
			return true;
		}

		// Token: 0x0603C6D4 RID: 247508 RVA: 0x01141726 File Offset: 0x0113F926
		private void AddEvents()
		{
			if (this.EventsInited)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			this.EventsInited = true;
		}

		// Token: 0x0603C6D5 RID: 247509 RVA: 0x0114175A File Offset: 0x0113F95A
		private void RemoveEvents()
		{
			if (!this.EventsInited)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			this.EventsInited = false;
		}

		// Token: 0x0603C6D6 RID: 247510 RVA: 0x0114178E File Offset: 0x0113F98E
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

		// Token: 0x0603C6D7 RID: 247511 RVA: 0x011417B7 File Offset: 0x0113F9B7
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.OnSceneItemStateChange();
		}

		// Token: 0x0603C6D8 RID: 247512 RVA: 0x011417C0 File Offset: 0x0113F9C0
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

		// Token: 0x0603C6D9 RID: 247513 RVA: 0x01141814 File Offset: 0x0113FA14
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

		// Token: 0x0603C6DA RID: 247514 RVA: 0x01141880 File Offset: 0x0113FA80
		private void OnPerformanceComplete()
		{
			this.IsInPerformance = false;
			this.ApplyBuffToPlayer();
		}

		// Token: 0x0603C6DB RID: 247515 RVA: 0x01141890 File Offset: 0x0113FA90
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

		// Token: 0x0603C6DC RID: 247516 RVA: 0x01141902 File Offset: 0x0113FB02
		private void UndoApplyBuffToPlayer()
		{
			if (this.IsBusyOperatingBuff || !this.CheckPlayerHasBuff())
			{
				return;
			}
			this.IsBusyOperatingBuff = true;
			SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.UndoBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
		}

		// Token: 0x0603C6DD RID: 247517 RVA: 0x0114193E File Offset: 0x0113FB3E
		private void ApplyBuffToPlayer()
		{
			if (this.IsBusyOperatingBuff || this.CheckPlayerHasBuff())
			{
				return;
			}
			this.IsBusyOperatingBuff = true;
			SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.AddBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
		}

		// Token: 0x0603C6DE RID: 247518 RVA: 0x0114197A File Offset: 0x0113FB7A
		private void OnBuffOperateCallBack(BuffOperateType type, bool isSuccess)
		{
			this.IsBusyOperatingBuff = false;
		}

		// Token: 0x0603C6DF RID: 247519 RVA: 0x01141984 File Offset: 0x0113FB84
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

		// Token: 0x0603C6E0 RID: 247520 RVA: 0x01141B14 File Offset: 0x0113FD14
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

		// Token: 0x0603C6E1 RID: 247521 RVA: 0x01141C38 File Offset: 0x0113FE38
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

		// Token: 0x0603C6E2 RID: 247522 RVA: 0x01141CB4 File Offset: 0x0113FEB4
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

		// Token: 0x0603C6E3 RID: 247523 RVA: 0x01141D1C File Offset: 0x0113FF1C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBuffProducerComponent sceneItemBuffProducerComponent = (SceneItemBuffProducerComponent)componentTemplate;
			this.ConfigId = sceneItemBuffProducerComponent.ConfigId;
			if (sceneItemBuffProducerComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.CommonTagComp == null)
			{
				this.CommonTagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommonTagComp), "CommonTagComp"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			this.IsInPerformance = sceneItemBuffProducerComponent.IsInPerformance;
			this.IsBusyOperatingBuff = sceneItemBuffProducerComponent.IsBusyOperatingBuff;
			this.SelfState = sceneItemBuffProducerComponent.SelfState;
			this.IsInRange = sceneItemBuffProducerComponent.IsInRange;
			this.EventsInited = sceneItemBuffProducerComponent.EventsInited;
			this.WorldOwner = sceneItemBuffProducerComponent.WorldOwner;
			this.BuffId = sceneItemBuffProducerComponent.BuffId;
			if (sceneItemBuffProducerComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			this.ContextMessageId = sceneItemBuffProducerComponent.ContextMessageId;
			if (sceneItemBuffProducerComponent.Direction == null)
			{
				this.Direction = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Direction), "Direction"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.LocationCache == null)
			{
				this.LocationCache = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LocationCache), "LocationCache"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.BulletOffset == null)
			{
				this.BulletOffset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletOffset), "BulletOffset"))
			{
				return false;
			}
			this.BulletId = sceneItemBuffProducerComponent.BulletId;
			if (sceneItemBuffProducerComponent.BulletEntity == null)
			{
				this.BulletEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletEntity), "BulletEntity"))
			{
				return false;
			}
			if (sceneItemBuffProducerComponent.TimerHandle == null)
			{
				this.TimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimerHandle), "TimerHandle"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700721F RID: 29215
		// (get) Token: 0x0603C6E4 RID: 247524 RVA: 0x01141F62 File Offset: 0x01140162
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007220 RID: 29216
		// (get) Token: 0x0603C6E5 RID: 247525 RVA: 0x01141F65 File Offset: 0x01140165
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007221 RID: 29217
		// (get) Token: 0x0603C6E6 RID: 247526 RVA: 0x01141F68 File Offset: 0x01140168
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007222 RID: 29218
		// (get) Token: 0x0603C6E7 RID: 247527 RVA: 0x01141F6B File Offset: 0x0114016B
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FFF1 RID: 131057
		private const float DISTANCE_THRESHOLD = 100f;

		// Token: 0x0401FFF2 RID: 131058
		private const float NORMALIZE = 0.01f;

		// Token: 0x0401FFF3 RID: 131059
		private const float SPEED = 600f;

		// Token: 0x0401FFF4 RID: 131060
		private const int MAX_BULLET_HIT_TIME = 5000;

		// Token: 0x0401FFF5 RID: 131061
		private int ConfigId;

		// Token: 0x0401FFF6 RID: 131062
		private SceneItemActorComponent ActorComp;

		// Token: 0x0401FFF7 RID: 131063
		private LevelTagComponent CommonTagComp;

		// Token: 0x0401FFF8 RID: 131064
		private SceneItemStateComponent StateComp;

		// Token: 0x0401FFF9 RID: 131065
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0401FFFA RID: 131066
		private bool IsInPerformance;

		// Token: 0x0401FFFB RID: 131067
		private bool IsBusyOperatingBuff;

		// Token: 0x0401FFFC RID: 131068
		private SceneItemStateComponent.ESceneItemState SelfState = SceneItemStateComponent.ESceneItemState.Normal;

		// Token: 0x0401FFFD RID: 131069
		private bool IsInRange = true;

		// Token: 0x0401FFFE RID: 131070
		private bool EventsInited;

		// Token: 0x0401FFFF RID: 131071
		private bool WorldOwner;

		// Token: 0x04020000 RID: 131072
		private long BuffId;

		// Token: 0x04020001 RID: 131073
		private BuffProducerComponent Config;

		// Token: 0x04020002 RID: 131074
		private long? ContextMessageId;

		// Token: 0x04020003 RID: 131075
		private global::Vector Direction;

		// Token: 0x04020004 RID: 131076
		private global::Vector LocationCache;

		// Token: 0x04020005 RID: 131077
		private global::Vector BulletOffset;

		// Token: 0x04020006 RID: 131078
		[Nullable(1)]
		private string BulletId = "";

		// Token: 0x04020007 RID: 131079
		private Entity BulletEntity;

		// Token: 0x04020008 RID: 131080
		private TimerHandle TimerHandle;
	}
}
