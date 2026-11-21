using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CEE RID: 19694
	public class FallDownPercentMachine
	{
		// Token: 0x06031532 RID: 202034 RVA: 0x00DC76B4 File Offset: 0x00DC58B4
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			if (percent > this.TargetPercent && percent < 1f)
			{
				this.TargetPercent = percent;
				this.Speed = (percent - this.CurPercent) / 100f;
				return;
			}
			this.TargetPercent = percent;
			this.CurPercent = percent;
			this.Speed = 0f;
		}

		// Token: 0x06031533 RID: 202035 RVA: 0x00DC7714 File Offset: 0x00DC5914
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

		// Token: 0x06031534 RID: 202036 RVA: 0x00DC776B File Offset: 0x00DC596B
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401A1E9 RID: 106985
		private const float DURATION = 100f;

		// Token: 0x0401A1EA RID: 106986
		private float TargetPercent;

		// Token: 0x0401A1EB RID: 106987
		private float CurPercent;

		// Token: 0x0401A1EC RID: 106988
		private float Speed;
	}
}
