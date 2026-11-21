using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549A RID: 21658
	public class ICategoryMatchingFoundationT
	{
		// Token: 0x17009A48 RID: 39496
		// (get) Token: 0x06022155 RID: 139605 RVA: 0x004B2DD7 File Offset: 0x004B0FD7
		// (set) Token: 0x06022156 RID: 139606 RVA: 0x004B2DDF File Offset: 0x004B0FDF
		public EItemFoundation Type { get; set; }

		// Token: 0x17009A49 RID: 39497
		// (get) Token: 0x06022157 RID: 139607 RVA: 0x004B2DE8 File Offset: 0x004B0FE8
		// (set) Token: 0x06022158 RID: 139608 RVA: 0x004B2DF0 File Offset: 0x004B0FF0
		public int InitMatchEntity { get; set; }

		// Token: 0x17009A4A RID: 39498
		// (get) Token: 0x06022159 RID: 139609 RVA: 0x004B2DF9 File Offset: 0x004B0FF9
		// (set) Token: 0x0602215A RID: 139610 RVA: 0x004B2E01 File Offset: 0x004B1001
		public List<ICategoryMatchingConfigT> MatchingConfigs { get; set; }

		// Token: 0x17009A4B RID: 39499
		// (get) Token: 0x0602215B RID: 139611 RVA: 0x004B2E0A File Offset: 0x004B100A
		// (set) Token: 0x0602215C RID: 139612 RVA: 0x004B2E12 File Offset: 0x004B1012
		public byte NullMask { get; set; }

		// Token: 0x0602215D RID: 139613 RVA: 0x004B2E1B File Offset: 0x004B101B
		public ICategoryMatchingFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
			this.InitMatchEntity = 0;
			this.MatchingConfigs = null;
			this.NullMask = 0;
		}
	}
}
