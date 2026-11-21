using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;

// Token: 0x0200149A RID: 5274
public class InventoryGiftCellItem : SmallItemGrid
{
	// Token: 0x0600D2D9 RID: 53977 RVA: 0x003E8A08 File Offset: 0x003E6C08
	[NullableContext(1)]
	public void RefreshByConfigId(GiftItemData giftItemData)
	{
		this.GiftItemData = giftItemData;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(giftItemData.ItemId)) == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(giftItemData.ItemId);
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = null,
				ItemConfigId = new int?(giftItemData.ItemId),
				BottomText = "",
				QualityId = new int?(roleConfig.Value.QualityId),
				IsReceivedVisible = new bool?(false)
			};
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		if (this.GiftItemData.PhantomItemData != null)
		{
			PhantomSmallItemGrid parameters2 = new PhantomSmallItemGrid
			{
				Data = null,
				ItemConfigId = new int?(giftItemData.ItemId),
				BottomText = "",
				IsReceivedVisible = new bool?(false),
				FetterGroupId = new int?(this.GiftItemData.PhantomItemData.FetterGroupId)
			};
			base.Apply<PhantomSmallItemGrid>(parameters2);
			return;
		}
		PropSmallItemGrid parameters3 = new PropSmallItemGrid
		{
			Data = null,
			ItemConfigId = new int?(giftItemData.ItemId),
			BottomText = "",
			IsReceivedVisible = new bool?(false)
		};
		base.Apply<PropSmallItemGrid>(parameters3);
	}

	// Token: 0x0600D2DA RID: 53978 RVA: 0x003E8B3F File Offset: 0x003E6D3F
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600D2DB RID: 53979 RVA: 0x003E8B44 File Offset: 0x003E6D44
	protected override void OnExtendToggleClicked()
	{
		bool canSkip = UiManager.Instance.IsViewShow(EUiViewName.InventoryView);
		if (this.GiftItemData.PhantomItemData != null)
		{
			ItemController.Instance.OpenItemTipsByExtraParam(this.GiftItemData.IncId, this.GiftItemData.PhantomItemData.Id, this.GiftItemData.PhantomItemData, canSkip, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(this.GiftItemData.IncId, this.GiftItemData.ItemId, canSkip, null);
	}

	// Token: 0x040076A3 RID: 30371
	[Nullable(2)]
	private GiftItemData GiftItemData;
}
