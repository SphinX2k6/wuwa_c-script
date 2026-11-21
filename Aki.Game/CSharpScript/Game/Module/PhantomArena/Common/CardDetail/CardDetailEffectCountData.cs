using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041ED RID: 16877
	public class CardDetailEffectCountData : ICardDetailEffectCountData
	{
		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x0602AAFB RID: 174843 RVA: 0x00C067A9 File Offset: 0x00C049A9
		// (set) Token: 0x0602AAFC RID: 174844 RVA: 0x00C067B1 File Offset: 0x00C049B1
		public int CurrentEffectCount { get; set; }

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x0602AAFD RID: 174845 RVA: 0x00C067BA File Offset: 0x00C049BA
		// (set) Token: 0x0602AAFE RID: 174846 RVA: 0x00C067C2 File Offset: 0x00C049C2
		public int TotalEffectCount { get; set; }
	}
}
