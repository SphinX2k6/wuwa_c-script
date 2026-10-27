using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200508F RID: 20623
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWaitingProxyComponent
	{
		// Token: 0x06034D5B RID: 216411 RVA: 0x00C7EEAE File Offset: 0x00C7D0AE
		[NullableContext(1)]
		public void Init(PlotWaitingProxyComponentContext context)
		{
			this.OnWaitingCompleteDelegate = context.OnWaitingCompleteDelegate;
			this.OnWaitingCancelDelegate = context.OnWaitingCancelDelegate;
			this.OnWaitingStartDelegate = context.OnWaitingStartDelegate;
		}

		// Token: 0x06034D5C RID: 216412 RVA: 0x00C7EED4 File Offset: 0x00C7D0D4
		public void Wait(float duration)
		{
			if (this.IsWaiting)
			{
				return;
			}
			this.WaitDuration = duration;
			this.ElapsedTime = 0f;
			this.IsWaiting = true;
			this.IsPaused = false;
			Action onWaitingStartDelegate = this.OnWaitingStartDelegate;
			if (onWaitingStartDelegate == null)
			{
				return;
			}
			onWaitingStartDelegate();
		}

		// Token: 0x06034D5D RID: 216413 RVA: 0x00C7EF0F File Offset: 0x00C7D10F
		public void Cancel()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			Action onWaitingCancelDelegate = this.OnWaitingCancelDelegate;
			if (onWaitingCancelDelegate != null)
			{
				onWaitingCancelDelegate();
			}
			this.IsWaiting = false;
			this.IsPaused = false;
			this.ElapsedTime = 0f;
		}

		// Token: 0x06034D5E RID: 216414 RVA: 0x00C7EF44 File Offset: 0x00C7D144
		public void Pause()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			this.IsPaused = true;
		}

		// Token: 0x06034D5F RID: 216415 RVA: 0x00C7EF56 File Offset: 0x00C7D156
		public void Resume()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			this.IsPaused = false;
		}

		// Token: 0x06034D60 RID: 216416 RVA: 0x00C7EF68 File Offset: 0x00C7D168
		public void OnTick(float delta)
		{
			if (!this.IsWaiting || this.IsPaused)
			{
				return;
			}
			this.ElapsedTime += delta;
			if (this.ElapsedTime >= this.WaitDuration)
			{
				this.OnWaitingComplete();
			}
		}

		// Token: 0x06034D61 RID: 216417 RVA: 0x00C7EF9D File Offset: 0x00C7D19D
		private void OnWaitingComplete()
		{
			this.IsWaiting = false;
			this.IsPaused = false;
			this.ElapsedTime = 0f;
			Action onWaitingCompleteDelegate = this.OnWaitingCompleteDelegate;
			if (onWaitingCompleteDelegate == null)
			{
				return;
			}
			onWaitingCompleteDelegate();
		}

		// Token: 0x06034D62 RID: 216418 RVA: 0x00C7EFC8 File Offset: 0x00C7D1C8
		public void Clear()
		{
			this.IsWaiting = false;
			this.IsPaused = false;
			this.ElapsedTime = 0f;
		}

		// Token: 0x06034D63 RID: 216419 RVA: 0x00C7EFE3 File Offset: 0x00C7D1E3
		public bool GetIsWaiting()
		{
			return this.IsWaiting;
		}

		// Token: 0x06034D64 RID: 216420 RVA: 0x00C7EFEB File Offset: 0x00C7D1EB
		public float GetWaitDuration()
		{
			return this.WaitDuration;
		}

		// Token: 0x06034D65 RID: 216421 RVA: 0x00C7EFF3 File Offset: 0x00C7D1F3
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x0401C262 RID: 115298
		private bool IsWaiting;

		// Token: 0x0401C263 RID: 115299
		private float WaitDuration;

		// Token: 0x0401C264 RID: 115300
		private float ElapsedTime;

		// Token: 0x0401C265 RID: 115301
		private bool IsPaused;

		// Token: 0x0401C266 RID: 115302
		private Action OnWaitingStartDelegate;

		// Token: 0x0401C267 RID: 115303
		private Action OnWaitingCompleteDelegate;

		// Token: 0x0401C268 RID: 115304
		private Action OnWaitingCancelDelegate;
	}
}
