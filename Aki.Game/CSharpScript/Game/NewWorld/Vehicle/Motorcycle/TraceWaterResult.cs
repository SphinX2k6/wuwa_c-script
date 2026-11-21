using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061AC RID: 25004
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceWaterResult : ITraceWaterResult
	{
		// Token: 0x17007134 RID: 28980
		// (get) Token: 0x0603C055 RID: 245845 RVA: 0x0110F4BD File Offset: 0x0110D6BD
		// (set) Token: 0x0603C056 RID: 245846 RVA: 0x0110F4C5 File Offset: 0x0110D6C5
		public bool FoundWater { get; set; }

		// Token: 0x17007135 RID: 28981
		// (get) Token: 0x0603C057 RID: 245847 RVA: 0x0110F4CE File Offset: 0x0110D6CE
		// (set) Token: 0x0603C058 RID: 245848 RVA: 0x0110F4D6 File Offset: 0x0110D6D6
		public float MinWaterHeight { get; set; }

		// Token: 0x17007136 RID: 28982
		// (get) Token: 0x0603C059 RID: 245849 RVA: 0x0110F4DF File Offset: 0x0110D6DF
		// (set) Token: 0x0603C05A RID: 245850 RVA: 0x0110F4E7 File Offset: 0x0110D6E7
		public Vector ImpactPoint { get; set; }

		// Token: 0x17007137 RID: 28983
		// (get) Token: 0x0603C05B RID: 245851 RVA: 0x0110F4F0 File Offset: 0x0110D6F0
		// (set) Token: 0x0603C05C RID: 245852 RVA: 0x0110F4F8 File Offset: 0x0110D6F8
		public Vector ImpactNormal { get; set; }
	}
}
