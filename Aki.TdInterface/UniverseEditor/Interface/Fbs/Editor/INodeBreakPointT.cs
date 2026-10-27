using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200488D RID: 18573
	public class INodeBreakPointT
	{
		// Token: 0x170086B5 RID: 34485
		// (get) Token: 0x0601CFAE RID: 118702 RVA: 0x00418532 File Offset: 0x00416732
		// (set) Token: 0x0601CFAF RID: 118703 RVA: 0x0041853A File Offset: 0x0041673A
		public bool Before { get; set; }

		// Token: 0x170086B6 RID: 34486
		// (get) Token: 0x0601CFB0 RID: 118704 RVA: 0x00418543 File Offset: 0x00416743
		// (set) Token: 0x0601CFB1 RID: 118705 RVA: 0x0041854B File Offset: 0x0041674B
		public bool After { get; set; }

		// Token: 0x170086B7 RID: 34487
		// (get) Token: 0x0601CFB2 RID: 118706 RVA: 0x00418554 File Offset: 0x00416754
		// (set) Token: 0x0601CFB3 RID: 118707 RVA: 0x0041855C File Offset: 0x0041675C
		public byte NullMask { get; set; }

		// Token: 0x0601CFB4 RID: 118708 RVA: 0x00418565 File Offset: 0x00416765
		public INodeBreakPointT()
		{
			this.Before = false;
			this.After = false;
			this.NullMask = 0;
		}
	}
}
