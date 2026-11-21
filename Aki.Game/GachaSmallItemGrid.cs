using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001148 RID: 4424
public class GachaSmallItemGrid : LoopScrollSmallItemGrid<int>
{
	// Token: 0x0600B08A RID: 45194 RVA: 0x003420D0 File Offset: 0x003402D0
	protected override void OnRefresh(int itemId, bool isSelected, int gridIndex)
	{
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId)) == InventoryDefine.EItemDataType.RoleItem)
		{
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				ItemConfigId = new int?(itemId),
				Data = null
			};
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		PropSmallItemGrid parameters2 = new PropSmallItemGrid
		{
			Data = null,
			ItemConfigId = new int?(itemId)
		};
		base.Apply<PropSmallItemGrid>(parameters2);
		base.SetToggleInteractive(false);
	}

	// Token: 0x0600B08B RID: 45195 RVA: 0x00342138 File Offset: 0x00340338
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600B08C RID: 45196 RVA: 0x0034213B File Offset: 0x0034033B
	protected override void OnExtendToggleClicked()
	{
	}
}
