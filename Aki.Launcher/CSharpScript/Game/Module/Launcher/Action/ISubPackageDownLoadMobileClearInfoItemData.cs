using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x0200002F RID: 47
	[NullableContext(2)]
	public interface ISubPackageDownLoadMobileClearInfoItemData : IHotFixLayoutData
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001B1 RID: 433
		// (set) Token: 0x060001B2 RID: 434
		ESubPackageDownLoadPackageType Type { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001B3 RID: 435
		// (set) Token: 0x060001B4 RID: 436
		int? SceneId { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001B5 RID: 437
		// (set) Token: 0x060001B6 RID: 438
		bool? HaveVideoCanClear { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001B7 RID: 439
		// (set) Token: 0x060001B8 RID: 440
		string VoiceLanguageCode { get; set; }
	}
}
