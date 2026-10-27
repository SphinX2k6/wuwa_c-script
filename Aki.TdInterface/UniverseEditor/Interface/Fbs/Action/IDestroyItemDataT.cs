using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006592 RID: 26002
	public class IDestroyItemDataT
	{
		// Token: 0x1700C11B RID: 49435
		// (get) Token: 0x0602D1A8 RID: 184744 RVA: 0x0062FCDE File Offset: 0x0062DEDE
		// (set) Token: 0x0602D1A9 RID: 184745 RVA: 0x0062FCE6 File Offset: 0x0062DEE6
		public int ItemId { get; set; }

		// Token: 0x1700C11C RID: 49436
		// (get) Token: 0x0602D1AA RID: 184746 RVA: 0x0062FCEF File Offset: 0x0062DEEF
		// (set) Token: 0x0602D1AB RID: 184747 RVA: 0x0062FCF7 File Offset: 0x0062DEF7
		public int Count { get; set; }

		// Token: 0x1700C11D RID: 49437
		// (get) Token: 0x0602D1AC RID: 184748 RVA: 0x0062FD00 File Offset: 0x0062DF00
		// (set) Token: 0x0602D1AD RID: 184749 RVA: 0x0062FD08 File Offset: 0x0062DF08
		public bool IsAll { get; set; }

		// Token: 0x0602D1AE RID: 184750 RVA: 0x0062FD11 File Offset: 0x0062DF11
		public IDestroyItemDataT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.IsAll = false;
		}
	}
}
