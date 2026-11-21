using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E3 RID: 16867
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDescriptionData : ICardDescriptionData
	{
		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x0602AAB1 RID: 174769 RVA: 0x00C05D57 File Offset: 0x00C03F57
		// (set) Token: 0x0602AAB2 RID: 174770 RVA: 0x00C05D5F File Offset: 0x00C03F5F
		public string Description { get; set; }

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x0602AAB3 RID: 174771 RVA: 0x00C05D68 File Offset: 0x00C03F68
		// (set) Token: 0x0602AAB4 RID: 174772 RVA: 0x00C05D70 File Offset: 0x00C03F70
		public List<string> DescriptionParams { get; set; }
	}
}
