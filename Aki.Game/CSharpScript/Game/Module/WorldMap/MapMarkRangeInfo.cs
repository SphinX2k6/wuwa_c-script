using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C7 RID: 14023
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkRangeInfo : IMapMarkRangeInfo
	{
		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x060246BE RID: 149182 RVA: 0x00A49BB5 File Offset: 0x00A47DB5
		// (set) Token: 0x060246BF RID: 149183 RVA: 0x00A49BBD File Offset: 0x00A47DBD
		public Vector2D Position { get; set; }

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x060246C0 RID: 149184 RVA: 0x00A49BC6 File Offset: 0x00A47DC6
		// (set) Token: 0x060246C1 RID: 149185 RVA: 0x00A49BCE File Offset: 0x00A47DCE
		public int? MapId { get; set; }

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x060246C2 RID: 149186 RVA: 0x00A49BD7 File Offset: 0x00A47DD7
		// (set) Token: 0x060246C3 RID: 149187 RVA: 0x00A49BDF File Offset: 0x00A47DDF
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x060246C4 RID: 149188 RVA: 0x00A49BE8 File Offset: 0x00A47DE8
		// (set) Token: 0x060246C5 RID: 149189 RVA: 0x00A49BF0 File Offset: 0x00A47DF0
		public float? Width { get; set; }

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x060246C6 RID: 149190 RVA: 0x00A49BF9 File Offset: 0x00A47DF9
		// (set) Token: 0x060246C7 RID: 149191 RVA: 0x00A49C01 File Offset: 0x00A47E01
		public float? Height { get; set; }
	}
}
