using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D75 RID: 3445
[NullableContext(2)]
[Nullable(0)]
public abstract class ItemGridAbstract : GridProxyAbstract<TItem>
{
	// Token: 0x06008D8E RID: 36238 RVA: 0x002AC250 File Offset: 0x002AA450
	public ItemGridAbstract(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null)
	{
		this.SourceItem = source;
		this.SetBelongViewName(belongView);
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x06008D8F RID: 36239 RVA: 0x002AC270 File Offset: 0x002AA470
	protected ItemConfig GetItemConfig()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetItemConfig();
		}
		return this.ItemConfig;
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x002AC28C File Offset: 0x002AA48C
	public int GetItemId()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetItemId();
		}
		return this.ItemId;
	}

	// Token: 0x06008D91 RID: 36241 RVA: 0x002AC2A8 File Offset: 0x002AA4A8
	protected EUiViewName GetBelongView()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetBelongView();
		}
		return this.BelongViewName.Value;
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x002AC2CC File Offset: 0x002AA4CC
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		this.RefreshByItemId(itemData.ItemId);
		this.ItemCount = data.Count;
		this.UniqueId = itemData.IncId;
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x002AC304 File Offset: 0x002AA504
	public void RefreshByItemId(int itemId)
	{
		this.ItemId = itemId;
		this.ItemConfig = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (this.InstanceOfBehaviourPop(this))
		{
			((IItemGrid)this).RefreshQualitySprite();
			((IItemGrid)this).RefreshTextureIcon();
		}
	}

	// Token: 0x06008D94 RID: 36244 RVA: 0x002AC33D File Offset: 0x002AA53D
	public void ShowDefaultDownText()
	{
		if (this.InstanceOfBehaviourPop(this))
		{
			((IItemGrid)this).RefreshTextDown(true, this.GetDefaultDownText());
		}
	}

	// Token: 0x06008D95 RID: 36245 RVA: 0x002AC35C File Offset: 0x002AA55C
	[NullableContext(1)]
	public string GetDefaultDownText()
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.UniqueId);
		if (this.ItemCount > 1)
		{
			return this.ItemCount.ToString();
		}
		if (!StringUtils.IsEmpty((attributeItemData != null) ? attributeItemData.GetDefaultDownText() : null))
		{
			if (attributeItemData is PhantomItemData)
			{
				int phantomLevel = PhantomBattleModel.Instance.GetPhantomBattleData(this.UniqueId).GetPhantomLevel();
				return StringUtils.Format(attributeItemData.GetDefaultDownText(), new string[]
				{
					phantomLevel.ToString()
				});
			}
			if (attributeItemData is WeaponItemData)
			{
				int level = WeaponModel.Instance.GetWeaponDataByIncId(this.UniqueId).GetLevel();
				return StringUtils.Format(attributeItemData.GetDefaultDownText(), new string[]
				{
					level.ToString()
				});
			}
		}
		return this.ItemCount.ToString();
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x002AC424 File Offset: 0x002AA624
	[NullableContext(1)]
	private bool InstanceOfBehaviourPop(object obj)
	{
		IItemGrid itemGrid = obj as IItemGrid;
		return itemGrid != null && itemGrid.IsItemGrid;
	}

	// Token: 0x06008D97 RID: 36247 RVA: 0x002AC443 File Offset: 0x002AA643
	public void SetBelongViewName(EUiViewName? viewName)
	{
		this.BelongViewName = viewName;
	}

	// Token: 0x040054DB RID: 21723
	private ItemConfig ItemConfig;

	// Token: 0x040054DC RID: 21724
	private int ItemId;

	// Token: 0x040054DD RID: 21725
	private int ItemCount;

	// Token: 0x040054DE RID: 21726
	private int UniqueId;

	// Token: 0x040054DF RID: 21727
	private EUiViewName? BelongViewName;

	// Token: 0x040054E0 RID: 21728
	private readonly ItemGridAbstract SourceItem;
}
