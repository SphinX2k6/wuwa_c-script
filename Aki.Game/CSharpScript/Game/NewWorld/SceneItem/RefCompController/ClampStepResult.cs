using System;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x0200626F RID: 25199
	public readonly struct ClampStepResult
	{
		// Token: 0x0603CCF5 RID: 249077 RVA: 0x0117807C File Offset: 0x0117627C
		public ClampStepResult(float? step, float nextAccumulated)
		{
			this.Step = step;
			this.NextAccumulated = nextAccumulated;
		}

		// Token: 0x1700730D RID: 29453
		// (get) Token: 0x0603CCF6 RID: 249078 RVA: 0x0117808C File Offset: 0x0117628C
		public float? Step { get; }

		// Token: 0x1700730E RID: 29454
		// (get) Token: 0x0603CCF7 RID: 249079 RVA: 0x01178094 File Offset: 0x01176294
		public float NextAccumulated { get; }
	}
}
