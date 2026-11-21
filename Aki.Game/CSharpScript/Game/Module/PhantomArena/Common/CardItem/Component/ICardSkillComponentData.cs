using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041BF RID: 16831
	public interface ICardSkillComponentData
	{
		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x0602A966 RID: 174438
		// (set) Token: 0x0602A967 RID: 174439
		int SkillCd { get; set; }

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x0602A968 RID: 174440
		// (set) Token: 0x0602A969 RID: 174441
		bool InSelect { get; set; }

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x0602A96A RID: 174442
		// (set) Token: 0x0602A96B RID: 174443
		bool InFight { get; set; }
	}
}
