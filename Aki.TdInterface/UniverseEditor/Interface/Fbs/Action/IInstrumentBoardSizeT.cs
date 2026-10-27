using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006967 RID: 26983
	public class IInstrumentBoardSizeT
	{
		// Token: 0x1700C81B RID: 51227
		// (get) Token: 0x0602F1C4 RID: 192964 RVA: 0x0066B36C File Offset: 0x0066956C
		// (set) Token: 0x0602F1C5 RID: 192965 RVA: 0x0066B374 File Offset: 0x00669574
		public int X { get; set; }

		// Token: 0x1700C81C RID: 51228
		// (get) Token: 0x0602F1C6 RID: 192966 RVA: 0x0066B37D File Offset: 0x0066957D
		// (set) Token: 0x0602F1C7 RID: 192967 RVA: 0x0066B385 File Offset: 0x00669585
		public int Y { get; set; }

		// Token: 0x0602F1C8 RID: 192968 RVA: 0x0066B38E File Offset: 0x0066958E
		public IInstrumentBoardSizeT()
		{
			this.X = 0;
			this.Y = 0;
		}
	}
}
