using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B8 RID: 29112
	public class IStartSlidePerformTypeT
	{
		// Token: 0x1700D837 RID: 55351
		// (get) Token: 0x060339FE RID: 211454 RVA: 0x006F3B1E File Offset: 0x006F1D1E
		// (set) Token: 0x060339FF RID: 211455 RVA: 0x006F3B26 File Offset: 0x006F1D26
		public ESlidePerformType Type { get; set; }

		// Token: 0x06033A00 RID: 211456 RVA: 0x006F3B2F File Offset: 0x006F1D2F
		public IStartSlidePerformTypeT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
		}
	}
}
