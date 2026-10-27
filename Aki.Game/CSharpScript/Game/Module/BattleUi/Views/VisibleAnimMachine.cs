using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E37 RID: 24119
	[NullableContext(2)]
	[Nullable(0)]
	public class VisibleAnimMachine
	{
		// Token: 0x0603D53C RID: 251196 RVA: 0x00EC8B91 File Offset: 0x00EC6D91
		public void InitCallback(Action<bool> visibleCallback, Action<bool> playAnimCallback, Action<bool> stopAnimCallback)
		{
			this.VisibleCallback = visibleCallback;
			this.PlayAnimCallback = playAnimCallback;
			this.StopAnimCallback = stopAnimCallback;
		}

		// Token: 0x0603D53D RID: 251197 RVA: 0x00EC8BA8 File Offset: 0x00EC6DA8
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

		// Token: 0x0603D53E RID: 251198 RVA: 0x00EC8BC4 File Offset: 0x00EC6DC4
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

		// Token: 0x0603D53F RID: 251199 RVA: 0x00EC8C88 File Offset: 0x00EC6E88
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

		// Token: 0x0603D540 RID: 251200 RVA: 0x00EC8CFF File Offset: 0x00EC6EFF
		public void Reset()
		{
			this.DestroyTimer();
		}

		// Token: 0x0603D541 RID: 251201 RVA: 0x00EC8D07 File Offset: 0x00EC6F07
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

		// Token: 0x0603D542 RID: 251202 RVA: 0x00EC8D44 File Offset: 0x00EC6F44
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

		// Token: 0x0603D543 RID: 251203 RVA: 0x00EC8D7F File Offset: 0x00EC6F7F
		private void DestroyTimer()
		{
			if (this.AnimTimer != null)
			{
				TimerSystem.Instance.Remove(this.AnimTimer);
				this.AnimTimer = null;
			}
		}

		// Token: 0x0401FFD1 RID: 131025
		public int State;

		// Token: 0x0401FFD2 RID: 131026
		public bool Visible;

		// Token: 0x0401FFD3 RID: 131027
		public Action<bool> VisibleCallback;

		// Token: 0x0401FFD4 RID: 131028
		public Action<bool> PlayAnimCallback;

		// Token: 0x0401FFD5 RID: 131029
		public Action<bool> StopAnimCallback;

		// Token: 0x0401FFD6 RID: 131030
		private TimerHandle AnimTimer;

		// Token: 0x0200C1B4 RID: 49588
		[NullableContext(0)]
		private enum EVisibleAnimState
		{
			// Token: 0x0403A88D RID: 239757
			Hide,
			// Token: 0x0403A88E RID: 239758
			Show,
			// Token: 0x0403A88F RID: 239759
			ShowAnim,
			// Token: 0x0403A890 RID: 239760
			HideAnim
		}
	}
}
