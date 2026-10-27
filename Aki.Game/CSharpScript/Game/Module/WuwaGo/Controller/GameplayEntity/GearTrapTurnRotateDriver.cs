using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004772 RID: 18290
	[NullableContext(1)]
	[Nullable(0)]
	internal class GearTrapTurnRotateDriver
	{
		// Token: 0x0602FD17 RID: 195863 RVA: 0x00B1486C File Offset: 0x00B12A6C
		public GearTrapTurnRotateDriver(WuWaGoGameplayEntityBase entity, Rotator startRotator, Rotator targetRotator, int durationMs, int tickIntervalMs)
		{
			this.Entity = entity;
			this.DurationMs = durationMs;
			this.TickIntervalMs = tickIntervalMs;
			this.StartRotator.DeepCopy(startRotator);
			this.TargetRotator.DeepCopy(targetRotator);
		}

		// Token: 0x0602FD18 RID: 195864 RVA: 0x00B148DC File Offset: 0x00B12ADC
		public UniTask Run()
		{
			GearTrapTurnRotateDriver.<Run>d__12 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<GearTrapTurnRotateDriver.<Run>d__12>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD19 RID: 195865 RVA: 0x00B14920 File Offset: 0x00B12B20
		private void OnTick()
		{
			if (!this.Entity.IsActorValid())
			{
				this.Finish();
				return;
			}
			this.ElapsedMs += this.TickIntervalMs;
			float num = Math.Min(1f, (float)this.ElapsedMs / (float)this.DurationMs);
			Rotator.Lerp(this.StartRotator, this.TargetRotator, num, this.CurrentRotator);
			this.ApplyRotator(this.CurrentRotator);
			if (num >= 1f)
			{
				this.Finish();
			}
		}

		// Token: 0x0602FD1A RID: 195866 RVA: 0x00B149A0 File Offset: 0x00B12BA0
		private void OnTimeout()
		{
			this.Finish();
		}

		// Token: 0x0602FD1B RID: 195867 RVA: 0x00B149A8 File Offset: 0x00B12BA8
		private void ApplyRotator(Rotator rotator)
		{
			if (!this.Entity.IsActorValid())
			{
				return;
			}
			this.Entity.SetActorWorldRotation(rotator);
		}

		// Token: 0x0602FD1C RID: 195868 RVA: 0x00B149C4 File Offset: 0x00B12BC4
		private void Finish()
		{
			if (this.Resolved)
			{
				return;
			}
			if (this.Entity.IsActorValid())
			{
				this.ApplyRotator(this.TargetRotator);
			}
			this.Cancel();
		}

		// Token: 0x0602FD1D RID: 195869 RVA: 0x00B149F0 File Offset: 0x00B12BF0
		public void Cancel()
		{
			if (this.Resolved)
			{
				return;
			}
			this.Resolved = true;
			TimerHandle tickHandle = this.TickHandle;
			if (tickHandle != null && tickHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TickHandle);
			}
			TimerHandle timeoutHandle = this.TimeoutHandle;
			if (timeoutHandle != null && timeoutHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
			}
			this.Done.SetResult(default(UniTaskVoid));
		}

		// Token: 0x04019CBA RID: 105658
		private readonly CustomPromise<UniTaskVoid> Done = new CustomPromise<UniTaskVoid>();

		// Token: 0x04019CBB RID: 105659
		private readonly Rotator StartRotator = Rotator.Create();

		// Token: 0x04019CBC RID: 105660
		private readonly Rotator TargetRotator = Rotator.Create();

		// Token: 0x04019CBD RID: 105661
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x04019CBE RID: 105662
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x04019CBF RID: 105663
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x04019CC0 RID: 105664
		private int ElapsedMs;

		// Token: 0x04019CC1 RID: 105665
		private bool Resolved;

		// Token: 0x04019CC2 RID: 105666
		private readonly WuWaGoGameplayEntityBase Entity;

		// Token: 0x04019CC3 RID: 105667
		private readonly int DurationMs;

		// Token: 0x04019CC4 RID: 105668
		private readonly int TickIntervalMs;
	}
}
