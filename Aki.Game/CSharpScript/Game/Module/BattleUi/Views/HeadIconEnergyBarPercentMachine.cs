using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1C RID: 19740
	[NullableContext(2)]
	[Nullable(0)]
	public class HeadIconEnergyBarPercentMachine
	{
		// Token: 0x060317D6 RID: 202710 RVA: 0x00DD6319 File Offset: 0x00DD4519
		public void SetWaitTimeWhenGrow(float timeInMs)
		{
			this.WaitTimeWhenGrow = timeInMs;
		}

		// Token: 0x060317D7 RID: 202711 RVA: 0x00DD6322 File Offset: 0x00DD4522
		public void Init(float percent, float waitTimeWhenGrow, float growTime = 100f, Action<float, float> targetPercentChanged = null)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
			this.WaitTimeWhenGrow = waitTimeWhenGrow;
			this.GrowTime = growTime;
			this.TargetPercentChanged = targetPercentChanged;
		}

		// Token: 0x060317D8 RID: 202712 RVA: 0x00DD6348 File Offset: 0x00DD4548
		public void SetTargetPercent(float percent)
		{
			if (percent == this.TargetPercent)
			{
				return;
			}
			float targetPercent = this.TargetPercent;
			if (percent > this.TargetPercent)
			{
				if (this.CurPercent >= this.TargetPercent)
				{
					this.CountDown = this.WaitTimeWhenGrow;
				}
				this.TargetPercent = percent;
				this.CurPercent = Math.Min(this.CurPercent, percent);
				this.Speed = (percent - this.CurPercent) / this.GrowTime;
				Action<float, float> targetPercentChanged = this.TargetPercentChanged;
				if (targetPercentChanged == null)
				{
					return;
				}
				targetPercentChanged(this.TargetPercent, targetPercent);
				return;
			}
			else
			{
				this.TargetPercent = percent;
				this.CurPercent = percent;
				this.Speed = 0f;
				Action<float, float> targetPercentChanged2 = this.TargetPercentChanged;
				if (targetPercentChanged2 == null)
				{
					return;
				}
				targetPercentChanged2(this.TargetPercent, targetPercent);
				return;
			}
		}

		// Token: 0x060317D9 RID: 202713 RVA: 0x00DD6400 File Offset: 0x00DD4600
		public bool Update(float delta)
		{
			if (this.Speed == 0f)
			{
				return false;
			}
			if (this.CountDown > 0f)
			{
				this.CountDown -= delta;
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

		// Token: 0x060317DA RID: 202714 RVA: 0x00DD6474 File Offset: 0x00DD4674
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x060317DB RID: 202715 RVA: 0x00DD647C File Offset: 0x00DD467C
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401A349 RID: 107337
		private float TargetPercent;

		// Token: 0x0401A34A RID: 107338
		private float CurPercent;

		// Token: 0x0401A34B RID: 107339
		private float Speed;

		// Token: 0x0401A34C RID: 107340
		private float WaitTimeWhenGrow;

		// Token: 0x0401A34D RID: 107341
		private float GrowTime;

		// Token: 0x0401A34E RID: 107342
		private float CountDown;

		// Token: 0x0401A34F RID: 107343
		private Action<float, float> TargetPercentChanged;
	}
}
