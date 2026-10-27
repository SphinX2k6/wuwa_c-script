using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FA RID: 22266
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoPopupItemDetailOpenParam : IKurotatoPopupItemDetailOpenParam
	{
		// Token: 0x17008818 RID: 34840
		// (get) Token: 0x06038A17 RID: 231959 RVA: 0x00D70737 File Offset: 0x00D6E937
		// (set) Token: 0x06038A18 RID: 231960 RVA: 0x00D7073F File Offset: 0x00D6E93F
		public int Index { get; set; }

		// Token: 0x17008819 RID: 34841
		// (get) Token: 0x06038A19 RID: 231961 RVA: 0x00D70748 File Offset: 0x00D6E948
		// (set) Token: 0x06038A1A RID: 231962 RVA: 0x00D70750 File Offset: 0x00D6E950
		public List<KurotatoCardTip> CardData { get; set; }

		// Token: 0x1700881A RID: 34842
		// (get) Token: 0x06038A1B RID: 231963 RVA: 0x00D70759 File Offset: 0x00D6E959
		// (set) Token: 0x06038A1C RID: 231964 RVA: 0x00D70761 File Offset: 0x00D6E961
		public bool? IsOutSide { get; set; }

		// Token: 0x1700881B RID: 34843
		// (get) Token: 0x06038A1D RID: 231965 RVA: 0x00D7076A File Offset: 0x00D6E96A
		// (set) Token: 0x06038A1E RID: 231966 RVA: 0x00D70772 File Offset: 0x00D6E972
		[Nullable(2)]
		public List<int> Price { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
