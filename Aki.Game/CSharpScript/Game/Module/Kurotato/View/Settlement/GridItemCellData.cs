using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004701 RID: 18177
	[NullableContext(1)]
	[Nullable(0)]
	internal class GridItemCellData
	{
		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x0602DACE RID: 187086 RVA: 0x00CC5A22 File Offset: 0x00CC3C22
		// (set) Token: 0x0602DACF RID: 187087 RVA: 0x00CC5A2A File Offset: 0x00CC3C2A
		public IKurotatoSmallItemGridData Item { get; set; }

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x0602DAD0 RID: 187088 RVA: 0x00CC5A33 File Offset: 0x00CC3C33
		// (set) Token: 0x0602DAD1 RID: 187089 RVA: 0x00CC5A3B File Offset: 0x00CC3C3B
		[Nullable(2)]
		public Action OnClick { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
