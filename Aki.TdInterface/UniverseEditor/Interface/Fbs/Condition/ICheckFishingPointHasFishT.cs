using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EEB RID: 20203
	public class ICheckFishingPointHasFishT
	{
		// Token: 0x17009042 RID: 36930
		// (get) Token: 0x0601F5DE RID: 128478 RVA: 0x0045EB20 File Offset: 0x0045CD20
		// (set) Token: 0x0601F5DF RID: 128479 RVA: 0x0045EB28 File Offset: 0x0045CD28
		public ECondition Type { get; set; }

		// Token: 0x17009043 RID: 36931
		// (get) Token: 0x0601F5E0 RID: 128480 RVA: 0x0045EB31 File Offset: 0x0045CD31
		// (set) Token: 0x0601F5E1 RID: 128481 RVA: 0x0045EB39 File Offset: 0x0045CD39
		public bool HasFish { get; set; }

		// Token: 0x0601F5E2 RID: 128482 RVA: 0x0045EB42 File Offset: 0x0045CD42
		public ICheckFishingPointHasFishT()
		{
			this.Type = ECondition.CompareVar;
			this.HasFish = false;
		}
	}
}
