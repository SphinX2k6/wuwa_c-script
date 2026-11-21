using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ECA RID: 20170
	public class ICheckEntityIsVisibilityT
	{
		// Token: 0x17008FFF RID: 36863
		// (get) Token: 0x0601F4C7 RID: 128199 RVA: 0x0045CCCE File Offset: 0x0045AECE
		// (set) Token: 0x0601F4C8 RID: 128200 RVA: 0x0045CCD6 File Offset: 0x0045AED6
		public ECondition Type { get; set; }

		// Token: 0x17009000 RID: 36864
		// (get) Token: 0x0601F4C9 RID: 128201 RVA: 0x0045CCDF File Offset: 0x0045AEDF
		// (set) Token: 0x0601F4CA RID: 128202 RVA: 0x0045CCE7 File Offset: 0x0045AEE7
		public int EntityId { get; set; }

		// Token: 0x17009001 RID: 36865
		// (get) Token: 0x0601F4CB RID: 128203 RVA: 0x0045CCF0 File Offset: 0x0045AEF0
		// (set) Token: 0x0601F4CC RID: 128204 RVA: 0x0045CCF8 File Offset: 0x0045AEF8
		public bool IsVisible { get; set; }

		// Token: 0x0601F4CD RID: 128205 RVA: 0x0045CD01 File Offset: 0x0045AF01
		public ICheckEntityIsVisibilityT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.IsVisible = false;
		}
	}
}
