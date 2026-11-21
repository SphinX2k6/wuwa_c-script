using System;

// Token: 0x02001483 RID: 5251
public class BattlePassItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D268 RID: 53864 RVA: 0x003E6F66 File Offset: 0x003E5166
	public override bool IsMatch(int itemId)
	{
		return itemId == BattlePassModel.Instance.PrimaryItemId || itemId == BattlePassModel.Instance.AdvanceItemId;
	}

	// Token: 0x0600D269 RID: 53865 RVA: 0x003E6F84 File Offset: 0x003E5184
	public override void OnUse(int itemId, int num)
	{
		BattlePassItemUseLogic.<>c__DisplayClass1_0 CS$<>8__locals1 = new BattlePassItemUseLogic.<>c__DisplayClass1_0();
		CS$<>8__locals1.itemId = itemId;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(BattlePassModel.Instance.GetBattlePassItemConfirmId(CS$<>8__locals1.itemId));
		confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<OnUse>g__confirmCallback|0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}
}
