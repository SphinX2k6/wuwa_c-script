using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x0200002E RID: 46
	[NullableContext(2)]
	[Nullable(0)]
	public class SubPackageDownLoadMobileClearData : ISubPackageDownLoadMobileClearData, IHotFixLayoutData
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000098CA File Offset: 0x00007ACA
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000098D2 File Offset: 0x00007AD2
		public int? Index { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000098DB File Offset: 0x00007ADB
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000098E3 File Offset: 0x00007AE3
		public int TitleId { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000098EC File Offset: 0x00007AEC
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000098F4 File Offset: 0x00007AF4
		public List<int> SceneIdList { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000098FD File Offset: 0x00007AFD
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00009905 File Offset: 0x00007B05
		public bool? HaveVideoCanClear { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000990E File Offset: 0x00007B0E
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00009916 File Offset: 0x00007B16
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> VoiceLanguageCodeList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
