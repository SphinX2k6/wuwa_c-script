using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D9 RID: 29401
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneFixInputData
	{
		// Token: 0x06048257 RID: 295511 RVA: 0x01282D64 File Offset: 0x01280F64
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

		// Token: 0x06048258 RID: 295512 RVA: 0x01282D94 File Offset: 0x01280F94
		public void DeepCopy(SceneFixInputData source)
		{
			this.PitchLimitMin = source.PitchLimitMin;
			this.PitchLimitMax = source.PitchLimitMax;
			this.YawLimitMin = source.YawLimitMin;
			this.YawLimitMax = source.YawLimitMax;
			this.PitchInputSpeed = source.PitchInputSpeed;
			this.YawInputSpeed = source.YawInputSpeed;
		}

		// Token: 0x06048259 RID: 295513 RVA: 0x01282DEC File Offset: 0x01280FEC
		public void Reset()
		{
			this.PitchLimitMin = 0f;
			this.PitchLimitMax = 0f;
			this.YawLimitMin = 0f;
			this.YawLimitMax = 0f;
			this.PitchInputSpeed = 0f;
			this.YawInputSpeed = 0f;
		}

		// Token: 0x04026138 RID: 155960
		public float PitchLimitMin;

		// Token: 0x04026139 RID: 155961
		public float PitchLimitMax;

		// Token: 0x0402613A RID: 155962
		public float YawLimitMin;

		// Token: 0x0402613B RID: 155963
		public float YawLimitMax;

		// Token: 0x0402613C RID: 155964
		public float PitchInputSpeed;

		// Token: 0x0402613D RID: 155965
		public float YawInputSpeed;
	}
}
