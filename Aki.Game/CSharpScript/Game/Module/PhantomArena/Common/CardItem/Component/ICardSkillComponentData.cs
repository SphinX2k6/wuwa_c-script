using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051EF RID: 20975
	public interface ICardSkillComponentData
	{
		// Token: 0x170081D0 RID: 33232
		// (get) Token: 0x06035A6B RID: 219755
		// (set) Token: 0x06035A6C RID: 219756
		int SkillCd { get; set; }

		// Token: 0x170081D1 RID: 33233
		// (get) Token: 0x06035A6D RID: 219757
		// (set) Token: 0x06035A6E RID: 219758
		bool InSelect { get; set; }

		// Token: 0x170081D2 RID: 33234
		// (get) Token: 0x06035A6F RID: 219759
		// (set) Token: 0x06035A70 RID: 219760
		bool InFight { get; set; }
	}
}
