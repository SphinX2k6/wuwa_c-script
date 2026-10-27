using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001C89 RID: 7305
public class GachaSmallItemGrid : LoopScrollSmallItemGrid<int>
{
	// Token: 0x0600DC74 RID: 56436 RVA: 0x00336BAC File Offset: 0x00334DAC
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

	// Token: 0x0600DC75 RID: 56437 RVA: 0x00336C14 File Offset: 0x00334E14
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600DC76 RID: 56438 RVA: 0x00336C17 File Offset: 0x00334E17
	protected override void OnExtendToggleClicked()
	{
	}
}
