using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA3 RID: 28323
	public class IFlowStateIndexT
	{
		// Token: 0x1700CFC2 RID: 53186
		// (get) Token: 0x06030FF0 RID: 200688 RVA: 0x006A560D File Offset: 0x006A380D
		// (set) Token: 0x06030FF1 RID: 200689 RVA: 0x006A5615 File Offset: 0x006A3815
		public string FlowListName { get; set; }

		// Token: 0x1700CFC3 RID: 53187
		// (get) Token: 0x06030FF2 RID: 200690 RVA: 0x006A561E File Offset: 0x006A381E
		// (set) Token: 0x06030FF3 RID: 200691 RVA: 0x006A5626 File Offset: 0x006A3826
		public int FlowId { get; set; }

		// Token: 0x1700CFC4 RID: 53188
		// (get) Token: 0x06030FF4 RID: 200692 RVA: 0x006A562F File Offset: 0x006A382F
		// (set) Token: 0x06030FF5 RID: 200693 RVA: 0x006A5637 File Offset: 0x006A3837
		public int StateId { get; set; }

		// Token: 0x06030FF6 RID: 200694 RVA: 0x006A5640 File Offset: 0x006A3840
		public IFlowStateIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
		}
	}
}
