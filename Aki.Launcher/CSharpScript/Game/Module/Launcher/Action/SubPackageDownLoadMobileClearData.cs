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
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009892 File Offset: 0x00007A92
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000989A File Offset: 0x00007A9A
		public int? Index { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000098A3 File Offset: 0x00007AA3
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000098AB File Offset: 0x00007AAB
		public int TitleId { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000098B4 File Offset: 0x00007AB4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000098BC File Offset: 0x00007ABC
		public List<int> SceneIdList { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000098C5 File Offset: 0x00007AC5
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000098CD File Offset: 0x00007ACD
		public bool? HaveVideoCanClear { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000098D6 File Offset: 0x00007AD6
		// (set) Token: 0x060001AF RID: 431 RVA: 0x000098DE File Offset: 0x00007ADE
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
