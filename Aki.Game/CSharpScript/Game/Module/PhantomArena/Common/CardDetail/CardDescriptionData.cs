using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005213 RID: 21011
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDescriptionData : ICardDescriptionData
	{
		// Token: 0x1700820B RID: 33291
		// (get) Token: 0x06035BB6 RID: 220086 RVA: 0x00CB8713 File Offset: 0x00CB6913
		// (set) Token: 0x06035BB7 RID: 220087 RVA: 0x00CB871B File Offset: 0x00CB691B
		public string Description { get; set; }

		// Token: 0x1700820C RID: 33292
		// (get) Token: 0x06035BB8 RID: 220088 RVA: 0x00CB8724 File Offset: 0x00CB6924
		// (set) Token: 0x06035BB9 RID: 220089 RVA: 0x00CB872C File Offset: 0x00CB692C
		public List<string> DescriptionParams { get; set; }
	}
}
