using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CAC RID: 23724
	public class AlertAreaUpdateMachine
	{
		// Token: 0x0603BEED RID: 245485 RVA: 0x00E52666 File Offset: 0x00E50866
		public void Init(float percent)
		{
			this.BarCurPercent = percent;
			this.BarTargetPercent = percent;
		}

		// Token: 0x0603BEEE RID: 245486 RVA: 0x00E52676 File Offset: 0x00E50876
		public bool Update(float delta)
		{
			return this.UpdateBarData(delta);
		}

		// Token: 0x0603BEEF RID: 245487 RVA: 0x00E52680 File Offset: 0x00E50880
		public void ChangeTargetPercent(float newTargetPercent)
		{
			if (newTargetPercent == this.BarTargetPercent)
			{
				return;
			}
			if (newTargetPercent > this.BarTargetPercent)
			{
				this.BarCurPercent = Math.Min(this.BarCurPercent, this.BarTargetPercent);
			}
			else
			{
				this.BarCurPercent = Math.Max(this.BarCurPercent, this.BarTargetPercent);
			}
			this.BarTargetPercent = newTargetPercent;
			this.BarProgressSpeed = (newTargetPercent - this.BarCurPercent) / 500f;
			this.ProgressDir = Math.Sign(this.BarProgressSpeed);
		}

		// Token: 0x0603BEF0 RID: 245488 RVA: 0x00E526FC File Offset: 0x00E508FC
		private bool UpdateBarData(float delta)
		{
			if (this.BarProgressSpeed == 0f)
			{
				return false;
			}
			this.BarCurPercent += this.BarProgressSpeed * delta;
			if ((this.BarProgressSpeed > 0f && this.BarCurPercent >= this.BarTargetPercent) || (this.BarProgressSpeed < 0f && this.BarCurPercent <= this.BarTargetPercent))
			{
				this.BarCurPercent = this.BarTargetPercent;
				this.BarProgressSpeed = 0f;
			}
			return true;
		}

		// Token: 0x0603BEF1 RID: 245489 RVA: 0x00E5277B File Offset: 0x00E5097B
		public float GetBarCurPercent()
		{
			return this.BarCurPercent;
		}

		// Token: 0x0603BEF2 RID: 245490 RVA: 0x00E52783 File Offset: 0x00E50983
		public float GetBarTargetPercent()
		{
			return this.BarTargetPercent;
		}

		// Token: 0x0603BEF3 RID: 245491 RVA: 0x00E5278B File Offset: 0x00E5098B
		public int GetProgressDir()
		{
			return this.ProgressDir;
		}

		// Token: 0x0401F467 RID: 128103
		private const int BAR_ANI_DURATION = 500;

		// Token: 0x0401F468 RID: 128104
		private float BarTargetPercent;

		// Token: 0x0401F469 RID: 128105
		private float BarCurPercent;

		// Token: 0x0401F46A RID: 128106
		private float BarProgressSpeed;

		// Token: 0x0401F46B RID: 128107
		private int ProgressDir;
	}
}
