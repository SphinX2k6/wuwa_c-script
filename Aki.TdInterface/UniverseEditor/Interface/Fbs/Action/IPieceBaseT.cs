using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007443 RID: 29763
	public class IPieceBaseT
	{
		// Token: 0x1700DA9D RID: 55965
		// (get) Token: 0x06034152 RID: 213330 RVA: 0x0070498B File Offset: 0x00702B8B
		// (set) Token: 0x06034153 RID: 213331 RVA: 0x00704993 File Offset: 0x00702B93
		public IPieceIndexT Index { get; set; }

		// Token: 0x1700DA9E RID: 55966
		// (get) Token: 0x06034154 RID: 213332 RVA: 0x0070499C File Offset: 0x00702B9C
		// (set) Token: 0x06034155 RID: 213333 RVA: 0x007049A4 File Offset: 0x00702BA4
		public bool Active { get; set; }

		// Token: 0x06034156 RID: 213334 RVA: 0x007049AD File Offset: 0x00702BAD
		public IPieceBaseT()
		{
			this.Index = null;
			this.Active = false;
		}
	}
}
