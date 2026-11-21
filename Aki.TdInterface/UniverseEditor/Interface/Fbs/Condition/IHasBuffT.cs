using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005125 RID: 20773
	public class IHasBuffT
	{
		// Token: 0x170094DD RID: 38109
		// (get) Token: 0x06020AA1 RID: 133793 RVA: 0x00486F37 File Offset: 0x00485137
		// (set) Token: 0x06020AA2 RID: 133794 RVA: 0x00486F3F File Offset: 0x0048513F
		public ECondition Type { get; set; }

		// Token: 0x170094DE RID: 38110
		// (get) Token: 0x06020AA3 RID: 133795 RVA: 0x00486F48 File Offset: 0x00485148
		// (set) Token: 0x06020AA4 RID: 133796 RVA: 0x00486F50 File Offset: 0x00485150
		public long BuffId { get; set; }

		// Token: 0x170094DF RID: 38111
		// (get) Token: 0x06020AA5 RID: 133797 RVA: 0x00486F59 File Offset: 0x00485159
		// (set) Token: 0x06020AA6 RID: 133798 RVA: 0x00486F61 File Offset: 0x00485161
		public ECompare Compare { get; set; }

		// Token: 0x170094E0 RID: 38112
		// (get) Token: 0x06020AA7 RID: 133799 RVA: 0x00486F6A File Offset: 0x0048516A
		// (set) Token: 0x06020AA8 RID: 133800 RVA: 0x00486F72 File Offset: 0x00485172
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020AA9 RID: 133801 RVA: 0x00486F7B File Offset: 0x0048517B
		public IHasBuffT()
		{
			this.Type = ECondition.CompareVar;
			this.BuffId = 0L;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
