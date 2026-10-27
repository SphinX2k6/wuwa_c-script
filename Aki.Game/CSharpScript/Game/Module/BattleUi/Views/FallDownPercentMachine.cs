using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D0C RID: 23820
	public class FallDownPercentMachine
	{
		// Token: 0x0603C5D9 RID: 247257 RVA: 0x00E77044 File Offset: 0x00E75244
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

		// Token: 0x0603C5DA RID: 247258 RVA: 0x00E770A4 File Offset: 0x00E752A4
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

		// Token: 0x0603C5DB RID: 247259 RVA: 0x00E770FB File Offset: 0x00E752FB
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0401F730 RID: 128816
		private const float DURATION = 100f;

		// Token: 0x0401F731 RID: 128817
		private float TargetPercent;

		// Token: 0x0401F732 RID: 128818
		private float CurPercent;

		// Token: 0x0401F733 RID: 128819
		private float Speed;
	}
}
