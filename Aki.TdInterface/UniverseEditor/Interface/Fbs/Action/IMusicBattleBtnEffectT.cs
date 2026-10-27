using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B92 RID: 27538
	public class IMusicBattleBtnEffectT
	{
		// Token: 0x1700CCB0 RID: 52400
		// (get) Token: 0x060305CD RID: 198093 RVA: 0x00691D3A File Offset: 0x0068FF3A
		// (set) Token: 0x060305CE RID: 198094 RVA: 0x00691D42 File Offset: 0x0068FF42
		public ESkillBtnEffectType Type { get; set; }

		// Token: 0x060305CF RID: 198095 RVA: 0x00691D4B File Offset: 0x0068FF4B
		public IMusicBattleBtnEffectT()
		{
			this.Type = ESkillBtnEffectType.MusicBattleBtnEffect;
		}
	}
}
