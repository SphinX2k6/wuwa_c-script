using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x02007234 RID: 29236
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BulletCasterBase : IBulletCaster
	{
		// Token: 0x06047A62 RID: 293474 RVA: 0x01255414 File Offset: 0x01253614
		public BulletCasterBase(BulletCasterInitParam bulletCasterInitParam)
		{
			this.BulletCasterInitParam = bulletCasterInitParam;
			this.OwnerEntity = bulletCasterInitParam.OwnerEntity;
			this.CasterConfig = bulletCasterInitParam.CasterConfig;
			this.CasterRelTransform = bulletCasterInitParam.CasterRelTransform;
			this.BulletContextId = bulletCasterInitParam.BulletContextId;
			this.WarningEffect = bulletCasterInitParam.WarningEffect;
		}

		// Token: 0x06047A63 RID: 293475 RVA: 0x01255480 File Offset: 0x01253680
		public virtual void Start()
		{
			if ((this.CasterConfig.DelayTime ?? 0) != 0)
			{
				int? delayTime = this.CasterConfig.DelayTime;
				int num = 20;
				if (!(delayTime.GetValueOrDefault() <= num & delayTime != null))
				{
					TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
					{
						this.CasterWaitStartTimers.RemoveAt(this.CasterWaitStartTimers.Count - 1);
						this.StartImmediately();
					}, (float)this.CasterConfig.DelayTime.Value, null, null, true, 1f);
					if (timerHandle != null)
					{
						this.CasterWaitStartTimers.Add(timerHandle);
						goto IL_9A;
					}
					goto IL_9A;
				}
			}
			this.StartImmediately();
			IL_9A:
			this.SetTimeDilationRespectOwnerEntity();
			this.OnStart();
		}

		// Token: 0x06047A64 RID: 293476
		protected abstract void OnStart();

		// Token: 0x06047A65 RID: 293477 RVA: 0x01255534 File Offset: 0x01253734
		public virtual void Stop()
		{
			foreach (TimerHandle timerHandle in this.CasterWaitStartTimers)
			{
				if (timerHandle.Valid())
				{
					timerHandle.Remove();
				}
			}
			this.CasterWaitStartTimers.Clear();
			this.OnStop();
		}

		// Token: 0x06047A66 RID: 293478
		protected abstract void OnStop();

		// Token: 0x06047A67 RID: 293479 RVA: 0x012555A0 File Offset: 0x012537A0
		public virtual void SetTimeDilationRespectOwnerEntity()
		{
			PawnTimeScaleComponent component = this.OwnerEntity.GetComponent<PawnTimeScaleComponent>();
			float timeDilation = this.OwnerEntity.TimeDilation * ((component != null) ? component.CurrentTimeScale : 1f);
			this.SetTimeDilation(timeDilation);
		}

		// Token: 0x06047A68 RID: 293480 RVA: 0x012555E0 File Offset: 0x012537E0
		public virtual void SetTimeDilation(float timeDilation)
		{
			foreach (TimerHandle timerHandle in this.CasterWaitStartTimers)
			{
				if (timerHandle.Valid())
				{
					BulletCasterUtils.SetTimerHandleTimeDilation(timerHandle, timeDilation);
				}
			}
			this.OnSetTimeDilation(timeDilation);
		}

		// Token: 0x06047A69 RID: 293481
		protected abstract void OnSetTimeDilation(float timeDilation);

		// Token: 0x06047A6A RID: 293482
		protected abstract void StartImmediately();

		// Token: 0x06047A6B RID: 293483 RVA: 0x01255644 File Offset: 0x01253844
		protected int PlayWarningEffect()
		{
			if (this.WarningEffect.Length == 0)
			{
				return 0;
			}
			FTransformDouble actorTransform = this.OwnerEntity.GetComponent<BaseActorComponent>().ActorTransform;
			FTransformDouble ftransformDouble = this.CasterRelTransform.ToUeTransform();
			FTransformDouble value = ftransformDouble * actorTransform;
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble2 = new FTransformDouble?(value);
			int num = instance.SpawnEffect(world, ftransformDouble2, this.WarningEffect, "[BatchBulletCasterComponent] PlayWarningEffect", new EffectContext(new int?(this.OwnerEntity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
			this.SetEffectParam(num);
			return num;
		}

		// Token: 0x06047A6C RID: 293484
		protected abstract void SetEffectParam(int effectHandleId);

		// Token: 0x04025B25 RID: 154405
		[Nullable(2)]
		public Entity OwnerEntity;

		// Token: 0x04025B26 RID: 154406
		[Nullable(2)]
		public IBatchBulletCaster CasterConfig;

		// Token: 0x04025B27 RID: 154407
		[Nullable(2)]
		public Transform CasterRelTransform;

		// Token: 0x04025B28 RID: 154408
		public long BulletContextId;

		// Token: 0x04025B29 RID: 154409
		public string WarningEffect = "";

		// Token: 0x04025B2A RID: 154410
		private readonly List<TimerHandle> CasterWaitStartTimers = new List<TimerHandle>();

		// Token: 0x04025B2B RID: 154411
		protected BulletCasterInitParam BulletCasterInitParam;
	}
}
