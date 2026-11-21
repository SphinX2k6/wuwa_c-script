using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001043 RID: 4163
public class FloroRanchCurrencyItem : UiPanelBase
{
	// Token: 0x0600A5CB RID: 42443 RVA: 0x0030CB88 File Offset: 0x0030AD88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A5CC RID: 42444 RVA: 0x0030CC70 File Offset: 0x0030AE70
	[NullableContext(1)]
	public void SetCurrencyData(FloroRanchCurrencyData currencyData)
	{
		this.CurrencyData = currencyData;
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(this.CurrencyData.GetIconPath(), texture, null, delegate(bool _)
		{
			this.SetTextureAllTransition();
		});
		long amount = this.CurrencyData.GetAmount();
		base.GetText(2).SetText(FloroRanchModel.Instance.GetCoinText(amount), true);
	}

	// Token: 0x0600A5CD RID: 42445 RVA: 0x0030CCD8 File Offset: 0x0030AED8
	private void SetTextureAllTransition()
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
		if (uiTextureTransitionComponent != null)
		{
			uiTextureTransitionComponent.SetAllStateTexture(base.GetTexture(0).GetTexture());
		}
	}

	// Token: 0x0600A5CE RID: 42446 RVA: 0x0030CD04 File Offset: 0x0030AF04
	private void OnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchCommonTipsView, new FloroRanchCommonTipParam
		{
			TipType = EFloroRanchCommonTipType.Currency,
			CurrencyData = this.CurrencyData,
			RemoveCallback = null,
			EntityData = null,
			ToyData = null,
			CardData = null
		}, null);
	}

	// Token: 0x04006105 RID: 24837
	[Nullable(1)]
	private FloroRanchCurrencyData CurrencyData;

	// Token: 0x02007295 RID: 29333
	private class EComponentDefine
	{
		// Token: 0x04025511 RID: 152849
		public const int Texture = 0;

		// Token: 0x04025512 RID: 152850
		public const int TextureTransition = 1;

		// Token: 0x04025513 RID: 152851
		public const int CountText = 2;

		// Token: 0x04025514 RID: 152852
		public const int Button = 3;
	}
}
