using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D1 RID: 18129
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupItemDetailOpenParam : IKurotatoPopupItemDetailOpenParam
	{
		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x0602D927 RID: 186663 RVA: 0x00CBED1F File Offset: 0x00CBCF1F
		// (set) Token: 0x0602D928 RID: 186664 RVA: 0x00CBED27 File Offset: 0x00CBCF27
		public int Index { get; set; }

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x0602D929 RID: 186665 RVA: 0x00CBED30 File Offset: 0x00CBCF30
		// (set) Token: 0x0602D92A RID: 186666 RVA: 0x00CBED38 File Offset: 0x00CBCF38
		public List<KurotatoCardTip> CardData { get; set; }

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x0602D92B RID: 186667 RVA: 0x00CBED41 File Offset: 0x00CBCF41
		// (set) Token: 0x0602D92C RID: 186668 RVA: 0x00CBED49 File Offset: 0x00CBCF49
		public bool? IsOutSide { get; set; }

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x0602D92D RID: 186669 RVA: 0x00CBED52 File Offset: 0x00CBCF52
		// (set) Token: 0x0602D92E RID: 186670 RVA: 0x00CBED5A File Offset: 0x00CBCF5A
		[Nullable(2)]
		public List<int> Price { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
