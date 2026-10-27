using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F0 RID: 20976
	public class CardSkillComponentData : ICardSkillComponentData
	{
		// Token: 0x170081D3 RID: 33235
		// (get) Token: 0x06035A71 RID: 219761 RVA: 0x00CB52D2 File Offset: 0x00CB34D2
		// (set) Token: 0x06035A72 RID: 219762 RVA: 0x00CB52DA File Offset: 0x00CB34DA
		public int SkillCd { get; set; }

		// Token: 0x170081D4 RID: 33236
		// (get) Token: 0x06035A73 RID: 219763 RVA: 0x00CB52E3 File Offset: 0x00CB34E3
		// (set) Token: 0x06035A74 RID: 219764 RVA: 0x00CB52EB File Offset: 0x00CB34EB
		public bool InSelect { get; set; }

		// Token: 0x170081D5 RID: 33237
		// (get) Token: 0x06035A75 RID: 219765 RVA: 0x00CB52F4 File Offset: 0x00CB34F4
		// (set) Token: 0x06035A76 RID: 219766 RVA: 0x00CB52FC File Offset: 0x00CB34FC
		public bool InFight { get; set; }
	}
}
