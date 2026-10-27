using System;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071A9 RID: 29097
	public interface IStepSpringResult
	{
		// Token: 0x17009DA7 RID: 40359
		// (get) Token: 0x0604733F RID: 291647
		// (set) Token: 0x06047340 RID: 291648
		float NewPosition { get; set; }

		// Token: 0x17009DA8 RID: 40360
		// (get) Token: 0x06047341 RID: 291649
		// (set) Token: 0x06047342 RID: 291650
		float NewVelocity { get; set; }

		// Token: 0x17009DA9 RID: 40361
		// (get) Token: 0x06047343 RID: 291651
		// (set) Token: 0x06047344 RID: 291652
		bool Converged { get; set; }
	}
}
