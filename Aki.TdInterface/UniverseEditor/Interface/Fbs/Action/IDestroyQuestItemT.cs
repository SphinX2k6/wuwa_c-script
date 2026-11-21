using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C03 RID: 27651
	public class IDestroyQuestItemT
	{
		// Token: 0x1700CABB RID: 51899
		// (get) Token: 0x0602F979 RID: 194937 RVA: 0x0067C7D2 File Offset: 0x0067A9D2
		// (set) Token: 0x0602F97A RID: 194938 RVA: 0x0067C7DA File Offset: 0x0067A9DA
		public int ItemId { get; set; }

		// Token: 0x1700CABC RID: 51900
		// (get) Token: 0x0602F97B RID: 194939 RVA: 0x0067C7E3 File Offset: 0x0067A9E3
		// (set) Token: 0x0602F97C RID: 194940 RVA: 0x0067C7EB File Offset: 0x0067A9EB
		public int Count { get; set; }

		// Token: 0x1700CABD RID: 51901
		// (get) Token: 0x0602F97D RID: 194941 RVA: 0x0067C7F4 File Offset: 0x0067A9F4
		// (set) Token: 0x0602F97E RID: 194942 RVA: 0x0067C7FC File Offset: 0x0067A9FC
		public bool IsAll { get; set; }

		// Token: 0x0602F97F RID: 194943 RVA: 0x0067C805 File Offset: 0x0067AA05
		public IDestroyQuestItemT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.IsAll = false;
		}
	}
}
