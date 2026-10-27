using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3E RID: 23102
	public class ITeleControlBaseCfgT
	{
		// Token: 0x1700ADD0 RID: 44496
		// (get) Token: 0x06027498 RID: 160920 RVA: 0x005681DF File Offset: 0x005663DF
		// (set) Token: 0x06027499 RID: 160921 RVA: 0x005681E7 File Offset: 0x005663E7
		public string CommonConfig { get; set; }

		// Token: 0x1700ADD1 RID: 44497
		// (get) Token: 0x0602749A RID: 160922 RVA: 0x005681F0 File Offset: 0x005663F0
		// (set) Token: 0x0602749B RID: 160923 RVA: 0x005681F8 File Offset: 0x005663F8
		public bool CanRotate { get; set; }

		// Token: 0x1700ADD2 RID: 44498
		// (get) Token: 0x0602749C RID: 160924 RVA: 0x00568201 File Offset: 0x00566401
		// (set) Token: 0x0602749D RID: 160925 RVA: 0x00568209 File Offset: 0x00566409
		public bool InitialGravity { get; set; }

		// Token: 0x1700ADD3 RID: 44499
		// (get) Token: 0x0602749E RID: 160926 RVA: 0x00568212 File Offset: 0x00566412
		// (set) Token: 0x0602749F RID: 160927 RVA: 0x0056821A File Offset: 0x0056641A
		public byte NullMask { get; set; }

		// Token: 0x060274A0 RID: 160928 RVA: 0x00568223 File Offset: 0x00566423
		public ITeleControlBaseCfgT()
		{
			this.CommonConfig = null;
			this.CanRotate = false;
			this.InitialGravity = false;
			this.NullMask = 0;
		}
	}
}
