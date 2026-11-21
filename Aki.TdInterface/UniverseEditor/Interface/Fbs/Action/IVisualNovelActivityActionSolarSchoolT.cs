using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D4D RID: 32077
	public class IVisualNovelActivityActionSolarSchoolT
	{
		// Token: 0x1700F00E RID: 61454
		// (get) Token: 0x06039E8A RID: 237194 RVA: 0x007CF850 File Offset: 0x007CDA50
		// (set) Token: 0x06039E8B RID: 237195 RVA: 0x007CF858 File Offset: 0x007CDA58
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700F00F RID: 61455
		// (get) Token: 0x06039E8C RID: 237196 RVA: 0x007CF861 File Offset: 0x007CDA61
		// (set) Token: 0x06039E8D RID: 237197 RVA: 0x007CF869 File Offset: 0x007CDA69
		public int SolarSchoolActionId { get; set; }

		// Token: 0x06039E8E RID: 237198 RVA: 0x007CF872 File Offset: 0x007CDA72
		public IVisualNovelActivityActionSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.SolarSchoolActionId = 0;
		}
	}
}
