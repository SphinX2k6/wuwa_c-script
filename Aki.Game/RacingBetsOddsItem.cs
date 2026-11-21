using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C08 RID: 7176
public class RacingBetsOddsItem : UiPanelBase
{
	// Token: 0x06011D37 RID: 73015 RVA: 0x0053D3A0 File Offset: 0x0053B5A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06011D38 RID: 73016 RVA: 0x0053D410 File Offset: 0x0053B610
	protected override void OnBeforeShow()
	{
		this.RefreshUi(this.OddsNumber, this.Rank, this.IsBet);
	}

	// Token: 0x06011D39 RID: 73017 RVA: 0x0053D42C File Offset: 0x0053B62C
	public void RefreshUi(int odds, int rank, bool isBet)
	{
		this.OddsNumber = odds;
		this.Rank = rank;
		this.IsBet = isBet;
		if (!base.IsShowOrShowing)
		{
			return;
		}
		base.GetArtText(0).SetText(odds.ToString());
		base.GetArtText(1).SetText(rank.ToString());
		base.GetItem(2).SetUIActive(rank > 0);
		base.GetItem(3).SetUIActive(isBet);
	}

	// Token: 0x06011D3A RID: 73018 RVA: 0x0053D49A File Offset: 0x0053B69A
	public void SetItemOffset(FVector2D position)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAnchorOffset(position);
	}

	// Token: 0x06011D3B RID: 73019 RVA: 0x0053D4AD File Offset: 0x0053B6AD
	public void SetVisible(bool visible)
	{
		this.SetActive(visible);
	}

	// Token: 0x04009BAE RID: 39854
	private int OddsNumber;

	// Token: 0x04009BAF RID: 39855
	private int Rank;

	// Token: 0x04009BB0 RID: 39856
	private bool IsBet;

	// Token: 0x02007EF9 RID: 32505
	private class EComponent
	{
		// Token: 0x0402915C RID: 168284
		public const int OddsText = 0;

		// Token: 0x0402915D RID: 168285
		public const int RankText = 1;

		// Token: 0x0402915E RID: 168286
		public const int RankItem = 2;

		// Token: 0x0402915F RID: 168287
		public const int BetsInfo = 3;
	}
}
