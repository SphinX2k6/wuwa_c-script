using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200270C RID: 9996
public class RacingBetsChampionRewardItem : UiPanelBase
{
	// Token: 0x060147DE RID: 83934 RVA: 0x0052CD28 File Offset: 0x0052AF28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickTipButton))
		};
	}

	// Token: 0x060147DF RID: 83935 RVA: 0x0052CDA8 File Offset: 0x0052AFA8
	public void Refresh(int itemId)
	{
		this.ItemId = itemId;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			base.SetItemIcon(texture, this.ItemId, null, null);
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText("x1", true);
	}

	// Token: 0x060147E0 RID: 83936 RVA: 0x0052CDF5 File Offset: 0x0052AFF5
	private void OnClickTipButton()
	{
		if (this.ItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}
	}

	// Token: 0x04009A2C RID: 39468
	private int ItemId;

	// Token: 0x02008D5A RID: 36186
	private class EComponent
	{
		// Token: 0x0402DDE8 RID: 187880
		public const int TipButton = 0;

		// Token: 0x0402DDE9 RID: 187881
		public const int ItemIcon = 1;

		// Token: 0x0402DDEA RID: 187882
		public const int ItemCount = 2;
	}
}
