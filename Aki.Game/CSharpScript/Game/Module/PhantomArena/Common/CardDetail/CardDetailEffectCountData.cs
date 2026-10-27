using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200521D RID: 21021
	public class CardDetailEffectCountData : ICardDetailEffectCountData
	{
		// Token: 0x17008221 RID: 33313
		// (get) Token: 0x06035C00 RID: 220160 RVA: 0x00CB9165 File Offset: 0x00CB7365
		// (set) Token: 0x06035C01 RID: 220161 RVA: 0x00CB916D File Offset: 0x00CB736D
		public int CurrentEffectCount { get; set; }

		// Token: 0x17008222 RID: 33314
		// (get) Token: 0x06035C02 RID: 220162 RVA: 0x00CB9176 File Offset: 0x00CB7376
		// (set) Token: 0x06035C03 RID: 220163 RVA: 0x00CB917E File Offset: 0x00CB737E
		public int TotalEffectCount { get; set; }
	}
}
