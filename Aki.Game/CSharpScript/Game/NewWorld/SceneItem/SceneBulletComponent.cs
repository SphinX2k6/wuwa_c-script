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
	// Token: 0x0200621E RID: 25118
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneBulletComponent : EntityComponent
	{
		// Token: 0x0603C638 RID: 247352 RVA: 0x0113B6F0 File Offset: 0x011398F0
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

		// Token: 0x0603C639 RID: 247353 RVA: 0x0113B890 File Offset: 0x01139A90
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

		// Token: 0x0603C63A RID: 247354 RVA: 0x0113B940 File Offset: 0x01139B40
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

		// Token: 0x0603C63B RID: 247355 RVA: 0x0113B9BD File Offset: 0x01139BBD
		private void OnWorldDone()
		{
			this.CreateBullets(this.CurrentState);
		}

		// Token: 0x0603C63C RID: 247356 RVA: 0x0113B9CC File Offset: 0x01139BCC
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

		// Token: 0x0603C63D RID: 247357 RVA: 0x0113BA60 File Offset: 0x01139C60
		protected override void OnTick(float delta)
		{
			this.ProcessTrafficBullet();
		}

		// Token: 0x0603C63E RID: 247358 RVA: 0x0113BA68 File Offset: 0x01139C68
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

		// Token: 0x0603C63F RID: 247359 RVA: 0x0113BB60 File Offset: 0x01139D60
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

		// Token: 0x0603C640 RID: 247360 RVA: 0x0113BC98 File Offset: 0x01139E98
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

		// Token: 0x0603C641 RID: 247361 RVA: 0x0113BF28 File Offset: 0x0113A128
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

		// Token: 0x0603C642 RID: 247362 RVA: 0x0113BFA4 File Offset: 0x0113A1A4
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

		// Token: 0x0603C643 RID: 247363 RVA: 0x0113C020 File Offset: 0x0113A220
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

		// Token: 0x0603C644 RID: 247364 RVA: 0x0113C0B0 File Offset: 0x0113A2B0
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

		// Token: 0x0603C645 RID: 247365 RVA: 0x0113C16C File Offset: 0x0113A36C
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

		// Token: 0x0603C646 RID: 247366 RVA: 0x0113C234 File Offset: 0x0113A434
		protected override bool OnClear()
		{
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState));
			}
			return true;
		}

		// Token: 0x0603C647 RID: 247367 RVA: 0x0113C288 File Offset: 0x0113A488
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneBulletComponent sceneBulletComponent = (SceneBulletComponent)componentTemplate;
			this.IsInitComplete = sceneBulletComponent.IsInitComplete;
			this.IsEnterTrigger = sceneBulletComponent.IsEnterTrigger;
			this.CurrentState = sceneBulletComponent.CurrentState;
			if (sceneBulletComponent.CacheOffset == null)
			{
				this.CacheOffset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheOffset), "CacheOffset"))
			{
				return false;
			}
			if (sceneBulletComponent.CacheRange == null)
			{
				this.CacheRange = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheRange), "CacheRange"))
			{
				return false;
			}
			if (sceneBulletComponent.BulletState == null)
			{
				this.BulletState = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletState), "BulletState"))
			{
				return false;
			}
			if (sceneBulletComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			if (sceneBulletComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneBulletComponent.RoadNetworkComp == null)
			{
				this.RoadNetworkComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoadNetworkComp), "RoadNetworkComp"))
			{
				return false;
			}
			this.ContextMessageId = sceneBulletComponent.ContextMessageId;
			this.DisableGenerateByRange = sceneBulletComponent.DisableGenerateByRange;
			this.IsPermanentBullet = sceneBulletComponent.IsPermanentBullet;
			return true;
		}

		// Token: 0x1700720B RID: 29195
		// (get) Token: 0x0603C648 RID: 247368 RVA: 0x0113C3F2 File Offset: 0x0113A5F2
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700720C RID: 29196
		// (get) Token: 0x0603C649 RID: 247369 RVA: 0x0113C3F5 File Offset: 0x0113A5F5
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700720D RID: 29197
		// (get) Token: 0x0603C64A RID: 247370 RVA: 0x0113C3F8 File Offset: 0x0113A5F8
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700720E RID: 29198
		// (get) Token: 0x0603C64B RID: 247371 RVA: 0x0113C3FB File Offset: 0x0113A5FB
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700720F RID: 29199
		// (get) Token: 0x0603C64C RID: 247372 RVA: 0x0113C3FE File Offset: 0x0113A5FE
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FF9E RID: 130974
		private bool IsInitComplete;

		// Token: 0x0401FF9F RID: 130975
		private bool IsEnterTrigger;

		// Token: 0x0401FFA0 RID: 130976
		private int CurrentState;

		// Token: 0x0401FFA1 RID: 130977
		private global::Vector CacheOffset;

		// Token: 0x0401FFA2 RID: 130978
		private global::Vector CacheRange;

		// Token: 0x0401FFA3 RID: 130979
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<BulletData>> BulletState;

		// Token: 0x0401FFA4 RID: 130980
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0401FFA5 RID: 130981
		private BaseActorComponent ActorComp;

		// Token: 0x0401FFA6 RID: 130982
		private CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent RoadNetworkComp;

		// Token: 0x0401FFA7 RID: 130983
		private long? ContextMessageId;

		// Token: 0x0401FFA8 RID: 130984
		private bool DisableGenerateByRange;

		// Token: 0x0401FFA9 RID: 130985
		private bool IsPermanentBullet;
	}
}
