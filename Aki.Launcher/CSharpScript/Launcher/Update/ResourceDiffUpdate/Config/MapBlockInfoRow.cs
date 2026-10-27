using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B4 RID: 180
	[NullableContext(1)]
	[Nullable(0)]
	public class MapBlockInfoRow : TableBaseRow
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00036BA4 File Offset: 0x00034DA4
		public override object GetId()
		{
			return this.BlockId;
		}

		// Token: 0x040003BA RID: 954
		public int BlockId;

		// Token: 0x040003BB RID: 955
		public int MapId;

		// Token: 0x040003BC RID: 956
		public string PackName = "";

		// Token: 0x040003BD RID: 957
		public string BlockDatalayer = "";

		// Token: 0x040003BE RID: 958
		public string RegionName = "";

		// Token: 0x040003BF RID: 959
		public List<Vector2D> RegionBoxes = new List<Vector2D>();
	}
}
