using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200622E RID: 25134
	public class IBubbleDataT
	{
		// Token: 0x1700BB47 RID: 47943
		// (get) Token: 0x0602B534 RID: 177460 RVA: 0x005F73EB File Offset: 0x005F55EB
		// (set) Token: 0x0602B535 RID: 177461 RVA: 0x005F73F3 File Offset: 0x005F55F3
		public IBubbleIndexT FlowIndex { get; set; }

		// Token: 0x1700BB48 RID: 47944
		// (get) Token: 0x0602B536 RID: 177462 RVA: 0x005F73FC File Offset: 0x005F55FC
		// (set) Token: 0x0602B537 RID: 177463 RVA: 0x005F7404 File Offset: 0x005F5604
		public int WaitTime { get; set; }

		// Token: 0x0602B538 RID: 177464 RVA: 0x005F740D File Offset: 0x005F560D
		public IBubbleDataT()
		{
			this.FlowIndex = null;
			this.WaitTime = 0;
		}
	}
}
