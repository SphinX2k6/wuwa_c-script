using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E1 RID: 25313
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterBatch : IBulletCaster
	{
		// Token: 0x0603D3A1 RID: 250785 RVA: 0x011AD0B4 File Offset: 0x011AB2B4
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

		// Token: 0x0603D3A2 RID: 250786 RVA: 0x011AD1C8 File Offset: 0x011AB3C8
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

		// Token: 0x0603D3A3 RID: 250787 RVA: 0x011AD21C File Offset: 0x011AB41C
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

		// Token: 0x0603D3A4 RID: 250788 RVA: 0x011AD2BC File Offset: 0x011AB4BC
		public void SetTimeDilationRespectOwnerEntity()
		{
			PawnTimeScaleComponent component = this.OwnerEntity.GetComponent<PawnTimeScaleComponent>();
			float timeDilation = this.OwnerEntity.TimeDilation * ((component != null) ? component.CurrentTimeScale : 1f);
			this.SetTimeDilation(timeDilation);
		}

		// Token: 0x0603D3A5 RID: 250789 RVA: 0x011AD2FC File Offset: 0x011AB4FC
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

		// Token: 0x0603D3A6 RID: 250790 RVA: 0x011AD390 File Offset: 0x011AB590
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

		// Token: 0x0603D3A7 RID: 250791 RVA: 0x011AD3E8 File Offset: 0x011AB5E8
		private void TriggerCasters()
		{
			foreach (IBulletCaster bulletCaster in this.BulletCasters)
			{
				bulletCaster.Start();
			}
		}

		// Token: 0x04020781 RID: 132993
		public readonly List<IBulletCaster> BulletCasters = new List<IBulletCaster>();

		// Token: 0x04020782 RID: 132994
		[Nullable(2)]
		private TimerHandle BatchDelayStartTimer;

		// Token: 0x04020783 RID: 132995
		[Nullable(2)]
		private TimerHandle BatchLoopTimer;

		// Token: 0x04020784 RID: 132996
		public Entity OwnerEntity;

		// Token: 0x04020785 RID: 132997
		public float LoopInterval;

		// Token: 0x04020786 RID: 132998
		public float DelayTime;
	}
}
