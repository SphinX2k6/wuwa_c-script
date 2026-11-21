using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x02000D90 RID: 3472
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsData
{
	// Token: 0x06008E81 RID: 36481 RVA: 0x002AE250 File Offset: 0x002AC450
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

	// Token: 0x06008E82 RID: 36482 RVA: 0x002AE3C8 File Offset: 0x002AC5C8
	public bool CanDeprecate()
	{
		if (this.IncId <= 0)
		{
			return false;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		return attributeItemData != null && attributeItemData.CanDeprecate();
	}

	// Token: 0x06008E83 RID: 36483 RVA: 0x002AE3FC File Offset: 0x002AC5FC
	public bool IsShowIconBig()
	{
		return this.OnIsShowIconBig();
	}

	// Token: 0x06008E84 RID: 36484 RVA: 0x002AE404 File Offset: 0x002AC604
	protected virtual bool OnIsShowIconBig()
	{
		return false;
	}

	// Token: 0x0400553C RID: 21820
	public int IncId;

	// Token: 0x0400553D RID: 21821
	public int ConfigId;

	// Token: 0x0400553E RID: 21822
	public string Title;

	// Token: 0x0400553F RID: 21823
	public int QualityId;

	// Token: 0x04005540 RID: 21824
	public bool CanSkip;

	// Token: 0x04005541 RID: 21825
	public bool IsIconByType;

	// Token: 0x04005542 RID: 21826
	public bool IsQualityByType;

	// Token: 0x04005543 RID: 21827
	public EItemTipsType ItemType;

	// Token: 0x04005544 RID: 21828
	public ESkipName PreviewType = ESkipName.NoSkip;

	// Token: 0x04005545 RID: 21829
	public bool ShowPreview;

	// Token: 0x04005546 RID: 21830
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IGetWayItemData[] GetWayData;

	// Token: 0x04005547 RID: 21831
	[Nullable(2)]
	public string LimitTimeTxt;

	// Token: 0x04005548 RID: 21832
	public Func<int, bool> CanClickLockButton = (int uniqueId) => true;

	// Token: 0x04005549 RID: 21833
	[Nullable(2)]
	public Func<int> UpdateShowNumCallback;

	// Token: 0x0400554A RID: 21834
	[Nullable(2)]
	public Func<bool> IsShowNumTextCallback;
}
