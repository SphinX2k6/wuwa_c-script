using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002348 RID: 9032
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopUtil
{
	// Token: 0x06011F8E RID: 73614 RVA: 0x0046808B File Offset: 0x0046628B
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

	// Token: 0x06011F8F RID: 73615 RVA: 0x004680C4 File Offset: 0x004662C4
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

	// Token: 0x06011F90 RID: 73616 RVA: 0x004680F8 File Offset: 0x004662F8
	public static void OpenExchangePopView(PayShopGoods goodsData)
	{
		CommonGameplayShopExchangePopViewProxy commonGameplayShopExchangePopViewProxy = new CommonGameplayShopExchangePopViewProxy();
		commonGameplayShopExchangePopViewProxy.UpdateFromPayShopGoods(goodsData);
		UiManager.Instance.OpenView(EUiViewName.GameplayExchangePopView, commonGameplayShopExchangePopViewProxy, null);
	}
}
