using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E94 RID: 28308
	public class IFlowIndexT
	{
		// Token: 0x1700CF78 RID: 53112
		// (get) Token: 0x06030EC0 RID: 200384 RVA: 0x006A28D3 File Offset: 0x006A0AD3
		// (set) Token: 0x06030EC1 RID: 200385 RVA: 0x006A28DB File Offset: 0x006A0ADB
		public string FlowListName { get; set; }

		// Token: 0x1700CF79 RID: 53113
		// (get) Token: 0x06030EC2 RID: 200386 RVA: 0x006A28E4 File Offset: 0x006A0AE4
		// (set) Token: 0x06030EC3 RID: 200387 RVA: 0x006A28EC File Offset: 0x006A0AEC
		public int FlowId { get; set; }

		// Token: 0x06030EC4 RID: 200388 RVA: 0x006A28F5 File Offset: 0x006A0AF5
		public IFlowIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
		}
	}
}
