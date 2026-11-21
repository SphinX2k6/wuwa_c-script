using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200645B RID: 25691
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneFixInputData
	{
		// Token: 0x0603E66B RID: 255595 RVA: 0x0122554C File Offset: 0x0122374C
		public SceneFixInputData Set(float pitchLimitMin, float pitchLimitMax, float yawLimitMin, float yawLimitMax, float pitchInputSpeed, float yawInputSpeed)
		{
			this.PitchLimitMin = pitchLimitMin;
			this.PitchLimitMax = pitchLimitMax;
			this.YawLimitMin = yawLimitMin;
			this.YawLimitMax = yawLimitMax;
			this.PitchInputSpeed = pitchInputSpeed;
			this.YawInputSpeed = yawInputSpeed;
			return this;
		}

		// Token: 0x0603E66C RID: 255596 RVA: 0x0122557C File Offset: 0x0122377C
		public void DeepCopy(SceneFixInputData source)
		{
			this.PitchLimitMin = source.PitchLimitMin;
			this.PitchLimitMax = source.PitchLimitMax;
			this.YawLimitMin = source.YawLimitMin;
			this.YawLimitMax = source.YawLimitMax;
			this.PitchInputSpeed = source.PitchInputSpeed;
			this.YawInputSpeed = source.YawInputSpeed;
		}

		// Token: 0x0603E66D RID: 255597 RVA: 0x012255D4 File Offset: 0x012237D4
		public void Reset()
		{
			this.PitchLimitMin = 0f;
			this.PitchLimitMax = 0f;
			this.YawLimitMin = 0f;
			this.YawLimitMax = 0f;
			this.PitchInputSpeed = 0f;
			this.YawInputSpeed = 0f;
		}

		// Token: 0x0402141B RID: 136219
		public float PitchLimitMin;

		// Token: 0x0402141C RID: 136220
		public float PitchLimitMax;

		// Token: 0x0402141D RID: 136221
		public float YawLimitMin;

		// Token: 0x0402141E RID: 136222
		public float YawLimitMax;

		// Token: 0x0402141F RID: 136223
		public float PitchInputSpeed;

		// Token: 0x04021420 RID: 136224
		public float YawInputSpeed;
	}
}
