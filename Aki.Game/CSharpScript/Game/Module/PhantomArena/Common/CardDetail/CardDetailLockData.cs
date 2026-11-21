using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E6 RID: 16870
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailLockData : ICardDetailLockData
	{
		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x0602AAD1 RID: 174801 RVA: 0x00C066A4 File Offset: 0x00C048A4
		// (set) Token: 0x0602AAD2 RID: 174802 RVA: 0x00C066AC File Offset: 0x00C048AC
		public string Desc { get; set; }

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x0602AAD3 RID: 174803 RVA: 0x00C066B5 File Offset: 0x00C048B5
		// (set) Token: 0x0602AAD4 RID: 174804 RVA: 0x00C066BD File Offset: 0x00C048BD
		public int RemainRound { get; set; }
	}
}
