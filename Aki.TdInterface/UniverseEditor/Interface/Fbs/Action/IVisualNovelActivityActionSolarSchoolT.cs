using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007557 RID: 30039
	public class IVisualNovelActivityActionSolarSchoolT
	{
		// Token: 0x1700E3E4 RID: 58340
		// (get) Token: 0x06036A74 RID: 223860 RVA: 0x0076C5A8 File Offset: 0x0076A7A8
		// (set) Token: 0x06036A75 RID: 223861 RVA: 0x0076C5B0 File Offset: 0x0076A7B0
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700E3E5 RID: 58341
		// (get) Token: 0x06036A76 RID: 223862 RVA: 0x0076C5B9 File Offset: 0x0076A7B9
		// (set) Token: 0x06036A77 RID: 223863 RVA: 0x0076C5C1 File Offset: 0x0076A7C1
		public int SolarSchoolActionId { get; set; }

		// Token: 0x06036A78 RID: 223864 RVA: 0x0076C5CA File Offset: 0x0076A7CA
		public IVisualNovelActivityActionSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.SolarSchoolActionId = 0;
		}
	}
}
