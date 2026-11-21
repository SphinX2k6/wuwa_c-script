using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02005F5D RID: 24413
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectVisiblePointData : IItemInspectVisiblePointData
	{
		// Token: 0x17006ED2 RID: 28370
		// (get) Token: 0x0603AAFA RID: 240378 RVA: 0x01097769 File Offset: 0x01095969
		// (set) Token: 0x0603AAFB RID: 240379 RVA: 0x01097771 File Offset: 0x01095971
		public int TagId { get; set; }

		// Token: 0x17006ED3 RID: 28371
		// (get) Token: 0x0603AAFC RID: 240380 RVA: 0x0109777A File Offset: 0x0109597A
		// (set) Token: 0x0603AAFD RID: 240381 RVA: 0x01097782 File Offset: 0x01095982
		public Vector Location { get; set; } = Vector.Create();

		// Token: 0x17006ED4 RID: 28372
		// (get) Token: 0x0603AAFE RID: 240382 RVA: 0x0109778B File Offset: 0x0109598B
		// (set) Token: 0x0603AAFF RID: 240383 RVA: 0x01097793 File Offset: 0x01095993
		public bool IsChecked { get; set; }
	}
}
