using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C4 RID: 14020
	[NullableContext(1)]
	[Nullable(0)]
	public class LastBigSceneMiniMapInfo : ILastBigSceneMiniMapInfo
	{
		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x060246AF RID: 149167 RVA: 0x00A49B8B File Offset: 0x00A47D8B
		// (set) Token: 0x060246B0 RID: 149168 RVA: 0x00A49B93 File Offset: 0x00A47D93
		public int InstanceDungeonId { get; set; }

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x060246B1 RID: 149169 RVA: 0x00A49B9C File Offset: 0x00A47D9C
		// (set) Token: 0x060246B2 RID: 149170 RVA: 0x00A49BA4 File Offset: 0x00A47DA4
		public Vector Position { get; set; }
	}
}
