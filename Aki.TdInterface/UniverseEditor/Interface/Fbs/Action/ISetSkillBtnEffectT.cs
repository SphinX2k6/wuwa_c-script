using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706E RID: 28782
	public class ISetSkillBtnEffectT
	{
		// Token: 0x1700D5EF RID: 54767
		// (get) Token: 0x06032F6C RID: 208748 RVA: 0x006DFFCD File Offset: 0x006DE1CD
		// (set) Token: 0x06032F6D RID: 208749 RVA: 0x006DFFD5 File Offset: 0x006DE1D5
		public ESkillButtonType SkillBtnType { get; set; }

		// Token: 0x1700D5F0 RID: 54768
		// (get) Token: 0x06032F6E RID: 208750 RVA: 0x006DFFDE File Offset: 0x006DE1DE
		// (set) Token: 0x06032F6F RID: 208751 RVA: 0x006DFFE6 File Offset: 0x006DE1E6
		public IMusicBattleBtnEffectT SkillBtnEffectData { get; set; }

		// Token: 0x1700D5F1 RID: 54769
		// (get) Token: 0x06032F70 RID: 208752 RVA: 0x006DFFEF File Offset: 0x006DE1EF
		// (set) Token: 0x06032F71 RID: 208753 RVA: 0x006DFFF7 File Offset: 0x006DE1F7
		public float Time { get; set; }

		// Token: 0x06032F72 RID: 208754 RVA: 0x006E0000 File Offset: 0x006DE200
		public ISetSkillBtnEffectT()
		{
			this.SkillBtnType = ESkillButtonType.None;
			this.SkillBtnEffectData = null;
			this.Time = 0f;
		}
	}
}
