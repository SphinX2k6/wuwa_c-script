using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x0200722C RID: 29228
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterBatch : IBulletCaster
	{
		// Token: 0x06047A40 RID: 293440 RVA: 0x0125451C File Offset: 0x0125271C
		public unsafe BulletCasterBatch(Entity ownerEntity, float loopInterval, float delayTime, List<IBatchBulletCaster> casterList, string warmingEffect, long contextMessageId, List<Transform> casterTransformList, EBatchBulletMovementType? movementType)
		{
			this.OwnerEntity = ownerEntity;
			this.LoopInterval = loopInterval;
			this.DelayTime = delayTime;
			foreach (IBatchBulletCaster batchBulletCaster in casterList)
			{
				int index = batchBulletCaster.BulletIndex - 1;
				BulletCasterInitParam bulletCasterInitParam = new BulletCasterInitParam(ownerEntity, batchBulletCaster, casterTransformList[index], contextMessageId, warmingEffect);
				IBulletCaster instance = BulletCasterClassFactory.Instance.GetInstance(movementType.GetValueOrDefault(), bulletCasterInitParam);
				if (instance != null)
				{
					this.BulletCasters.Add(instance);
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "构建批量发射子弹的时候工厂里面没拿出来";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("movementType", movementType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bulletCasterInitParam", bulletCasterInitParam);
					instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x06047A41 RID: 293441 RVA: 0x01254630 File Offset: 0x01252830
		public void Start()
		{
			if (this.DelayTime < 20f)
			{
				this.StartImmediately();
			}
			else
			{
				this.BatchDelayStartTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.StartImmediately();
				}, this.DelayTime, null, null, true, 1f);
			}
			this.SetTimeDilationRespectOwnerEntity();
		}

		// Token: 0x06047A42 RID: 293442 RVA: 0x01254684 File Offset: 0x01252884
		public void Stop()
		{
			foreach (IBulletCaster bulletCaster in this.BulletCasters)
			{
				bulletCaster.Stop();
			}
			TimerHandle batchLoopTimer = this.BatchLoopTimer;
			if (batchLoopTimer != null && batchLoopTimer.Valid())
			{
				this.BatchLoopTimer.Remove();
			}
			this.BatchLoopTimer = null;
			TimerHandle batchDelayStartTimer = this.BatchDelayStartTimer;
			if (batchDelayStartTimer != null && batchDelayStartTimer.Valid())
			{
				this.BatchDelayStartTimer.Remove();
			}
			this.BatchDelayStartTimer = null;
		}

		// Token: 0x06047A43 RID: 293443 RVA: 0x01254724 File Offset: 0x01252924
		public void SetTimeDilationRespectOwnerEntity()
		{
			PawnTimeScaleComponent component = this.OwnerEntity.GetComponent<PawnTimeScaleComponent>();
			float timeDilation = this.OwnerEntity.TimeDilation * ((component != null) ? component.CurrentTimeScale : 1f);
			this.SetTimeDilation(timeDilation);
		}

		// Token: 0x06047A44 RID: 293444 RVA: 0x01254764 File Offset: 0x01252964
		public void SetTimeDilation(float timeDilation)
		{
			TimerHandle batchDelayStartTimer = this.BatchDelayStartTimer;
			if (batchDelayStartTimer != null && batchDelayStartTimer.Valid())
			{
				BulletCasterUtils.SetTimerHandleTimeDilation(this.BatchDelayStartTimer, timeDilation);
			}
			TimerHandle batchLoopTimer = this.BatchLoopTimer;
			if (batchLoopTimer != null && batchLoopTimer.Valid())
			{
				BulletCasterUtils.SetTimerHandleTimeDilation(this.BatchLoopTimer, timeDilation);
			}
			foreach (IBulletCaster bulletCaster in this.BulletCasters)
			{
				bulletCaster.SetTimeDilation(timeDilation);
			}
		}

		// Token: 0x06047A45 RID: 293445 RVA: 0x012547F8 File Offset: 0x012529F8
		private void StartImmediately()
		{
			if (this.LoopInterval < 20f)
			{
				this.TriggerCasters();
			}
			else
			{
				this.TriggerCasters();
				this.BatchLoopTimer = TimerSystem.Instance.Forever(delegate(float _)
				{
					this.TriggerCasters();
				}, this.LoopInterval, 1f, null, null, true);
			}
			this.SetTimeDilationRespectOwnerEntity();
		}

		// Token: 0x06047A46 RID: 293446 RVA: 0x01254850 File Offset: 0x01252A50
		private void TriggerCasters()
		{
			foreach (IBulletCaster bulletCaster in this.BulletCasters)
			{
				bulletCaster.Start();
			}
		}

		// Token: 0x04025B12 RID: 154386
		public readonly List<IBulletCaster> BulletCasters = new List<IBulletCaster>();

		// Token: 0x04025B13 RID: 154387
		[Nullable(2)]
		private TimerHandle BatchDelayStartTimer;

		// Token: 0x04025B14 RID: 154388
		[Nullable(2)]
		private TimerHandle BatchLoopTimer;

		// Token: 0x04025B15 RID: 154389
		public Entity OwnerEntity;

		// Token: 0x04025B16 RID: 154390
		public float LoopInterval;

		// Token: 0x04025B17 RID: 154391
		public float DelayTime;
	}
}
