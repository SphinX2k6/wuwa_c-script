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

// Token: 0x02002737 RID: 10039
public class RacingBetsRankView : UiTickViewBase
{
	// Token: 0x06014990 RID: 84368 RVA: 0x005363F7 File Offset: 0x005345F7
	[NullableContext(1)]
	public RacingBetsRankView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014991 RID: 84369 RVA: 0x00536400 File Offset: 0x00534600
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

	// Token: 0x06014992 RID: 84370 RVA: 0x00536560 File Offset: 0x00534760
	protected override void OnStart()
	{
		this.RankLoopViewRoot = base.GetLoopScrollViewComponent(0).RootUIComp.Get();
		this.RankLoopView = new LoopScrollView<RacingBetsRankItem, IRacingBetsRankData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<RacingBetsRankItem>(this.CreateRankItem), false);
	}

	// Token: 0x06014993 RID: 84371 RVA: 0x005365B8 File Offset: 0x005347B8
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

	// Token: 0x06014994 RID: 84372 RVA: 0x0053661C File Offset: 0x0053481C
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

	// Token: 0x06014995 RID: 84373 RVA: 0x00536719 File Offset: 0x00534919
	[NullableContext(1)]
	private RacingBetsRankItem CreateRankItem()
	{
		return new RacingBetsRankItem();
	}

	// Token: 0x06014996 RID: 84374 RVA: 0x00536720 File Offset: 0x00534920
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

	// Token: 0x06014997 RID: 84375 RVA: 0x00536780 File Offset: 0x00534980
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

	// Token: 0x06014998 RID: 84376 RVA: 0x00536955 File Offset: 0x00534B55
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009ACD RID: 39629
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RacingBetsRankItem, IRacingBetsRankData> RankLoopView;

	// Token: 0x04009ACE RID: 39630
	[Nullable(2)]
	private UUIItem RankLoopViewRoot;

	// Token: 0x04009ACF RID: 39631
	private bool CrossDayRefresh;

	// Token: 0x04009AD0 RID: 39632
	private double NextUpdateTime;

	// Token: 0x02008DAA RID: 36266
	private class EComponent
	{
		// Token: 0x0402DFC8 RID: 188360
		public const int RankLoopView = 0;

		// Token: 0x0402DFC9 RID: 188361
		public const int RankViewItem = 1;

		// Token: 0x0402DFCA RID: 188362
		public const int SelfRankPanel = 2;

		// Token: 0x0402DFCB RID: 188363
		public const int SelfNoRankPanel = 3;

		// Token: 0x0402DFCC RID: 188364
		public const int SelfRankNumArtText = 4;

		// Token: 0x0402DFCD RID: 188365
		public const int SelfHeadIcon = 5;

		// Token: 0x0402DFCE RID: 188366
		public const int SelfNameText = 6;

		// Token: 0x0402DFCF RID: 188367
		public const int SelfHitNum = 7;

		// Token: 0x0402DFD0 RID: 188368
		public const int SelfTotalMoney = 8;

		// Token: 0x0402DFD1 RID: 188369
		public const int CloseBtn = 9;

		// Token: 0x0402DFD2 RID: 188370
		public const int EmptyItem = 10;

		// Token: 0x0402DFD3 RID: 188371
		public const int SelfPercentRankText = 11;

		// Token: 0x0402DFD4 RID: 188372
		public const int RankUpdateTimeText = 12;
	}
}
