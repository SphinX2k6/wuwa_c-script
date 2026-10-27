using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002370 RID: 9072
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x060121D5 RID: 74197 RVA: 0x00472EA8 File Offset: 0x004710A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060121D6 RID: 74198 RVA: 0x00472F18 File Offset: 0x00471118
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopRecommendSwitchItem>(base.GetHorizontalLayout(0).GetRootComponent(), new Func<UUIItem, int?, PayShopRecommendSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(1));
		this.TabViewComponent = new TabViewComponent<int>(base.GetItem(3), EKeyMode.Index);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 界面Start";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060121D7 RID: 74199 RVA: 0x00472F9C File Offset: 0x0047119C
	protected override void OnTickUiTabViewBase(float deltaTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (serverTime - this.LastUpdateTime >= 1.0)
		{
			this.LastUpdateTime = serverTime;
			EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
		}
	}

	// Token: 0x060121D8 RID: 74200 RVA: 0x00472FDE File Offset: 0x004711DE
	private PayShopRecommendSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopRecommendSwitchItem();
	}

	// Token: 0x060121D9 RID: 74201 RVA: 0x00472FE8 File Offset: 0x004711E8
	private void ToggleCallBack(int gridIndex)
	{
		PayShopRecommendView.RecommendData recommendData = this.TabRecommendData[gridIndex];
		EUiTabViewName value = recommendData.TabViewName.Value;
		PayShopRecommendSwitchItem tabItemByIndex = this.TabGroup.GetTabItemByIndex(gridIndex);
		int id = recommendData.Id;
		this.TabViewComponent.ToggleCallBack(gridIndex, value, tabItemByIndex, id, new int?(recommendData.Id));
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = 1;
		onClickPayShopTabLogEvent.i_tab_id = recommendData.Id;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
	}

	// Token: 0x060121DA RID: 74202 RVA: 0x00473069 File Offset: 0x00471269
	protected override void OnShowUiTabViewFromToggle()
	{
		this.RefreshTab();
	}

	// Token: 0x060121DB RID: 74203 RVA: 0x00473071 File Offset: 0x00471271
	protected override void OnShowUiTabViewFromView()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
	}

	// Token: 0x060121DC RID: 74204 RVA: 0x0047307F File Offset: 0x0047127F
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x060121DD RID: 74205 RVA: 0x00473090 File Offset: 0x00471290
	private void RefreshTab()
	{
		this.InitRecommendData();
		int openTab = 0;
		if (this.ExtraParams != null)
		{
			int num = (int)this.ExtraParams;
			for (int i = 0; i < this.TabRecommendData.Count; i++)
			{
				if (this.TabRecommendData[i].Id == num)
				{
					openTab = i;
					break;
				}
			}
		}
		this.TabGroup.ResetLastSelectTab();
		this.UpdateTabs().ContinueWith(delegate()
		{
			this.TabGroup.SelectToggleByIndex(openTab, true, true);
			this.TabViewComponent.SetCurrentTabViewState(true);
		}).Forget();
	}

	// Token: 0x060121DE RID: 74206 RVA: 0x00473128 File Offset: 0x00471328
	private void InitRecommendData()
	{
		this.TabRecommendData.Clear();
		List<PayShopRecommendData> needShowRecommendData = PayShopModel.Instance.GetNeedShowRecommendData();
		int count = needShowRecommendData.Count;
		int i = 0;
		while (i < count)
		{
			PayShopRecommendData payShopRecommendData = needShowRecommendData[i];
			PayShopRecommendView.RecommendData recommendData = new PayShopRecommendView.RecommendData();
			if (payShopRecommendData.RecommendType == 1)
			{
				recommendData.TabViewName = new EUiTabViewName?(PayShopDefine.RecommendTabView[PayShopDefine.ERecommendTabType.MonthCard]);
				goto IL_CE;
			}
			if (payShopRecommendData.RecommendType == 2)
			{
				recommendData.TabViewName = new EUiTabViewName?(PayShopDefine.RecommendTabView[PayShopDefine.ERecommendTabType.RoleSkinRecommendView]);
				goto IL_CE;
			}
			if (payShopRecommendData.RecommendType == 3)
			{
				if (WeekCardModel.Instance.GetViewModel(EWeekCardKind.Normal).IsKindOpen())
				{
					recommendData.TabViewName = new EUiTabViewName?(PayShopDefine.RecommendTabView[PayShopDefine.ERecommendTabType.WeekCard]);
					goto IL_CE;
				}
			}
			else
			{
				if (payShopRecommendData.RecommendType == 4)
				{
					recommendData.TabViewName = new EUiTabViewName?(PayShopDefine.RecommendTabView[PayShopDefine.ERecommendTabType.MotorSkin]);
					goto IL_CE;
				}
				goto IL_CE;
			}
			IL_157:
			i++;
			continue;
			IL_CE:
			recommendData.TabName = payShopRecommendData.TabName;
			recommendData.TabImage = payShopRecommendData.TabImage;
			recommendData.Param = payShopRecommendData.RecommendId;
			recommendData.Id = payShopRecommendData.Id;
			recommendData.Sort = payShopRecommendData.Sort;
			int boughtParam = (payShopRecommendData.RecommendType == 4 || payShopRecommendData.RecommendType == 2) ? payShopRecommendData.RecommendId : -1;
			recommendData.HasBought = PayShopModel.Instance.CheckRecommendHasBought(payShopRecommendData.RecommendType, boughtParam);
			this.TabRecommendData.Add(recommendData);
			goto IL_157;
		}
		this.TabRecommendData.Sort(new Comparison<PayShopRecommendView.RecommendData>(this.CompareSortListItems));
	}

	// Token: 0x060121DF RID: 74207 RVA: 0x004732AE File Offset: 0x004714AE
	private int CompareSortListItems(PayShopRecommendView.RecommendData a, PayShopRecommendView.RecommendData b)
	{
		if (a.HasBought == b.HasBought)
		{
			return a.Sort.CompareTo(b.Sort);
		}
		if (!a.HasBought)
		{
			return -1;
		}
		return 1;
	}

	// Token: 0x060121E0 RID: 74208 RVA: 0x004732DC File Offset: 0x004714DC
	protected override void OnAfterShow()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 界面AfterShow";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060121E1 RID: 74209 RVA: 0x00473318 File Offset: 0x00471518
	private UniTask UpdateTabs()
	{
		PayShopRecommendView.<UpdateTabs>d__19 <UpdateTabs>d__;
		<UpdateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateTabs>d__.<>4__this = this;
		<UpdateTabs>d__.<>1__state = -1;
		<UpdateTabs>d__.<>t__builder.Start<PayShopRecommendView.<UpdateTabs>d__19>(ref <UpdateTabs>d__);
		return <UpdateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060121E2 RID: 74210 RVA: 0x0047335B File Offset: 0x0047155B
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x060121E3 RID: 74211 RVA: 0x00473383 File Offset: 0x00471583
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		this.RefreshTab();
	}

	// Token: 0x040088FF RID: 35071
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopRecommendSwitchItem> TabGroup;

	// Token: 0x04008900 RID: 35072
	[Nullable(2)]
	protected TabViewComponent<int> TabViewComponent;

	// Token: 0x04008901 RID: 35073
	protected int CurrentSelectTabId;

	// Token: 0x04008902 RID: 35074
	private double LastUpdateTime;

	// Token: 0x04008903 RID: 35075
	private readonly List<PayShopRecommendView.RecommendData> TabRecommendData = new List<PayShopRecommendView.RecommendData>();

	// Token: 0x02008907 RID: 35079
	[NullableContext(0)]
	public enum EPayShopRecommendViewDefine
	{
		// Token: 0x0402C871 RID: 182385
		GroupScroller,
		// Token: 0x0402C872 RID: 182386
		TabItem,
		// Token: 0x0402C873 RID: 182387
		TabPanel,
		// Token: 0x0402C874 RID: 182388
		PanelContent
	}

	// Token: 0x02008908 RID: 35080
	[Nullable(0)]
	private class RecommendData
	{
		// Token: 0x0402C875 RID: 182389
		public EUiTabViewName? TabViewName;

		// Token: 0x0402C876 RID: 182390
		[Nullable(2)]
		public object Param;

		// Token: 0x0402C877 RID: 182391
		public string TabName = string.Empty;

		// Token: 0x0402C878 RID: 182392
		public int Id;

		// Token: 0x0402C879 RID: 182393
		public int Sort;

		// Token: 0x0402C87A RID: 182394
		public string TabImage = "";

		// Token: 0x0402C87B RID: 182395
		public bool HasBought;
	}
}
