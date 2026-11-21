using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C0 RID: 16832
	public class CardSkillComponentData : ICardSkillComponentData
	{
		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x0602A96C RID: 174444 RVA: 0x00C0290E File Offset: 0x00C00B0E
		// (set) Token: 0x0602A96D RID: 174445 RVA: 0x00C02916 File Offset: 0x00C00B16
		public int SkillCd { get; set; }

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x0602A96E RID: 174446 RVA: 0x00C0291F File Offset: 0x00C00B1F
		// (set) Token: 0x0602A96F RID: 174447 RVA: 0x00C02927 File Offset: 0x00C00B27
		public bool InSelect { get; set; }

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x0602A970 RID: 174448 RVA: 0x00C02930 File Offset: 0x00C00B30
		// (set) Token: 0x0602A971 RID: 174449 RVA: 0x00C02938 File Offset: 0x00C00B38
		public bool InFight { get; set; }
	}
}
