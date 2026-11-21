using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BF7 RID: 7159
public class RacingBetsChampionRewardItem : UiPanelBase
{
	// Token: 0x06011CC0 RID: 72896 RVA: 0x0053BA44 File Offset: 0x00539C44
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

	// Token: 0x06011CC1 RID: 72897 RVA: 0x0053BAC4 File Offset: 0x00539CC4
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

	// Token: 0x06011CC2 RID: 72898 RVA: 0x0053BB11 File Offset: 0x00539D11
	private void OnClickTipButton()
	{
		if (this.ItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}
	}

	// Token: 0x04009B84 RID: 39812
	private int ItemId;

	// Token: 0x02007EE3 RID: 32483
	private class EComponent
	{
		// Token: 0x040290FF RID: 168191
		public const int TipButton = 0;

		// Token: 0x04029100 RID: 168192
		public const int ItemIcon = 1;

		// Token: 0x04029101 RID: 168193
		public const int ItemCount = 2;
	}
}
