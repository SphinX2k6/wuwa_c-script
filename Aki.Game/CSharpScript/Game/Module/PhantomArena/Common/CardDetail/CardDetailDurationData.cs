using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005209 RID: 21001
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailDurationData : ICardDetailDurationData
	{
		// Token: 0x17008201 RID: 33281
		// (get) Token: 0x06035B8D RID: 220045 RVA: 0x00CB82F6 File Offset: 0x00CB64F6
		// (set) Token: 0x06035B8E RID: 220046 RVA: 0x00CB82FE File Offset: 0x00CB64FE
		public string Tips { get; set; }

		// Token: 0x17008202 RID: 33282
		// (get) Token: 0x06035B8F RID: 220047 RVA: 0x00CB8307 File Offset: 0x00CB6507
		// (set) Token: 0x06035B90 RID: 220048 RVA: 0x00CB830F File Offset: 0x00CB650F
		public string DurationDesc { get; set; }
	}
}
