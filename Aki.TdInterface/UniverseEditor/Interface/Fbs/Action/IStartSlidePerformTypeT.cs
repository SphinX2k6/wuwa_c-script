using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200798D RID: 31117
	public class IStartSlidePerformTypeT
	{
		// Token: 0x1700E42E RID: 58414
		// (get) Token: 0x06036CFC RID: 224508 RVA: 0x00754DEA File Offset: 0x00752FEA
		// (set) Token: 0x06036CFD RID: 224509 RVA: 0x00754DF2 File Offset: 0x00752FF2
		public ESlidePerformType Type { get; set; }

		// Token: 0x06036CFE RID: 224510 RVA: 0x00754DFB File Offset: 0x00752FFB
		public IStartSlidePerformTypeT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
		}
	}
}
