using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000BE RID: 190
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerInGame : ILoadModeHandler
{
	// Token: 0x0600061A RID: 1562 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
	public void EnterMode(UObject worldContext)
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 5", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 5", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 4", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority Normal", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(5);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(3f);
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0001F936 File Offset: 0x0001DB36
	public void ExitMode(UObject worldContext)
	{
	}

	// Token: 0x040004D5 RID: 1237
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_InGame", "", "");
}
