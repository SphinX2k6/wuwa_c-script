using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D2 RID: 26578
	public class IFixedTimeT
	{
		// Token: 0x1700C551 RID: 50513
		// (get) Token: 0x0602E457 RID: 189527 RVA: 0x00651910 File Offset: 0x0064FB10
		// (set) Token: 0x0602E458 RID: 189528 RVA: 0x00651918 File Offset: 0x0064FB18
		public int Hour { get; set; }

		// Token: 0x1700C552 RID: 50514
		// (get) Token: 0x0602E459 RID: 189529 RVA: 0x00651921 File Offset: 0x0064FB21
		// (set) Token: 0x0602E45A RID: 189530 RVA: 0x00651929 File Offset: 0x0064FB29
		public int Minutes { get; set; }

		// Token: 0x0602E45B RID: 189531 RVA: 0x00651932 File Offset: 0x0064FB32
		public IFixedTimeT()
		{
			this.Hour = 0;
			this.Minutes = 0;
		}
	}
}
