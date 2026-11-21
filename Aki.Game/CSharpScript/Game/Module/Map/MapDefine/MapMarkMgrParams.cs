using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004551 RID: 17745
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkMgrParams
	{
		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x0602CB56 RID: 183126 RVA: 0x00C86D8F File Offset: 0x00C84F8F
		// (set) Token: 0x0602CB57 RID: 183127 RVA: 0x00C86D97 File Offset: 0x00C84F97
		public EMapType MapType { get; set; }

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x0602CB58 RID: 183128 RVA: 0x00C86DA0 File Offset: 0x00C84FA0
		// (set) Token: 0x0602CB59 RID: 183129 RVA: 0x00C86DA8 File Offset: 0x00C84FA8
		public int MapId { get; set; }

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x0602CB5A RID: 183130 RVA: 0x00C86DB1 File Offset: 0x00C84FB1
		// (set) Token: 0x0602CB5B RID: 183131 RVA: 0x00C86DB9 File Offset: 0x00C84FB9
		public int InstanceDungeonId { get; set; }

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x0602CB5C RID: 183132 RVA: 0x00C86DC2 File Offset: 0x00C84FC2
		// (set) Token: 0x0602CB5D RID: 183133 RVA: 0x00C86DCA File Offset: 0x00C84FCA
		public UUIItem MarkContainer { get; set; }

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x0602CB5E RID: 183134 RVA: 0x00C86DD3 File Offset: 0x00C84FD3
		// (set) Token: 0x0602CB5F RID: 183135 RVA: 0x00C86DDB File Offset: 0x00C84FDB
		public float MarkScale { get; set; }

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x0602CB60 RID: 183136 RVA: 0x00C86DE4 File Offset: 0x00C84FE4
		// (set) Token: 0x0602CB61 RID: 183137 RVA: 0x00C86DEC File Offset: 0x00C84FEC
		public EMapGravityDirection? Gravity { get; set; }
	}
}
