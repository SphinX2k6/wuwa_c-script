using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004793 RID: 18323
	[NullableContext(1)]
	[Nullable(0)]
	public class LastBigSceneMiniMapInfo : ILastBigSceneMiniMapInfo
	{
		// Token: 0x170077E2 RID: 30690
		// (get) Token: 0x0602FEE4 RID: 196324 RVA: 0x00B19CAF File Offset: 0x00B17EAF
		// (set) Token: 0x0602FEE5 RID: 196325 RVA: 0x00B19CB7 File Offset: 0x00B17EB7
		public int InstanceDungeonId { get; set; }

		// Token: 0x170077E3 RID: 30691
		// (get) Token: 0x0602FEE6 RID: 196326 RVA: 0x00B19CC0 File Offset: 0x00B17EC0
		// (set) Token: 0x0602FEE7 RID: 196327 RVA: 0x00B19CC8 File Offset: 0x00B17EC8
		public Vector Position { get; set; }
	}
}
