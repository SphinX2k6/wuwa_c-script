using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x0200724E RID: 29262
	[NullableContext(1)]
	public interface ITalkItem
	{
		// Token: 0x17009E61 RID: 40545
		// (get) Token: 0x06047BA6 RID: 293798
		// (set) Token: 0x06047BA7 RID: 293799
		int Id { get; set; }

		// Token: 0x17009E62 RID: 40546
		// (get) Token: 0x06047BA8 RID: 293800
		// (set) Token: 0x06047BA9 RID: 293801
		string Name { get; set; }

		// Token: 0x17009E63 RID: 40547
		// (get) Token: 0x06047BAA RID: 293802
		// (set) Token: 0x06047BAB RID: 293803
		int WhoId { get; set; }

		// Token: 0x17009E64 RID: 40548
		// (get) Token: 0x06047BAC RID: 293804
		// (set) Token: 0x06047BAD RID: 293805
		int TextId { get; set; }

		// Token: 0x17009E65 RID: 40549
		// (get) Token: 0x06047BAE RID: 293806
		// (set) Token: 0x06047BAF RID: 293807
		double? WaitTime { get; set; }

		// Token: 0x17009E66 RID: 40550
		// (get) Token: 0x06047BB0 RID: 293808
		// (set) Token: 0x06047BB1 RID: 293809
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IActionInfo[] Actions { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17009E67 RID: 40551
		// (get) Token: 0x06047BB2 RID: 293810
		// (set) Token: 0x06047BB3 RID: 293811
		[Nullable(new byte[]
		{
			2,
			1
		})]
		ITalkOption[] Options { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
