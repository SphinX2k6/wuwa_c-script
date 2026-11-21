using System;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.Cipher;
using CSharpScript.Game.Ui;

// Token: 0x02001491 RID: 5265
public class UiPlayItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D2A1 RID: 53921 RVA: 0x003E79C0 File Offset: 0x003E5BC0
	public override bool IsMatch(int itemId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemId, true);
		return config != null && config.Value.UiPlayItem && ConfigUiPlayItemById.GetConfig(itemId, true) != null;
	}

	// Token: 0x0600D2A2 RID: 53922 RVA: 0x003E7A08 File Offset: 0x003E5C08
	public override void OnUse(int itemId, int num)
	{
		UiPlayItem? config = ConfigUiPlayItemById.GetConfig(itemId, true);
		ESimpleGameplayType esimpleGameplayType = ESimpleGameplayTypeExtensions.FromString(config.Value.Type);
		if (esimpleGameplayType == ESimpleGameplayType.Cipher)
		{
			CipherController.Instance.OpenCipherView(config.Value.UiPlayKey);
			return;
		}
		if (esimpleGameplayType != ESimpleGameplayType.SignalBreak)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SignalDecodeView, config.Value.UiPlayKey, null);
	}
}
