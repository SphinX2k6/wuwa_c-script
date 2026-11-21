using System;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x0200625E RID: 25182
	public interface IStepSpringResult
	{
		// Token: 0x170072F7 RID: 29431
		// (get) Token: 0x0603CC3A RID: 248890
		// (set) Token: 0x0603CC3B RID: 248891
		float NewPosition { get; set; }

		// Token: 0x170072F8 RID: 29432
		// (get) Token: 0x0603CC3C RID: 248892
		// (set) Token: 0x0603CC3D RID: 248893
		float NewVelocity { get; set; }

		// Token: 0x170072F9 RID: 29433
		// (get) Token: 0x0603CC3E RID: 248894
		// (set) Token: 0x0603CC3F RID: 248895
		bool Converged { get; set; }
	}
}
