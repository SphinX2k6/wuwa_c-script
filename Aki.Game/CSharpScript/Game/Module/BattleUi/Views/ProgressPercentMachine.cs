using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D09 RID: 23817
	internal class ProgressPercentMachine
	{
		// Token: 0x0603C571 RID: 247153 RVA: 0x00E74546 File Offset: 0x00E72746
		public void SetDuration(float duration)
		{
			this.Duration = MathF.Max(duration, 1E-08f);
		}

		// Token: 0x0603C572 RID: 247154 RVA: 0x00E74559 File Offset: 0x00E72759
		public void SetCurrentPercent(float percent)
		{
			this.CurPercent = percent;
		}

		// Token: 0x0603C573 RID: 247155 RVA: 0x00E74564 File Offset: 0x00E72764
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			if (percent > this.TargetPercent && percent < 1f)
			{
				this.TargetPercent = percent;
				this.Speed = (percent - this.CurPercent) / this.Duration;
				return;
			}
			this.TargetPercent = percent;
			this.CurPercent = percent;
			this.Speed = 0f;
		}

		// Token: 0x0603C574 RID: 247156 RVA: 0x00E745C2 File Offset: 0x00E727C2
		public void UpdateSpeed(bool check = false)
		{
			this.Speed = (this.TargetPercent - this.CurPercent) / this.Duration;
			if (check && this.Speed == 0f)
			{
				this.Speed = this.Duration * 0.1f;
			}
		}

		// Token: 0x0603C575 RID: 247157 RVA: 0x00E74600 File Offset: 0x00E72800
		public bool Update(float delta)
		{
			if (this.Speed == 0f)
			{
				return false;
			}
			this.CurPercent += this.Speed * delta;
			if (this.Speed > 0f)
			{
				if (this.CurPercent >= this.TargetPercent)
				{
					this.CurPercent = this.TargetPercent;
					this.Speed = 0f;
				}
			}
			else if (this.CurPercent <= this.TargetPercent)
			{
				this.CurPercent = this.TargetPercent;
				this.Speed = 0f;
			}
			return true;
		}

		// Token: 0x0603C576 RID: 247158 RVA: 0x00E7468B File Offset: 0x00E7288B
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401F6EA RID: 128746
		private float TargetPercent;

		// Token: 0x0401F6EB RID: 128747
		private float CurPercent;

		// Token: 0x0401F6EC RID: 128748
		private float Speed;

		// Token: 0x0401F6ED RID: 128749
		private float Duration = 1f;
	}
}
