using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000BE RID: 190
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerLoading : ILoadModeHandler
{
	// Token: 0x060005DF RID: 1503 RVA: 0x0001F460 File Offset: 0x0001D660
	public void EnterMode(UObject worldContext)
	{
		FKuroPerfSightHelper.BeginExtTag("InLoadingMode");
		if (Info.Instance.IsPlayInEditor)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 5000", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 1000", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 200", null);
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 50", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 1000", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 40", null);
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority High", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(0);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(9999f);
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0001F4FA File Offset: 0x0001D6FA
	public void ExitMode(UObject worldContext)
	{
		FKuroPerfSightHelper.EndExtTag("InLoadingMode");
	}

	// Token: 0x040004C9 RID: 1225
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_Loading", "", "");
}
