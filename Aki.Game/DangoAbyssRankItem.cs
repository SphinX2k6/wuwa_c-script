using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A4F RID: 6735
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssRankItem : GridProxyAbstract<DangoRankItemData>
{
	// Token: 0x0600C63A RID: 50746 RVA: 0x002D0F9D File Offset: 0x002CF19D
	public DangoAbyssRankItem(bool isShowInBottom)
	{
		this.IsShowInBottom = isShowInBottom;
	}

	// Token: 0x0600C63B RID: 50747 RVA: 0x002D0FAC File Offset: 0x002CF1AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C63C RID: 50748 RVA: 0x002D111F File Offset: 0x002CF31F
	protected override void OnStart()
	{
		this.InitOnlineNameLayout();
		this.InitRankGridLayout();
	}

	// Token: 0x0600C63D RID: 50749 RVA: 0x002D112D File Offset: 0x002CF32D
	private void InitOnlineNameLayout()
	{
		this.OnlineNameLayout = new GenericLayout<OnlineItem, OnlineData>(base.GetLayoutBase(4), new Func<OnlineItem>(this.InitOnlineItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C63E RID: 50750 RVA: 0x002D1160 File Offset: 0x002CF360
	private void InitRankGridLayout()
	{
		this.RankGridLayout = new GenericLayout<RankRoleGridItem, DangoAbyssRankRoleData>(base.GetLayoutBase(7), new Func<RankRoleGridItem>(this.InitRankGridItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C63F RID: 50751 RVA: 0x002D1193 File Offset: 0x002CF393
	private OnlineItem InitOnlineItem()
	{
		return new OnlineItem(this.IsShowInBottom);
	}

	// Token: 0x0600C640 RID: 50752 RVA: 0x002D11A0 File Offset: 0x002CF3A0
	private RankRoleGridItem InitRankGridItem()
	{
		return new RankRoleGridItem();
	}

	// Token: 0x0600C641 RID: 50753 RVA: 0x002D11A8 File Offset: 0x002CF3A8
	private void RefreshEmpty()
	{
		base.GetText(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(true);
		UUIItem rootUiItem = this.OnlineNameLayout.GetRootUiItem();
		if (rootUiItem != null)
		{
			rootUiItem.SetUIActive(false);
		}
		string newText = PlayerInfoModel.Instance.GetAccountName(true) ?? "";
		base.GetText(3).SetText(newText, true);
		base.GetText(3).SetUIActive(true);
		base.GetText(6).SetUIActive(false);
		UUIItem rootUiItem2 = this.RankGridLayout.GetRootUiItem();
		if (rootUiItem2 != null)
		{
			rootUiItem2.SetUIActive(false);
		}
		base.GetItem(9).SetUIActive(true);
		this.RefreshRankBg();
	}

	// Token: 0x0600C642 RID: 50754 RVA: 0x002D1250 File Offset: 0x002CF450
	private void RefreshRankBg()
	{
		base.GetTexture(0).SetUIActive(true);
		string resourceId = this.IfRankData ? this.RankItemData.AbyssChallengeInfo.RankBg : "T_AnniversaryCelebrationRankOwnBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
	}

	// Token: 0x0600C643 RID: 50755 RVA: 0x002D12B0 File Offset: 0x002CF4B0
	private void RefreshRankNum()
	{
		UUIText text = base.GetText(1);
		text.SetUIActive(true);
		base.GetItem(2).SetUIActive(!this.RankItemData.AbyssChallengeInfo.IsInRank);
		text.SetText(this.RankItemData.AbyssChallengeInfo.Rank.ToString(), true);
	}

	// Token: 0x0600C644 RID: 50756 RVA: 0x002D1308 File Offset: 0x002CF508
	private void RefreshTimeScore()
	{
		base.GetText(6).SetUIActive(true);
		if (!DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.RankItemData.AbyssChallengeInfo.GetChallengeId()).Value.IsEndless)
		{
			string timeDataFormat = TimeUtil.Instance.GetTimeDataFormat((double)this.RankItemData.AbyssChallengeInfo.GetPassTime());
			base.GetText(6).SetText(timeDataFormat, true);
			return;
		}
		int progress = this.RankItemData.AbyssChallengeInfo.GetProgress();
		if (progress == 100)
		{
			string timeDataFormat2 = TimeUtil.Instance.GetTimeDataFormat((double)this.RankItemData.AbyssChallengeInfo.GetPassTime());
			base.GetText(6).SetText(timeDataFormat2, true);
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		base.GetText(6).SetText(newText, true);
	}

	// Token: 0x0600C645 RID: 50757 RVA: 0x002D13F4 File Offset: 0x002CF5F4
	public UniTask RefreshPlayerName()
	{
		DangoAbyssRankItem.<RefreshPlayerName>d__17 <RefreshPlayerName>d__;
		<RefreshPlayerName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPlayerName>d__.<>4__this = this;
		<RefreshPlayerName>d__.<>1__state = -1;
		<RefreshPlayerName>d__.<>t__builder.Start<DangoAbyssRankItem.<RefreshPlayerName>d__17>(ref <RefreshPlayerName>d__);
		return <RefreshPlayerName>d__.<>t__builder.Task;
	}

	// Token: 0x0600C646 RID: 50758 RVA: 0x002D1438 File Offset: 0x002CF638
	private UniTask RefreshRankGrid()
	{
		DangoAbyssRankItem.<RefreshRankGrid>d__18 <RefreshRankGrid>d__;
		<RefreshRankGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRankGrid>d__.<>4__this = this;
		<RefreshRankGrid>d__.<>1__state = -1;
		<RefreshRankGrid>d__.<>t__builder.Start<DangoAbyssRankItem.<RefreshRankGrid>d__18>(ref <RefreshRankGrid>d__);
		return <RefreshRankGrid>d__.<>t__builder.Task;
	}

	// Token: 0x0600C647 RID: 50759 RVA: 0x002D147B File Offset: 0x002CF67B
	public override void Refresh(DangoRankItemData data, bool isSelected = false, int gridIndex = 0)
	{
		this.Refresh(data, isSelected, gridIndex, true);
	}

	// Token: 0x0600C648 RID: 50760 RVA: 0x002D1488 File Offset: 0x002CF688
	public void Refresh(DangoRankItemData data, bool isSelected, int gridIndex, bool ifRankData)
	{
		this.IfRankData = ifRankData;
		this.RankItemData = data;
		if (data.AbyssChallengeInfo.IsEmpty)
		{
			this.RefreshEmpty();
			return;
		}
		this.RefreshRankBg();
		this.RefreshRankNum();
		this.RefreshPlayerName();
		this.RefreshTimeScore();
		this.RefreshRankGrid();
	}

	// Token: 0x0600C649 RID: 50761 RVA: 0x002D14D8 File Offset: 0x002CF6D8
	public bool IsSelfItem()
	{
		return this.RankItemData.AbyssChallengeInfo.IsSelfInData;
	}

	// Token: 0x04005B57 RID: 23383
	private readonly bool IsShowInBottom;

	// Token: 0x04005B58 RID: 23384
	private bool IfRankData;

	// Token: 0x04005B59 RID: 23385
	private DangoRankItemData RankItemData;

	// Token: 0x04005B5A RID: 23386
	private GenericLayout<OnlineItem, OnlineData> OnlineNameLayout;

	// Token: 0x04005B5B RID: 23387
	private GenericLayout<RankRoleGridItem, DangoAbyssRankRoleData> RankGridLayout;

	// Token: 0x02007F95 RID: 32661
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029A82 RID: 170626
		public const int RankBg = 0;

		// Token: 0x04029A83 RID: 170627
		public const int RankNum = 1;

		// Token: 0x04029A84 RID: 170628
		public const int NoneRankItem = 2;

		// Token: 0x04029A85 RID: 170629
		public const int Name = 3;

		// Token: 0x04029A86 RID: 170630
		public const int OnlineNameLayout = 4;

		// Token: 0x04029A87 RID: 170631
		public const int OnlineNameItem = 5;

		// Token: 0x04029A88 RID: 170632
		public const int ScoreText = 6;

		// Token: 0x04029A89 RID: 170633
		public const int RankGridLayout = 7;

		// Token: 0x04029A8A RID: 170634
		public const int RankGridItem = 8;

		// Token: 0x04029A8B RID: 170635
		public const int NoneScoreText = 9;
	}
}
