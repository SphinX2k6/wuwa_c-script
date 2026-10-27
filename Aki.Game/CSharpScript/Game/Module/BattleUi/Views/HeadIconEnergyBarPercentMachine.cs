using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D3A RID: 23866
	[NullableContext(2)]
	[Nullable(0)]
	public class HeadIconEnergyBarPercentMachine
	{
		// Token: 0x0603C87D RID: 247933 RVA: 0x00E85B79 File Offset: 0x00E83D79
		public void SetWaitTimeWhenGrow(float timeInMs)
		{
			this.WaitTimeWhenGrow = timeInMs;
		}

		// Token: 0x0603C87E RID: 247934 RVA: 0x00E85B82 File Offset: 0x00E83D82
		public void Init(float percent, float waitTimeWhenGrow, float growTime = 100f, Action<float, float> targetPercentChanged = null)
		{
			this.CurPercent = percent;
			this.TargetPercent = percent;
			this.WaitTimeWhenGrow = waitTimeWhenGrow;
			this.GrowTime = growTime;
			this.TargetPercentChanged = targetPercentChanged;
		}

		// Token: 0x0603C87F RID: 247935 RVA: 0x00E85BA8 File Offset: 0x00E83DA8
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

		// Token: 0x0603C880 RID: 247936 RVA: 0x00E85C60 File Offset: 0x00E83E60
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

		// Token: 0x0603C881 RID: 247937 RVA: 0x00E85CD4 File Offset: 0x00E83ED4
		public float GetCurPercent()
		{
			return this.CurPercent;
		}

		// Token: 0x0603C882 RID: 247938 RVA: 0x00E85CDC File Offset: 0x00E83EDC
		public float GetTargetPercent()
		{
			return this.TargetPercent;
		}

		// Token: 0x0401F890 RID: 129168
		private float TargetPercent;

		// Token: 0x0401F891 RID: 129169
		private float CurPercent;

		// Token: 0x0401F892 RID: 129170
		private float Speed;

		// Token: 0x0401F893 RID: 129171
		private float WaitTimeWhenGrow;

		// Token: 0x0401F894 RID: 129172
		private float GrowTime;

		// Token: 0x0401F895 RID: 129173
		private float CountDown;

		// Token: 0x0401F896 RID: 129174
		private Action<float, float> TargetPercentChanged;
	}
}
