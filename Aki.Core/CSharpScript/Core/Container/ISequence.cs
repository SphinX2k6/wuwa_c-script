using System;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015D RID: 349
	public interface ISequence
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000BFE RID: 3070
		// (set) Token: 0x06000BFF RID: 3071
		int Node { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C00 RID: 3072
		// (set) Token: 0x06000C01 RID: 3073
		int? ArrivedByEdgeId { get; set; }
	}
}
