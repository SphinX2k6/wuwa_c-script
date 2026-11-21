using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E07 RID: 19975
	public class SpecialEnergyBarPercentMachine
	{
		// Token: 0x06032428 RID: 205864 RVA: 0x00E167AF File Offset: 0x00E149AF
		public void Init(float percent)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
		}

		// Token: 0x06032429 RID: 205865 RVA: 0x00E167C0 File Offset: 0x00E149C0
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			if (percent > this.TargetPercent)
			{
				this.TargetPercent = percent;
				this.CurPercent = Math.Min(this.CurPercent, percent);
				this.Speed = (percent - this.CurPercent) / 100f;
				return;
			}
			this.TargetPercent = percent;
			this.CurPercent = percent;
			this.Speed = 0f;
		}

		// Token: 0x0603242A RID: 205866 RVA: 0x00E16828 File Offset: 0x00E14A28
		public bool Update(float delta)
		{
			if (this.Speed == 0f)
			{
				return false;
			}
			this.CurPercent += this.Speed * delta;
			if (this.CurPercent >= this.TargetPercent)
			{
				this.CurPercent = this.TargetPercent;
				this.Speed = 0f;
			}
			return true;
		}

		// Token: 0x0603242B RID: 205867 RVA: 0x00E1687F File Offset: 0x00E14A7F
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0603242C RID: 205868 RVA: 0x00E16887 File Offset: 0x00E14A87
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401AA20 RID: 109088
		private const int DURATION = 100;

		// Token: 0x0401AA21 RID: 109089
		private float TargetPercent;

		// Token: 0x0401AA22 RID: 109090
		private float CurPercent;

		// Token: 0x0401AA23 RID: 109091
		private float Speed;
	}
}
