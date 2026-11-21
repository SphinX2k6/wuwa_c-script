using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DE RID: 222
	[EnumExtensions]
	public enum ERestartTipType
	{
		// Token: 0x04000462 RID: 1122
		[EnumStringMember("HotFixRestartToCompleteHotFix")]
		HotFixComplete,
		// Token: 0x04000463 RID: 1123
		[EnumStringMember("HotFixRestartToRepairFiles")]
		RepairFilesComplete,
		// Token: 0x04000464 RID: 1124
		[EnumStringMember("HotFixRestartToCompleteHotFixWin")]
		HotFixCompleteWin,
		// Token: 0x04000465 RID: 1125
		[EnumStringMember("HotFixRestartToRepairFilesWin")]
		RepairFilesCompleteWin
	}
}
