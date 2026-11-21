using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001486 RID: 5254
public class BuffEquipItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D271 RID: 53873 RVA: 0x003E7090 File Offset: 0x003E5290
	public override bool IsMatch(int itemId)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		return itemConfigData != null && itemConfigData.Parameters.ContainsKey(5);
	}

	// Token: 0x0600D272 RID: 53874 RVA: 0x003E70BC File Offset: 0x003E52BC
	public override void OnUse(int itemId, int num)
	{
		BuffEquipItemUseLogic.<>c__DisplayClass1_0 CS$<>8__locals1 = new BuffEquipItemUseLogic.<>c__DisplayClass1_0();
		CS$<>8__locals1.itemId = itemId;
		BuffItemConfig instance = BuffItemConfig.Instance;
		BuffItemModel instance2 = BuffItemModel.Instance;
		if (instance.IsEquipBuffItem(CS$<>8__locals1.itemId) && !instance2.IsEquippedBuffItem(CS$<>8__locals1.itemId))
		{
			int buffEquipItemCategory = instance.GetBuffEquipItemCategory(CS$<>8__locals1.itemId);
			int? equippedBuffItemId = instance2.GetEquippedBuffItemId((EBuffItemEquipCategory)buffEquipItemCategory);
			if (equippedBuffItemId != null)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ReplaceBuffEquipItemConfirm);
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
				});
				confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<OnUse>g__confirmCallback|0));
				string name = InventoryConfig.Instance.GetItemConfig(equippedBuffItemId.Value).Value.Name;
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew(name, null)
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
		}
		InventoryController.Instance.RequestItemUse(CS$<>8__locals1.itemId, 1);
	}
}
