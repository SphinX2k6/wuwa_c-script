using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A5B RID: 19035
	public class ICheckHonamiStoryGetItemT
	{
		// Token: 0x170089CF RID: 35279
		// (get) Token: 0x0601DD0A RID: 122122 RVA: 0x00430B24 File Offset: 0x0042ED24
		// (set) Token: 0x0601DD0B RID: 122123 RVA: 0x00430B2C File Offset: 0x0042ED2C
		public ECondition Type { get; set; }

		// Token: 0x170089D0 RID: 35280
		// (get) Token: 0x0601DD0C RID: 122124 RVA: 0x00430B35 File Offset: 0x0042ED35
		// (set) Token: 0x0601DD0D RID: 122125 RVA: 0x00430B3D File Offset: 0x0042ED3D
		public int ItemId { get; set; }

		// Token: 0x0601DD0E RID: 122126 RVA: 0x00430B46 File Offset: 0x0042ED46
		public ICheckHonamiStoryGetItemT()
		{
			this.Type = ECondition.CompareVar;
			this.ItemId = 0;
		}
	}
}
