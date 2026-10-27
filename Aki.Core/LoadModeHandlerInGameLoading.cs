using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000BD RID: 189
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerInGameLoading : ILoadModeHandler
{
	// Token: 0x060005DC RID: 1500 RVA: 0x0001F398 File Offset: 0x0001D598
	public void EnterMode(UObject worldContext)
	{
		FKuroPerfSightHelper.BeginExtTag("InGameLoadingMode");
		if (Info.Instance.IsPlayInEditor)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 40", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 40", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 8", null);
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 10", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 10", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 8", null);
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority Normal", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(5);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(3f);
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0001F432 File Offset: 0x0001D632
	public void ExitMode(UObject worldContext)
	{
		FKuroPerfSightHelper.EndExtTag("InGameLoadingMode");
	}

	// Token: 0x040004C8 RID: 1224
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_InGameLoading", "", "");
}
