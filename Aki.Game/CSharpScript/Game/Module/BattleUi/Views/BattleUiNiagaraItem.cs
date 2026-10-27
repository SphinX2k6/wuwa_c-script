using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF6 RID: 23798
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiNiagaraItem
	{
		// Token: 0x0603C439 RID: 246841 RVA: 0x00E6D47E File Offset: 0x00E6B67E
		public BattleUiNiagaraItem(UUINiagara item)
		{
			this.Item = item;
			this.Duration = 1000f;
			this.Item.bIsAlphaZeroClip = false;
		}

		// Token: 0x0603C43A RID: 246842 RVA: 0x00E6D4A4 File Offset: 0x00E6B6A4
		public void Play()
		{
			this.Item.SetUIActive(true);
			this.Item.ActivateSystem(true);
			this.RemoveTimer();
			this.AddTimer();
		}

		// Token: 0x0603C43B RID: 246843 RVA: 0x00E6D4CA File Offset: 0x00E6B6CA
		private void OnTimer(float _)
		{
			this.TimerId = null;
			this.StopInternal();
		}

		// Token: 0x0603C43C RID: 246844 RVA: 0x00E6D4D9 File Offset: 0x00E6B6D9
		public void Stop()
		{
			if (this.TimerId == null)
			{
				return;
			}
			this.RemoveTimer();
			this.StopInternal();
		}

		// Token: 0x0603C43D RID: 246845 RVA: 0x00E6D4F0 File Offset: 0x00E6B6F0
		private void StopInternal()
		{
			this.Item.SetUIActive(false);
		}

		// Token: 0x0603C43E RID: 246846 RVA: 0x00E6D4FE File Offset: 0x00E6B6FE
		private void AddTimer()
		{
			this.TimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimer), this.Duration, null, null, true, 1f);
		}

		// Token: 0x0603C43F RID: 246847 RVA: 0x00E6D52A File Offset: 0x00E6B72A
		private void RemoveTimer()
		{
			if (this.TimerId != null)
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x0401F674 RID: 128628
		private const int DEFAULT_DURATION = 1000;

		// Token: 0x0401F675 RID: 128629
		public UUINiagara Item;

		// Token: 0x0401F676 RID: 128630
		public float Duration;

		// Token: 0x0401F677 RID: 128631
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
