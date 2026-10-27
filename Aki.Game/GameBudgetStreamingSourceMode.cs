using System;
using UnrealEngine;

// Token: 0x02001CAD RID: 7341
public class GameBudgetStreamingSourceMode : GameBudgetMode
{
	// Token: 0x0600DD9F RID: 56735 RVA: 0x0033D52C File Offset: 0x0033B72C
	public GameBudgetStreamingSourceMode() : base("EGameBudgetMode.StreamingSource", EGameBudgetMode.StreamingSource)
	{
	}

	// Token: 0x0600DDA0 RID: 56736 RVA: 0x0033D53A File Offset: 0x0033B73A
	public override void OnEnterMode()
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetDisableAssistantCenterActor(true);
		GameBudgetInterfaceController.Instance.SetCenterRole(GameModeModel.Instance.StreamingSource);
	}

	// Token: 0x0600DDA1 RID: 56737 RVA: 0x0033D556 File Offset: 0x0033B756
	public override void OnExitMode()
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetDisableAssistantCenterActor(false);
	}

	// Token: 0x0600DDA2 RID: 56738 RVA: 0x0033D55E File Offset: 0x0033B75E
	public override bool AllowSwitchMode()
	{
		return false;
	}

	// Token: 0x0600DDA3 RID: 56739 RVA: 0x0033D561 File Offset: 0x0033B761
	public override bool AllowSetCenterActor()
	{
		return false;
	}

	// Token: 0x0600DDA4 RID: 56740 RVA: 0x0033D564 File Offset: 0x0033B764
	public override bool AllowSetCenterOffset()
	{
		return false;
	}

	// Token: 0x0600DDA5 RID: 56741 RVA: 0x0033D567 File Offset: 0x0033B767
	public override bool AllowAddAssistantActor()
	{
		return false;
	}
}
