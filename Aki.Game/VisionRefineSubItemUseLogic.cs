using System;
using CSharpScript.Game.Ui;

// Token: 0x02001493 RID: 5267
public class VisionRefineSubItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D2A7 RID: 53927 RVA: 0x003E7AF4 File Offset: 0x003E5CF4
	public override bool IsMatch(int itemId)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		return commonItemData != null && Array.IndexOf<int>(commonItemData.GetConfig().ShowTypes, 58) >= 0;
	}

	// Token: 0x0600D2A8 RID: 53928 RVA: 0x003E7B2C File Offset: 0x003E5D2C
	public override void OnUse(int itemId, int num)
	{
		VisionRefineTabViewParam param = new VisionRefineTabViewParam
		{
			ViewState = ERefineViewState.Choose,
			RefineType = new EVisionRefineRefineType?(EVisionRefineRefineType.Sub)
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRefineTabView, param);
	}
}
