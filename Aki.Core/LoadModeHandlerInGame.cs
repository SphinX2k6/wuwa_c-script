using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020000BC RID: 188
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerInGame : ILoadModeHandler
{
	// Token: 0x060005D9 RID: 1497 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
	public void EnterMode(UObject worldContext)
	{
		if (Info.Instance.IsPlayInEditor)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 20", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 20", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 4", null);
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 5", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 5", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 4", null);
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority Normal", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(5);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(3f);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0001F374 File Offset: 0x0001D574
	public void ExitMode(UObject worldContext)
	{
	}

	// Token: 0x040004C7 RID: 1223
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_InGame", "", "");
}
