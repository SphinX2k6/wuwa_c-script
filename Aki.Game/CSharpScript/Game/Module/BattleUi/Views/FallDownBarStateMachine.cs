using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D44 RID: 23876
	[NullableContext(1)]
	[Nullable(0)]
	public class FallDownBarStateMachine
	{
		// Token: 0x0603C95A RID: 248154 RVA: 0x00E8A047 File Offset: 0x00E88247
		public FallDownBarStateMachine(Action<float> fallDownChangeFunction)
		{
		}

		// Token: 0x0603C95B RID: 248155 RVA: 0x00E8A064 File Offset: 0x00E88264
		public void Update(float delta)
		{
			if (!this.IsEnable)
			{
				return;
			}
			this.CurrentDuration += delta * this.TimeDilation;
			float obj = this.CurrentDuration / this.Duration;
			this.<fallDownChangeFunction>P(obj);
		}

		// Token: 0x0603C95C RID: 248156 RVA: 0x00E8A0A9 File Offset: 0x00E882A9
		public void OnFallDownStart(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
			this.CurrentDuration = 0f;
			this.IsEnable = true;
		}

		// Token: 0x0603C95D RID: 248157 RVA: 0x00E8A0D0 File Offset: 0x00E882D0
		public void OnChangeTimeDilation(float timeDilation)
		{
			this.TimeDilation = timeDilation;
		}

		// Token: 0x0603C95E RID: 248158 RVA: 0x00E8A0D9 File Offset: 0x00E882D9
		public void OnFallDownEnd()
		{
			this.IsEnable = false;
		}

		// Token: 0x0603C95F RID: 248159 RVA: 0x00E8A0E2 File Offset: 0x00E882E2
		public void OnDestroy()
		{
			this.IsEnable = false;
			this.TimeDilation = 1f;
		}

		// Token: 0x0401F8D7 RID: 129239
		[CompilerGenerated]
		private Action<float> <fallDownChangeFunction>P = fallDownChangeFunction;

		// Token: 0x0401F8D8 RID: 129240
		private float Duration;

		// Token: 0x0401F8D9 RID: 129241
		private float CurrentDuration;

		// Token: 0x0401F8DA RID: 129242
		private float TimeDilation = 1f;

		// Token: 0x0401F8DB RID: 129243
		private bool IsEnable;
	}
}
