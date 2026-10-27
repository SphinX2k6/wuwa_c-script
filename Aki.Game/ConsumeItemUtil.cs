using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001815 RID: 6165
[NullableContext(1)]
[Nullable(0)]
public class ConsumeItemUtil
{
	// Token: 0x0600B4BF RID: 46271 RVA: 0x0028CA44 File Offset: 0x0028AC44
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

	// Token: 0x0600B4C0 RID: 46272 RVA: 0x0028CA88 File Offset: 0x0028AC88
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

	// Token: 0x0600B4C1 RID: 46273 RVA: 0x0028CB08 File Offset: 0x0028AD08
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
