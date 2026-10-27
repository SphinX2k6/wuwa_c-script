using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200271D RID: 10013
public class RacingBetsOddsItem : UiPanelBase
{
	// Token: 0x06014855 RID: 84053 RVA: 0x0052E684 File Offset: 0x0052C884
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

	// Token: 0x06014856 RID: 84054 RVA: 0x0052E6F4 File Offset: 0x0052C8F4
	protected override void OnBeforeShow()
	{
		this.RefreshUi(this.OddsNumber, this.Rank, this.IsBet);
	}

	// Token: 0x06014857 RID: 84055 RVA: 0x0052E710 File Offset: 0x0052C910
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

	// Token: 0x06014858 RID: 84056 RVA: 0x0052E77E File Offset: 0x0052C97E
	public void SetItemOffset(FVector2D position)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAnchorOffset(position);
	}

	// Token: 0x06014859 RID: 84057 RVA: 0x0052E791 File Offset: 0x0052C991
	public void SetVisible(bool visible)
	{
		this.SetActive(visible);
	}

	// Token: 0x04009A56 RID: 39510
	private int OddsNumber;

	// Token: 0x04009A57 RID: 39511
	private int Rank;

	// Token: 0x04009A58 RID: 39512
	private bool IsBet;

	// Token: 0x02008D70 RID: 36208
	private class EComponent
	{
		// Token: 0x0402DE45 RID: 187973
		public const int OddsText = 0;

		// Token: 0x0402DE46 RID: 187974
		public const int RankText = 1;

		// Token: 0x0402DE47 RID: 187975
		public const int RankItem = 2;

		// Token: 0x0402DE48 RID: 187976
		public const int BetsInfo = 3;
	}
}
