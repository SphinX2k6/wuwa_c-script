using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557F RID: 21887
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoadWaysMgrParams
	{
		// Token: 0x1700863F RID: 34367
		// (get) Token: 0x06037C89 RID: 228489 RVA: 0x00D39329 File Offset: 0x00D37529
		// (set) Token: 0x06037C8A RID: 228490 RVA: 0x00D39331 File Offset: 0x00D37531
		public int MapId { get; set; }

		// Token: 0x17008640 RID: 34368
		// (get) Token: 0x06037C8B RID: 228491 RVA: 0x00D3933A File Offset: 0x00D3753A
		// (set) Token: 0x06037C8C RID: 228492 RVA: 0x00D39342 File Offset: 0x00D37542
		public int InstanceDungeonId { get; set; }

		// Token: 0x17008641 RID: 34369
		// (get) Token: 0x06037C8D RID: 228493 RVA: 0x00D3934B File Offset: 0x00D3754B
		// (set) Token: 0x06037C8E RID: 228494 RVA: 0x00D39353 File Offset: 0x00D37553
		public UUIItem Container { get; set; }
	}
}
