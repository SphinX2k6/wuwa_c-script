using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B3 RID: 179
	[NullableContext(1)]
	[Nullable(0)]
	public class DownLoadSubPackageRow : TableBaseRow
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x000383AF File Offset: 0x000365AF
		public override object GetId()
		{
			return this.Id;
		}

		// Token: 0x040003DC RID: 988
		public int Id;

		// Token: 0x040003DD RID: 989
		public int Version;

		// Token: 0x040003DE RID: 990
		public int SortId;

		// Token: 0x040003DF RID: 991
		public int Type;

		// Token: 0x040003E0 RID: 992
		public int BelongBranch = 1;

		// Token: 0x040003E1 RID: 993
		public List<int> Area = new List<int>();

		// Token: 0x040003E2 RID: 994
		public bool BelongKey;

		// Token: 0x040003E3 RID: 995
		public string Title = "";
	}
}
