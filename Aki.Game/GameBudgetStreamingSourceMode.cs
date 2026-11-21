using System;
using UnrealEngine;

// Token: 0x0200116F RID: 4463
public class GameBudgetStreamingSourceMode : GameBudgetMode
{
	// Token: 0x0600B1C1 RID: 45505 RVA: 0x00348EF8 File Offset: 0x003470F8
	public GameBudgetStreamingSourceMode() : base("EGameBudgetMode.StreamingSource", EGameBudgetMode.StreamingSource)
	{
		base.Active("disableAssistantCenterActor", delegate
		{
			UKuroGameBudgetAllocatorCSharpInterface.SetDisableAssistantCenterActor(true);
		}, delegate
		{
			UKuroGameBudgetAllocatorCSharpInterface.SetDisableAssistantCenterActor(false);
		});
		base.Active("centerRole", delegate
		{
			GameBudgetInterfaceController.Instance.SetCenterRole(GameModeModel.Instance.StreamingSource);
		}, delegate
		{
		});
	}

	// Token: 0x17001228 RID: 4648
	// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x00348FA3 File Offset: 0x003471A3
	public override bool AllowExternalCenter
	{
		get
		{
			return false;
		}
	}
}
