using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E22 RID: 24098
	public class SpecialEnergyBarPercentMachine
	{
		// Token: 0x0603D499 RID: 251033 RVA: 0x00EC524F File Offset: 0x00EC344F
		public void Init(float percent)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
		}

		// Token: 0x0603D49A RID: 251034 RVA: 0x00EC5260 File Offset: 0x00EC3460
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

		// Token: 0x0603D49B RID: 251035 RVA: 0x00EC52C8 File Offset: 0x00EC34C8
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

		// Token: 0x0603D49C RID: 251036 RVA: 0x00EC531F File Offset: 0x00EC351F
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0603D49D RID: 251037 RVA: 0x00EC5327 File Offset: 0x00EC3527
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401FF59 RID: 130905
		private const int DURATION = 100;

		// Token: 0x0401FF5A RID: 130906
		private float TargetPercent;

		// Token: 0x0401FF5B RID: 130907
		private float CurPercent;

		// Token: 0x0401FF5C RID: 130908
		private float Speed;
	}
}
