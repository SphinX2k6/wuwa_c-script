using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Popup
{
	// Token: 0x020047F9 RID: 18425
	public class RewardItem : LoopScrollSmallItemGrid<TPreviewItem>
	{
		// Token: 0x06030416 RID: 197654 RVA: 0x00B311B2 File Offset: 0x00B2F3B2
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x06030417 RID: 197655 RVA: 0x00B311B5 File Offset: 0x00B2F3B5
		protected override void OnExtendToggleClicked()
		{
			ItemController instance = ItemController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OpenItemTipsByItemId(this.ConfigId, true, null);
		}

		// Token: 0x06030418 RID: 197656 RVA: 0x00B311D0 File Offset: 0x00B2F3D0
		protected override void OnRefresh(TPreviewItem data, bool isSelected, int gridIndex)
		{
			this.ConfigId = data.ItemId;
			int count = data.Count;
			InventoryConfig instance = InventoryConfig.Instance;
			if (((instance != null) ? new InventoryDefine.EItemDataType?(instance.GetItemDataTypeByConfigId(new int?(this.ConfigId))) : null).GetValueOrDefault() == InventoryDefine.EItemDataType.RoleItem)
			{
				RoleConfig instance2 = RoleConfig.Instance;
				RoleInfo? roleInfo = (instance2 != null) ? instance2.GetRoleConfig(this.ConfigId) : null;
				CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
				{
					Data = data,
					ItemConfigId = new int?(this.ConfigId),
					BottomText = ((count > 0) ? count.ToString() : ""),
					QualityId = new int?((roleInfo != null) ? roleInfo.GetValueOrDefault().QualityId : 0)
				};
				base.Apply<CharacterSmallItemGrid>(parameters);
				return;
			}
			PropSmallItemGrid parameters2 = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(this.ConfigId),
				BottomText = ((count > 0) ? count.ToString() : "")
			};
			base.Apply<PropSmallItemGrid>(parameters2);
		}

		// Token: 0x04019F99 RID: 106393
		public int ConfigId;
	}
}
