using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A2 RID: 18338
	[NullableContext(1)]
	[Nullable(0)]
	public class MapProgressItemData
	{
		// Token: 0x17007815 RID: 30741
		// (get) Token: 0x0602FF53 RID: 196435 RVA: 0x00B19EA1 File Offset: 0x00B180A1
		// (set) Token: 0x0602FF54 RID: 196436 RVA: 0x00B19EA9 File Offset: 0x00B180A9
		public string TitleTextId { get; set; } = string.Empty;

		// Token: 0x17007816 RID: 30742
		// (get) Token: 0x0602FF55 RID: 196437 RVA: 0x00B19EB2 File Offset: 0x00B180B2
		// (set) Token: 0x0602FF56 RID: 196438 RVA: 0x00B19EBA File Offset: 0x00B180BA
		public string CountText { get; set; } = string.Empty;

		// Token: 0x17007817 RID: 30743
		// (get) Token: 0x0602FF57 RID: 196439 RVA: 0x00B19EC3 File Offset: 0x00B180C3
		// (set) Token: 0x0602FF58 RID: 196440 RVA: 0x00B19ECB File Offset: 0x00B180CB
		public bool Completed { get; set; }

		// Token: 0x17007818 RID: 30744
		// (get) Token: 0x0602FF59 RID: 196441 RVA: 0x00B19ED4 File Offset: 0x00B180D4
		// (set) Token: 0x0602FF5A RID: 196442 RVA: 0x00B19EDC File Offset: 0x00B180DC
		[Nullable(2)]
		public string IconPath { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
