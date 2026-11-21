using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;

// Token: 0x02001485 RID: 5253
public class BrochureItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D26E RID: 53870 RVA: 0x003E7008 File Offset: 0x003E5208
	public override bool IsMatch(int itemId)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("SpringManorBrochureItemId");
		return intArrayConfig != null && intArrayConfig.Count > 0 && itemId == intArrayConfig[0];
	}

	// Token: 0x0600D26F RID: 53871 RVA: 0x003E7038 File Offset: 0x003E5238
	public override void OnUse(int itemId, int num)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("SpringManorBrochureItemId");
		if (intArrayConfig == null || intArrayConfig.Count <= 1)
		{
			return;
		}
		SpringManorBrochureViewOpenParam param = new SpringManorBrochureViewOpenParam
		{
			IsHideReward = true,
			ActivityId = intArrayConfig[1]
		};
		UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, param, null);
	}

	// Token: 0x0400768A RID: 30346
	private const int ITEM_ID_INDEX = 0;

	// Token: 0x0400768B RID: 30347
	private const int ACTIVITY_ID_INDEX = 1;
}
