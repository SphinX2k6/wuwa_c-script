using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Popup
{
	// Token: 0x0200372A RID: 14122
	public class RewardItem : LoopScrollSmallItemGrid<TPreviewItem>
	{
		// Token: 0x06024BE6 RID: 150502 RVA: 0x00A61152 File Offset: 0x00A5F352
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x06024BE7 RID: 150503 RVA: 0x00A61155 File Offset: 0x00A5F355
		protected override void OnExtendToggleClicked()
		{
			ItemController instance = ItemController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
		}

		// Token: 0x06024BE8 RID: 150504 RVA: 0x00A61170 File Offset: 0x00A5F370
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

		// Token: 0x0401464D RID: 83533
		public int ConfigId;
	}
}
