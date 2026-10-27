using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B9C RID: 19356
	public class ICompareEntityStateConditionT
	{
		// Token: 0x17008C79 RID: 35961
		// (get) Token: 0x0601E844 RID: 124996 RVA: 0x004454D3 File Offset: 0x004436D3
		// (set) Token: 0x0601E845 RID: 124997 RVA: 0x004454DB File Offset: 0x004436DB
		public ECondition Type { get; set; }

		// Token: 0x17008C7A RID: 35962
		// (get) Token: 0x0601E846 RID: 124998 RVA: 0x004454E4 File Offset: 0x004436E4
		// (set) Token: 0x0601E847 RID: 124999 RVA: 0x004454EC File Offset: 0x004436EC
		public int EntityId { get; set; }

		// Token: 0x17008C7B RID: 35963
		// (get) Token: 0x0601E848 RID: 125000 RVA: 0x004454F5 File Offset: 0x004436F5
		// (set) Token: 0x0601E849 RID: 125001 RVA: 0x004454FD File Offset: 0x004436FD
		public ECompare Compare { get; set; }

		// Token: 0x17008C7C RID: 35964
		// (get) Token: 0x0601E84A RID: 125002 RVA: 0x00445506 File Offset: 0x00443706
		// (set) Token: 0x0601E84B RID: 125003 RVA: 0x0044550E File Offset: 0x0044370E
		public string State { get; set; }

		// Token: 0x0601E84C RID: 125004 RVA: 0x00445517 File Offset: 0x00443717
		public ICompareEntityStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.State = null;
		}
	}
}
