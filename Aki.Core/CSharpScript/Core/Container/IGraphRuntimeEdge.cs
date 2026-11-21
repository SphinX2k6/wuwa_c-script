using System;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000151 RID: 337
	public interface IGraphRuntimeEdge
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000BF7 RID: 3063
		// (set) Token: 0x06000BF8 RID: 3064
		int Id { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000BF9 RID: 3065
		// (set) Token: 0x06000BFA RID: 3066
		int From { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000BFB RID: 3067
		// (set) Token: 0x06000BFC RID: 3068
		int To { get; set; }
	}
}
