using System;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014D RID: 333
	public interface IGraphRuntimeEdge
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000B9B RID: 2971
		// (set) Token: 0x06000B9C RID: 2972
		int Id { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000B9D RID: 2973
		// (set) Token: 0x06000B9E RID: 2974
		int From { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000B9F RID: 2975
		// (set) Token: 0x06000BA0 RID: 2976
		int To { get; set; }
	}
}
