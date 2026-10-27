using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004995 RID: 18837
	public class ICheckCertainFishingItemCountT
	{
		// Token: 0x17008817 RID: 34839
		// (get) Token: 0x0601D60E RID: 120334 RVA: 0x004242C4 File Offset: 0x004224C4
		// (set) Token: 0x0601D60F RID: 120335 RVA: 0x004242CC File Offset: 0x004224CC
		public ECondition Type { get; set; }

		// Token: 0x17008818 RID: 34840
		// (get) Token: 0x0601D610 RID: 120336 RVA: 0x004242D5 File Offset: 0x004224D5
		// (set) Token: 0x0601D611 RID: 120337 RVA: 0x004242DD File Offset: 0x004224DD
		public int Id { get; set; }

		// Token: 0x17008819 RID: 34841
		// (get) Token: 0x0601D612 RID: 120338 RVA: 0x004242E6 File Offset: 0x004224E6
		// (set) Token: 0x0601D613 RID: 120339 RVA: 0x004242EE File Offset: 0x004224EE
		public ECompare Compare { get; set; }

		// Token: 0x1700881A RID: 34842
		// (get) Token: 0x0601D614 RID: 120340 RVA: 0x004242F7 File Offset: 0x004224F7
		// (set) Token: 0x0601D615 RID: 120341 RVA: 0x004242FF File Offset: 0x004224FF
		public int Count { get; set; }

		// Token: 0x0601D616 RID: 120342 RVA: 0x00424308 File Offset: 0x00422508
		public ICheckCertainFishingItemCountT()
		{
			this.Type = ECondition.CompareVar;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}
