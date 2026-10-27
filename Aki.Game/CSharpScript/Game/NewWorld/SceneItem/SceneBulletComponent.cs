using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VehicleStream.StateMachineContainer;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200716A RID: 29034
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneBulletComponent : EntityComponent
	{
		// Token: 0x06046DEB RID: 290283 RVA: 0x011DFD00 File Offset: 0x011DDF00
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CacheRange = global::Vector.Create(0.0, 0.0, 0.0);
			this.CacheOffset = global::Vector.Create(0.0, 0.0, 0.0);
			this.BulletState = new Dictionary<int, List<BulletData>>();
			SceneBulletComponent sceneBulletComponent = args.GetP1<CreateEntityData>().GetParam<SceneBulletComponent>() as SceneBulletComponent;
			foreach (ISceneBulletGroup sceneBulletGroup in sceneBulletComponent.BulletGroups)
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(sceneBulletGroup.EntityState);
				if (!this.BulletState.ContainsKey(tagIdByName))
				{
					this.BulletState[tagIdByName] = new List<BulletData>();
				}
				this.BulletState.GetValueOrDefault(tagIdByName).Add(new BulletData(sceneBulletGroup, global::Transform.Create()));
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			EntityComponentPb entityComponentPb = (component != null) ? component.ComponentDataMap.GetValueOrDefault("EntityBulletComponentPb") : null;
			long? contextMessageId;
			if (entityComponentPb == null)
			{
				contextMessageId = null;
			}
			else
			{
				EntityBulletComponentPb entityBulletComponentPb = entityComponentPb.EntityBulletComponentPb;
				contextMessageId = ((entityBulletComponentPb != null) ? new long?(entityBulletComponentPb.ContextId) : null);
			}
			this.ContextMessageId = contextMessageId;
			this.DisableGenerateByRange = sceneBulletComponent.DisableGenerateByRange.GetValueOrDefault();
			this.RoadNetworkComp = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent>();
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState));
			return true;
		}

		// Token: 0x06046DEC RID: 290284 RVA: 0x011DFEA0 File Offset: 0x011DE0A0
		protected override bool OnStart()
		{
			CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent component = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
			if (!this.DisableGenerateByRange && component != null)
			{
				this.RangeComp = component;
				this.RangeComp.AddOnEntityOverlapCallback(new Action<bool, EntityHandle>(this.OnEntityTrigger));
			}
			else
			{
				this.IsPermanentBullet = true;
			}
			LevelTagComponent component2 = base.Entity.GetComponent<LevelTagComponent>();
			foreach (int num in this.BulletState.Keys)
			{
				if (component2.HasTag(num))
				{
					this.CurrentState = num;
					break;
				}
			}
			return true;
		}

		// Token: 0x06046DED RID: 290285 RVA: 0x011DFF50 File Offset: 0x011DE150
		protected override void OnActivate()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.IsInitComplete = true;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) != null && GameModeModel.Instance.WorldDone)
			{
				if (this.IsPermanentBullet)
				{
					this.CreateBullets(this.CurrentState);
					return;
				}
			}
			else if (this.IsPermanentBullet)
			{
				EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
		}

		// Token: 0x06046DEE RID: 290286 RVA: 0x011DFFCD File Offset: 0x011DE1CD
		private void OnWorldDone()
		{
			this.CreateBullets(this.CurrentState);
		}

		// Token: 0x06046DEF RID: 290287 RVA: 0x011DFFDC File Offset: 0x011DE1DC
		[NullableContext(1)]
		private void OnEntityTrigger(bool isEnter, EntityHandle handle)
		{
			WorldEntity entity = handle.Entity;
			if (!this.IsInitComplete || entity == null)
			{
				return;
			}
			if (entity.GetComponent<CharacterHitComponent>() == null && entity.GetComponent<SceneItemHitComponent>() == null)
			{
				return;
			}
			this.IsEnterTrigger = isEnter;
			if (!isEnter)
			{
				foreach (int state in this.BulletState.Keys)
				{
					this.DestroyBullets(state);
				}
				return;
			}
			this.CreateBullets(this.CurrentState);
		}

		// Token: 0x06046DF0 RID: 290288 RVA: 0x011E0070 File Offset: 0x011DE270
		protected override void OnTick(float delta)
		{
			this.ProcessTrafficBullet();
		}

		// Token: 0x06046DF1 RID: 290289 RVA: 0x011E0078 File Offset: 0x011DE278
		private void ProcessTrafficBullet()
		{
			if (!GameModeModel.Instance.WorldDone)
			{
				return;
			}
			if (this.BulletState == null || this.RoadNetworkComp == null)
			{
				return;
			}
			VehicleTeamMember vehicleTeamMember = this.RoadNetworkComp.GetVehicleTeamMember();
			if (vehicleTeamMember == null)
			{
				return;
			}
			List<BulletData> valueOrDefault = this.BulletState.GetValueOrDefault(this.CurrentState);
			if (valueOrDefault == null || valueOrDefault.Count == 0)
			{
				return;
			}
			foreach (BulletData bulletData in valueOrDefault)
			{
				ISceneBulletGroup bulletGroup = bulletData.BulletGroup;
				ITrafficBulletLogic trafficBulletLogic = (bulletGroup != null) ? bulletGroup.CustomBulletLogic : null;
				if (trafficBulletLogic != null && trafficBulletLogic.Type == ECustomBulletLogic.TrafficBullet)
				{
					bool flag = vehicleTeamMember.GetSpeed() >= trafficBulletLogic.MinSpeed;
					bool flag2 = this.RoadNetworkComp.IsInPerceptionRange();
					if (flag && flag2)
					{
						if (bulletData.BulletEntityId == null)
						{
							this.CreateBullet(bulletData);
						}
					}
					else
					{
						this.DestroyBullet(bulletData);
					}
				}
			}
		}

		// Token: 0x06046DF2 RID: 290290 RVA: 0x011E0170 File Offset: 0x011DE370
		private void CreateBullets(int state)
		{
			if (this.BulletState == null)
			{
				return;
			}
			List<BulletData> valueOrDefault = this.BulletState.GetValueOrDefault(state);
			if (valueOrDefault == null || valueOrDefault.Count == 0)
			{
				return;
			}
			foreach (BulletData bulletData in valueOrDefault)
			{
				if (bulletData.BulletEntityId == null)
				{
					ISceneBulletGroup bulletGroup = bulletData.BulletGroup;
					bool flag;
					if (bulletGroup == null)
					{
						flag = false;
					}
					else
					{
						ITrafficBulletLogic customBulletLogic = bulletGroup.CustomBulletLogic;
						ECustomBulletLogic? ecustomBulletLogic = (customBulletLogic != null) ? new ECustomBulletLogic?(customBulletLogic.Type) : null;
						ECustomBulletLogic ecustomBulletLogic2 = ECustomBulletLogic.TrafficBullet;
						flag = (ecustomBulletLogic.GetValueOrDefault() == ecustomBulletLogic2 & ecustomBulletLogic != null);
					}
					if (flag)
					{
						if (this.RoadNetworkComp == null)
						{
							continue;
						}
						VehicleTeamMember vehicleTeamMember = this.RoadNetworkComp.GetVehicleTeamMember();
						if (vehicleTeamMember == null || vehicleTeamMember.GetSpeed() < bulletData.BulletGroup.CustomBulletLogic.MinSpeed)
						{
							continue;
						}
					}
					if (this.CreateBullet(bulletData) && EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
					{
						EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
					}
				}
			}
		}

		// Token: 0x06046DF3 RID: 290291 RVA: 0x011E02A8 File Offset: 0x011DE4A8
		[NullableContext(1)]
		private unsafe bool CreateBullet(BulletData bulletData)
		{
			if (bulletData.BulletEntityId != null)
			{
				return false;
			}
			this.CreateBulletTransform(bulletData);
			ISceneBulletGroup bulletGroup = bulletData.BulletGroup;
			global::Transform bulletTransform = bulletData.BulletTransform;
			BulletController.BulletCreateParams bulletCreateParams = null;
			if (bulletGroup.Range != null)
			{
				this.CacheRange.Set((double)bulletGroup.Range.X.GetValueOrDefault(), (double)bulletGroup.Range.Y.GetValueOrDefault(), (double)bulletGroup.Range.Z.GetValueOrDefault());
				bulletCreateParams = new BulletController.BulletCreateParams
				{
					Size = this.CacheRange
				};
			}
			EntityHandle sceneBulletOwner = BulletController.Instance.GetSceneBulletOwner();
			if (sceneBulletOwner == null || !sceneBulletOwner.IsInit)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "Bullet生成错误, 找不到场景子弹owner";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityID", base.Entity.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(sceneBulletOwner.Entity, bulletGroup.BulletId.ToString(), new FTransformDouble?(bulletTransform.ToUeTransform()), bulletCreateParams ?? new BulletController.BulletCreateParams(), this.ContextMessageId, global::EBulletCreateSource.Others);
			object obj;
			if (bulletEntity == null)
			{
				obj = null;
			}
			else
			{
				BulletActorComponent component = bulletEntity.GetComponent<BulletActorComponent>();
				obj = ((component != null) ? component.Owner : null);
			}
			object obj2 = obj;
			if (obj2 != null && obj2.IsValid())
			{
				EAttachmentRule value = EAttachmentRule.KeepWorld;
				BulletActionInfoAttachActor bulletActionInfoAttachActor = BulletController.Instance.GetActionCenter().CreateBulletActionInfo(EBulletAction.AttachActor) as BulletActionInfoAttachActor;
				bulletActionInfoAttachActor.IsParentActor = true;
				bulletActionInfoAttachActor.Actor = this.ActorComp.Owner;
				bulletActionInfoAttachActor.LocationRule = new EAttachmentRule?(value);
				bulletActionInfoAttachActor.RotationRule = new EAttachmentRule?(value);
				bulletActionInfoAttachActor.ScaleRule = new EAttachmentRule?(value);
				bulletActionInfoAttachActor.WeldSimulatedBodies = false;
				BulletController.Instance.GetActionRunner().AddAction(bulletEntity.GetBulletInfo(), bulletActionInfoAttachActor);
			}
			bulletData.BulletEntityId = ((bulletEntity != null) ? new int?(bulletEntity.Id) : null);
			if (bulletEntity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "Bullet生成错误";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletID", bulletGroup.BulletId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前Bullet的EntityState", bulletGroup.EntityState);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityID", base.Entity.Id);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			return bulletEntity != null && bulletEntity.Valid;
		}

		// Token: 0x06046DF4 RID: 290292 RVA: 0x011E0538 File Offset: 0x011DE738
		private void DestroyBullets(int state)
		{
			if (!this.BulletState.ContainsKey(state) || this.BulletState.GetValueOrDefault(state).Count == 0)
			{
				return;
			}
			foreach (BulletData bulletData in this.BulletState.GetValueOrDefault(state))
			{
				this.DestroyBullet(bulletData);
			}
		}

		// Token: 0x06046DF5 RID: 290293 RVA: 0x011E05B4 File Offset: 0x011DE7B4
		[NullableContext(1)]
		private bool DestroyBullet(BulletData bulletData)
		{
			if (bulletData.BulletEntityId == null)
			{
				return false;
			}
			Entity entity = EntitySystem.Instance.Get(bulletData.BulletEntityId.Value);
			if (entity != null && entity.Valid)
			{
				AActor owner = entity.GetComponent<BulletActorComponent>().Owner;
				if (owner != null)
				{
					owner.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
			}
			BulletController.Instance.DestroyBullet(bulletData.BulletEntityId.Value, false, EBulletDestroyReason.Normal, false);
			bulletData.BulletEntityId = null;
			return true;
		}

		// Token: 0x06046DF6 RID: 290294 RVA: 0x011E0630 File Offset: 0x011DE830
		private void HandleUpdateState(int stateId, bool isReady)
		{
			this.CurrentState = stateId;
			if (this.IsInitComplete && isReady)
			{
				if (this.IsEnterTrigger || this.IsPermanentBullet)
				{
					this.CreateBullets(this.CurrentState);
				}
				foreach (int num in this.BulletState.Keys)
				{
					if (num != this.CurrentState)
					{
						this.DestroyBullets(num);
					}
				}
			}
		}

		// Token: 0x06046DF7 RID: 290295 RVA: 0x011E06C0 File Offset: 0x011DE8C0
		[NullableContext(1)]
		private void CreateBulletTransform(BulletData bullet)
		{
			bullet.BulletTransform = global::Transform.Create();
			global::Transform bulletTransform = bullet.BulletTransform;
			FTransformDouble actorTransform = this.ActorComp.ActorTransform;
			bulletTransform.FromUeTransform(actorTransform);
			if (bullet.BulletGroup.Offset != null)
			{
				this.CacheOffset.Set((double)bullet.BulletGroup.Offset.X.GetValueOrDefault(), (double)bullet.BulletGroup.Offset.Y.GetValueOrDefault(), (double)bullet.BulletGroup.Offset.Z.GetValueOrDefault());
				bullet.BulletTransform.TransformPositionNoScale(this.CacheOffset, this.CacheOffset);
				bullet.BulletTransform.SetLocation(this.CacheOffset);
			}
		}

		// Token: 0x06046DF8 RID: 290296 RVA: 0x011E077C File Offset: 0x011DE97C
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent rangeComp = this.RangeComp;
			if (rangeComp != null)
			{
				rangeComp.RemoveOnEntityOverlapCallback(new Action<bool, EntityHandle>(this.OnEntityTrigger));
			}
			foreach (int state in this.BulletState.Keys)
			{
				this.DestroyBullets(state);
			}
			this.BulletState.Clear();
			this.IsInitComplete = false;
			this.IsEnterTrigger = false;
			return true;
		}

		// Token: 0x06046DF9 RID: 290297 RVA: 0x011E0844 File Offset: 0x011DEA44
		protected override bool OnClear()
		{
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState));
			}
			return true;
		}

		// Token: 0x06046DFA RID: 290298 RVA: 0x011E0898 File Offset: 0x011DEA98
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneBulletComponent sceneBulletComponent = (SceneBulletComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsInitComplete"))
			{
				this.IsInitComplete = sceneBulletComponent.IsInitComplete;
			}
			if (base.CanResetComponentProperty("IsEnterTrigger"))
			{
				this.IsEnterTrigger = sceneBulletComponent.IsEnterTrigger;
			}
			if (base.CanResetComponentProperty("CurrentState"))
			{
				this.CurrentState = sceneBulletComponent.CurrentState;
			}
			if (base.CanResetComponentProperty("CacheOffset"))
			{
				if (sceneBulletComponent.CacheOffset == null)
				{
					this.CacheOffset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheOffset), "CacheOffset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CacheRange"))
			{
				if (sceneBulletComponent.CacheRange == null)
				{
					this.CacheRange = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheRange), "CacheRange"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BulletState"))
			{
				if (sceneBulletComponent.BulletState == null)
				{
					this.BulletState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, List<BulletData>>>(this.BulletState), "BulletState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (sceneBulletComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneBulletComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RoadNetworkComp"))
			{
				if (sceneBulletComponent.RoadNetworkComp == null)
				{
					this.RoadNetworkComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent>(this.RoadNetworkComp), "RoadNetworkComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ContextMessageId"))
			{
				this.ContextMessageId = sceneBulletComponent.ContextMessageId;
			}
			if (base.CanResetComponentProperty("DisableGenerateByRange"))
			{
				this.DisableGenerateByRange = sceneBulletComponent.DisableGenerateByRange;
			}
			if (base.CanResetComponentProperty("IsPermanentBullet"))
			{
				this.IsPermanentBullet = sceneBulletComponent.IsPermanentBullet;
			}
			return true;
		}

		// Token: 0x04025337 RID: 152375
		private bool IsInitComplete;

		// Token: 0x04025338 RID: 152376
		private bool IsEnterTrigger;

		// Token: 0x04025339 RID: 152377
		private int CurrentState;

		// Token: 0x0402533A RID: 152378
		private global::Vector CacheOffset;

		// Token: 0x0402533B RID: 152379
		private global::Vector CacheRange;

		// Token: 0x0402533C RID: 152380
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<BulletData>> BulletState;

		// Token: 0x0402533D RID: 152381
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0402533E RID: 152382
		private BaseActorComponent ActorComp;

		// Token: 0x0402533F RID: 152383
		private CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent RoadNetworkComp;

		// Token: 0x04025340 RID: 152384
		private long? ContextMessageId;

		// Token: 0x04025341 RID: 152385
		private bool DisableGenerateByRange;

		// Token: 0x04025342 RID: 152386
		private bool IsPermanentBullet;
	}
}
