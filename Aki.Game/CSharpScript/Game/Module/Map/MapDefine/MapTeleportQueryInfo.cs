using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004553 RID: 17747
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTeleportQueryInfo
	{
		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x0602CB6A RID: 183146 RVA: 0x00C86E38 File Offset: 0x00C85038
		// (set) Token: 0x0602CB6B RID: 183147 RVA: 0x00C86E40 File Offset: 0x00C85040
		public int MarkId { get; set; }

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x0602CB6C RID: 183148 RVA: 0x00C86E49 File Offset: 0x00C85049
		// (set) Token: 0x0602CB6D RID: 183149 RVA: 0x00C86E51 File Offset: 0x00C85051
		public EMarkType MarkType { get; set; }

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x0602CB6E RID: 183150 RVA: 0x00C86E5A File Offset: 0x00C8505A
		// (set) Token: 0x0602CB6F RID: 183151 RVA: 0x00C86E62 File Offset: 0x00C85062
		public int MapId { get; set; }

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x0602CB70 RID: 183152 RVA: 0x00C86E6B File Offset: 0x00C8506B
		// (set) Token: 0x0602CB71 RID: 183153 RVA: 0x00C86E73 File Offset: 0x00C85073
		public int InstanceDungeonId { get; set; }

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x0602CB72 RID: 183154 RVA: 0x00C86E7C File Offset: 0x00C8507C
		// (set) Token: 0x0602CB73 RID: 183155 RVA: 0x00C86E84 File Offset: 0x00C85084
		public EMapGravityDirection Gravity { get; set; }

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x0602CB74 RID: 183156 RVA: 0x00C86E8D File Offset: 0x00C8508D
		// (set) Token: 0x0602CB75 RID: 183157 RVA: 0x00C86E95 File Offset: 0x00C85095
		public int MultiMapId { get; set; }

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x0602CB76 RID: 183158 RVA: 0x00C86E9E File Offset: 0x00C8509E
		// (set) Token: 0x0602CB77 RID: 183159 RVA: 0x00C86EA6 File Offset: 0x00C850A6
		public int[] ConnectMultiMapIds { get; set; } = Array.Empty<int>();

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x0602CB78 RID: 183160 RVA: 0x00C86EAF File Offset: 0x00C850AF
		// (set) Token: 0x0602CB79 RID: 183161 RVA: 0x00C86EB7 File Offset: 0x00C850B7
		public Vector WorldPosition { get; set; }
	}
}
