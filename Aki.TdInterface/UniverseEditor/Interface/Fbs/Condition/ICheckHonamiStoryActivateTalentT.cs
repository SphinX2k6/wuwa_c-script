using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F18 RID: 20248
	public class ICheckHonamiStoryActivateTalentT
	{
		// Token: 0x17009095 RID: 37013
		// (get) Token: 0x0601F75D RID: 128861 RVA: 0x004614D6 File Offset: 0x0045F6D6
		// (set) Token: 0x0601F75E RID: 128862 RVA: 0x004614DE File Offset: 0x0045F6DE
		public ECondition Type { get; set; }

		// Token: 0x17009096 RID: 37014
		// (get) Token: 0x0601F75F RID: 128863 RVA: 0x004614E7 File Offset: 0x0045F6E7
		// (set) Token: 0x0601F760 RID: 128864 RVA: 0x004614EF File Offset: 0x0045F6EF
		public int TalentId { get; set; }

		// Token: 0x17009097 RID: 37015
		// (get) Token: 0x0601F761 RID: 128865 RVA: 0x004614F8 File Offset: 0x0045F6F8
		// (set) Token: 0x0601F762 RID: 128866 RVA: 0x00461500 File Offset: 0x0045F700
		public bool IsActivated { get; set; }

		// Token: 0x0601F763 RID: 128867 RVA: 0x00461509 File Offset: 0x0045F709
		public ICheckHonamiStoryActivateTalentT()
		{
			this.Type = ECondition.CompareVar;
			this.TalentId = 0;
			this.IsActivated = false;
		}
	}
}
