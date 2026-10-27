using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B84 RID: 7044
public class FloroRanchCurrencyItem : UiPanelBase
{
	// Token: 0x0600D1BA RID: 53690 RVA: 0x00301AB0 File Offset: 0x002FFCB0
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

	// Token: 0x0600D1BB RID: 53691 RVA: 0x00301B98 File Offset: 0x002FFD98
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

	// Token: 0x0600D1BC RID: 53692 RVA: 0x00301C00 File Offset: 0x002FFE00
	private void SetTextureAllTransition()
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
		if (uiTextureTransitionComponent != null)
		{
			uiTextureTransitionComponent.SetAllStateTexture(base.GetTexture(0).GetTexture());
		}
	}

	// Token: 0x0600D1BD RID: 53693 RVA: 0x00301C2C File Offset: 0x002FFE2C
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

	// Token: 0x04006036 RID: 24630
	[Nullable(1)]
	private FloroRanchCurrencyData CurrencyData;

	// Token: 0x02008107 RID: 33031
	private class EComponentDefine
	{
		// Token: 0x0402A1DD RID: 172509
		public const int Texture = 0;

		// Token: 0x0402A1DE RID: 172510
		public const int TextureTransition = 1;

		// Token: 0x0402A1DF RID: 172511
		public const int CountText = 2;

		// Token: 0x0402A1E0 RID: 172512
		public const int Button = 3;
	}
}
