using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005580 RID: 21888
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTeleportQueryInfo
	{
		// Token: 0x17008642 RID: 34370
		// (get) Token: 0x06037C90 RID: 228496 RVA: 0x00D39364 File Offset: 0x00D37564
		// (set) Token: 0x06037C91 RID: 228497 RVA: 0x00D3936C File Offset: 0x00D3756C
		public int MarkId { get; set; }

		// Token: 0x17008643 RID: 34371
		// (get) Token: 0x06037C92 RID: 228498 RVA: 0x00D39375 File Offset: 0x00D37575
		// (set) Token: 0x06037C93 RID: 228499 RVA: 0x00D3937D File Offset: 0x00D3757D
		public EMarkType MarkType { get; set; }

		// Token: 0x17008644 RID: 34372
		// (get) Token: 0x06037C94 RID: 228500 RVA: 0x00D39386 File Offset: 0x00D37586
		// (set) Token: 0x06037C95 RID: 228501 RVA: 0x00D3938E File Offset: 0x00D3758E
		public int MapId { get; set; }

		// Token: 0x17008645 RID: 34373
		// (get) Token: 0x06037C96 RID: 228502 RVA: 0x00D39397 File Offset: 0x00D37597
		// (set) Token: 0x06037C97 RID: 228503 RVA: 0x00D3939F File Offset: 0x00D3759F
		public int InstanceDungeonId { get; set; }

		// Token: 0x17008646 RID: 34374
		// (get) Token: 0x06037C98 RID: 228504 RVA: 0x00D393A8 File Offset: 0x00D375A8
		// (set) Token: 0x06037C99 RID: 228505 RVA: 0x00D393B0 File Offset: 0x00D375B0
		public EMapGravityDirection Gravity { get; set; }

		// Token: 0x17008647 RID: 34375
		// (get) Token: 0x06037C9A RID: 228506 RVA: 0x00D393B9 File Offset: 0x00D375B9
		// (set) Token: 0x06037C9B RID: 228507 RVA: 0x00D393C1 File Offset: 0x00D375C1
		public int MultiMapId { get; set; }

		// Token: 0x17008648 RID: 34376
		// (get) Token: 0x06037C9C RID: 228508 RVA: 0x00D393CA File Offset: 0x00D375CA
		// (set) Token: 0x06037C9D RID: 228509 RVA: 0x00D393D2 File Offset: 0x00D375D2
		public int[] ConnectMultiMapIds { get; set; } = Array.Empty<int>();

		// Token: 0x17008649 RID: 34377
		// (get) Token: 0x06037C9E RID: 228510 RVA: 0x00D393DB File Offset: 0x00D375DB
		// (set) Token: 0x06037C9F RID: 228511 RVA: 0x00D393E3 File Offset: 0x00D375E3
		public Vector WorldPosition { get; set; }
	}
}
