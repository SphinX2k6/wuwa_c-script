using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D9F RID: 23967
	public class MotorcyclePercentMachine
	{
		// Token: 0x0603CD96 RID: 249238 RVA: 0x00E9DAD1 File Offset: 0x00E9BCD1
		public void Init(float percent, float? duration = null)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
			if (duration != null)
			{
				this.Duration = duration.Value;
				this.Speed = 0f;
			}
		}

		// Token: 0x0603CD97 RID: 249239 RVA: 0x00E9DB02 File Offset: 0x00E9BD02
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			this.TargetPercent = percent;
			this.Speed = (percent - this.CurPercent) / this.Duration;
		}

		// Token: 0x0603CD98 RID: 249240 RVA: 0x00E9DB2C File Offset: 0x00E9BD2C
		public bool Update(float delta)
		{
			if (this.Speed == 0f)
			{
				return false;
			}
			if (this.Speed > 0f)
			{
				this.CurPercent += this.Speed * delta;
				if (this.CurPercent >= this.TargetPercent)
				{
					this.CurPercent = this.TargetPercent;
					this.Speed = 0f;
				}
			}
			else
			{
				this.CurPercent += this.Speed * delta;
				if (this.CurPercent <= this.TargetPercent)
				{
					this.CurPercent = this.TargetPercent;
					this.Speed = 0f;
				}
			}
			return true;
		}

		// Token: 0x0603CD99 RID: 249241 RVA: 0x00E9DBCC File Offset: 0x00E9BDCC
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0603CD9A RID: 249242 RVA: 0x00E9DBD4 File Offset: 0x00E9BDD4
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401FB30 RID: 129840
		private const int DURATION = 100;

		// Token: 0x0401FB31 RID: 129841
		private float TargetPercent;

		// Token: 0x0401FB32 RID: 129842
		private float CurPercent;

		// Token: 0x0401FB33 RID: 129843
		private float Speed;

		// Token: 0x0401FB34 RID: 129844
		public float Duration = 100f;
	}
}
