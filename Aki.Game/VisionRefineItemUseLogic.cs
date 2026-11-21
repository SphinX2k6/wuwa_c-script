using System;
using CSharpScript.Game.Ui;

// Token: 0x02001492 RID: 5266
public class VisionRefineItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D2A4 RID: 53924 RVA: 0x003E7A7C File Offset: 0x003E5C7C
	public override bool IsMatch(int itemId)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		return commonItemData != null && Array.IndexOf<int>(commonItemData.GetConfig().ShowTypes, 54) >= 0;
	}

	// Token: 0x0600D2A5 RID: 53925 RVA: 0x003E7AB4 File Offset: 0x003E5CB4
	public override void OnUse(int itemId, int num)
	{
		VisionRefineTabViewParam param = new VisionRefineTabViewParam
		{
			ViewState = ERefineViewState.Choose,
			RefineType = new EVisionRefineRefineType?(EVisionRefineRefineType.Main)
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRefineTabView, param);
	}
}
