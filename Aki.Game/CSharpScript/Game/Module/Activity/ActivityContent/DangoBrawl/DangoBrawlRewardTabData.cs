using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005708 RID: 22280
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRewardTabData
	{
		// Token: 0x06036D95 RID: 224661 RVA: 0x00F4B9BB File Offset: 0x00F49BBB
		public DangoBrawlRewardTabData(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x0401D0DC RID: 119004
		public int Id;

		// Token: 0x0401D0DD RID: 119005
		public string Name = "";

		// Token: 0x0401D0DE RID: 119006
		public bool CanReceive;
	}
}
