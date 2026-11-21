using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007517 RID: 29975
	public class IPreloadPhantomCharacterForSkillT
	{
		// Token: 0x1700DC96 RID: 56470
		// (get) Token: 0x06034919 RID: 215321 RVA: 0x0071344C File Offset: 0x0071164C
		// (set) Token: 0x0603491A RID: 215322 RVA: 0x00713454 File Offset: 0x00711654
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700DC97 RID: 56471
		// (get) Token: 0x0603491B RID: 215323 RVA: 0x0071345D File Offset: 0x0071165D
		// (set) Token: 0x0603491C RID: 215324 RVA: 0x00713465 File Offset: 0x00711665
		public int Id { get; set; }

		// Token: 0x0603491D RID: 215325 RVA: 0x0071346E File Offset: 0x0071166E
		public IPreloadPhantomCharacterForSkillT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.Id = 0;
		}
	}
}
