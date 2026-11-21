using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D9 RID: 16857
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailDurationData : ICardDetailDurationData
	{
		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x0602AA88 RID: 174728 RVA: 0x00C05932 File Offset: 0x00C03B32
		// (set) Token: 0x0602AA89 RID: 174729 RVA: 0x00C0593A File Offset: 0x00C03B3A
		public string Tips { get; set; }

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x0602AA8A RID: 174730 RVA: 0x00C05943 File Offset: 0x00C03B43
		// (set) Token: 0x0602AA8B RID: 174731 RVA: 0x00C0594B File Offset: 0x00C03B4B
		public string DurationDesc { get; set; }
	}
}
