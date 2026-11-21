using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001855 RID: 6229
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F685 RID: 63109 RVA: 0x00480028 File Offset: 0x0047E228
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

	// Token: 0x0600F686 RID: 63110 RVA: 0x00480098 File Offset: 0x0047E298
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

	// Token: 0x0600F687 RID: 63111 RVA: 0x0048011C File Offset: 0x0047E31C
	protected override void OnTickUiTabViewBase(float deltaTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (serverTime - this.LastUpdateTime >= 1.0)
		{
			this.LastUpdateTime = serverTime;
			EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
		}
	}

	// Token: 0x0600F688 RID: 63112 RVA: 0x0048015E File Offset: 0x0047E35E
	private PayShopRecommendSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopRecommendSwitchItem();
	}

	// Token: 0x0600F689 RID: 63113 RVA: 0x00480168 File Offset: 0x0047E368
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

	// Token: 0x0600F68A RID: 63114 RVA: 0x004801E9 File Offset: 0x0047E3E9
	protected override void OnShowUiTabViewFromToggle()
	{
		this.RefreshTab();
	}

	// Token: 0x0600F68B RID: 63115 RVA: 0x004801F1 File Offset: 0x0047E3F1
	protected override void OnShowUiTabViewFromView()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
	}

	// Token: 0x0600F68C RID: 63116 RVA: 0x004801FF File Offset: 0x0047E3FF
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x0600F68D RID: 63117 RVA: 0x00480210 File Offset: 0x0047E410
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

	// Token: 0x0600F68E RID: 63118 RVA: 0x004802A8 File Offset: 0x0047E4A8
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

	// Token: 0x0600F68F RID: 63119 RVA: 0x0048042E File Offset: 0x0047E62E
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

	// Token: 0x0600F690 RID: 63120 RVA: 0x0048045C File Offset: 0x0047E65C
	protected override void OnAfterShow()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 界面AfterShow";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F691 RID: 63121 RVA: 0x00480498 File Offset: 0x0047E698
	private UniTask UpdateTabs()
	{
		PayShopRecommendView.<UpdateTabs>d__19 <UpdateTabs>d__;
		<UpdateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateTabs>d__.<>4__this = this;
		<UpdateTabs>d__.<>1__state = -1;
		<UpdateTabs>d__.<>t__builder.Start<PayShopRecommendView.<UpdateTabs>d__19>(ref <UpdateTabs>d__);
		return <UpdateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600F692 RID: 63122 RVA: 0x004804DB File Offset: 0x0047E6DB
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x0600F693 RID: 63123 RVA: 0x00480503 File Offset: 0x0047E703
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		this.RefreshTab();
	}

	// Token: 0x04008A44 RID: 35396
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopRecommendSwitchItem> TabGroup;

	// Token: 0x04008A45 RID: 35397
	[Nullable(2)]
	protected TabViewComponent<int> TabViewComponent;

	// Token: 0x04008A46 RID: 35398
	protected int CurrentSelectTabId;

	// Token: 0x04008A47 RID: 35399
	private double LastUpdateTime;

	// Token: 0x04008A48 RID: 35400
	private readonly List<PayShopRecommendView.RecommendData> TabRecommendData = new List<PayShopRecommendView.RecommendData>();

	// Token: 0x02007A91 RID: 31377
	[NullableContext(0)]
	public enum EPayShopRecommendViewDefine
	{
		// Token: 0x04027B89 RID: 162697
		GroupScroller,
		// Token: 0x04027B8A RID: 162698
		TabItem,
		// Token: 0x04027B8B RID: 162699
		TabPanel,
		// Token: 0x04027B8C RID: 162700
		PanelContent
	}

	// Token: 0x02007A92 RID: 31378
	[Nullable(0)]
	private class RecommendData
	{
		// Token: 0x04027B8D RID: 162701
		public EUiTabViewName? TabViewName;

		// Token: 0x04027B8E RID: 162702
		[Nullable(2)]
		public object Param;

		// Token: 0x04027B8F RID: 162703
		public string TabName = string.Empty;

		// Token: 0x04027B90 RID: 162704
		public int Id;

		// Token: 0x04027B91 RID: 162705
		public int Sort;

		// Token: 0x04027B92 RID: 162706
		public string TabImage = "";

		// Token: 0x04027B93 RID: 162707
		public bool HasBought;
	}
}
