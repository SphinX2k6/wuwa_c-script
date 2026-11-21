using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061AB RID: 25003
	[NullableContext(1)]
	public interface ITraceWaterResult
	{
		// Token: 0x17007130 RID: 28976
		// (get) Token: 0x0603C04D RID: 245837
		// (set) Token: 0x0603C04E RID: 245838
		bool FoundWater { get; set; }

		// Token: 0x17007131 RID: 28977
		// (get) Token: 0x0603C04F RID: 245839
		// (set) Token: 0x0603C050 RID: 245840
		float MinWaterHeight { get; set; }

		// Token: 0x17007132 RID: 28978
		// (get) Token: 0x0603C051 RID: 245841
		// (set) Token: 0x0603C052 RID: 245842
		Vector ImpactPoint { get; set; }

		// Token: 0x17007133 RID: 28979
		// (get) Token: 0x0603C053 RID: 245843
		// (set) Token: 0x0603C054 RID: 245844
		Vector ImpactNormal { get; set; }
	}
}
