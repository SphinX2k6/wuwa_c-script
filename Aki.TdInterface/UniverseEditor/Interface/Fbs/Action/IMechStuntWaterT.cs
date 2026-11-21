using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C3 RID: 29123
	public class IMechStuntWaterT
	{
		// Token: 0x1700D544 RID: 54596
		// (get) Token: 0x06032A86 RID: 207494 RVA: 0x006D808E File Offset: 0x006D628E
		// (set) Token: 0x06032A87 RID: 207495 RVA: 0x006D8096 File Offset: 0x006D6296
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A88 RID: 207496 RVA: 0x006D809F File Offset: 0x006D629F
		public IMechStuntWaterT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
