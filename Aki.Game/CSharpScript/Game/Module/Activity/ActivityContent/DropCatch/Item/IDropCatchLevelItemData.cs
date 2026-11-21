using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200562B RID: 22059
	public interface IDropCatchLevelItemData
	{
		// Token: 0x17006984 RID: 27012
		// (get) Token: 0x0603686E RID: 223342
		// (set) Token: 0x0603686F RID: 223343
		int CfgId { get; set; }

		// Token: 0x17006985 RID: 27013
		// (get) Token: 0x06036870 RID: 223344
		// (set) Token: 0x06036871 RID: 223345
		EDropCatchLevelState? State { get; set; }

		// Token: 0x17006986 RID: 27014
		// (get) Token: 0x06036872 RID: 223346
		// (set) Token: 0x06036873 RID: 223347
		bool HasRedPoint { get; set; }
	}
}
