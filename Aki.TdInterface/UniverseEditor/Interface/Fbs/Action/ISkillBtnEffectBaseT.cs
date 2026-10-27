using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712B RID: 28971
	public class ISkillBtnEffectBaseT
	{
		// Token: 0x1700D758 RID: 55128
		// (get) Token: 0x060335E3 RID: 210403 RVA: 0x006EC812 File Offset: 0x006EAA12
		// (set) Token: 0x060335E4 RID: 210404 RVA: 0x006EC81A File Offset: 0x006EAA1A
		public ESkillBtnEffectType Type { get; set; }

		// Token: 0x060335E5 RID: 210405 RVA: 0x006EC823 File Offset: 0x006EAA23
		public ISkillBtnEffectBaseT()
		{
			this.Type = ESkillBtnEffectType.MusicBattleBtnEffect;
		}
	}
}
