using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D83 RID: 19843
	public class MotorcycleShieldPercentMachine
	{
		// Token: 0x06031D08 RID: 204040 RVA: 0x00DEE800 File Offset: 0x00DECA00
		public void Init(float percent)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
			this.Speed = 0f;
		}

		// Token: 0x06031D09 RID: 204041 RVA: 0x00DEE81B File Offset: 0x00DECA1B
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			this.TargetPercent = percent;
			this.Speed = (percent - this.CurPercent) / (float)this.Duration;
		}

		// Token: 0x06031D0A RID: 204042 RVA: 0x00DEE844 File Offset: 0x00DECA44
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

		// Token: 0x06031D0B RID: 204043 RVA: 0x00DEE8E4 File Offset: 0x00DECAE4
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x06031D0C RID: 204044 RVA: 0x00DEE8EC File Offset: 0x00DECAEC
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x06031D0D RID: 204045 RVA: 0x00DEE8F4 File Offset: 0x00DECAF4
		public bool IsDecreasing()
		{
			return this.Speed < 0f;
		}

		// Token: 0x0401A5F5 RID: 108021
		private const int DURATION = 100;

		// Token: 0x0401A5F6 RID: 108022
		private float TargetPercent;

		// Token: 0x0401A5F7 RID: 108023
		private float CurPercent;

		// Token: 0x0401A5F8 RID: 108024
		private float Speed;

		// Token: 0x0401A5F9 RID: 108025
		public int Duration = 100;
	}
}
