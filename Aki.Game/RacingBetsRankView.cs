using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C22 RID: 7202
public class RacingBetsRankView : UiTickViewBase
{
	// Token: 0x06011E72 RID: 73330 RVA: 0x00545103 File Offset: 0x00543303
	[NullableContext(1)]
	public RacingBetsRankView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E73 RID: 73331 RVA: 0x0054510C File Offset: 0x0054330C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIArtText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x06011E74 RID: 73332 RVA: 0x0054526C File Offset: 0x0054346C
	protected override void OnStart()
	{
		this.RankLoopViewRoot = base.GetLoopScrollViewComponent(0).RootUIComp.Get();
		this.RankLoopView = new LoopScrollView<RacingBetsRankItem, IRacingBetsRankData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<RacingBetsRankItem>(this.CreateRankItem), false);
	}

	// Token: 0x06011E75 RID: 73333 RVA: 0x005452C4 File Offset: 0x005434C4
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		UUIInturnAnimController uuiinturnAnimController = base.GetLoopScrollViewComponent(0).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController != null)
		{
			uuiinturnAnimController.Play("", -1, false);
		}
		this.NextUpdateTime = (double)RacingBetsModel.Instance.GetRacingBetsSeasonData().GetNextRankUpdateTime();
	}

	// Token: 0x06011E76 RID: 73334 RVA: 0x00545328 File Offset: 0x00543528
	protected override void OnTick(float delta)
	{
		if (this.NextUpdateTime < 0.0)
		{
			UUIText text = base.GetText(12);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
			return;
		}
		else
		{
			RacingBetsSeasonData seasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (this.NextUpdateTime - serverTime >= 0.0)
			{
				this.CrossDayRefresh = false;
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(this.NextUpdateTime - serverTime);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Dango_RankPage_Countdown", new <>z__ReadOnlySingleElementList<object>(((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? ""));
			}
			else if (!this.CrossDayRefresh)
			{
				RacingBetsController.Instance.RacingBetsRankRequest(seasonData.Id, delegate
				{
					this.RefreshView();
					this.NextUpdateTime = (double)seasonData.GetNextRankUpdateTime();
				});
				this.CrossDayRefresh = true;
			}
			UUIText text2 = base.GetText(12);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(true);
			return;
		}
	}

	// Token: 0x06011E77 RID: 73335 RVA: 0x00545425 File Offset: 0x00543625
	[NullableContext(1)]
	private RacingBetsRankItem CreateRankItem()
	{
		return new RacingBetsRankItem();
	}

	// Token: 0x06011E78 RID: 73336 RVA: 0x0054542C File Offset: 0x0054362C
	private void RefreshView()
	{
		List<IRacingBetsRankData> rankData = RacingBetsModel.Instance.GetRankData();
		int count = rankData.Count;
		base.GetItem(10).SetUIActive(count == 0);
		UUIItem rankLoopViewRoot = this.RankLoopViewRoot;
		if (rankLoopViewRoot != null)
		{
			rankLoopViewRoot.SetUIActive(count > 0);
		}
		if (count > 0)
		{
			this.RankLoopView.RefreshByData(rankData, false, null, false);
		}
		this.RefreshSelfData();
	}

	// Token: 0x06011E79 RID: 73337 RVA: 0x0054548C File Offset: 0x0054368C
	private void RefreshSelfData()
	{
		IRacingBetsSelfRankData selfRank = RacingBetsModel.Instance.GetSelfRank();
		if (selfRank == null)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIText text = base.GetText(11);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
			return;
		}
		else
		{
			base.GetText(6).SetText(selfRank.Name, true);
			UUIText text2 = base.GetText(7);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(selfRank.HitNum);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			UUIText text3 = base.GetText(8);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(selfRank.CashNum);
			text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			UUITexture texture = base.GetTexture(5);
			PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(selfRank.HeadIcon, true);
			if (playerHeadData != null)
			{
				base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), texture, null);
			}
			RacingBetsRankStatus rankStatus = selfRank.RankStatus;
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(rankStatus == RacingBetsRankStatus.Rank);
			}
			UUIItem item4 = base.GetItem(3);
			if (item4 != null)
			{
				item4.SetUIActive(rankStatus == RacingBetsRankStatus.UnRank);
			}
			UUIText text4 = base.GetText(11);
			if (text4 != null)
			{
				text4.SetUIActive(false);
			}
			if (rankStatus == RacingBetsRankStatus.Top1)
			{
				UUIText text5 = base.GetText(11);
				if (text5 != null)
				{
					text5.SetUIActive(true);
				}
				UUIText text6 = base.GetText(11);
				if (text6 == null)
				{
					return;
				}
				text6.ShowTextNew("Dango_RankPage_Top1Percent");
				return;
			}
			else
			{
				if (rankStatus == RacingBetsRankStatus.Top50)
				{
					UUIText text7 = base.GetText(11);
					if (text7 != null)
					{
						text7.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Dango_RankPage_Top50Percent", new <>z__ReadOnlySingleElementList<object>(selfRank.RankNum));
					return;
				}
				if (rankStatus == RacingBetsRankStatus.Rank)
				{
					UUIText text8 = base.GetText(11);
					if (text8 != null)
					{
						text8.SetUIActive(false);
					}
					UUIArtText artText = base.GetArtText(4);
					if (artText == null)
					{
						return;
					}
					artText.SetText(selfRank.RankNum.ToString());
				}
				return;
			}
		}
	}

	// Token: 0x06011E7A RID: 73338 RVA: 0x00545661 File Offset: 0x00543861
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009C25 RID: 39973
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RacingBetsRankItem, IRacingBetsRankData> RankLoopView;

	// Token: 0x04009C26 RID: 39974
	[Nullable(2)]
	private UUIItem RankLoopViewRoot;

	// Token: 0x04009C27 RID: 39975
	private bool CrossDayRefresh;

	// Token: 0x04009C28 RID: 39976
	private double NextUpdateTime;

	// Token: 0x02007F32 RID: 32562
	private class EComponent
	{
		// Token: 0x040292DE RID: 168670
		public const int RankLoopView = 0;

		// Token: 0x040292DF RID: 168671
		public const int RankViewItem = 1;

		// Token: 0x040292E0 RID: 168672
		public const int SelfRankPanel = 2;

		// Token: 0x040292E1 RID: 168673
		public const int SelfNoRankPanel = 3;

		// Token: 0x040292E2 RID: 168674
		public const int SelfRankNumArtText = 4;

		// Token: 0x040292E3 RID: 168675
		public const int SelfHeadIcon = 5;

		// Token: 0x040292E4 RID: 168676
		public const int SelfNameText = 6;

		// Token: 0x040292E5 RID: 168677
		public const int SelfHitNum = 7;

		// Token: 0x040292E6 RID: 168678
		public const int SelfTotalMoney = 8;

		// Token: 0x040292E7 RID: 168679
		public const int CloseBtn = 9;

		// Token: 0x040292E8 RID: 168680
		public const int EmptyItem = 10;

		// Token: 0x040292E9 RID: 168681
		public const int SelfPercentRankText = 11;

		// Token: 0x040292EA RID: 168682
		public const int RankUpdateTimeText = 12;
	}
}
