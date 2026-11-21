using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200405F RID: 16479
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWaitingProxyComponent
	{
		// Token: 0x06029C54 RID: 171092 RVA: 0x00BCC45E File Offset: 0x00BCA65E
		[NullableContext(1)]
		public void Init(PlotWaitingProxyComponentContext context)
		{
			this.OnWaitingCompleteDelegate = context.OnWaitingCompleteDelegate;
			this.OnWaitingCancelDelegate = context.OnWaitingCancelDelegate;
			this.OnWaitingStartDelegate = context.OnWaitingStartDelegate;
		}

		// Token: 0x06029C55 RID: 171093 RVA: 0x00BCC484 File Offset: 0x00BCA684
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

		// Token: 0x06029C56 RID: 171094 RVA: 0x00BCC4BF File Offset: 0x00BCA6BF
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

		// Token: 0x06029C57 RID: 171095 RVA: 0x00BCC4F4 File Offset: 0x00BCA6F4
		public void Pause()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			this.IsPaused = true;
		}

		// Token: 0x06029C58 RID: 171096 RVA: 0x00BCC506 File Offset: 0x00BCA706
		public void Resume()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			this.IsPaused = false;
		}

		// Token: 0x06029C59 RID: 171097 RVA: 0x00BCC518 File Offset: 0x00BCA718
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

		// Token: 0x06029C5A RID: 171098 RVA: 0x00BCC54D File Offset: 0x00BCA74D
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

		// Token: 0x06029C5B RID: 171099 RVA: 0x00BCC578 File Offset: 0x00BCA778
		public void Clear()
		{
			this.IsWaiting = false;
			this.IsPaused = false;
			this.ElapsedTime = 0f;
		}

		// Token: 0x06029C5C RID: 171100 RVA: 0x00BCC593 File Offset: 0x00BCA793
		public bool GetIsWaiting()
		{
			return this.IsWaiting;
		}

		// Token: 0x06029C5D RID: 171101 RVA: 0x00BCC59B File Offset: 0x00BCA79B
		public float GetWaitDuration()
		{
			return this.WaitDuration;
		}

		// Token: 0x06029C5E RID: 171102 RVA: 0x00BCC5A3 File Offset: 0x00BCA7A3
		public bool GetIsPaused()
		{
			return this.IsPaused;
		}

		// Token: 0x04016C91 RID: 93329
		private bool IsWaiting;

		// Token: 0x04016C92 RID: 93330
		private float WaitDuration;

		// Token: 0x04016C93 RID: 93331
		private float ElapsedTime;

		// Token: 0x04016C94 RID: 93332
		private bool IsPaused;

		// Token: 0x04016C95 RID: 93333
		private Action OnWaitingStartDelegate;

		// Token: 0x04016C96 RID: 93334
		private Action OnWaitingCompleteDelegate;

		// Token: 0x04016C97 RID: 93335
		private Action OnWaitingCancelDelegate;
	}
}
