using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006679 RID: 26233
	public class IEnableNearbyTrackingT
	{
		// Token: 0x1700C2DE RID: 49886
		// (get) Token: 0x0602D93B RID: 186683 RVA: 0x0063D513 File Offset: 0x0063B713
		// (set) Token: 0x0602D93C RID: 186684 RVA: 0x0063D51B File Offset: 0x0063B71B
		public bool IsEnable { get; set; }

		// Token: 0x1700C2DF RID: 49887
		// (get) Token: 0x0602D93D RID: 186685 RVA: 0x0063D524 File Offset: 0x0063B724
		// (set) Token: 0x0602D93E RID: 186686 RVA: 0x0063D52C File Offset: 0x0063B72C
		public TControlTrackingTypeUnion ControlType { get; set; }

		// Token: 0x0602D93F RID: 186687 RVA: 0x0063D535 File Offset: 0x0063B735
		public IEnableNearbyTrackingT()
		{
			this.IsEnable = false;
			this.ControlType = null;
		}
	}
}
