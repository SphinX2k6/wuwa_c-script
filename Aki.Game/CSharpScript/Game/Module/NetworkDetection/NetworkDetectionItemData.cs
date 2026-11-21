using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02004342 RID: 17218
	[NullableContext(2)]
	[Nullable(0)]
	public class NetworkDetectionItemData : INetworkDetectionItemData
	{
		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x0602B7AE RID: 178094 RVA: 0x00C3810C File Offset: 0x00C3630C
		// (set) Token: 0x0602B7AF RID: 178095 RVA: 0x00C38114 File Offset: 0x00C36314
		[Nullable(1)]
		public INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x0602B7B0 RID: 178096 RVA: 0x00C3811D File Offset: 0x00C3631D
		// (set) Token: 0x0602B7B1 RID: 178097 RVA: 0x00C38125 File Offset: 0x00C36325
		public INetworkDetectionResult Result { get; set; }

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x0602B7B2 RID: 178098 RVA: 0x00C3812E File Offset: 0x00C3632E
		// (set) Token: 0x0602B7B3 RID: 178099 RVA: 0x00C38136 File Offset: 0x00C36336
		public bool Proceed { get; set; }

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x0602B7B4 RID: 178100 RVA: 0x00C3813F File Offset: 0x00C3633F
		// (set) Token: 0x0602B7B5 RID: 178101 RVA: 0x00C38147 File Offset: 0x00C36347
		public string ErrorCodeText { get; set; }
	}
}
