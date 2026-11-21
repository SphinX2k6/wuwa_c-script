using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D81 RID: 19841
	public class MotorcyclePercentMachine
	{
		// Token: 0x06031CF3 RID: 204019 RVA: 0x00DEE389 File Offset: 0x00DEC589
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

		// Token: 0x06031CF4 RID: 204020 RVA: 0x00DEE3BA File Offset: 0x00DEC5BA
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			this.TargetPercent = percent;
			this.Speed = (percent - this.CurPercent) / this.Duration;
		}

		// Token: 0x06031CF5 RID: 204021 RVA: 0x00DEE3E4 File Offset: 0x00DEC5E4
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

		// Token: 0x06031CF6 RID: 204022 RVA: 0x00DEE484 File Offset: 0x00DEC684
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x06031CF7 RID: 204023 RVA: 0x00DEE48C File Offset: 0x00DEC68C
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401A5E8 RID: 108008
		private const int DURATION = 100;

		// Token: 0x0401A5E9 RID: 108009
		private float TargetPercent;

		// Token: 0x0401A5EA RID: 108010
		private float CurPercent;

		// Token: 0x0401A5EB RID: 108011
		private float Speed;

		// Token: 0x0401A5EC RID: 108012
		public float Duration = 100f;
	}
}
