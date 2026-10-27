using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x0200702A RID: 28714
	[NullableContext(1)]
	public interface ITraceWaterResult
	{
		// Token: 0x17009BCB RID: 39883
		// (get) Token: 0x06045E74 RID: 286324
		// (set) Token: 0x06045E75 RID: 286325
		bool FoundWater { get; set; }

		// Token: 0x17009BCC RID: 39884
		// (get) Token: 0x06045E76 RID: 286326
		// (set) Token: 0x06045E77 RID: 286327
		float MinWaterHeight { get; set; }

		// Token: 0x17009BCD RID: 39885
		// (get) Token: 0x06045E78 RID: 286328
		// (set) Token: 0x06045E79 RID: 286329
		Vector ImpactPoint { get; set; }

		// Token: 0x17009BCE RID: 39886
		// (get) Token: 0x06045E7A RID: 286330
		// (set) Token: 0x06045E7B RID: 286331
		Vector ImpactNormal { get; set; }
	}
}
