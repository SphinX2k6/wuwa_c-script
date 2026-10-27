using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DB RID: 219
	[EnumExtensions]
	public enum ERestartTipType
	{
		// Token: 0x04000433 RID: 1075
		[EnumStringMember("HotFixRestartToCompleteHotFix")]
		HotFixComplete,
		// Token: 0x04000434 RID: 1076
		[EnumStringMember("HotFixRestartToRepairFiles")]
		RepairFilesComplete,
		// Token: 0x04000435 RID: 1077
		[EnumStringMember("HotFixRestartToCompleteHotFixWin")]
		HotFixCompleteWin,
		// Token: 0x04000436 RID: 1078
		[EnumStringMember("HotFixRestartToRepairFilesWin")]
		RepairFilesCompleteWin
	}
}
