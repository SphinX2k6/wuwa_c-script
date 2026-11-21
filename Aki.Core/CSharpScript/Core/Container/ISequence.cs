using System;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000162 RID: 354
	public interface ISequence
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000C5D RID: 3165
		// (set) Token: 0x06000C5E RID: 3166
		int Node { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000C5F RID: 3167
		// (set) Token: 0x06000C60 RID: 3168
		int? ArrivedByEdgeId { get; set; }
	}
}
