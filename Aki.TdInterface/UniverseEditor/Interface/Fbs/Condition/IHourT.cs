using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005131 RID: 20785
	public class IHourT
	{
		// Token: 0x170094F5 RID: 38133
		// (get) Token: 0x06020B01 RID: 133889 RVA: 0x0048785C File Offset: 0x00485A5C
		// (set) Token: 0x06020B02 RID: 133890 RVA: 0x00487864 File Offset: 0x00485A64
		public int Hour { get; set; }

		// Token: 0x170094F6 RID: 38134
		// (get) Token: 0x06020B03 RID: 133891 RVA: 0x0048786D File Offset: 0x00485A6D
		// (set) Token: 0x06020B04 RID: 133892 RVA: 0x00487875 File Offset: 0x00485A75
		public int Min { get; set; }

		// Token: 0x06020B05 RID: 133893 RVA: 0x0048787E File Offset: 0x00485A7E
		public IHourT()
		{
			this.Hour = 0;
			this.Min = 0;
		}
	}
}
