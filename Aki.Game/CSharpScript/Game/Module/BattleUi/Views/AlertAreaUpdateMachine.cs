using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C8E RID: 19598
	public class AlertAreaUpdateMachine
	{
		// Token: 0x06030E40 RID: 200256 RVA: 0x00DA2D0E File Offset: 0x00DA0F0E
		public void Init(float percent)
		{
			this.BarCurPercent = percent;
			this.BarTargetPercent = percent;
		}

		// Token: 0x06030E41 RID: 200257 RVA: 0x00DA2D1E File Offset: 0x00DA0F1E
		public bool Update(float delta)
		{
			return this.UpdateBarData(delta);
		}

		// Token: 0x06030E42 RID: 200258 RVA: 0x00DA2D28 File Offset: 0x00DA0F28
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

		// Token: 0x06030E43 RID: 200259 RVA: 0x00DA2DA4 File Offset: 0x00DA0FA4
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

		// Token: 0x06030E44 RID: 200260 RVA: 0x00DA2E23 File Offset: 0x00DA1023
		public float GetBarCurPercent()
		{
			return this.BarCurPercent;
		}

		// Token: 0x06030E45 RID: 200261 RVA: 0x00DA2E2B File Offset: 0x00DA102B
		public float GetBarTargetPercent()
		{
			return this.BarTargetPercent;
		}

		// Token: 0x06030E46 RID: 200262 RVA: 0x00DA2E33 File Offset: 0x00DA1033
		public int GetProgressDir()
		{
			return this.ProgressDir;
		}

		// Token: 0x04019F20 RID: 106272
		private const int BAR_ANI_DURATION = 500;

		// Token: 0x04019F21 RID: 106273
		private float BarTargetPercent;

		// Token: 0x04019F22 RID: 106274
		private float BarCurPercent;

		// Token: 0x04019F23 RID: 106275
		private float BarProgressSpeed;

		// Token: 0x04019F24 RID: 106276
		private int ProgressDir;
	}
}
