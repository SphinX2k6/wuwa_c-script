using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A5 RID: 26789
	public class IBubbleRangeCylinderConfigT
	{
		// Token: 0x1700C4DD RID: 50397
		// (get) Token: 0x0602DCCB RID: 187595 RVA: 0x00642832 File Offset: 0x00640A32
		// (set) Token: 0x0602DCCC RID: 187596 RVA: 0x0064283A File Offset: 0x00640A3A
		public IBubbleCylinderConfigT InnerConfig { get; set; }

		// Token: 0x1700C4DE RID: 50398
		// (get) Token: 0x0602DCCD RID: 187597 RVA: 0x00642843 File Offset: 0x00640A43
		// (set) Token: 0x0602DCCE RID: 187598 RVA: 0x0064284B File Offset: 0x00640A4B
		public IBubbleCylinderConfigT OuterConfig { get; set; }

		// Token: 0x0602DCCF RID: 187599 RVA: 0x00642854 File Offset: 0x00640A54
		public IBubbleRangeCylinderConfigT()
		{
			this.InnerConfig = null;
			this.OuterConfig = null;
		}
	}
}
