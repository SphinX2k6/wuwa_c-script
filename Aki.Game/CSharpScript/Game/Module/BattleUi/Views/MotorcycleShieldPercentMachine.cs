using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA1 RID: 23969
	public class MotorcycleShieldPercentMachine
	{
		// Token: 0x0603CDAB RID: 249259 RVA: 0x00E9DF48 File Offset: 0x00E9C148
		public void Init(float percent)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
			this.Speed = 0f;
		}

		// Token: 0x0603CDAC RID: 249260 RVA: 0x00E9DF63 File Offset: 0x00E9C163
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			this.TargetPercent = percent;
			this.Speed = (percent - this.CurPercent) / (float)this.Duration;
		}

		// Token: 0x0603CDAD RID: 249261 RVA: 0x00E9DF8C File Offset: 0x00E9C18C
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

		// Token: 0x0603CDAE RID: 249262 RVA: 0x00E9E02C File Offset: 0x00E9C22C
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0603CDAF RID: 249263 RVA: 0x00E9E034 File Offset: 0x00E9C234
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0603CDB0 RID: 249264 RVA: 0x00E9E03C File Offset: 0x00E9C23C
		public bool IsDecreasing()
		{
			return this.Speed < 0f;
		}

		// Token: 0x0401FB3D RID: 129853
		private const int DURATION = 100;

		// Token: 0x0401FB3E RID: 129854
		private float TargetPercent;

		// Token: 0x0401FB3F RID: 129855
		private float CurPercent;

		// Token: 0x0401FB40 RID: 129856
		private float Speed;

		// Token: 0x0401FB41 RID: 129857
		public int Duration = 100;
	}
}
