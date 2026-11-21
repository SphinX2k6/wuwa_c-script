using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000CCE RID: 3278
[NullableContext(1)]
[Nullable(0)]
public class ConsumeItemUtil
{
	// Token: 0x060088AA RID: 34986 RVA: 0x00297164 File Offset: 0x00295364
	[return: Nullable(2)]
	public static ConsumeItemData GetConsumeItemData(InventoryDefine.IGetItemData getItemData, int count)
	{
		ItemDataBase itemDataBase = InventoryModel.Instance.GetItemDataBase(getItemData)[0];
		if (itemDataBase == null)
		{
			return null;
		}
		if (itemDataBase.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Weapon)
		{
			return ConsumeItemUtil.WeaponConsumeData(itemDataBase);
		}
		return ConsumeItemUtil.MaterialConsumeData(itemDataBase, count);
	}

	// Token: 0x060088AB RID: 34987 RVA: 0x002971A8 File Offset: 0x002953A8
	protected static ConsumeItemData WeaponConsumeData(ItemDataBase itemDataBase)
	{
		ConsumeItemData consumeItemData = new ConsumeItemData();
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase.GetUniqueId());
		consumeItemData.IncId = itemDataBase.GetUniqueId();
		consumeItemData.ItemId = itemDataBase.GetConfigId();
		consumeItemData.ResonanceLevel = weaponDataByIncId.GetResonanceLevel();
		string text = TextConfig.Instance.GetTextById("LevelShow") ?? "";
		consumeItemData.BottomText = text.Replace("{0}", weaponDataByIncId.GetLevel().ToString());
		return consumeItemData;
	}

	// Token: 0x060088AC RID: 34988 RVA: 0x00297228 File Offset: 0x00295428
	protected static ConsumeItemData MaterialConsumeData(ItemDataBase itemDataBase, int count)
	{
		return new ConsumeItemData
		{
			IncId = itemDataBase.GetUniqueId(),
			ItemId = itemDataBase.GetConfigId(),
			BottomText = count.ToString() + "/" + itemDataBase.GetCount().ToString()
		};
	}
}
