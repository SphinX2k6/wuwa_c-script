using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B1 RID: 26801
	public class IBvbDeployT
	{
		// Token: 0x1700C4FA RID: 50426
		// (get) Token: 0x0602DD45 RID: 187717 RVA: 0x00643599 File Offset: 0x00641799
		// (set) Token: 0x0602DD46 RID: 187718 RVA: 0x006435A1 File Offset: 0x006417A1
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C4FB RID: 50427
		// (get) Token: 0x0602DD47 RID: 187719 RVA: 0x006435AA File Offset: 0x006417AA
		// (set) Token: 0x0602DD48 RID: 187720 RVA: 0x006435B2 File Offset: 0x006417B2
		public int HandCardIndex { get; set; }

		// Token: 0x1700C4FC RID: 50428
		// (get) Token: 0x0602DD49 RID: 187721 RVA: 0x006435BB File Offset: 0x006417BB
		// (set) Token: 0x0602DD4A RID: 187722 RVA: 0x006435C3 File Offset: 0x006417C3
		public int BoardPosIndex { get; set; }

		// Token: 0x1700C4FD RID: 50429
		// (get) Token: 0x0602DD4B RID: 187723 RVA: 0x006435CC File Offset: 0x006417CC
		// (set) Token: 0x0602DD4C RID: 187724 RVA: 0x006435D4 File Offset: 0x006417D4
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700C4FE RID: 50430
		// (get) Token: 0x0602DD4D RID: 187725 RVA: 0x006435DD File Offset: 0x006417DD
		// (set) Token: 0x0602DD4E RID: 187726 RVA: 0x006435E5 File Offset: 0x006417E5
		public byte NullMask { get; set; }

		// Token: 0x0602DD4F RID: 187727 RVA: 0x006435EE File Offset: 0x006417EE
		public IBvbDeployT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.BoardPosIndex = 0;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
