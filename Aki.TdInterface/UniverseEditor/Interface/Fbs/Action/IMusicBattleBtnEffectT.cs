using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D8 RID: 29400
	public class IMusicBattleBtnEffectT
	{
		// Token: 0x1700D795 RID: 55189
		// (get) Token: 0x06033425 RID: 209957 RVA: 0x006EA35A File Offset: 0x006E855A
		// (set) Token: 0x06033426 RID: 209958 RVA: 0x006EA362 File Offset: 0x006E8562
		public ESkillBtnEffectType Type { get; set; }

		// Token: 0x06033427 RID: 209959 RVA: 0x006EA36B File Offset: 0x006E856B
		public IMusicBattleBtnEffectT()
		{
			this.Type = ESkillBtnEffectType.MusicBattleBtnEffect;
		}
	}
}
