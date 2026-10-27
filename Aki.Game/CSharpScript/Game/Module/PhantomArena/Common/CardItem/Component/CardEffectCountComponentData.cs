using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E8 RID: 20968
	public class CardEffectCountComponentData : ICardEffectCountComponentData
	{
		// Token: 0x170081CB RID: 33227
		// (get) Token: 0x06035A46 RID: 219718 RVA: 0x00CB4DA3 File Offset: 0x00CB2FA3
		// (set) Token: 0x06035A47 RID: 219719 RVA: 0x00CB4DAB File Offset: 0x00CB2FAB
		public int EffectCount { get; set; }

		// Token: 0x170081CC RID: 33228
		// (get) Token: 0x06035A48 RID: 219720 RVA: 0x00CB4DB4 File Offset: 0x00CB2FB4
		// (set) Token: 0x06035A49 RID: 219721 RVA: 0x00CB4DBC File Offset: 0x00CB2FBC
		public int EffectCountMax { get; set; }

		// Token: 0x170081CD RID: 33229
		// (get) Token: 0x06035A4A RID: 219722 RVA: 0x00CB4DC5 File Offset: 0x00CB2FC5
		// (set) Token: 0x06035A4B RID: 219723 RVA: 0x00CB4DCD File Offset: 0x00CB2FCD
		public bool InFight { get; set; }
	}
}
