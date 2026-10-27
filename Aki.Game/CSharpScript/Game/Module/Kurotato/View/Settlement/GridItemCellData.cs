using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572A RID: 22314
	[NullableContext(1)]
	[Nullable(0)]
	internal class GridItemCellData
	{
		// Token: 0x17008862 RID: 34914
		// (get) Token: 0x06038BBE RID: 232382 RVA: 0x00D77376 File Offset: 0x00D75576
		// (set) Token: 0x06038BBF RID: 232383 RVA: 0x00D7737E File Offset: 0x00D7557E
		public IKurotatoSmallItemGridData Item { get; set; }

		// Token: 0x17008863 RID: 34915
		// (get) Token: 0x06038BC0 RID: 232384 RVA: 0x00D77387 File Offset: 0x00D75587
		// (set) Token: 0x06038BC1 RID: 232385 RVA: 0x00D7738F File Offset: 0x00D7558F
		[Nullable(2)]
		public Action OnClick { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
