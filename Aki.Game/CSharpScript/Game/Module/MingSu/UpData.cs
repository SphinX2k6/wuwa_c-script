using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053D3 RID: 21459
	[NullableContext(1)]
	[Nullable(0)]
	public class UpData : IUpData
	{
		// Token: 0x170083C8 RID: 33736
		// (get) Token: 0x06036D61 RID: 224609 RVA: 0x00CFCA45 File Offset: 0x00CFAC45
		// (set) Token: 0x06036D62 RID: 224610 RVA: 0x00CFCA4D File Offset: 0x00CFAC4D
		public int UseCoreCount { get; set; }

		// Token: 0x170083C9 RID: 33737
		// (get) Token: 0x06036D63 RID: 224611 RVA: 0x00CFCA56 File Offset: 0x00CFAC56
		// (set) Token: 0x06036D64 RID: 224612 RVA: 0x00CFCA5E File Offset: 0x00CFAC5E
		public string CoreName { get; set; } = "";
	}
}
