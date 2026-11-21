using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CEB RID: 19691
	internal class ProgressPercentMachine
	{
		// Token: 0x060314CA RID: 201930 RVA: 0x00DC4BAE File Offset: 0x00DC2DAE
		public void SetDuration(float duration)
		{
			this.Duration = MathF.Max(duration, 1E-08f);
		}

		// Token: 0x060314CB RID: 201931 RVA: 0x00DC4BC1 File Offset: 0x00DC2DC1
		public void SetCurrentPercent(float percent)
		{
			this.CurPercent = percent;
		}

		// Token: 0x060314CC RID: 201932 RVA: 0x00DC4BCC File Offset: 0x00DC2DCC
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

		// Token: 0x060314CD RID: 201933 RVA: 0x00DC4C2A File Offset: 0x00DC2E2A
		public void UpdateSpeed(bool check = false)
		{
			this.Speed = (this.TargetPercent - this.CurPercent) / this.Duration;
			if (check && this.Speed == 0f)
			{
				this.Speed = this.Duration * 0.1f;
			}
		}

		// Token: 0x060314CE RID: 201934 RVA: 0x00DC4C68 File Offset: 0x00DC2E68
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

		// Token: 0x060314CF RID: 201935 RVA: 0x00DC4CF3 File Offset: 0x00DC2EF3
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401A1A3 RID: 106915
		private float TargetPercent;

		// Token: 0x0401A1A4 RID: 106916
		private float CurPercent;

		// Token: 0x0401A1A5 RID: 106917
		private float Speed;

		// Token: 0x0401A1A6 RID: 106918
		private float Duration = 1f;
	}
}
