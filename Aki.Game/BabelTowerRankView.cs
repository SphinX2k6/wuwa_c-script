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

// Token: 0x02000636 RID: 1590
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x06004A14 RID: 18964 RVA: 0x0019310B File Offset: 0x0019130B
	public BabelTowerRankView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004A15 RID: 18965 RVA: 0x00193131 File Offset: 0x00191331
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.BabelTowerRank);
	}

	// Token: 0x06004A16 RID: 18966 RVA: 0x0019313A File Offset: 0x0019133A
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewOpen));
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x0019315A File Offset: 0x0019135A
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewOpen));
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x0019317A File Offset: 0x0019137A
	private void OnViewOpen(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PersonalRootView)
		{
			UiManager.Instance.CloseView(EUiViewName.BabelTowerRankView, null);
		}
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x0019319C File Offset: 0x0019139C
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

	// Token: 0x06004A1A RID: 18970 RVA: 0x00193268 File Offset: 0x00191468
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

	// Token: 0x06004A1B RID: 18971 RVA: 0x001932EC File Offset: 0x001914EC
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

	// Token: 0x06004A1C RID: 18972 RVA: 0x00193358 File Offset: 0x00191558
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerRankView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerRankView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A1D RID: 18973 RVA: 0x0019339C File Offset: 0x0019159C
	private UniTask InitDropDown()
	{
		BabelTowerRankView.<InitDropDown>d__20 <InitDropDown>d__;
		<InitDropDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDropDown>d__.<>4__this = this;
		<InitDropDown>d__.<>1__state = -1;
		<InitDropDown>d__.<>t__builder.Start<BabelTowerRankView.<InitDropDown>d__20>(ref <InitDropDown>d__);
		return <InitDropDown>d__.<>t__builder.Task;
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x001933E0 File Offset: 0x001915E0
	private TableTextArgNew GetLevelTextId(int levelId)
	{
		if (levelId == -1)
		{
			return new TableTextArgNew("BabelRanking_guanqia", Array.Empty<object>());
		}
		return new TableTextArgNew(BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).NameText, Array.Empty<object>());
	}

	// Token: 0x06004A1F RID: 18975 RVA: 0x0019341E File Offset: 0x0019161E
	private void OnDropDownSelect(int index, int levelId)
	{
		this.CurrentRankType = levelId;
		this.RefreshRankListByType();
	}

	// Token: 0x06004A20 RID: 18976 RVA: 0x0019342D File Offset: 0x0019162D
	private void RefreshRankListByType()
	{
		this.RebuildRankListData();
		this.RefreshMyRankItem();
		this.RefreshScrollView();
	}

	// Token: 0x06004A21 RID: 18977 RVA: 0x00193441 File Offset: 0x00191641
	private void RefreshRankListOnly()
	{
		this.RebuildRankListData();
		this.RefreshScrollView();
	}

	// Token: 0x06004A22 RID: 18978 RVA: 0x00193450 File Offset: 0x00191650
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

	// Token: 0x06004A23 RID: 18979 RVA: 0x00193488 File Offset: 0x00191688
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

	// Token: 0x06004A24 RID: 18980 RVA: 0x0019356C File Offset: 0x0019176C
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

	// Token: 0x06004A25 RID: 18981 RVA: 0x001935F4 File Offset: 0x001917F4
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

	// Token: 0x06004A26 RID: 18982 RVA: 0x00193646 File Offset: 0x00191846
	private BabelTowerRankItem CreateItem()
	{
		return new BabelTowerRankItem();
	}

	// Token: 0x040036F8 RID: 14072
	private const int TOTAL_RANK_LEVEL_ID = -1;

	// Token: 0x040036F9 RID: 14073
	[Nullable(2)]
	private BabelTowerData BabelTowerData;

	// Token: 0x040036FA RID: 14074
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BabelTowerRankItem, BabelTowerRankItemData> RankScrollView;

	// Token: 0x040036FB RID: 14075
	[Nullable(2)]
	private BabelTowerRankItem MyRankItem;

	// Token: 0x040036FC RID: 14076
	private bool ShowAnonymous;

	// Token: 0x040036FD RID: 14077
	private readonly List<BabelTowerRankItemData> RankListData = new List<BabelTowerRankItemData>();

	// Token: 0x040036FE RID: 14078
	private readonly BabelTowerRankItemData MyRankItemData = new BabelTowerRankItemData();

	// Token: 0x040036FF RID: 14079
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, int> RankDropDown;

	// Token: 0x04003700 RID: 14080
	private int CurrentRankType = -1;

	// Token: 0x04003701 RID: 14081
	[Nullable(2)]
	private TogTabItemSubComponent TogTabItemIns;

	// Token: 0x020068E6 RID: 26854
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022925 RID: 141605
		public const int DropDownItem = 0;

		// Token: 0x04022926 RID: 141606
		public const int TogTabItem = 1;

		// Token: 0x04022927 RID: 141607
		public const int LoopViewRank = 2;

		// Token: 0x04022928 RID: 141608
		public const int ItemRank = 3;

		// Token: 0x04022929 RID: 141609
		public const int ItemMyRank = 4;
	}
}
