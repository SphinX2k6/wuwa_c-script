using System;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000C0 RID: 192
[NullableContext(1)]
[Nullable(0)]
public class LoadModeHandlerLoading : ILoadModeHandler
{
	// Token: 0x06000620 RID: 1568 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
	public void EnterMode(UObject worldContext)
	{
		FKuroPerfSightHelper.BeginExtTag("InLoadingMode");
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.AsyncLoadingTimeLimit 50", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "s.LevelStreamingActorsUpdateTimeLimit 1000", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.MaxLoadingStreamingCells 40", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.BlockOnSlowStreaming 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(worldContext, "wp.Runtime.StreamingPortalPriority High", null);
		ResourceSystem.Instance.SetCallbackTimeLimit(0);
		GameBudgetInterfaceController.UpdateMinUpdateFifoBudgetTime(9999f);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x0001FA5C File Offset: 0x0001DC5C
	public void ExitMode(UObject worldContext)
	{
		FKuroPerfSightHelper.EndExtTag("InLoadingMode");
	}

	// Token: 0x040004D7 RID: 1239
	public Stat StatEnterMode = Stat.Create("LoadModeHandler_Enter_Loading", "", "");
}
