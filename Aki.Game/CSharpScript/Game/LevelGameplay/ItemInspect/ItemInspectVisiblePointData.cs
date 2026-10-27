using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02006DDE RID: 28126
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectVisiblePointData : IItemInspectVisiblePointData
	{
		// Token: 0x170099CF RID: 39375
		// (get) Token: 0x06044996 RID: 280982 RVA: 0x010ED51D File Offset: 0x010EB71D
		// (set) Token: 0x06044997 RID: 280983 RVA: 0x010ED525 File Offset: 0x010EB725
		public int TagId { get; set; }

		// Token: 0x170099D0 RID: 39376
		// (get) Token: 0x06044998 RID: 280984 RVA: 0x010ED52E File Offset: 0x010EB72E
		// (set) Token: 0x06044999 RID: 280985 RVA: 0x010ED536 File Offset: 0x010EB736
		public Vector Location { get; set; } = Vector.Create();

		// Token: 0x170099D1 RID: 39377
		// (get) Token: 0x0604499A RID: 280986 RVA: 0x010ED53F File Offset: 0x010EB73F
		// (set) Token: 0x0604499B RID: 280987 RVA: 0x010ED547 File Offset: 0x010EB747
		public bool IsChecked { get; set; }
	}
}
