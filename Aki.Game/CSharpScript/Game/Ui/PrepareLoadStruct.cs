using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046CB RID: 18123
	[NullableContext(1)]
	[Nullable(0)]
	public class PrepareLoadStruct : IPrepareLoadStruct
	{
		// Token: 0x17007673 RID: 30323
		// (get) Token: 0x0602EBB9 RID: 191417 RVA: 0x00AD0CD9 File Offset: 0x00ACEED9
		// (set) Token: 0x0602EBBA RID: 191418 RVA: 0x00AD0CE1 File Offset: 0x00ACEEE1
		public string ResourceId { get; set; } = "";

		// Token: 0x17007674 RID: 30324
		// (get) Token: 0x0602EBBB RID: 191419 RVA: 0x00AD0CEA File Offset: 0x00ACEEEA
		// (set) Token: 0x0602EBBC RID: 191420 RVA: 0x00AD0CF2 File Offset: 0x00ACEEF2
		public Func<int> CacheCount { get; set; } = () => 0;
	}
}
