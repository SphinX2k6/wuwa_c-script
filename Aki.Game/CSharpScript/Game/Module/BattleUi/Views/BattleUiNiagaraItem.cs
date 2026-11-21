using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD8 RID: 19672
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiNiagaraItem
	{
		// Token: 0x0603138F RID: 201615 RVA: 0x00DBDA32 File Offset: 0x00DBBC32
		public BattleUiNiagaraItem(UUINiagara item)
		{
			this.Item = item;
			this.Duration = 1000f;
			this.Item.bIsAlphaZeroClip = false;
		}

		// Token: 0x06031390 RID: 201616 RVA: 0x00DBDA58 File Offset: 0x00DBBC58
		public void Play()
		{
			this.Item.SetUIActive(true);
			this.Item.ActivateSystem(true);
			this.RemoveTimer();
			this.AddTimer();
		}

		// Token: 0x06031391 RID: 201617 RVA: 0x00DBDA7E File Offset: 0x00DBBC7E
		private void OnTimer(float _)
		{
			this.TimerId = null;
			this.StopInternal();
		}

		// Token: 0x06031392 RID: 201618 RVA: 0x00DBDA8D File Offset: 0x00DBBC8D
		public void Stop()
		{
			if (this.TimerId == null)
			{
				return;
			}
			this.RemoveTimer();
			this.StopInternal();
		}

		// Token: 0x06031393 RID: 201619 RVA: 0x00DBDAA4 File Offset: 0x00DBBCA4
		private void StopInternal()
		{
			this.Item.SetUIActive(false);
		}

		// Token: 0x06031394 RID: 201620 RVA: 0x00DBDAB2 File Offset: 0x00DBBCB2
		private void AddTimer()
		{
			this.TimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimer), this.Duration, null, null, true, 1f);
		}

		// Token: 0x06031395 RID: 201621 RVA: 0x00DBDADE File Offset: 0x00DBBCDE
		private void RemoveTimer()
		{
			if (this.TimerId != null)
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x0401A12D RID: 106797
		private const int DEFAULT_DURATION = 1000;

		// Token: 0x0401A12E RID: 106798
		public UUINiagara Item;

		// Token: 0x0401A12F RID: 106799
		public float Duration;

		// Token: 0x0401A130 RID: 106800
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
