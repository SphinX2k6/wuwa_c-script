using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F5 RID: 245
	[NullableContext(2)]
	[Nullable(0)]
	public class HotFixNetworkDetectionLayoutItemData : IHotFixNetworkDetectionLayoutItemData, IHotFixLayoutData
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0003CF2C File Offset: 0x0003B12C
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0003CF34 File Offset: 0x0003B134
		public int? Index { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0003CF3D File Offset: 0x0003B13D
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x0003CF45 File Offset: 0x0003B145
		[Nullable(1)]
		public INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0003CF4E File Offset: 0x0003B14E
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0003CF56 File Offset: 0x0003B156
		public INetworkDetectionResult Result { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0003CF5F File Offset: 0x0003B15F
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x0003CF67 File Offset: 0x0003B167
		public bool Proceed { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0003CF70 File Offset: 0x0003B170
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0003CF78 File Offset: 0x0003B178
		public string ErrorCodeText { get; set; }
	}
}
