using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A3 RID: 13987
	[NullableContext(1)]
	[Nullable(0)]
	internal class GearTrapTurnRotateDriver
	{
		// Token: 0x060244E1 RID: 148705 RVA: 0x00A448E0 File Offset: 0x00A42AE0
		public GearTrapTurnRotateDriver(WuWaGoGameplayEntityBase entity, Rotator startRotator, Rotator targetRotator, int durationMs, int tickIntervalMs)
		{
			this.Entity = entity;
			this.DurationMs = durationMs;
			this.TickIntervalMs = tickIntervalMs;
			this.StartRotator.DeepCopy(startRotator);
			this.TargetRotator.DeepCopy(targetRotator);
		}

		// Token: 0x060244E2 RID: 148706 RVA: 0x00A44950 File Offset: 0x00A42B50
		public UniTask Run()
		{
			GearTrapTurnRotateDriver.<Run>d__12 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<GearTrapTurnRotateDriver.<Run>d__12>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x060244E3 RID: 148707 RVA: 0x00A44994 File Offset: 0x00A42B94
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

		// Token: 0x060244E4 RID: 148708 RVA: 0x00A44A14 File Offset: 0x00A42C14
		private void OnTimeout()
		{
			this.Finish();
		}

		// Token: 0x060244E5 RID: 148709 RVA: 0x00A44A1C File Offset: 0x00A42C1C
		private void ApplyRotator(Rotator rotator)
		{
			if (!this.Entity.IsActorValid())
			{
				return;
			}
			this.Entity.SetActorWorldRotation(rotator);
		}

		// Token: 0x060244E6 RID: 148710 RVA: 0x00A44A38 File Offset: 0x00A42C38
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

		// Token: 0x060244E7 RID: 148711 RVA: 0x00A44A64 File Offset: 0x00A42C64
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

		// Token: 0x0401436A RID: 82794
		private readonly CustomPromise<UniTaskVoid> Done = new CustomPromise<UniTaskVoid>();

		// Token: 0x0401436B RID: 82795
		private readonly Rotator StartRotator = Rotator.Create();

		// Token: 0x0401436C RID: 82796
		private readonly Rotator TargetRotator = Rotator.Create();

		// Token: 0x0401436D RID: 82797
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401436E RID: 82798
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x0401436F RID: 82799
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x04014370 RID: 82800
		private int ElapsedMs;

		// Token: 0x04014371 RID: 82801
		private bool Resolved;

		// Token: 0x04014372 RID: 82802
		private readonly WuWaGoGameplayEntityBase Entity;

		// Token: 0x04014373 RID: 82803
		private readonly int DurationMs;

		// Token: 0x04014374 RID: 82804
		private readonly int TickIntervalMs;
	}
}
