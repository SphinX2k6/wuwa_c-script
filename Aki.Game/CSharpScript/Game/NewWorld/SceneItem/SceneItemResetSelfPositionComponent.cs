using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006245 RID: 25157
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemResetSelfPositionComponent : EntityComponent
	{
		// Token: 0x0603CABF RID: 248511 RVA: 0x011677B0 File Offset: 0x011659B0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			ResetSelfPosComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemResetSelfPositionComponent>() as ResetSelfPosComponent;
			this.Config = config;
			float resetRadius = this.Config.ResetRadius;
			this.ResetRadiusSquared = (double)(this.Config.ResetRadius * this.Config.ResetRadius);
			this.CheckInterval = 500f;
			return true;
		}

		// Token: 0x0603CAC0 RID: 248512 RVA: 0x0116780C File Offset: 0x01165A0C
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<SceneItemActorComponent>();
			this.MoveSyncComp = base.Entity.CheckGetComponent<SceneItemMovementSyncComponent>();
			if (base.Entity.CheckGetComponent<SceneItemManipulatableComponent>() == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SceneItemResetSelfPositionComponent] OnStart失败，实体不是可被控物";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataID", this.ActorComp.CreatureData.GetPbDataId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.DisableTickChecking("[SceneItemResetSelfPositionComponent] 初始关闭检查距离Tick");
			EventSystem.Instance.AddWithTarget<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(base.Entity, EEventName.OnManipulatableItemStateModified, new Action<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(this.OnManipulatableItemStateModified));
			return true;
		}

		// Token: 0x0603CAC1 RID: 248513 RVA: 0x011678B3 File Offset: 0x01165AB3
		protected override void OnActivate()
		{
			if (this.ResetRadiusSquared != -1.0)
			{
				this.TickHandle = TimerSystem.Instance.Forever(delegate(float _)
				{
					this.CheckAndResetSelfPos();
				}, this.CheckInterval, 1f, null, null, true);
			}
		}

		// Token: 0x0603CAC2 RID: 248514 RVA: 0x011678F0 File Offset: 0x01165AF0
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(base.Entity, EEventName.OnManipulatableItemStateModified, new Action<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(this.OnManipulatableItemStateModified)))
			{
				EventSystem.Instance.RemoveWithTarget<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(base.Entity, EEventName.OnManipulatableItemStateModified, new Action<SceneItemManipulatableComponent.EManipulatableState, SceneItemManipulatableComponent.EManipulatableState, Entity, SceneItemManipulableBaseState, SceneItemManipulableBaseState>(this.OnManipulatableItemStateModified));
			}
			if (this.TickHandle != null)
			{
				TimerSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
			return true;
		}

		// Token: 0x0603CAC3 RID: 248515 RVA: 0x01167964 File Offset: 0x01165B64
		private void OnManipulatableItemStateModified(SceneItemManipulatableComponent.EManipulatableState oldStateEnum, SceneItemManipulatableComponent.EManipulatableState newStateEnum, [Nullable(1)] Entity entity, SceneItemManipulableBaseState oldState, SceneItemManipulableBaseState newState)
		{
			SceneItemMovementSyncComponent moveSyncComp = this.MoveSyncComp;
			if (moveSyncComp == null || !moveSyncComp.HasMoveAuthority())
			{
				return;
			}
			if ((this.IsCastState(oldStateEnum) || oldStateEnum == SceneItemManipulatableComponent.EManipulatableState.BeDropping) && !this.IsStopCheckOnCast)
			{
				this.DisableTickChecking("[SceneItemResetSelfPositionComponent] 结束被当前主控移动，停止检查距离Tick");
				if (this.ResetRadiusSquared != -1.0)
				{
					this.CheckAndResetSelfPos();
				}
			}
			if (newStateEnum == SceneItemManipulatableComponent.EManipulatableState.BeDrawing)
			{
				this.EnableTickChecking();
			}
			ResetSelfPosComponent config = this.Config;
			if (config != null && config.IsDisableResetPosAfterThrow.GetValueOrDefault() && this.IsCastState(newStateEnum))
			{
				this.DisableTickChecking("[SceneItemResetSelfPositionComponent] 被控物配置丢出时停止检测");
				this.IsStopCheckOnCast = true;
			}
			ResetSelfPosComponent config2 = this.Config;
			if (config2 != null && config2.IsResetPosAfterThrow.GetValueOrDefault() && newStateEnum == SceneItemManipulatableComponent.EManipulatableState.BeDropping)
			{
				if (this.TimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.TimerHandle);
					this.TimerHandle = null;
				}
				this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TimerHandle = null;
					this.ResetSelfPos("ResetPositionTip2");
				}, 0.35f * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			}
			ResetSelfPosComponent config3 = this.Config;
			float? num = (config3 != null) ? config3.ResetPosDelayTime : null;
			if (num != null && num.GetValueOrDefault() != 0f && (oldState == null || !oldState.IsNoLockCasting()) && newState != null && newState.IsNoLockCasting())
			{
				if (this.TimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.TimerHandle);
					this.TimerHandle = null;
				}
				this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TimerHandle = null;
					this.ResetSelfPos(null);
				}, this.Config.ResetPosDelayTime.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			}
			if (newStateEnum == SceneItemManipulatableComponent.EManipulatableState.BeAdsorbed && this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603CAC4 RID: 248516 RVA: 0x01167B58 File Offset: 0x01165D58
		private void EnableTickChecking()
		{
			if (!this.GetTickCheckingEnabled())
			{
				TimerHandle tickHandle = this.TickHandle;
				if (tickHandle == null)
				{
					return;
				}
				tickHandle.Resume();
			}
		}

		// Token: 0x0603CAC5 RID: 248517 RVA: 0x01167B73 File Offset: 0x01165D73
		[NullableContext(1)]
		private void DisableTickChecking(string reason)
		{
			if (this.GetTickCheckingEnabled())
			{
				TimerHandle tickHandle = this.TickHandle;
				if (tickHandle == null)
				{
					return;
				}
				tickHandle.Pause();
			}
		}

		// Token: 0x0603CAC6 RID: 248518 RVA: 0x01167B8E File Offset: 0x01165D8E
		private bool GetTickCheckingEnabled()
		{
			TimerHandle tickHandle = this.TickHandle;
			return tickHandle == null || !tickHandle.IsPause();
		}

		// Token: 0x0603CAC7 RID: 248519 RVA: 0x01167BA8 File Offset: 0x01165DA8
		private void CheckAndResetSelfPos()
		{
			bool selfPosInRangeCache = this.SelfPosInRangeCache;
			if (!this.CheckSelfPosInRange() && selfPosInRangeCache)
			{
				this.ResetSelfPos(null);
			}
		}

		// Token: 0x0603CAC8 RID: 248520 RVA: 0x01167BD0 File Offset: 0x01165DD0
		private bool CheckSelfPosInRange()
		{
			global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			if (actorLocationProxy == this.ActorLocationCache)
			{
				return this.SelfPosInRangeCache;
			}
			this.ActorLocationCache = global::Vector.Create(actorLocationProxy);
			Aki.Protocol.Vector initLocation = this.ActorComp.CreatureData.GetInitLocation();
			if (initLocation == null)
			{
				return this.SelfPosInRangeCache;
			}
			global::Vector v = global::Vector.Create(initLocation);
			this.SelfPosInRangeCache = (global::Vector.DistSquared(v, actorLocationProxy) <= this.ResetRadiusSquared);
			return this.SelfPosInRangeCache;
		}

		// Token: 0x0603CAC9 RID: 248521 RVA: 0x01167C45 File Offset: 0x01165E45
		private void ResetSelfPos(string promptId)
		{
			LevelGamePlayController.Instance.OnManipulatableItemExitAreaInternal(base.Entity, promptId, 0L);
		}

		// Token: 0x0603CACA RID: 248522 RVA: 0x01167C5A File Offset: 0x01165E5A
		private bool IsCastState(SceneItemManipulatableComponent.EManipulatableState state)
		{
			return state == SceneItemManipulatableComponent.EManipulatableState.BeCastingToTarget || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingToOutlet || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingFree || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingProjectile;
		}

		// Token: 0x0603CACB RID: 248523 RVA: 0x01167C6F File Offset: 0x01165E6F
		public void StopTimerOnResetPos()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603CACC RID: 248524 RVA: 0x01167C94 File Offset: 0x01165E94
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemResetSelfPositionComponent sceneItemResetSelfPositionComponent = (SceneItemResetSelfPositionComponent)componentTemplate;
			if (sceneItemResetSelfPositionComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemResetSelfPositionComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemResetSelfPositionComponent.MoveSyncComp == null)
			{
				this.MoveSyncComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveSyncComp), "MoveSyncComp"))
			{
				return false;
			}
			this.ResetRadiusSquared = sceneItemResetSelfPositionComponent.ResetRadiusSquared;
			this.CheckInterval = sceneItemResetSelfPositionComponent.CheckInterval;
			this.SelfPosInRangeCache = sceneItemResetSelfPositionComponent.SelfPosInRangeCache;
			if (sceneItemResetSelfPositionComponent.ActorLocationCache == null)
			{
				this.ActorLocationCache = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorLocationCache), "ActorLocationCache"))
			{
				return false;
			}
			this.IsStopCheckOnCast = sceneItemResetSelfPositionComponent.IsStopCheckOnCast;
			if (sceneItemResetSelfPositionComponent.TimerHandle == null)
			{
				this.TimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimerHandle), "TimerHandle"))
			{
				return false;
			}
			if (sceneItemResetSelfPositionComponent.TickHandle == null)
			{
				this.TickHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TickHandle), "TickHandle"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x0603CACD RID: 248525 RVA: 0x01167DE6 File Offset: 0x01165FE6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x0603CACE RID: 248526 RVA: 0x01167DE9 File Offset: 0x01165FE9
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x0603CACF RID: 248527 RVA: 0x01167DEC File Offset: 0x01165FEC
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202A7 RID: 131751
		private const float TICK_CHECK_INTERVAL = 500f;

		// Token: 0x040202A8 RID: 131752
		private const float FIX_DELAY = 0.35f;

		// Token: 0x040202A9 RID: 131753
		private ResetSelfPosComponent Config;

		// Token: 0x040202AA RID: 131754
		private SceneItemActorComponent ActorComp;

		// Token: 0x040202AB RID: 131755
		private SceneItemMovementSyncComponent MoveSyncComp;

		// Token: 0x040202AC RID: 131756
		private double ResetRadiusSquared = -1.0;

		// Token: 0x040202AD RID: 131757
		private float CheckInterval;

		// Token: 0x040202AE RID: 131758
		private bool SelfPosInRangeCache = true;

		// Token: 0x040202AF RID: 131759
		private global::Vector ActorLocationCache;

		// Token: 0x040202B0 RID: 131760
		private bool IsStopCheckOnCast;

		// Token: 0x040202B1 RID: 131761
		private TimerHandle TimerHandle;

		// Token: 0x040202B2 RID: 131762
		private TimerHandle TickHandle;
	}
}
