using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F9 RID: 249
	[NullableContext(2)]
	[Nullable(0)]
	public class HotFixNetworkDetectionLayoutItemData : IHotFixNetworkDetectionLayoutItemData, IHotFixLayoutData
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0003F2CC File Offset: 0x0003D4CC
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0003F2D4 File Offset: 0x0003D4D4
		public int? Index { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0003F2DD File Offset: 0x0003D4DD
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0003F2E5 File Offset: 0x0003D4E5
		[Nullable(1)]
		public INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0003F2EE File Offset: 0x0003D4EE
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x0003F2F6 File Offset: 0x0003D4F6
		public INetworkDetectionResult Result { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x0003F2FF File Offset: 0x0003D4FF
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x0003F307 File Offset: 0x0003D507
		public bool Proceed { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0003F310 File Offset: 0x0003D510
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0003F318 File Offset: 0x0003D518
		public string ErrorCodeText { get; set; }
	}
}
