using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200659B RID: 26011
	public class IDestroyQuestItemT
	{
		// Token: 0x1700C12C RID: 49452
		// (get) Token: 0x0602D1F5 RID: 184821 RVA: 0x0063060E File Offset: 0x0062E80E
		// (set) Token: 0x0602D1F6 RID: 184822 RVA: 0x00630616 File Offset: 0x0062E816
		public int ItemId { get; set; }

		// Token: 0x1700C12D RID: 49453
		// (get) Token: 0x0602D1F7 RID: 184823 RVA: 0x0063061F File Offset: 0x0062E81F
		// (set) Token: 0x0602D1F8 RID: 184824 RVA: 0x00630627 File Offset: 0x0062E827
		public int Count { get; set; }

		// Token: 0x1700C12E RID: 49454
		// (get) Token: 0x0602D1F9 RID: 184825 RVA: 0x00630630 File Offset: 0x0062E830
		// (set) Token: 0x0602D1FA RID: 184826 RVA: 0x00630638 File Offset: 0x0062E838
		public bool IsAll { get; set; }

		// Token: 0x0602D1FB RID: 184827 RVA: 0x00630641 File Offset: 0x0062E841
		public IDestroyQuestItemT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.IsAll = false;
		}
	}
}
