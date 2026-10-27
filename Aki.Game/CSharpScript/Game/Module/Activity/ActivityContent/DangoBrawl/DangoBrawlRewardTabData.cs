using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067B8 RID: 26552
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRewardTabData
	{
		// Token: 0x0604223F RID: 270911 RVA: 0x0100A5D7 File Offset: 0x010087D7
		public DangoBrawlRewardTabData(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x0402287F RID: 141439
		public int Id;

		// Token: 0x04022880 RID: 141440
		public string Name = "";

		// Token: 0x04022881 RID: 141441
		public bool CanReceive;
	}
}
