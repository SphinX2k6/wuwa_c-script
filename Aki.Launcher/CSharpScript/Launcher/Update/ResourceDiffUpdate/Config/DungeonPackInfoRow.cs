using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(1)]
	[Nullable(0)]
	public class DungeonPackInfoRow : TableBaseRow
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00036A0D File Offset: 0x00034C0D
		public override object GetId()
		{
			return this.DungeonId;
		}

		// Token: 0x040003B5 RID: 949
		public int DungeonId;

		// Token: 0x040003B6 RID: 950
		public string Umap = "";

		// Token: 0x040003B7 RID: 951
		public List<int> OwnerBlockIds = new List<int>();

		// Token: 0x040003B8 RID: 952
		public string BlockPakName = "";

		// Token: 0x040003B9 RID: 953
		public List<int> ReachableBlockIds = new List<int>();
	}
}
