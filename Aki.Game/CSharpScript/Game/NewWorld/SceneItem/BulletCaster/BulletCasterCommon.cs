using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x0200722D RID: 29229
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BulletCasterCommon : BulletCasterBase
	{
		// Token: 0x06047A49 RID: 293449 RVA: 0x012548B0 File Offset: 0x01252AB0
		protected BulletCasterCommon(BulletCasterInitParam bulletCasterInitParam) : base(bulletCasterInitParam)
		{
		}

		// Token: 0x06047A4A RID: 293450 RVA: 0x012548DC File Offset: 0x01252ADC
		protected override void OnStop()
		{
			foreach (TimerHandle timerHandle in this.BulletWaitWarningTimers)
			{
				if (timerHandle.Valid())
				{
					timerHandle.Remove();
				}
			}
			this.BulletWaitWarningTimers.Clear();
			foreach (int num in this.WarningEffectHandles)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, "[BulletCaster] Stop", false, null);
				}
			}
			this.WarningEffectHandles.Clear();
			foreach (KeyValuePair<int, TimerHandle> keyValuePair in this.DestroyBulletTimers)
			{
				int num2;
				TimerHandle timerHandle2;
				keyValuePair.Deconstruct(out num2, out timerHandle2);
				int id = num2;
				TimerHandle timerHandle3 = timerHandle2;
				if (timerHandle3.Valid())
				{
					timerHandle3.Remove();
				}
				BulletController.Instance.DestroyBullet(id, true, EBulletDestroyReason.Normal, false);
			}
			this.DestroyBulletTimers.Clear();
		}

		// Token: 0x06047A4B RID: 293451 RVA: 0x01254A2C File Offset: 0x01252C2C
		protected override void OnSetTimeDilation(float timeDilation)
		{
			foreach (TimerHandle timerHandle in this.BulletWaitWarningTimers)
			{
				if (timerHandle.Valid())
				{
					BulletCasterUtils.SetTimerHandleTimeDilation(timerHandle, timeDilation);
				}
			}
			float num = (this.CasterConfig.WarningTime > 0) ? (1f / ((float)this.CasterConfig.WarningTime * 0.001f)) : 1f;
			foreach (int id in this.WarningEffectHandles)
			{
				if (EffectSystem.Instance.IsValid(id))
				{
					EffectSystem.Instance.SetTimeScale(id, timeDilation * num, false);
				}
			}
			foreach (KeyValuePair<int, TimerHandle> keyValuePair in this.DestroyBulletTimers)
			{
				int num2;
				TimerHandle timerHandle2;
				keyValuePair.Deconstruct(out num2, out timerHandle2);
				int id2 = num2;
				TimerHandle timerHandle3 = timerHandle2;
				BulletModel instance = BulletModel.Instance;
				BulletEntity bulletEntity = (instance != null) ? instance.GetBulletEntityById(id2) : null;
				if (bulletEntity != null && bulletEntity.Valid)
				{
					bulletEntity.SetTimeDilation(timeDilation);
				}
				if (timerHandle3.Valid())
				{
					BulletCasterUtils.SetTimerHandleTimeDilation(timerHandle3, timeDilation);
				}
			}
		}

		// Token: 0x04025B18 RID: 154392
		protected readonly HashSet<int> WarningEffectHandles = new HashSet<int>();

		// Token: 0x04025B19 RID: 154393
		protected readonly HashSet<TimerHandle> BulletWaitWarningTimers = new HashSet<TimerHandle>();

		// Token: 0x04025B1A RID: 154394
		protected readonly Dictionary<int, TimerHandle> DestroyBulletTimers = new Dictionary<int, TimerHandle>();
	}
}
