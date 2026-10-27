using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004989 RID: 18825
	public class ICheckAvailableSunSpiritCountT
	{
		// Token: 0x170087F9 RID: 34809
		// (get) Token: 0x0601D5A2 RID: 120226 RVA: 0x004237FC File Offset: 0x004219FC
		// (set) Token: 0x0601D5A3 RID: 120227 RVA: 0x00423804 File Offset: 0x00421A04
		public ECondition Type { get; set; }

		// Token: 0x170087FA RID: 34810
		// (get) Token: 0x0601D5A4 RID: 120228 RVA: 0x0042380D File Offset: 0x00421A0D
		// (set) Token: 0x0601D5A5 RID: 120229 RVA: 0x00423815 File Offset: 0x00421A15
		public int AreaId { get; set; }

		// Token: 0x170087FB RID: 34811
		// (get) Token: 0x0601D5A6 RID: 120230 RVA: 0x0042381E File Offset: 0x00421A1E
		// (set) Token: 0x0601D5A7 RID: 120231 RVA: 0x00423826 File Offset: 0x00421A26
		public ECompare Compare { get; set; }

		// Token: 0x170087FC RID: 34812
		// (get) Token: 0x0601D5A8 RID: 120232 RVA: 0x0042382F File Offset: 0x00421A2F
		// (set) Token: 0x0601D5A9 RID: 120233 RVA: 0x00423837 File Offset: 0x00421A37
		public int Count { get; set; }

		// Token: 0x0601D5AA RID: 120234 RVA: 0x00423840 File Offset: 0x00421A40
		public ICheckAvailableSunSpiritCountT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}
