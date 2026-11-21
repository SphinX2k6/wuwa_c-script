using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F7 RID: 30967
	public class ISkillBtnEffectBaseT
	{
		// Token: 0x1700E33B RID: 58171
		// (get) Token: 0x06036885 RID: 223365 RVA: 0x0074CE1E File Offset: 0x0074B01E
		// (set) Token: 0x06036886 RID: 223366 RVA: 0x0074CE26 File Offset: 0x0074B026
		public ESkillBtnEffectType Type { get; set; }

		// Token: 0x06036887 RID: 223367 RVA: 0x0074CE2F File Offset: 0x0074B02F
		public ISkillBtnEffectBaseT()
		{
			this.Type = ESkillBtnEffectType.MusicBattleBtnEffect;
		}
	}
}
