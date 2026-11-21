using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005134 RID: 20788
	public class IHourToHourT
	{
		// Token: 0x170094FA RID: 38138
		// (get) Token: 0x06020B17 RID: 133911 RVA: 0x00487B2E File Offset: 0x00485D2E
		// (set) Token: 0x06020B18 RID: 133912 RVA: 0x00487B36 File Offset: 0x00485D36
		public IHourT Start { get; set; }

		// Token: 0x170094FB RID: 38139
		// (get) Token: 0x06020B19 RID: 133913 RVA: 0x00487B3F File Offset: 0x00485D3F
		// (set) Token: 0x06020B1A RID: 133914 RVA: 0x00487B47 File Offset: 0x00485D47
		public IHourT End { get; set; }

		// Token: 0x06020B1B RID: 133915 RVA: 0x00487B50 File Offset: 0x00485D50
		public IHourToHourT()
		{
			this.Start = null;
			this.End = null;
		}
	}
}
