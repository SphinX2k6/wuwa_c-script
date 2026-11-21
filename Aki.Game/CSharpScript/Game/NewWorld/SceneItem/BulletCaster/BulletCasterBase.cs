using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E9 RID: 25321
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BulletCasterBase : IBulletCaster
	{
		// Token: 0x0603D3C3 RID: 250819 RVA: 0x011ADFAC File Offset: 0x011AC1AC
		public BulletCasterBase(BulletCasterInitParam bulletCasterInitParam)
		{
			this.BulletCasterInitParam = bulletCasterInitParam;
			this.OwnerEntity = bulletCasterInitParam.OwnerEntity;
			this.CasterConfig = bulletCasterInitParam.CasterConfig;
			this.CasterRelTransform = bulletCasterInitParam.CasterRelTransform;
			this.BulletContextId = bulletCasterInitParam.BulletContextId;
			this.WarningEffect = bulletCasterInitParam.WarningEffect;
		}

		// Token: 0x0603D3C4 RID: 250820 RVA: 0x011AE018 File Offset: 0x011AC218
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

		// Token: 0x0603D3C5 RID: 250821
		protected abstract void OnStart();

		// Token: 0x0603D3C6 RID: 250822 RVA: 0x011AE0CC File Offset: 0x011AC2CC
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

		// Token: 0x0603D3C7 RID: 250823
		protected abstract void OnStop();

		// Token: 0x0603D3C8 RID: 250824 RVA: 0x011AE138 File Offset: 0x011AC338
		public virtual void SetTimeDilationRespectOwnerEntity()
		{
			PawnTimeScaleComponent component = this.OwnerEntity.GetComponent<PawnTimeScaleComponent>();
			float timeDilation = this.OwnerEntity.TimeDilation * ((component != null) ? component.CurrentTimeScale : 1f);
			this.SetTimeDilation(timeDilation);
		}

		// Token: 0x0603D3C9 RID: 250825 RVA: 0x011AE178 File Offset: 0x011AC378
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

		// Token: 0x0603D3CA RID: 250826
		protected abstract void OnSetTimeDilation(float timeDilation);

		// Token: 0x0603D3CB RID: 250827
		protected abstract void StartImmediately();

		// Token: 0x0603D3CC RID: 250828 RVA: 0x011AE1DC File Offset: 0x011AC3DC
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

		// Token: 0x0603D3CD RID: 250829
		protected abstract void SetEffectParam(int effectHandleId);

		// Token: 0x04020794 RID: 133012
		[Nullable(2)]
		public Entity OwnerEntity;

		// Token: 0x04020795 RID: 133013
		[Nullable(2)]
		public IBatchBulletCaster CasterConfig;

		// Token: 0x04020796 RID: 133014
		[Nullable(2)]
		public Transform CasterRelTransform;

		// Token: 0x04020797 RID: 133015
		public long BulletContextId;

		// Token: 0x04020798 RID: 133016
		public string WarningEffect = "";

		// Token: 0x04020799 RID: 133017
		private readonly List<TimerHandle> CasterWaitStartTimers = new List<TimerHandle>();

		// Token: 0x0402079A RID: 133018
		protected BulletCasterInitParam BulletCasterInitParam;
	}
}
