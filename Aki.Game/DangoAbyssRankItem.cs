using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F0E RID: 3854
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssRankItem : GridProxyAbstract<DangoRankItemData>
{
	// Token: 0x06009A4A RID: 39498 RVA: 0x002DC0B1 File Offset: 0x002DA2B1
	public DangoAbyssRankItem(bool isShowInBottom)
	{
		this.IsShowInBottom = isShowInBottom;
	}

	// Token: 0x06009A4B RID: 39499 RVA: 0x002DC0C0 File Offset: 0x002DA2C0
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

	// Token: 0x06009A4C RID: 39500 RVA: 0x002DC233 File Offset: 0x002DA433
	protected override void OnStart()
	{
		this.InitOnlineNameLayout();
		this.InitRankGridLayout();
	}

	// Token: 0x06009A4D RID: 39501 RVA: 0x002DC241 File Offset: 0x002DA441
	private void InitOnlineNameLayout()
	{
		this.OnlineNameLayout = new GenericLayout<OnlineItem, OnlineData>(base.GetLayoutBase(4), new Func<OnlineItem>(this.InitOnlineItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009A4E RID: 39502 RVA: 0x002DC274 File Offset: 0x002DA474
	private void InitRankGridLayout()
	{
		this.RankGridLayout = new GenericLayout<RankRoleGridItem, DangoAbyssRankRoleData>(base.GetLayoutBase(7), new Func<RankRoleGridItem>(this.InitRankGridItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009A4F RID: 39503 RVA: 0x002DC2A7 File Offset: 0x002DA4A7
	private OnlineItem InitOnlineItem()
	{
		return new OnlineItem(this.IsShowInBottom);
	}

	// Token: 0x06009A50 RID: 39504 RVA: 0x002DC2B4 File Offset: 0x002DA4B4
	private RankRoleGridItem InitRankGridItem()
	{
		return new RankRoleGridItem();
	}

	// Token: 0x06009A51 RID: 39505 RVA: 0x002DC2BC File Offset: 0x002DA4BC
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

	// Token: 0x06009A52 RID: 39506 RVA: 0x002DC364 File Offset: 0x002DA564
	private void RefreshRankBg()
	{
		base.GetTexture(0).SetUIActive(true);
		string resourceId = this.IfRankData ? this.RankItemData.AbyssChallengeInfo.RankBg : "T_AnniversaryCelebrationRankOwnBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
	}

	// Token: 0x06009A53 RID: 39507 RVA: 0x002DC3C4 File Offset: 0x002DA5C4
	private void RefreshRankNum()
	{
		UUIText text = base.GetText(1);
		text.SetUIActive(true);
		base.GetItem(2).SetUIActive(!this.RankItemData.AbyssChallengeInfo.IsInRank);
		text.SetText(this.RankItemData.AbyssChallengeInfo.Rank.ToString(), true);
	}

	// Token: 0x06009A54 RID: 39508 RVA: 0x002DC41C File Offset: 0x002DA61C
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

	// Token: 0x06009A55 RID: 39509 RVA: 0x002DC508 File Offset: 0x002DA708
	public UniTask RefreshPlayerName()
	{
		DangoAbyssRankItem.<RefreshPlayerName>d__17 <RefreshPlayerName>d__;
		<RefreshPlayerName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPlayerName>d__.<>4__this = this;
		<RefreshPlayerName>d__.<>1__state = -1;
		<RefreshPlayerName>d__.<>t__builder.Start<DangoAbyssRankItem.<RefreshPlayerName>d__17>(ref <RefreshPlayerName>d__);
		return <RefreshPlayerName>d__.<>t__builder.Task;
	}

	// Token: 0x06009A56 RID: 39510 RVA: 0x002DC54C File Offset: 0x002DA74C
	private UniTask RefreshRankGrid()
	{
		DangoAbyssRankItem.<RefreshRankGrid>d__18 <RefreshRankGrid>d__;
		<RefreshRankGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRankGrid>d__.<>4__this = this;
		<RefreshRankGrid>d__.<>1__state = -1;
		<RefreshRankGrid>d__.<>t__builder.Start<DangoAbyssRankItem.<RefreshRankGrid>d__18>(ref <RefreshRankGrid>d__);
		return <RefreshRankGrid>d__.<>t__builder.Task;
	}

	// Token: 0x06009A57 RID: 39511 RVA: 0x002DC58F File Offset: 0x002DA78F
	public override void Refresh(DangoRankItemData data, bool isSelected = false, int gridIndex = 0)
	{
		this.Refresh(data, isSelected, gridIndex, true);
	}

	// Token: 0x06009A58 RID: 39512 RVA: 0x002DC59C File Offset: 0x002DA79C
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

	// Token: 0x06009A59 RID: 39513 RVA: 0x002DC5EC File Offset: 0x002DA7EC
	public bool IsSelfItem()
	{
		return this.RankItemData.AbyssChallengeInfo.IsSelfInData;
	}

	// Token: 0x04005C26 RID: 23590
	private readonly bool IsShowInBottom;

	// Token: 0x04005C27 RID: 23591
	private bool IfRankData;

	// Token: 0x04005C28 RID: 23592
	private DangoRankItemData RankItemData;

	// Token: 0x04005C29 RID: 23593
	private GenericLayout<OnlineItem, OnlineData> OnlineNameLayout;

	// Token: 0x04005C2A RID: 23594
	private GenericLayout<RankRoleGridItem, DangoAbyssRankRoleData> RankGridLayout;

	// Token: 0x02007124 RID: 28964
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024DBF RID: 150975
		public const int RankBg = 0;

		// Token: 0x04024DC0 RID: 150976
		public const int RankNum = 1;

		// Token: 0x04024DC1 RID: 150977
		public const int NoneRankItem = 2;

		// Token: 0x04024DC2 RID: 150978
		public const int Name = 3;

		// Token: 0x04024DC3 RID: 150979
		public const int OnlineNameLayout = 4;

		// Token: 0x04024DC4 RID: 150980
		public const int OnlineNameItem = 5;

		// Token: 0x04024DC5 RID: 150981
		public const int ScoreText = 6;

		// Token: 0x04024DC6 RID: 150982
		public const int RankGridLayout = 7;

		// Token: 0x04024DC7 RID: 150983
		public const int RankGridItem = 8;

		// Token: 0x04024DC8 RID: 150984
		public const int NoneScoreText = 9;
	}
}
