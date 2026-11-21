using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007104 RID: 28932
	public class ILiveInteractDanmakuTriggerSkillGenreT
	{
		// Token: 0x1700D3E3 RID: 54243
		// (get) Token: 0x06032405 RID: 205829 RVA: 0x006CBC30 File Offset: 0x006C9E30
		// (set) Token: 0x06032406 RID: 205830 RVA: 0x006CBC38 File Offset: 0x006C9E38
		public ELiveInteractDanmakuTriggerType Type { get; set; }

		// Token: 0x1700D3E4 RID: 54244
		// (get) Token: 0x06032407 RID: 205831 RVA: 0x006CBC41 File Offset: 0x006C9E41
		// (set) Token: 0x06032408 RID: 205832 RVA: 0x006CBC49 File Offset: 0x006C9E49
		public int SkillGenre { get; set; }

		// Token: 0x06032409 RID: 205833 RVA: 0x006CBC52 File Offset: 0x006C9E52
		public ILiveInteractDanmakuTriggerSkillGenreT()
		{
			this.Type = ELiveInteractDanmakuTriggerType.SkillGenre;
			this.SkillGenre = 0;
		}
	}
}
