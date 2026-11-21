using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDC RID: 27612
	public class IDeliverItemProbeCollectiblesConfigT
	{
		// Token: 0x1700CA89 RID: 51849
		// (get) Token: 0x0602F874 RID: 194676 RVA: 0x0067ADAF File Offset: 0x00678FAF
		// (set) Token: 0x0602F875 RID: 194677 RVA: 0x0067ADB7 File Offset: 0x00678FB7
		public IHandInItemViewStyleT ViewStyle { get; set; }

		// Token: 0x1700CA8A RID: 51850
		// (get) Token: 0x0602F876 RID: 194678 RVA: 0x0067ADC0 File Offset: 0x00678FC0
		// (set) Token: 0x0602F877 RID: 194679 RVA: 0x0067ADC8 File Offset: 0x00678FC8
		public int CollectiblesDetectionId { get; set; }

		// Token: 0x0602F878 RID: 194680 RVA: 0x0067ADD1 File Offset: 0x00678FD1
		public IDeliverItemProbeCollectiblesConfigT()
		{
			this.ViewStyle = null;
			this.CollectiblesDetectionId = 0;
		}
	}
}
