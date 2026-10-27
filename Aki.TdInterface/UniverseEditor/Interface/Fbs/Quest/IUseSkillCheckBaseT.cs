using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004245 RID: 16965
	public class IUseSkillCheckBaseT
	{
		// Token: 0x17007875 RID: 30837
		// (get) Token: 0x06019179 RID: 102777 RVA: 0x0039BBBA File Offset: 0x00399DBA
		// (set) Token: 0x0601917A RID: 102778 RVA: 0x0039BBC2 File Offset: 0x00399DC2
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x0601917B RID: 102779 RVA: 0x0039BBCB File Offset: 0x00399DCB
		public IUseSkillCheckBaseT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
		}
	}
}
