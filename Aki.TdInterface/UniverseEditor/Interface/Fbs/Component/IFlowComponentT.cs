using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200527D RID: 21117
	public class IFlowComponentT
	{
		// Token: 0x17009AC2 RID: 39618
		// (get) Token: 0x0602260B RID: 140811 RVA: 0x004C3F09 File Offset: 0x004C2109
		// (set) Token: 0x0602260C RID: 140812 RVA: 0x004C3F11 File Offset: 0x004C2111
		public bool Disabled { get; set; }

		// Token: 0x17009AC3 RID: 39619
		// (get) Token: 0x0602260D RID: 140813 RVA: 0x004C3F1A File Offset: 0x004C211A
		// (set) Token: 0x0602260E RID: 140814 RVA: 0x004C3F22 File Offset: 0x004C2122
		public IPlayFlowT InitState { get; set; }

		// Token: 0x17009AC4 RID: 39620
		// (get) Token: 0x0602260F RID: 140815 RVA: 0x004C3F2B File Offset: 0x004C212B
		// (set) Token: 0x06022610 RID: 140816 RVA: 0x004C3F33 File Offset: 0x004C2133
		public byte NullMask { get; set; }

		// Token: 0x06022611 RID: 140817 RVA: 0x004C3F3C File Offset: 0x004C213C
		public IFlowComponentT()
		{
			this.Disabled = false;
			this.InitState = null;
			this.NullMask = 0;
		}
	}
}
