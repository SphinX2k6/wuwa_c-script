using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701A RID: 28698
	public class IInstrumentBoardSizeT
	{
		// Token: 0x1700D21E RID: 53790
		// (get) Token: 0x06031B94 RID: 203668 RVA: 0x006BB854 File Offset: 0x006B9A54
		// (set) Token: 0x06031B95 RID: 203669 RVA: 0x006BB85C File Offset: 0x006B9A5C
		public int X { get; set; }

		// Token: 0x1700D21F RID: 53791
		// (get) Token: 0x06031B96 RID: 203670 RVA: 0x006BB865 File Offset: 0x006B9A65
		// (set) Token: 0x06031B97 RID: 203671 RVA: 0x006BB86D File Offset: 0x006B9A6D
		public int Y { get; set; }

		// Token: 0x06031B98 RID: 203672 RVA: 0x006BB876 File Offset: 0x006B9A76
		public IInstrumentBoardSizeT()
		{
			this.X = 0;
			this.Y = 0;
		}
	}
}
