using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018BC RID: 6332
[NullableContext(2)]
[Nullable(0)]
public abstract class ItemGridAbstract : GridProxyAbstract<TItem>
{
	// Token: 0x0600B9A5 RID: 47525 RVA: 0x002A1AF8 File Offset: 0x0029FCF8
	public ItemGridAbstract(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null)
	{
		this.SourceItem = source;
		this.SetBelongViewName(belongView);
		if (commonItemActor != null)
		{
			this.CreateThenShowByActor(commonItemActor);
		}
	}

	// Token: 0x0600B9A6 RID: 47526 RVA: 0x002A1B18 File Offset: 0x0029FD18
	protected ItemConfig GetItemConfig()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetItemConfig();
		}
		return this.ItemConfig;
	}

	// Token: 0x0600B9A7 RID: 47527 RVA: 0x002A1B34 File Offset: 0x0029FD34
	public int GetItemId()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetItemId();
		}
		return this.ItemId;
	}

	// Token: 0x0600B9A8 RID: 47528 RVA: 0x002A1B50 File Offset: 0x0029FD50
	protected EUiViewName GetBelongView()
	{
		if (this.SourceItem != null)
		{
			return this.SourceItem.GetBelongView();
		}
		return this.BelongViewName.Value;
	}

	// Token: 0x0600B9A9 RID: 47529 RVA: 0x002A1B74 File Offset: 0x0029FD74
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		this.RefreshByItemId(itemData.ItemId);
		this.ItemCount = data.Count;
		this.UniqueId = itemData.IncId;
	}

	// Token: 0x0600B9AA RID: 47530 RVA: 0x002A1BAC File Offset: 0x0029FDAC
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

	// Token: 0x0600B9AB RID: 47531 RVA: 0x002A1BE5 File Offset: 0x0029FDE5
	public void ShowDefaultDownText()
	{
		if (this.InstanceOfBehaviourPop(this))
		{
			((IItemGrid)this).RefreshTextDown(true, this.GetDefaultDownText());
		}
	}

	// Token: 0x0600B9AC RID: 47532 RVA: 0x002A1C04 File Offset: 0x0029FE04
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

	// Token: 0x0600B9AD RID: 47533 RVA: 0x002A1CCC File Offset: 0x0029FECC
	[NullableContext(1)]
	private bool InstanceOfBehaviourPop(object obj)
	{
		IItemGrid itemGrid = obj as IItemGrid;
		return itemGrid != null && itemGrid.IsItemGrid;
	}

	// Token: 0x0600B9AE RID: 47534 RVA: 0x002A1CEB File Offset: 0x0029FEEB
	public void SetBelongViewName(EUiViewName? viewName)
	{
		this.BelongViewName = viewName;
	}

	// Token: 0x04005430 RID: 21552
	private ItemConfig ItemConfig;

	// Token: 0x04005431 RID: 21553
	private int ItemId;

	// Token: 0x04005432 RID: 21554
	private int ItemCount;

	// Token: 0x04005433 RID: 21555
	private int UniqueId;

	// Token: 0x04005434 RID: 21556
	private EUiViewName? BelongViewName;

	// Token: 0x04005435 RID: 21557
	private readonly ItemGridAbstract SourceItem;
}
