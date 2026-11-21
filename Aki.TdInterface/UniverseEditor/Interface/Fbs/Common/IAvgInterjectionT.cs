using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200634E RID: 25422
	public class IAvgInterjectionT
	{
		// Token: 0x1700BBF5 RID: 48117
		// (get) Token: 0x0602B1D7 RID: 176599 RVA: 0x005E03FA File Offset: 0x005DE5FA
		// (set) Token: 0x0602B1D8 RID: 176600 RVA: 0x005E0402 File Offset: 0x005DE602
		public string Word { get; set; }

		// Token: 0x1700BBF6 RID: 48118
		// (get) Token: 0x0602B1D9 RID: 176601 RVA: 0x005E040B File Offset: 0x005DE60B
		// (set) Token: 0x0602B1DA RID: 176602 RVA: 0x005E0413 File Offset: 0x005DE613
		public string AkEvent { get; set; }

		// Token: 0x0602B1DB RID: 176603 RVA: 0x005E041C File Offset: 0x005DE61C
		public IAvgInterjectionT()
		{
			this.Word = null;
			this.AkEvent = null;
		}
	}
}
