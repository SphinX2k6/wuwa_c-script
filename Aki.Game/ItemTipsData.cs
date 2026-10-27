using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x020018D7 RID: 6359
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsData
{
	// Token: 0x0600BA98 RID: 47768 RVA: 0x002A3AF8 File Offset: 0x002A1CF8
	public ItemTipsData(ItemTipsParam data)
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.ItemId);
		this.ConfigId = data.ItemId;
		this.IncId = data.ItemUid;
		this.CanSkip = data.CanSkip;
		this.PreviewType = itemConfigData.PreviewType;
		this.ShowPreview = itemConfigData.ShowPreview;
		this.Title = itemConfigData.Name;
		this.QualityId = itemConfigData.QualityId;
		List<IGetWayItemData> list = new List<IGetWayItemData>();
		if (itemConfigData.ItemAccess != null && itemConfigData.ItemAccess.Length != 0)
		{
			int[] itemAccess = itemConfigData.ItemAccess;
			for (int i = 0; i < itemAccess.Length; i++)
			{
				int num = itemAccess[i];
				AccessPath? configById = GetWayConfig.Instance.GetConfigById(num);
				if (configById != null && SkipInterfaceModel.Instance.CheckAccessPathCondition(num))
				{
					int getWayIdLocal = num;
					GetWayItemData item = new GetWayItemData(num, (EGetWayItemType)configById.Value.Type, configById.Value.Description, configById.Value.SortIndex, delegate()
					{
						if (this.CanSkip)
						{
							SkipTaskManager.RunByConfigId(getWayIdLocal, this.ConfigId);
							return;
						}
						ScrollingTipsController.Instance.ShowTipsByTextId("SkipTask_Prevent", Array.Empty<object>());
					});
					list.Add(item);
				}
			}
		}
		this.GetWayData = list.ToArray();
	}

	// Token: 0x0600BA99 RID: 47769 RVA: 0x002A3C70 File Offset: 0x002A1E70
	public bool CanDeprecate()
	{
		if (this.IncId <= 0)
		{
			return false;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		return attributeItemData != null && attributeItemData.CanDeprecate();
	}

	// Token: 0x0600BA9A RID: 47770 RVA: 0x002A3CA4 File Offset: 0x002A1EA4
	public bool IsShowIconBig()
	{
		return this.OnIsShowIconBig();
	}

	// Token: 0x0600BA9B RID: 47771 RVA: 0x002A3CAC File Offset: 0x002A1EAC
	protected virtual bool OnIsShowIconBig()
	{
		return false;
	}

	// Token: 0x04005491 RID: 21649
	public int IncId;

	// Token: 0x04005492 RID: 21650
	public int ConfigId;

	// Token: 0x04005493 RID: 21651
	public string Title;

	// Token: 0x04005494 RID: 21652
	public int QualityId;

	// Token: 0x04005495 RID: 21653
	public bool CanSkip;

	// Token: 0x04005496 RID: 21654
	public bool IsIconByType;

	// Token: 0x04005497 RID: 21655
	public bool IsQualityByType;

	// Token: 0x04005498 RID: 21656
	public EItemTipsType ItemType;

	// Token: 0x04005499 RID: 21657
	public ESkipName PreviewType = ESkipName.NoSkip;

	// Token: 0x0400549A RID: 21658
	public bool ShowPreview;

	// Token: 0x0400549B RID: 21659
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IGetWayItemData[] GetWayData;

	// Token: 0x0400549C RID: 21660
	[Nullable(2)]
	public string LimitTimeTxt;

	// Token: 0x0400549D RID: 21661
	public Func<int, bool> CanClickLockButton = (int uniqueId) => true;

	// Token: 0x0400549E RID: 21662
	[Nullable(2)]
	public Func<int> UpdateShowNumCallback;

	// Token: 0x0400549F RID: 21663
	[Nullable(2)]
	public Func<bool> IsShowNumTextCallback;
}
