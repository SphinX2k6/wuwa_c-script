using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A9 RID: 17833
	public class IRollBlockPathNodeT
	{
		// Token: 0x17007EC0 RID: 32448
		// (get) Token: 0x0601AF5F RID: 110431 RVA: 0x003D8730 File Offset: 0x003D6930
		// (set) Token: 0x0601AF60 RID: 110432 RVA: 0x003D8738 File Offset: 0x003D6938
		public int X { get; set; }

		// Token: 0x17007EC1 RID: 32449
		// (get) Token: 0x0601AF61 RID: 110433 RVA: 0x003D8741 File Offset: 0x003D6941
		// (set) Token: 0x0601AF62 RID: 110434 RVA: 0x003D8749 File Offset: 0x003D6949
		public int Y { get; set; }

		// Token: 0x0601AF63 RID: 110435 RVA: 0x003D8752 File Offset: 0x003D6952
		public IRollBlockPathNodeT()
		{
			this.X = 0;
			this.Y = 0;
		}
	}
}
