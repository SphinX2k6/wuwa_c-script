using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E96 RID: 24214
	public class IRollBlockItemComponentT
	{
		// Token: 0x1700B2AF RID: 45743
		// (get) Token: 0x0602886E RID: 165998 RVA: 0x0058A620 File Offset: 0x00588820
		// (set) Token: 0x0602886F RID: 165999 RVA: 0x0058A628 File Offset: 0x00588828
		public bool Disabled { get; set; }

		// Token: 0x1700B2B0 RID: 45744
		// (get) Token: 0x06028870 RID: 166000 RVA: 0x0058A631 File Offset: 0x00588831
		// (set) Token: 0x06028871 RID: 166001 RVA: 0x0058A639 File Offset: 0x00588839
		public byte NullMask { get; set; }

		// Token: 0x06028872 RID: 166002 RVA: 0x0058A642 File Offset: 0x00588842
		public IRollBlockItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
