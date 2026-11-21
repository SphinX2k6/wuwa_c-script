using System;

// Token: 0x0200148E RID: 5262
public class PowerItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D298 RID: 53912 RVA: 0x003E794E File Offset: 0x003E5B4E
	public override bool IsMatch(int itemId)
	{
		return itemId == 10800;
	}

	// Token: 0x0600D299 RID: 53913 RVA: 0x003E7958 File Offset: 0x003E5B58
	public override void OnUse(int itemId, int num)
	{
		PowerController.Instance.OpenPowerRecoveryExchangeView((EPowerRecoveryItem)itemId);
	}
}
