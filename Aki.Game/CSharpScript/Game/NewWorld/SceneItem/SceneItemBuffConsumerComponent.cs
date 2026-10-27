using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200716F RID: 29039
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBuffConsumerComponent : EntityComponent
	{
		// Token: 0x06046E5E RID: 290398 RVA: 0x011E5354 File Offset: 0x011E3554
		protected override bool OnInitData(IEntityArgs args = null)
		{
			BuffConsumerComponent buffConsumerComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemBuffConsumerComponent>() as BuffConsumerComponent;
			this.BuffId = buffConsumerComponent.BuffId;
			long? num = buffConsumerComponent.BulletId;
			if (num != null && num.GetValueOrDefault() != 0L)
			{
				this.BulletId = buffConsumerComponent.BulletId.ToString();
			}
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			EntityComponentPb entityComponentPb = (component != null) ? component.ComponentDataMap.GetValueOrDefault("Proto_BuffConsumerComponentPb") : null;
			long? num2;
			if (entityComponentPb == null)
			{
				num2 = null;
			}
			else
			{
				BuffConsumerComponentPb buffConsumerComponentPb = entityComponentPb.BuffConsumerComponentPb;
				num2 = ((buffConsumerComponentPb != null) ? new long?(buffConsumerComponentPb.ContextId) : null);
			}
			num = num2;
			this.ContextMessageId = new long?(num.GetValueOrDefault());
			return true;
		}

		// Token: 0x06046E5F RID: 290399 RVA: 0x011E5414 File Offset: 0x011E3614
		protected unsafe override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.CJH, "[SceneItemBuffConsumerComponent] 组件初始化失败 Actor Component Undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.CommonTagComp = base.Entity.GetComponent<LevelTagComponent>();
			if (this.CommonTagComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "[SceneItemBuffConsumerComponent] 组件初始化失败 实体缺少LevelTagComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			if (this.StateComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneGameplay;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "[SceneItemBuffConsumerComponent] 组件初始化失败 实体缺少SceneItemStateComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return false;
			}
			this.RangeComp = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
			if (this.RangeComp == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneGameplay;
				ELogAuthor author3 = ELogAuthor.CJH;
				string message3 = "[SceneItemBuffConsumerComponent] 组件初始化失败 实体缺少RangeComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return false;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int worldOwner = CreatureModel.Instance.GetWorldOwner();
				if (!(id.GetValueOrDefault() == worldOwner & id != null))
				{
					return true;
				}
			}
			this.CreatureDataId = this.ActorComp.CreatureData.GetCreatureDataId();
			this.CommonTagComp.AddTag(new int?(SceneItemBuffConsumerComponent.HIT_CONDITION_TAGID));
			this.HitComp = base.Entity.GetComponent<SceneItemHitComponent>();
			this.HitComp.RegisterComponent(this, null);
			this.RangeComp.AddOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerInOutRange));
			return true;
		}

		// Token: 0x06046E60 RID: 290400 RVA: 0x011E5743 File Offset: 0x011E3943
		protected override bool OnEnd()
		{
			CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent rangeComp = this.RangeComp;
			if (rangeComp != null)
			{
				rangeComp.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerInOutRange));
			}
			if (this.BulletTimeOutTimerHandle != null && TimerSystem.Instance.Remove(this.BulletTimeOutTimerHandle))
			{
				this.OnBulletTimeOut();
			}
			return true;
		}

		// Token: 0x06046E61 RID: 290401 RVA: 0x011E5783 File Offset: 0x011E3983
		private void OnPlayerInOutRange(bool isEnter)
		{
			if (isEnter && this.CheckCanConsume())
			{
				this.IsBusyConsuming = true;
				SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.RemoveBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
			}
		}

		// Token: 0x06046E62 RID: 290402 RVA: 0x011E57BC File Offset: 0x011E39BC
		private bool CheckCanConsume()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int worldOwner = CreatureModel.Instance.GetWorldOwner();
				if (!(id.GetValueOrDefault() == worldOwner & id != null))
				{
					return false;
				}
			}
			return !this.IsBusyConsuming && this.StateComp.IsInState(SceneItemStateComponent.ESceneItemState.Normal) && !SceneTeamModel.Instance.IsPhantomTeam && this.CheckPlayerHasBuff();
		}

		// Token: 0x06046E63 RID: 290403 RVA: 0x011E5834 File Offset: 0x011E3A34
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

		// Token: 0x06046E64 RID: 290404 RVA: 0x011E58A6 File Offset: 0x011E3AA6
		private void OnBuffOperateCallBack(BuffOperateType type, bool isSuccess)
		{
			if (type == BuffOperateType.RemoveBuff && isSuccess)
			{
				this.PlayPerformance();
				return;
			}
			this.IsBusyConsuming = false;
		}

		// Token: 0x06046E65 RID: 290405 RVA: 0x011E58BE File Offset: 0x011E3ABE
		private void PlayPerformance()
		{
			if (!string.IsNullOrEmpty(this.BulletId))
			{
				this.CreateBullet();
				return;
			}
			this.OnPerformanceComplete();
		}

		// Token: 0x06046E66 RID: 290406 RVA: 0x011E58DC File Offset: 0x011E3ADC
		private void CreateBullet()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			Entity entity = characterActorComponent.Entity;
			BulletModel.Instance.SetEntityIdByCustomKey(entity.Id, "HeiShiSuo", base.Entity.Id);
			BulletController.Instance.CreateBulletCustomTarget(Global.BaseCharacter, this.BulletId, new FTransformDouble?(characterActorComponent.ActorTransform), new BulletController.BulletCreateParams(), this.ContextMessageId, global::EBulletCreateSource.Others);
			EventSystem.Instance.AddWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit));
			this.BulletTimeOutTimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnBulletTimeOut), 5000f, null, null, true, 1f);
		}

		// Token: 0x06046E67 RID: 290407 RVA: 0x011E5994 File Offset: 0x011E3B94
		[NullableContext(1)]
		private void OnHit(global::HitInformation hitData)
		{
			if (hitData.ReBulletData.Base.HitConditionTagId != SceneItemBuffConsumerComponent.HIT_CONDITION_TAGID)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(hitData.BulletEntityId);
			if (entity != null && entity.Valid)
			{
				BulletController.Instance.DestroyBullet(hitData.BulletEntityId, false, EBulletDestroyReason.Normal, false);
			}
			if (this.BulletTimeOutTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.BulletTimeOutTimerHandle);
				this.BulletTimeOutTimerHandle = null;
			}
			EventSystem.Instance.RemoveWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit));
			this.OnPerformanceComplete();
		}

		// Token: 0x06046E68 RID: 290408 RVA: 0x011E5A2B File Offset: 0x011E3C2B
		private void OnBulletTimeOut(float delta)
		{
			this.OnBulletTimeOut();
		}

		// Token: 0x06046E69 RID: 290409 RVA: 0x011E5A34 File Offset: 0x011E3C34
		private void OnBulletTimeOut()
		{
			if (EventSystem.Instance.HasWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit)))
			{
				EventSystem.Instance.RemoveWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit));
			}
			this.BulletTimeOutTimerHandle = null;
			this.OnPerformanceComplete();
		}

		// Token: 0x06046E6A RID: 290410 RVA: 0x011E5A89 File Offset: 0x011E3C89
		private void OnPerformanceComplete()
		{
			LevelGamePlayController.Instance.EntityBuffProducerRequest(this.CreatureDataId, delegate(EntityBuffProducerResponse response, Net.CallbackStatus _)
			{
				this.IsBusyConsuming = false;
			});
		}

		// Token: 0x06046E6B RID: 290411 RVA: 0x011E5AA8 File Offset: 0x011E3CA8
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBuffConsumerComponent sceneItemBuffConsumerComponent = (SceneItemBuffConsumerComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemBuffConsumerComponent.ActorComp == null)
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
				if (sceneItemBuffConsumerComponent.CommonTagComp == null)
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
				if (sceneItemBuffConsumerComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HitComp"))
			{
				if (sceneItemBuffConsumerComponent.HitComp == null)
				{
					this.HitComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemHitComponent>(this.HitComp), "HitComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (sceneItemBuffConsumerComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataId"))
			{
				this.CreatureDataId = sceneItemBuffConsumerComponent.CreatureDataId;
			}
			if (base.CanResetComponentProperty("BulletId"))
			{
				this.BulletId = sceneItemBuffConsumerComponent.BulletId;
			}
			if (base.CanResetComponentProperty("BuffId"))
			{
				this.BuffId = sceneItemBuffConsumerComponent.BuffId;
			}
			if (base.CanResetComponentProperty("BulletTimeOutTimerHandle"))
			{
				if (sceneItemBuffConsumerComponent.BulletTimeOutTimerHandle == null)
				{
					this.BulletTimeOutTimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.BulletTimeOutTimerHandle), "BulletTimeOutTimerHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ContextMessageId"))
			{
				this.ContextMessageId = sceneItemBuffConsumerComponent.ContextMessageId;
			}
			if (base.CanResetComponentProperty("IsBusyConsuming"))
			{
				this.IsBusyConsuming = sceneItemBuffConsumerComponent.IsBusyConsuming;
			}
			return true;
		}

		// Token: 0x0402537C RID: 152444
		[Nullable(1)]
		private const string BLACKBOARD_KEY = "HeiShiSuo";

		// Token: 0x0402537D RID: 152445
		private static readonly int HIT_CONDITION_TAGID = GameplayTagDefine.EGameplayTagId["关卡.黑石锁.功能.命中判定"];

		// Token: 0x0402537E RID: 152446
		private const int MAX_BULLET_HIT_TIME = 5000;

		// Token: 0x0402537F RID: 152447
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025380 RID: 152448
		private LevelTagComponent CommonTagComp;

		// Token: 0x04025381 RID: 152449
		private SceneItemStateComponent StateComp;

		// Token: 0x04025382 RID: 152450
		private SceneItemHitComponent HitComp;

		// Token: 0x04025383 RID: 152451
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x04025384 RID: 152452
		private long CreatureDataId;

		// Token: 0x04025385 RID: 152453
		[Nullable(1)]
		private string BulletId = "";

		// Token: 0x04025386 RID: 152454
		private long BuffId;

		// Token: 0x04025387 RID: 152455
		private TimerHandle BulletTimeOutTimerHandle;

		// Token: 0x04025388 RID: 152456
		private long? ContextMessageId;

		// Token: 0x04025389 RID: 152457
		private bool IsBusyConsuming;
	}
}
