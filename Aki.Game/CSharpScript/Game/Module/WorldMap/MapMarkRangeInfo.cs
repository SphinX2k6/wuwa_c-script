using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004796 RID: 18326
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkRangeInfo : IMapMarkRangeInfo
	{
		// Token: 0x170077E9 RID: 30697
		// (get) Token: 0x0602FEF3 RID: 196339 RVA: 0x00B19CD9 File Offset: 0x00B17ED9
		// (set) Token: 0x0602FEF4 RID: 196340 RVA: 0x00B19CE1 File Offset: 0x00B17EE1
		public Vector2D Position { get; set; }

		// Token: 0x170077EA RID: 30698
		// (get) Token: 0x0602FEF5 RID: 196341 RVA: 0x00B19CEA File Offset: 0x00B17EEA
		// (set) Token: 0x0602FEF6 RID: 196342 RVA: 0x00B19CF2 File Offset: 0x00B17EF2
		public int? MapId { get; set; }

		// Token: 0x170077EB RID: 30699
		// (get) Token: 0x0602FEF7 RID: 196343 RVA: 0x00B19CFB File Offset: 0x00B17EFB
		// (set) Token: 0x0602FEF8 RID: 196344 RVA: 0x00B19D03 File Offset: 0x00B17F03
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170077EC RID: 30700
		// (get) Token: 0x0602FEF9 RID: 196345 RVA: 0x00B19D0C File Offset: 0x00B17F0C
		// (set) Token: 0x0602FEFA RID: 196346 RVA: 0x00B19D14 File Offset: 0x00B17F14
		public float? Width { get; set; }

		// Token: 0x170077ED RID: 30701
		// (get) Token: 0x0602FEFB RID: 196347 RVA: 0x00B19D1D File Offset: 0x00B17F1D
		// (set) Token: 0x0602FEFC RID: 196348 RVA: 0x00B19D25 File Offset: 0x00B17F25
		public float? Height { get; set; }
	}
}
