using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000030 RID: 48
	[NullableContext(2)]
	[Nullable(0)]
	public class SubPackageDownLoadMobileClearInfoItemData : ISubPackageDownLoadMobileClearInfoItemData, IHotFixLayoutData
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000098EF File Offset: 0x00007AEF
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000098F7 File Offset: 0x00007AF7
		public int? Index { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00009900 File Offset: 0x00007B00
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00009908 File Offset: 0x00007B08
		public ESubPackageDownLoadPackageType Type { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00009911 File Offset: 0x00007B11
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00009919 File Offset: 0x00007B19
		public int? SceneId { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00009922 File Offset: 0x00007B22
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000992A File Offset: 0x00007B2A
		public bool? HaveVideoCanClear { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00009933 File Offset: 0x00007B33
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000993B File Offset: 0x00007B3B
		public string VoiceLanguageCode { get; set; }
	}
}
