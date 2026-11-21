using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200182D RID: 6189
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopUtil
{
	// Token: 0x0600F43E RID: 62526 RVA: 0x00475153 File Offset: 0x00473353
	public static void SetText(UUIText text, GameplayShopTextData textData)
	{
		if (text == null || textData == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(textData.Content))
		{
			text.SetText(textData.Content, true);
			return;
		}
		if (textData.Data != null)
		{
			GameplayShopUtil.SetTextByData(text, textData.Data);
		}
	}

	// Token: 0x0600F43F RID: 62527 RVA: 0x0047518C File Offset: 0x0047338C
	public static void SetTextByData(UUIText text, TableTextArgNew data)
	{
		if (text == null)
		{
			return;
		}
		string textKey = data.TextKey;
		if (string.IsNullOrEmpty(textKey))
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, textKey, data.Params);
	}

	// Token: 0x0600F440 RID: 62528 RVA: 0x004751C0 File Offset: 0x004733C0
	public static void OpenExchangePopView(PayShopGoods goodsData)
	{
		CommonGameplayShopExchangePopViewProxy commonGameplayShopExchangePopViewProxy = new CommonGameplayShopExchangePopViewProxy();
		commonGameplayShopExchangePopViewProxy.UpdateFromPayShopGoods(goodsData);
		UiManager.Instance.OpenView(EUiViewName.GameplayExchangePopView, commonGameplayShopExchangePopViewProxy, null);
	}
}
