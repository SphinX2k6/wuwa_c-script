using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDF RID: 27615
	public class IDeliverItemProbeCollectibleViewStyleT
	{
		// Token: 0x1700CA8D RID: 51853
		// (get) Token: 0x0602F888 RID: 194696 RVA: 0x0067AF6E File Offset: 0x0067916E
		// (set) Token: 0x0602F889 RID: 194697 RVA: 0x0067AF76 File Offset: 0x00679176
		public EDeliverItemProbeCollectibleViewStyle Type { get; set; }

		// Token: 0x0602F88A RID: 194698 RVA: 0x0067AF7F File Offset: 0x0067917F
		public IDeliverItemProbeCollectibleViewStyleT()
		{
			this.Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
		}
	}
}
