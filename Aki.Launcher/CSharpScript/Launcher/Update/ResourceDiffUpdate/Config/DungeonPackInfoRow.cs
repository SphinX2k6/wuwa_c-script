using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B5 RID: 181
	[NullableContext(1)]
	[Nullable(0)]
	public class DungeonPackInfoRow : TableBaseRow
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x0003850D File Offset: 0x0003670D
		public override object GetId()
		{
			return this.DungeonId;
		}

		// Token: 0x040003E4 RID: 996
		public int DungeonId;

		// Token: 0x040003E5 RID: 997
		public string Umap = "";

		// Token: 0x040003E6 RID: 998
		public List<int> OwnerBlockIds = new List<int>();

		// Token: 0x040003E7 RID: 999
		public string BlockPakName = "";

		// Token: 0x040003E8 RID: 1000
		public List<int> ReachableBlockIds = new List<int>();
	}
}
