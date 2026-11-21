using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200148F RID: 5263
public class ShipTowerItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D29B RID: 53915 RVA: 0x003E796E File Offset: 0x003E5B6E
	public override bool CheckUseCondition(int itemId, int num)
	{
		return InventoryModel.Instance.GetCommonItemData(itemId, 0) != null;
	}

	// Token: 0x0600D29C RID: 53916 RVA: 0x003E797F File Offset: 0x003E5B7F
	public override void OnUse(int itemId, int num)
	{
		EventSystem.Instance.Emit(EEventName.OpenActivityViewShipTower);
	}
}
