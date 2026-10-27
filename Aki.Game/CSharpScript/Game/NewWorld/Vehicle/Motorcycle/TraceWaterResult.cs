using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x0200702B RID: 28715
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceWaterResult : ITraceWaterResult
	{
		// Token: 0x17009BCF RID: 39887
		// (get) Token: 0x06045E7C RID: 286332 RVA: 0x0116555E File Offset: 0x0116375E
		// (set) Token: 0x06045E7D RID: 286333 RVA: 0x01165566 File Offset: 0x01163766
		public bool FoundWater { get; set; }

		// Token: 0x17009BD0 RID: 39888
		// (get) Token: 0x06045E7E RID: 286334 RVA: 0x0116556F File Offset: 0x0116376F
		// (set) Token: 0x06045E7F RID: 286335 RVA: 0x01165577 File Offset: 0x01163777
		public float MinWaterHeight { get; set; }

		// Token: 0x17009BD1 RID: 39889
		// (get) Token: 0x06045E80 RID: 286336 RVA: 0x01165580 File Offset: 0x01163780
		// (set) Token: 0x06045E81 RID: 286337 RVA: 0x01165588 File Offset: 0x01163788
		public Vector ImpactPoint { get; set; }

		// Token: 0x17009BD2 RID: 39890
		// (get) Token: 0x06045E82 RID: 286338 RVA: 0x01165591 File Offset: 0x01163791
		// (set) Token: 0x06045E83 RID: 286339 RVA: 0x01165599 File Offset: 0x01163799
		public Vector ImpactNormal { get; set; }
	}
}
