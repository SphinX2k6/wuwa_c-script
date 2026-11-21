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
	// Token: 0x02006223 RID: 25123
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBuffConsumerComponent : EntityComponent
	{
		// Token: 0x0603C6BC RID: 247484 RVA: 0x01140A2C File Offset: 0x0113EC2C
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

		// Token: 0x0603C6BD RID: 247485 RVA: 0x01140AEC File Offset: 0x0113ECEC
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

		// Token: 0x0603C6BE RID: 247486 RVA: 0x01140E1B File Offset: 0x0113F01B
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

		// Token: 0x0603C6BF RID: 247487 RVA: 0x01140E5B File Offset: 0x0113F05B
		private void OnPlayerInOutRange(bool isEnter)
		{
			if (isEnter && this.CheckCanConsume())
			{
				this.IsBusyConsuming = true;
				SceneItemBuffController.Instance.BuffOperate(base.Entity.Id, BuffOperateType.RemoveBuff, new Action<BuffOperateType, bool>(this.OnBuffOperateCallBack));
			}
		}

		// Token: 0x0603C6C0 RID: 247488 RVA: 0x01140E94 File Offset: 0x0113F094
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

		// Token: 0x0603C6C1 RID: 247489 RVA: 0x01140F0C File Offset: 0x0113F10C
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

		// Token: 0x0603C6C2 RID: 247490 RVA: 0x01140F7E File Offset: 0x0113F17E
		private void OnBuffOperateCallBack(BuffOperateType type, bool isSuccess)
		{
			if (type == BuffOperateType.RemoveBuff && isSuccess)
			{
				this.PlayPerformance();
				return;
			}
			this.IsBusyConsuming = false;
		}

		// Token: 0x0603C6C3 RID: 247491 RVA: 0x01140F96 File Offset: 0x0113F196
		private void PlayPerformance()
		{
			if (!string.IsNullOrEmpty(this.BulletId))
			{
				this.CreateBullet();
				return;
			}
			this.OnPerformanceComplete();
		}

		// Token: 0x0603C6C4 RID: 247492 RVA: 0x01140FB4 File Offset: 0x0113F1B4
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

		// Token: 0x0603C6C5 RID: 247493 RVA: 0x0114106C File Offset: 0x0113F26C
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

		// Token: 0x0603C6C6 RID: 247494 RVA: 0x01141103 File Offset: 0x0113F303
		private void OnBulletTimeOut(float delta)
		{
			this.OnBulletTimeOut();
		}

		// Token: 0x0603C6C7 RID: 247495 RVA: 0x0114110C File Offset: 0x0113F30C
		private void OnBulletTimeOut()
		{
			if (EventSystem.Instance.HasWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit)))
			{
				EventSystem.Instance.RemoveWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnHit));
			}
			this.BulletTimeOutTimerHandle = null;
			this.OnPerformanceComplete();
		}

		// Token: 0x0603C6C8 RID: 247496 RVA: 0x01141161 File Offset: 0x0113F361
		private void OnPerformanceComplete()
		{
			LevelGamePlayController.Instance.EntityBuffProducerRequest(this.CreatureDataId, delegate(EntityBuffProducerResponse response, Net.CallbackStatus _)
			{
				this.IsBusyConsuming = false;
			});
		}

		// Token: 0x0603C6C9 RID: 247497 RVA: 0x01141180 File Offset: 0x0113F380
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBuffConsumerComponent sceneItemBuffConsumerComponent = (SceneItemBuffConsumerComponent)componentTemplate;
			if (sceneItemBuffConsumerComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemBuffConsumerComponent.CommonTagComp == null)
			{
				this.CommonTagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommonTagComp), "CommonTagComp"))
			{
				return false;
			}
			if (sceneItemBuffConsumerComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemBuffConsumerComponent.HitComp == null)
			{
				this.HitComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComp), "HitComp"))
			{
				return false;
			}
			if (sceneItemBuffConsumerComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			this.CreatureDataId = sceneItemBuffConsumerComponent.CreatureDataId;
			this.BulletId = sceneItemBuffConsumerComponent.BulletId;
			this.BuffId = sceneItemBuffConsumerComponent.BuffId;
			if (sceneItemBuffConsumerComponent.BulletTimeOutTimerHandle == null)
			{
				this.BulletTimeOutTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletTimeOutTimerHandle), "BulletTimeOutTimerHandle"))
			{
				return false;
			}
			this.ContextMessageId = sceneItemBuffConsumerComponent.ContextMessageId;
			this.IsBusyConsuming = sceneItemBuffConsumerComponent.IsBusyConsuming;
			return true;
		}

		// Token: 0x1700721D RID: 29213
		// (get) Token: 0x0603C6CA RID: 247498 RVA: 0x011412DE File Offset: 0x0113F4DE
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700721E RID: 29214
		// (get) Token: 0x0603C6CB RID: 247499 RVA: 0x011412E1 File Offset: 0x0113F4E1
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FFE3 RID: 131043
		[Nullable(1)]
		private const string BLACKBOARD_KEY = "HeiShiSuo";

		// Token: 0x0401FFE4 RID: 131044
		private static readonly int HIT_CONDITION_TAGID = GameplayTagDefine.EGameplayTagId["关卡.黑石锁.功能.命中判定"];

		// Token: 0x0401FFE5 RID: 131045
		private const int MAX_BULLET_HIT_TIME = 5000;

		// Token: 0x0401FFE6 RID: 131046
		private SceneItemActorComponent ActorComp;

		// Token: 0x0401FFE7 RID: 131047
		private LevelTagComponent CommonTagComp;

		// Token: 0x0401FFE8 RID: 131048
		private SceneItemStateComponent StateComp;

		// Token: 0x0401FFE9 RID: 131049
		private SceneItemHitComponent HitComp;

		// Token: 0x0401FFEA RID: 131050
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComp;

		// Token: 0x0401FFEB RID: 131051
		private long CreatureDataId;

		// Token: 0x0401FFEC RID: 131052
		[Nullable(1)]
		private string BulletId = "";

		// Token: 0x0401FFED RID: 131053
		private long BuffId;

		// Token: 0x0401FFEE RID: 131054
		private TimerHandle BulletTimeOutTimerHandle;

		// Token: 0x0401FFEF RID: 131055
		private long? ContextMessageId;

		// Token: 0x0401FFF0 RID: 131056
		private bool IsBusyConsuming;
	}
}
