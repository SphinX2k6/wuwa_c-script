using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D26 RID: 19750
	[NullableContext(1)]
	[Nullable(0)]
	public class FallDownBarStateMachine
	{
		// Token: 0x060318B3 RID: 202931 RVA: 0x00DDA7F7 File Offset: 0x00DD89F7
		public FallDownBarStateMachine(Action<float> fallDownChangeFunction)
		{
		}

		// Token: 0x060318B4 RID: 202932 RVA: 0x00DDA814 File Offset: 0x00DD8A14
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

		// Token: 0x060318B5 RID: 202933 RVA: 0x00DDA859 File Offset: 0x00DD8A59
		public void OnFallDownStart(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
			this.CurrentDuration = 0f;
			this.IsEnable = true;
		}

		// Token: 0x060318B6 RID: 202934 RVA: 0x00DDA880 File Offset: 0x00DD8A80
		public void OnChangeTimeDilation(float timeDilation)
		{
			this.TimeDilation = timeDilation;
		}

		// Token: 0x060318B7 RID: 202935 RVA: 0x00DDA889 File Offset: 0x00DD8A89
		public void OnFallDownEnd()
		{
			this.IsEnable = false;
		}

		// Token: 0x060318B8 RID: 202936 RVA: 0x00DDA892 File Offset: 0x00DD8A92
		public void OnDestroy()
		{
			this.IsEnable = false;
			this.TimeDilation = 1f;
		}

		// Token: 0x0401A390 RID: 107408
		[CompilerGenerated]
		private Action<float> <fallDownChangeFunction>P = fallDownChangeFunction;

		// Token: 0x0401A391 RID: 107409
		private float Duration;

		// Token: 0x0401A392 RID: 107410
		private float CurrentDuration;

		// Token: 0x0401A393 RID: 107411
		private float TimeDilation = 1f;

		// Token: 0x0401A394 RID: 107412
		private bool IsEnable;
	}
}
