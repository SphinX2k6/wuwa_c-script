using System;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071BA RID: 29114
	public readonly struct ClampStepResult
	{
		// Token: 0x060473FA RID: 291834 RVA: 0x0121E170 File Offset: 0x0121C370
		public ClampStepResult(float? step, float nextAccumulated)
		{
			this.Step = step;
			this.NextAccumulated = nextAccumulated;
		}

		// Token: 0x17009DBD RID: 40381
		// (get) Token: 0x060473FB RID: 291835 RVA: 0x0121E180 File Offset: 0x0121C380
		public float? Step { get; }

		// Token: 0x17009DBE RID: 40382
		// (get) Token: 0x060473FC RID: 291836 RVA: 0x0121E188 File Offset: 0x0121C388
		public float NextAccumulated { get; }
	}
}
