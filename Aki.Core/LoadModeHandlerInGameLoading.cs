using System;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000BF RID: 191
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerInGameLoading : ILoadModeHandler
{
	// Token: 0x0600061D RID: 1565 RVA: 0x0001F95C File Offset: 0x0001DB5C
	public void EnterMode(UObject worldContext)
	{
		FKuroPerfSightHelper.BeginExtTag("InGameLoadingMode");
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 10", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 10", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 8", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority Normal", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(5);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(3f);
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x0001F9C4 File Offset: 0x0001DBC4
	public void ExitMode(UObject worldContext)
	{
		FKuroPerfSightHelper.EndExtTag("InGameLoadingMode");
	}

	// Token: 0x040004D6 RID: 1238
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_InGameLoading", "", "");
}
