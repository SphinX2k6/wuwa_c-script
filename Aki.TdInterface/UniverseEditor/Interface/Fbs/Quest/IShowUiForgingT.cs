using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200456C RID: 17772
	public class IShowUiForgingT
	{
		// Token: 0x17007C35 RID: 31797
		// (get) Token: 0x06019DF1 RID: 105969 RVA: 0x003B0E50 File Offset: 0x003AF050
		// (set) Token: 0x06019DF2 RID: 105970 RVA: 0x003B0E58 File Offset: 0x003AF058
		public EShowUiType Type { get; set; }

		// Token: 0x17007C36 RID: 31798
		// (get) Token: 0x06019DF3 RID: 105971 RVA: 0x003B0E61 File Offset: 0x003AF061
		// (set) Token: 0x06019DF4 RID: 105972 RVA: 0x003B0E69 File Offset: 0x003AF069
		public List<int> EntityIds { get; set; }

		// Token: 0x17007C37 RID: 31799
		// (get) Token: 0x06019DF5 RID: 105973 RVA: 0x003B0E72 File Offset: 0x003AF072
		// (set) Token: 0x06019DF6 RID: 105974 RVA: 0x003B0E7A File Offset: 0x003AF07A
		public List<int> ProductIds { get; set; }

		// Token: 0x17007C38 RID: 31800
		// (get) Token: 0x06019DF7 RID: 105975 RVA: 0x003B0E83 File Offset: 0x003AF083
		// (set) Token: 0x06019DF8 RID: 105976 RVA: 0x003B0E8B File Offset: 0x003AF08B
		public byte NullMask { get; set; }

		// Token: 0x06019DF9 RID: 105977 RVA: 0x003B0E94 File Offset: 0x003AF094
		public IShowUiForgingT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
