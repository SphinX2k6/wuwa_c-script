using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CED RID: 27885
	public class IEnableNearbyTrackingT
	{
		// Token: 0x1700CC81 RID: 52353
		// (get) Token: 0x06030124 RID: 196900 RVA: 0x0068A2AF File Offset: 0x006884AF
		// (set) Token: 0x06030125 RID: 196901 RVA: 0x0068A2B7 File Offset: 0x006884B7
		public bool IsEnable { get; set; }

		// Token: 0x1700CC82 RID: 52354
		// (get) Token: 0x06030126 RID: 196902 RVA: 0x0068A2C0 File Offset: 0x006884C0
		// (set) Token: 0x06030127 RID: 196903 RVA: 0x0068A2C8 File Offset: 0x006884C8
		public TControlTrackingTypeUnion ControlType { get; set; }

		// Token: 0x06030128 RID: 196904 RVA: 0x0068A2D1 File Offset: 0x006884D1
		public IEnableNearbyTrackingT()
		{
			this.IsEnable = false;
			this.ControlType = null;
		}
	}
}
