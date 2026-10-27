using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557E RID: 21886
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkMgrParams
	{
		// Token: 0x17008639 RID: 34361
		// (get) Token: 0x06037C7C RID: 228476 RVA: 0x00D392BB File Offset: 0x00D374BB
		// (set) Token: 0x06037C7D RID: 228477 RVA: 0x00D392C3 File Offset: 0x00D374C3
		public EMapType MapType { get; set; }

		// Token: 0x1700863A RID: 34362
		// (get) Token: 0x06037C7E RID: 228478 RVA: 0x00D392CC File Offset: 0x00D374CC
		// (set) Token: 0x06037C7F RID: 228479 RVA: 0x00D392D4 File Offset: 0x00D374D4
		public int MapId { get; set; }

		// Token: 0x1700863B RID: 34363
		// (get) Token: 0x06037C80 RID: 228480 RVA: 0x00D392DD File Offset: 0x00D374DD
		// (set) Token: 0x06037C81 RID: 228481 RVA: 0x00D392E5 File Offset: 0x00D374E5
		public int InstanceDungeonId { get; set; }

		// Token: 0x1700863C RID: 34364
		// (get) Token: 0x06037C82 RID: 228482 RVA: 0x00D392EE File Offset: 0x00D374EE
		// (set) Token: 0x06037C83 RID: 228483 RVA: 0x00D392F6 File Offset: 0x00D374F6
		public UUIItem MarkContainer { get; set; }

		// Token: 0x1700863D RID: 34365
		// (get) Token: 0x06037C84 RID: 228484 RVA: 0x00D392FF File Offset: 0x00D374FF
		// (set) Token: 0x06037C85 RID: 228485 RVA: 0x00D39307 File Offset: 0x00D37507
		public float MarkScale { get; set; }

		// Token: 0x1700863E RID: 34366
		// (get) Token: 0x06037C86 RID: 228486 RVA: 0x00D39310 File Offset: 0x00D37510
		// (set) Token: 0x06037C87 RID: 228487 RVA: 0x00D39318 File Offset: 0x00D37518
		public EMapGravityDirection? Gravity { get; set; }
	}
}
