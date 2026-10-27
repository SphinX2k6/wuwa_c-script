using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x0200002D RID: 45
	[NullableContext(2)]
	public interface ISubPackageDownLoadMobileClearData : IHotFixLayoutData
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		int TitleId { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001A0 RID: 416
		// (set) Token: 0x060001A1 RID: 417
		List<int> SceneIdList { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		bool? HaveVideoCanClear { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<string> VoiceLanguageCodeList { [return: Nullable(new byte[]
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
