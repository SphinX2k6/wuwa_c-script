using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007191 RID: 29073
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemResetSelfPositionComponent : EntityComponent
	{
		// Token: 0x060471F9 RID: 291321 RVA: 0x0120DBA0 File Offset: 0x0120BDA0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			ResetSelfPosComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemResetSelfPositionComponent>() as ResetSelfPosComponent;
			this.Config = config;
			float resetRadius = this.Config.ResetRadius;
			this.ResetRadiusSquared = (double)(this.Config.ResetRadius * this.Config.ResetRadius);
			this.CheckInterval = 500f;
			return true;
		}

		// Token: 0x060471FA RID: 291322 RVA: 0x0120DBFC File Offset: 0x0120BDFC
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

		// Token: 0x060471FB RID: 291323 RVA: 0x0120DCA3 File Offset: 0x0120BEA3
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

		// Token: 0x060471FC RID: 291324 RVA: 0x0120DCE0 File Offset: 0x0120BEE0
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

		// Token: 0x060471FD RID: 291325 RVA: 0x0120DD54 File Offset: 0x0120BF54
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

		// Token: 0x060471FE RID: 291326 RVA: 0x0120DF48 File Offset: 0x0120C148
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

		// Token: 0x060471FF RID: 291327 RVA: 0x0120DF63 File Offset: 0x0120C163
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

		// Token: 0x06047200 RID: 291328 RVA: 0x0120DF7E File Offset: 0x0120C17E
		private bool GetTickCheckingEnabled()
		{
			TimerHandle tickHandle = this.TickHandle;
			return tickHandle == null || !tickHandle.IsPause();
		}

		// Token: 0x06047201 RID: 291329 RVA: 0x0120DF98 File Offset: 0x0120C198
		private void CheckAndResetSelfPos()
		{
			bool selfPosInRangeCache = this.SelfPosInRangeCache;
			if (!this.CheckSelfPosInRange() && selfPosInRangeCache)
			{
				this.ResetSelfPos(null);
			}
		}

		// Token: 0x06047202 RID: 291330 RVA: 0x0120DFC0 File Offset: 0x0120C1C0
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

		// Token: 0x06047203 RID: 291331 RVA: 0x0120E035 File Offset: 0x0120C235
		private void ResetSelfPos(string promptId)
		{
			LevelGamePlayController.Instance.OnManipulatableItemExitAreaInternal(base.Entity, promptId, 0L);
		}

		// Token: 0x06047204 RID: 291332 RVA: 0x0120E04A File Offset: 0x0120C24A
		private bool IsCastState(SceneItemManipulatableComponent.EManipulatableState state)
		{
			return state == SceneItemManipulatableComponent.EManipulatableState.BeCastingToTarget || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingToOutlet || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingFree || state == SceneItemManipulatableComponent.EManipulatableState.BeCastingProjectile;
		}

		// Token: 0x06047205 RID: 291333 RVA: 0x0120E05F File Offset: 0x0120C25F
		public void StopTimerOnResetPos()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06047206 RID: 291334 RVA: 0x0120E084 File Offset: 0x0120C284
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemResetSelfPositionComponent sceneItemResetSelfPositionComponent = (SceneItemResetSelfPositionComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemResetSelfPositionComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ResetSelfPosComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemResetSelfPositionComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveSyncComp"))
			{
				if (sceneItemResetSelfPositionComponent.MoveSyncComp == null)
				{
					this.MoveSyncComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMovementSyncComponent>(this.MoveSyncComp), "MoveSyncComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ResetRadiusSquared"))
			{
				this.ResetRadiusSquared = sceneItemResetSelfPositionComponent.ResetRadiusSquared;
			}
			if (base.CanResetComponentProperty("CheckInterval"))
			{
				this.CheckInterval = sceneItemResetSelfPositionComponent.CheckInterval;
			}
			if (base.CanResetComponentProperty("SelfPosInRangeCache"))
			{
				this.SelfPosInRangeCache = sceneItemResetSelfPositionComponent.SelfPosInRangeCache;
			}
			if (base.CanResetComponentProperty("ActorLocationCache"))
			{
				if (sceneItemResetSelfPositionComponent.ActorLocationCache == null)
				{
					this.ActorLocationCache = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ActorLocationCache), "ActorLocationCache"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsStopCheckOnCast"))
			{
				this.IsStopCheckOnCast = sceneItemResetSelfPositionComponent.IsStopCheckOnCast;
			}
			if (base.CanResetComponentProperty("TimerHandle"))
			{
				if (sceneItemResetSelfPositionComponent.TimerHandle == null)
				{
					this.TimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TimerHandle), "TimerHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TickHandle"))
			{
				if (sceneItemResetSelfPositionComponent.TickHandle == null)
				{
					this.TickHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TickHandle), "TickHandle"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04025640 RID: 153152
		private const float TICK_CHECK_INTERVAL = 500f;

		// Token: 0x04025641 RID: 153153
		private const float FIX_DELAY = 0.35f;

		// Token: 0x04025642 RID: 153154
		private ResetSelfPosComponent Config;

		// Token: 0x04025643 RID: 153155
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025644 RID: 153156
		private SceneItemMovementSyncComponent MoveSyncComp;

		// Token: 0x04025645 RID: 153157
		private double ResetRadiusSquared = -1.0;

		// Token: 0x04025646 RID: 153158
		private float CheckInterval;

		// Token: 0x04025647 RID: 153159
		private bool SelfPosInRangeCache = true;

		// Token: 0x04025648 RID: 153160
		private global::Vector ActorLocationCache;

		// Token: 0x04025649 RID: 153161
		private bool IsStopCheckOnCast;

		// Token: 0x0402564A RID: 153162
		private TimerHandle TimerHandle;

		// Token: 0x0402564B RID: 153163
		private TimerHandle TickHandle;
	}
}
