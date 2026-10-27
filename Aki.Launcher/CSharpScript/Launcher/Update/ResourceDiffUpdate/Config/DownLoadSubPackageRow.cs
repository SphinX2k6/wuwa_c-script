using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B0 RID: 176
	[NullableContext(1)]
	[Nullable(0)]
	public class DownLoadSubPackageRow : TableBaseRow
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x000368B0 File Offset: 0x00034AB0
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x040003AE RID: 942
		public int Id;

		// Token: 0x040003AF RID: 943
		public int Version;

		// Token: 0x040003B0 RID: 944
		public int Type;

		// Token: 0x040003B1 RID: 945
		public int BelongBranch = 1;

		// Token: 0x040003B2 RID: 946
		public List<int> Area = new List<int>();

		// Token: 0x040003B3 RID: 947
		public bool BelongKey;

		// Token: 0x040003B4 RID: 948
		public string Title = "";
	}
}
