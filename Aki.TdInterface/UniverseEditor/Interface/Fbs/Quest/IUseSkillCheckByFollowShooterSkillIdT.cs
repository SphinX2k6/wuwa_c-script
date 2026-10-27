using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424B RID: 16971
	public class IUseSkillCheckByFollowShooterSkillIdT
	{
		// Token: 0x1700787B RID: 30843
		// (get) Token: 0x060191A1 RID: 102817 RVA: 0x0039BFA4 File Offset: 0x0039A1A4
		// (set) Token: 0x060191A2 RID: 102818 RVA: 0x0039BFAC File Offset: 0x0039A1AC
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x1700787C RID: 30844
		// (get) Token: 0x060191A3 RID: 102819 RVA: 0x0039BFB5 File Offset: 0x0039A1B5
		// (set) Token: 0x060191A4 RID: 102820 RVA: 0x0039BFBD File Offset: 0x0039A1BD
		public int SkillId { get; set; }

		// Token: 0x060191A5 RID: 102821 RVA: 0x0039BFC6 File Offset: 0x0039A1C6
		public IUseSkillCheckByFollowShooterSkillIdT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
			this.SkillId = 0;
		}
	}
}
