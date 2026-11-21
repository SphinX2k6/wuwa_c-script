using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E1C RID: 19996
	[NullableContext(2)]
	[Nullable(0)]
	public class VisibleAnimMachine
	{
		// Token: 0x060324CC RID: 206028 RVA: 0x00E1A0FD File Offset: 0x00E182FD
		public void InitCallback(Action<bool> visibleCallback, Action<bool> playAnimCallback, Action<bool> stopAnimCallback)
		{
			this.VisibleCallback = visibleCallback;
			this.PlayAnimCallback = playAnimCallback;
			this.StopAnimCallback = stopAnimCallback;
		}

		// Token: 0x060324CD RID: 206029 RVA: 0x00E1A114 File Offset: 0x00E18314
		public void InitVisible(bool value)
		{
			this.Visible = value;
			if (value)
			{
				this.State = 1;
				return;
			}
			this.State = 0;
		}

		// Token: 0x060324CE RID: 206030 RVA: 0x00E1A130 File Offset: 0x00E18330
		public void SetVisible(bool value, float animTime)
		{
			if (this.Visible == value)
			{
				return;
			}
			this.Visible = value;
			Action<bool> stopAnimCallback = this.StopAnimCallback;
			if (stopAnimCallback != null)
			{
				stopAnimCallback(!value);
			}
			if (animTime > 0f)
			{
				if (value)
				{
					Action<bool> visibleCallback = this.VisibleCallback;
					if (visibleCallback != null)
					{
						visibleCallback(true);
					}
					this.State = 2;
				}
				else
				{
					this.State = 3;
				}
				Action<bool> playAnimCallback = this.PlayAnimCallback;
				if (playAnimCallback != null)
				{
					playAnimCallback(value);
				}
				this.DestroyTimer();
				this.AnimTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnAnimFinish), animTime, null, null, true, 1f);
				return;
			}
			if (value)
			{
				this.State = 1;
			}
			else
			{
				this.State = 0;
			}
			Action<bool> visibleCallback2 = this.VisibleCallback;
			if (visibleCallback2 == null)
			{
				return;
			}
			visibleCallback2(value);
		}

		// Token: 0x060324CF RID: 206031 RVA: 0x00E1A1F4 File Offset: 0x00E183F4
		public void ForcePlayShowAnim(int animTime)
		{
			if (this.State == 2)
			{
				return;
			}
			if (this.State == 3)
			{
				Action<bool> stopAnimCallback = this.StopAnimCallback;
				if (stopAnimCallback != null)
				{
					stopAnimCallback(false);
				}
			}
			this.State = 2;
			Action<bool> playAnimCallback = this.PlayAnimCallback;
			if (playAnimCallback != null)
			{
				playAnimCallback(true);
			}
			this.DestroyTimer();
			this.AnimTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnAnimFinish), (float)animTime, null, null, true, 1f);
		}

		// Token: 0x060324D0 RID: 206032 RVA: 0x00E1A26B File Offset: 0x00E1846B
		public void Reset()
		{
			this.DestroyTimer();
		}

		// Token: 0x060324D1 RID: 206033 RVA: 0x00E1A273 File Offset: 0x00E18473
		public void Deactivate()
		{
			this.DestroyTimer();
			if (this.State != 3)
			{
				if (this.State == 2)
				{
					Action<bool> stopAnimCallback = this.StopAnimCallback;
					if (stopAnimCallback == null)
					{
						return;
					}
					stopAnimCallback(true);
				}
				return;
			}
			Action<bool> stopAnimCallback2 = this.StopAnimCallback;
			if (stopAnimCallback2 == null)
			{
				return;
			}
			stopAnimCallback2(false);
		}

		// Token: 0x060324D2 RID: 206034 RVA: 0x00E1A2B0 File Offset: 0x00E184B0
		private void OnAnimFinish(float _)
		{
			this.AnimTimer = null;
			if (this.State != 3)
			{
				if (this.State == 2)
				{
					this.State = 1;
				}
				return;
			}
			this.State = 0;
			Action<bool> visibleCallback = this.VisibleCallback;
			if (visibleCallback == null)
			{
				return;
			}
			visibleCallback(false);
		}

		// Token: 0x060324D3 RID: 206035 RVA: 0x00E1A2EB File Offset: 0x00E184EB
		private void DestroyTimer()
		{
			if (this.AnimTimer != null)
			{
				TimerSystem.Instance.Remove(this.AnimTimer);
				this.AnimTimer = null;
			}
		}

		// Token: 0x0401AA98 RID: 109208
		public int State;

		// Token: 0x0401AA99 RID: 109209
		public bool Visible;

		// Token: 0x0401AA9A RID: 109210
		public Action<bool> VisibleCallback;

		// Token: 0x0401AA9B RID: 109211
		public Action<bool> PlayAnimCallback;

		// Token: 0x0401AA9C RID: 109212
		public Action<bool> StopAnimCallback;

		// Token: 0x0401AA9D RID: 109213
		private TimerHandle AnimTimer;

		// Token: 0x0200ABC3 RID: 43971
		[NullableContext(0)]
		private enum EVisibleAnimState
		{
			// Token: 0x0403527F RID: 217727
			Hide,
			// Token: 0x04035280 RID: 217728
			Show,
			// Token: 0x04035281 RID: 217729
			ShowAnim,
			// Token: 0x04035282 RID: 217730
			HideAnim
		}
	}
}
