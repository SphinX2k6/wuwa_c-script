using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E08 RID: 19976
	public class SpecialEnergyBarPercentMachinePro
	{
		// Token: 0x0603242E RID: 205870 RVA: 0x00E16898 File Offset: 0x00E14A98
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

		// Token: 0x0603242F RID: 205871 RVA: 0x00E168F8 File Offset: 0x00E14AF8
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

		// Token: 0x06032430 RID: 205872 RVA: 0x00E16983 File Offset: 0x00E14B83
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401AA24 RID: 109092
		public float Duration = 100f;

		// Token: 0x0401AA25 RID: 109093
		private float TargetPercent;

		// Token: 0x0401AA26 RID: 109094
		private float CurPercent;

		// Token: 0x0401AA27 RID: 109095
		private float Speed;
	}
}
