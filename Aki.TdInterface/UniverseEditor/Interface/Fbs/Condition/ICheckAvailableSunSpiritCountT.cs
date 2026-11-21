using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E40 RID: 20032
	public class ICheckAvailableSunSpiritCountT
	{
		// Token: 0x17008EB4 RID: 36532
		// (get) Token: 0x0601EFC7 RID: 126919 RVA: 0x00453CB0 File Offset: 0x00451EB0
		// (set) Token: 0x0601EFC8 RID: 126920 RVA: 0x00453CB8 File Offset: 0x00451EB8
		public ECondition Type { get; set; }

		// Token: 0x17008EB5 RID: 36533
		// (get) Token: 0x0601EFC9 RID: 126921 RVA: 0x00453CC1 File Offset: 0x00451EC1
		// (set) Token: 0x0601EFCA RID: 126922 RVA: 0x00453CC9 File Offset: 0x00451EC9
		public int AreaId { get; set; }

		// Token: 0x17008EB6 RID: 36534
		// (get) Token: 0x0601EFCB RID: 126923 RVA: 0x00453CD2 File Offset: 0x00451ED2
		// (set) Token: 0x0601EFCC RID: 126924 RVA: 0x00453CDA File Offset: 0x00451EDA
		public ECompare Compare { get; set; }

		// Token: 0x17008EB7 RID: 36535
		// (get) Token: 0x0601EFCD RID: 126925 RVA: 0x00453CE3 File Offset: 0x00451EE3
		// (set) Token: 0x0601EFCE RID: 126926 RVA: 0x00453CEB File Offset: 0x00451EEB
		public int Count { get; set; }

		// Token: 0x0601EFCF RID: 126927 RVA: 0x00453CF4 File Offset: 0x00451EF4
		public ICheckAvailableSunSpiritCountT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}
