using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B7 RID: 183
	[NullableContext(1)]
	[Nullable(0)]
	public class MapBlockInfoRow : TableBaseRow
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x000386A4 File Offset: 0x000368A4
		public override object GetId()
		{
			return this.BlockId;
		}

		// Token: 0x040003E9 RID: 1001
		public int BlockId;

		// Token: 0x040003EA RID: 1002
		public int MapId;

		// Token: 0x040003EB RID: 1003
		public string PackName = "";

		// Token: 0x040003EC RID: 1004
		public string BlockDatalayer = "";

		// Token: 0x040003ED RID: 1005
		public string RegionName = "";

		// Token: 0x040003EE RID: 1006
		public List<Vector2D> RegionBoxes = new List<Vector2D>();
	}
}
