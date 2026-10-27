using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715B RID: 29019
	public class ISlopeSlidePerformStartT
	{
		// Token: 0x1700D7A6 RID: 55206
		// (get) Token: 0x06033746 RID: 210758 RVA: 0x006EECA7 File Offset: 0x006ECEA7
		// (set) Token: 0x06033747 RID: 210759 RVA: 0x006EECAF File Offset: 0x006ECEAF
		public ESlidePerformType Type { get; set; }

		// Token: 0x1700D7A7 RID: 55207
		// (get) Token: 0x06033748 RID: 210760 RVA: 0x006EECB8 File Offset: 0x006ECEB8
		// (set) Token: 0x06033749 RID: 210761 RVA: 0x006EECC0 File Offset: 0x006ECEC0
		public string SlopeSlidePerformDaPath { get; set; }

		// Token: 0x0603374A RID: 210762 RVA: 0x006EECC9 File Offset: 0x006ECEC9
		public ISlopeSlidePerformStartT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
			this.SlopeSlidePerformDaPath = null;
		}
	}
}
