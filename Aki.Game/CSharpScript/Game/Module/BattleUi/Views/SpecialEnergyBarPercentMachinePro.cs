using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E23 RID: 24099
	public class SpecialEnergyBarPercentMachinePro
	{
		// Token: 0x0603D49F RID: 251039 RVA: 0x00EC5338 File Offset: 0x00EC3538
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			this.TargetPercent = percent;
			if (this.Duration <= 0f)
			{
				this.CurPercent = this.TargetPercent;
				this.Speed = 0f;
				return;
			}
			this.Speed = (this.TargetPercent - this.CurPercent) / this.Duration;
		}

		// Token: 0x0603D4A0 RID: 251040 RVA: 0x00EC5398 File Offset: 0x00EC3598
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

		// Token: 0x0603D4A1 RID: 251041 RVA: 0x00EC5423 File Offset: 0x00EC3623
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401FF5D RID: 130909
		public float Duration = 100f;

		// Token: 0x0401FF5E RID: 130910
		private float TargetPercent;

		// Token: 0x0401FF5F RID: 130911
		private float CurPercent;

		// Token: 0x0401FF60 RID: 130912
		private float Speed;
	}
}
