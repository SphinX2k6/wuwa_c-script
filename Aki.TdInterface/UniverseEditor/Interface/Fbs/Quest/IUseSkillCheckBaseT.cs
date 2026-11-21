using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A1 RID: 18081
	public class IUseSkillCheckBaseT
	{
		// Token: 0x17007EA6 RID: 32422
		// (get) Token: 0x0601A8E5 RID: 108773 RVA: 0x003C7292 File Offset: 0x003C5492
		// (set) Token: 0x0601A8E6 RID: 108774 RVA: 0x003C729A File Offset: 0x003C549A
		public EUseSkillCheckType Type { get; set; }

		// Token: 0x0601A8E7 RID: 108775 RVA: 0x003C72A3 File Offset: 0x003C54A3
		public IUseSkillCheckBaseT()
		{
			this.Type = EUseSkillCheckType.CheckSkillGenre;
		}
	}
}
