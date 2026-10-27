using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001182 RID: 4482
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x0600767D RID: 30333 RVA: 0x0018A55B File Offset: 0x0018875B
	public BabelTowerRankView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600767E RID: 30334 RVA: 0x0018A581 File Offset: 0x00188781
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.BabelTowerRank);
	}

	// Token: 0x0600767F RID: 30335 RVA: 0x0018A58A File Offset: 0x0018878A
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewOpen));
	}

	// Token: 0x06007680 RID: 30336 RVA: 0x0018A5AA File Offset: 0x001887AA
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewOpen));
	}

	// Token: 0x06007681 RID: 30337 RVA: 0x0018A5CA File Offset: 0x001887CA
	private void OnViewOpen(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PersonalRootView)
		{
			UiManager.Instance.CloseView(EUiViewName.BabelTowerRankView, null);
		}
	}

	// Token: 0x06007682 RID: 30338 RVA: 0x0018A5EC File Offset: 0x001887EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007683 RID: 30339 RVA: 0x0018A6B8 File Offset: 0x001888B8
	private void OnToggleTabClick(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		this.ShowAnonymous = flag;
		this.BabelTowerData.SetSelfShowName(!this.ShowAnonymous);
		BabelTowerController.Instance.SetShowNameRequestAsync(this.BabelTowerData.Id, !this.ShowAnonymous).Forget();
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelRanking_Anonymousopen", Array.Empty<object>());
		}
		else
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelRanking_Anonymousstop", Array.Empty<object>());
		}
		this.RefreshRankListOnly();
	}

	// Token: 0x06007684 RID: 30340 RVA: 0x0018A73C File Offset: 0x0018893C
	protected override void OnBeforeShow()
	{
		int? num = this.OpenParam as int?;
		if (num != null)
		{
			this.CurrentRankType = num.Value;
		}
		if (this.TogTabItemIns != null && this.BabelTowerData != null)
		{
			bool flag = !this.BabelTowerData.GetSelfShowName();
			this.ShowAnonymous = flag;
			this.TogTabItemIns.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x06007685 RID: 30341 RVA: 0x0018A7A8 File Offset: 0x001889A8
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerRankView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerRankView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007686 RID: 30342 RVA: 0x0018A7EC File Offset: 0x001889EC
	private UniTask InitDropDown()
	{
		BabelTowerRankView.<InitDropDown>d__20 <InitDropDown>d__;
		<InitDropDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDropDown>d__.<>4__this = this;
		<InitDropDown>d__.<>1__state = -1;
		<InitDropDown>d__.<>t__builder.Start<BabelTowerRankView.<InitDropDown>d__20>(ref <InitDropDown>d__);
		return <InitDropDown>d__.<>t__builder.Task;
	}

	// Token: 0x06007687 RID: 30343 RVA: 0x0018A830 File Offset: 0x00188A30
	private TableTextArgNew GetLevelTextId(int levelId)
	{
		if (levelId == -1)
		{
			return new TableTextArgNew("BabelRanking_guanqia", Array.Empty<object>());
		}
		return new TableTextArgNew(BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).NameText, Array.Empty<object>());
	}

	// Token: 0x06007688 RID: 30344 RVA: 0x0018A86E File Offset: 0x00188A6E
	private void OnDropDownSelect(int index, int levelId)
	{
		this.CurrentRankType = levelId;
		this.RefreshRankListByType();
	}

	// Token: 0x06007689 RID: 30345 RVA: 0x0018A87D File Offset: 0x00188A7D
	private void RefreshRankListByType()
	{
		this.RebuildRankListData();
		this.RefreshMyRankItem();
		this.RefreshScrollView();
	}

	// Token: 0x0600768A RID: 30346 RVA: 0x0018A891 File Offset: 0x00188A91
	private void RefreshRankListOnly()
	{
		this.RebuildRankListData();
		this.RefreshScrollView();
	}

	// Token: 0x0600768B RID: 30347 RVA: 0x0018A8A0 File Offset: 0x00188AA0
	[return: Nullable(2)]
	private BabelTowerRankItemData TryAppendRankItem(List<BabelTowerRankItemData> list, PublicBabelTowerInfo protoData, bool isMyRank)
	{
		BabelTowerRankItemData babelTowerRankItemData = new BabelTowerRankItemData();
		babelTowerRankItemData.IsMyRank = isMyRank;
		if (!BabelTowerController.Instance.ConvertProtoToRankData(protoData, babelTowerRankItemData, this.CurrentRankType))
		{
			return null;
		}
		list.Add(babelTowerRankItemData);
		return babelTowerRankItemData;
	}

	// Token: 0x0600768C RID: 30348 RVA: 0x0018A8D8 File Offset: 0x00188AD8
	private void RebuildRankListData()
	{
		List<BabelTowerRankItemData> rankListData = this.RankListData;
		rankListData.Clear();
		BabelTowerData babelTowerData = this.BabelTowerData;
		foreach (PublicBabelTowerInfo protoData in (((babelTowerData != null) ? babelTowerData.GetRawFriendData() : null) ?? new List<PublicBabelTowerInfo>()))
		{
			this.TryAppendRankItem(rankListData, protoData, false);
		}
		BabelTowerData babelTowerData2 = this.BabelTowerData;
		PublicBabelTowerInfo publicBabelTowerInfo = (babelTowerData2 != null) ? babelTowerData2.GetRawSelfData() : null;
		if (publicBabelTowerInfo != null)
		{
			this.TryAppendRankItem(rankListData, publicBabelTowerInfo, true);
		}
		rankListData.Sort(delegate(BabelTowerRankItemData a, BabelTowerRankItemData b)
		{
			if (a.PassStar != b.PassStar)
			{
				return b.PassStar - a.PassStar;
			}
			if (a.PassTime != b.PassTime)
			{
				return a.PassTime - b.PassTime;
			}
			return a.PlayerId - b.PlayerId;
		});
		for (int i = 0; i < rankListData.Count; i++)
		{
			rankListData[i].Ranking = i + 1;
		}
	}

	// Token: 0x0600768D RID: 30349 RVA: 0x0018A9BC File Offset: 0x00188BBC
	private void RefreshMyRankItem()
	{
		if (this.MyRankItem == null)
		{
			return;
		}
		int num = this.RankListData.FindIndex((BabelTowerRankItemData d) => d.IsMyRank);
		if (num < 0)
		{
			this.MyRankItem.ShowLockState();
			return;
		}
		this.MyRankItemData.CopyFrom(this.RankListData[num]);
		this.MyRankItemData.ShowName = true;
		this.MyRankItem.Refresh(this.MyRankItemData, false, num);
	}

	// Token: 0x0600768E RID: 30350 RVA: 0x0018AA44 File Offset: 0x00188C44
	private void RefreshScrollView()
	{
		bool flag = this.RankListData.Count > 0;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		this.RankScrollView.SetTargetRootComponentActive(flag);
		if (flag)
		{
			this.RankScrollView.RefreshByData(this.RankListData, false, null, false);
		}
	}

	// Token: 0x0600768F RID: 30351 RVA: 0x0018AA96 File Offset: 0x00188C96
	private BabelTowerRankItem CreateItem()
	{
		return new BabelTowerRankItem();
	}

	// Token: 0x0400365F RID: 13919
	private const int TOTAL_RANK_LEVEL_ID = -1;

	// Token: 0x04003660 RID: 13920
	[Nullable(2)]
	private BabelTowerData BabelTowerData;

	// Token: 0x04003661 RID: 13921
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerRankItem, BabelTowerRankItemData> RankScrollView;

	// Token: 0x04003662 RID: 13922
	[Nullable(2)]
	private BabelTowerRankItem MyRankItem;

	// Token: 0x04003663 RID: 13923
	private bool ShowAnonymous;

	// Token: 0x04003664 RID: 13924
	private readonly List<BabelTowerRankItemData> RankListData = new List<BabelTowerRankItemData>();

	// Token: 0x04003665 RID: 13925
	private readonly BabelTowerRankItemData MyRankItemData = new BabelTowerRankItemData();

	// Token: 0x04003666 RID: 13926
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, int> RankDropDown;

	// Token: 0x04003667 RID: 13927
	private int CurrentRankType = -1;

	// Token: 0x04003668 RID: 13928
	[Nullable(2)]
	private TogTabItemSubComponent TogTabItemIns;

	// Token: 0x02007759 RID: 30553
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040275EC RID: 161260
		public const int DropDownItem = 0;

		// Token: 0x040275ED RID: 161261
		public const int TogTabItem = 1;

		// Token: 0x040275EE RID: 161262
		public const int LoopViewRank = 2;

		// Token: 0x040275EF RID: 161263
		public const int ItemRank = 3;

		// Token: 0x040275F0 RID: 161264
		public const int ItemMyRank = 4;
	}
}
