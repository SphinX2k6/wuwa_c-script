using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F3 RID: 20723
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeShopView : UiViewBase
	{
		// Token: 0x06033DD0 RID: 212432 RVA: 0x00E845F7 File Offset: 0x00E827F7
		public RoverlikeShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033DD1 RID: 212433 RVA: 0x00E8460C File Offset: 0x00E8280C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033DD2 RID: 212434 RVA: 0x00E846FC File Offset: 0x00E828FC
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeShopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeShopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DD3 RID: 212435 RVA: 0x00E8473F File Offset: 0x00E8293F
		protected override void OnBeforeShow()
		{
			this.RefreshCategoryTabs().Forget();
		}

		// Token: 0x06033DD4 RID: 212436 RVA: 0x00E8474C File Offset: 0x00E8294C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06033DD5 RID: 212437 RVA: 0x00E84786 File Offset: 0x00E82986
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x06033DD6 RID: 212438 RVA: 0x00E847C0 File Offset: 0x00E829C0
		protected override void OnBeforeDestroy()
		{
			if (this.CategoryPanel != null)
			{
				this.CategoryPanel.Destroy(null);
				this.CategoryPanel = null;
			}
			if (this.SubTabScroll != null)
			{
				this.SubTabScroll.ClearChildren();
				this.SubTabScroll = null;
			}
			if (this.GoodsScroll != null)
			{
				this.GoodsScroll.ClearGridProxies();
				this.GoodsScroll = null;
			}
			this.TabDataList = new List<UiDynamicTab>();
		}

		// Token: 0x06033DD7 RID: 212439 RVA: 0x00E84828 File Offset: 0x00E82A28
		private UniTask RefreshCategoryTabs()
		{
			RoverlikeShopView.<RefreshCategoryTabs>d__14 <RefreshCategoryTabs>d__;
			<RefreshCategoryTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCategoryTabs>d__.<>4__this = this;
			<RefreshCategoryTabs>d__.<>1__state = -1;
			<RefreshCategoryTabs>d__.<>t__builder.Start<RoverlikeShopView.<RefreshCategoryTabs>d__14>(ref <RefreshCategoryTabs>d__);
			return <RefreshCategoryTabs>d__.<>t__builder.Task;
		}

		// Token: 0x06033DD8 RID: 212440 RVA: 0x00E8486B File Offset: 0x00E82A6B
		private ActivityRegressTabItemPanel ProxyCreateCategoryItem([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new ActivityRegressTabItemPanel();
		}

		// Token: 0x06033DD9 RID: 212441 RVA: 0x00E84874 File Offset: 0x00E82A74
		[NullableContext(2)]
		private CommonTabData GetCategoryCommonData(int index)
		{
			if (index < 0 || index >= this.TabDataList.Count)
			{
				return null;
			}
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06033DDA RID: 212442 RVA: 0x00E848C0 File Offset: 0x00E82AC0
		private void OnCategorySelected(int index)
		{
			this.RefreshSubTabs();
		}

		// Token: 0x06033DDB RID: 212443 RVA: 0x00E848C8 File Offset: 0x00E82AC8
		private void RefreshSubTabs()
		{
			List<int> subTabIdList = this.GetSubTabIdList();
			this.CurrentSubTabId = ((subTabIdList.Count > 0) ? subTabIdList[0] : 0);
			this.SubTabScroll.RefreshByData(subTabIdList, null, false);
			if (this.CurrentSubTabId != 0)
			{
				RoverlikeShopSubTabItem layoutItemByKey = this.SubTabScroll.GetLayoutItemByKey(this.CurrentSubTabId);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetToggleState(true);
				}
			}
			this.RefreshGoods();
		}

		// Token: 0x06033DDC RID: 212444 RVA: 0x00E84933 File Offset: 0x00E82B33
		private RoverlikeShopSubTabItem CreateSubTabItem()
		{
			RoverlikeShopSubTabItem roverlikeShopSubTabItem = new RoverlikeShopSubTabItem();
			roverlikeShopSubTabItem.SetShopId(this.ShopId);
			roverlikeShopSubTabItem.SetOnToggle(new Action<int>(this.OnSubTabToggle));
			return roverlikeShopSubTabItem;
		}

		// Token: 0x06033DDD RID: 212445 RVA: 0x00E84958 File Offset: 0x00E82B58
		private void OnSubTabToggle(int subTabId)
		{
			if (this.CurrentSubTabId != 0 && this.CurrentSubTabId != subTabId)
			{
				RoverlikeShopSubTabItem layoutItemByKey = this.SubTabScroll.GetLayoutItemByKey(this.CurrentSubTabId);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetToggleState(false);
				}
			}
			this.CurrentSubTabId = subTabId;
			this.RefreshGoods();
		}

		// Token: 0x06033DDE RID: 212446 RVA: 0x00E849A8 File Offset: 0x00E82BA8
		private void RefreshGoods()
		{
			if (this.ShopId <= 0 || this.CurrentSubTabId <= 0)
			{
				LoopScrollView<ActivityShopGridItem, IPayShopUnionData> goodsScroll = this.GoodsScroll;
				if (goodsScroll != null)
				{
					goodsScroll.ClearGridProxies();
				}
				this.SetEmptyActive(true);
				return;
			}
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.ShopId, this.CurrentSubTabId, true);
			this.GoodsScroll.ClearGridProxies();
			this.GoodsScroll.RefreshByDataAsync(payShopTabData, false, true).Forget();
			this.SetEmptyActive(payShopTabData.Count <= 0);
		}

		// Token: 0x06033DDF RID: 212447 RVA: 0x00E84A28 File Offset: 0x00E82C28
		private void SetEmptyActive(bool isEmpty)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isEmpty);
		}

		// Token: 0x06033DE0 RID: 212448 RVA: 0x00E84A3C File Offset: 0x00E82C3C
		private UniTask RefreshCurrency()
		{
			RoverlikeShopView.<RefreshCurrency>d__23 <RefreshCurrency>d__;
			<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrency>d__.<>4__this = this;
			<RefreshCurrency>d__.<>1__state = -1;
			<RefreshCurrency>d__.<>t__builder.Start<RoverlikeShopView.<RefreshCurrency>d__23>(ref <RefreshCurrency>d__);
			return <RefreshCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x06033DE1 RID: 212449 RVA: 0x00E84A7F File Offset: 0x00E82C7F
		private ActivityShopGridItem InitGoodsItem()
		{
			return new ActivityShopGridItem();
		}

		// Token: 0x06033DE2 RID: 212450 RVA: 0x00E84A86 File Offset: 0x00E82C86
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshGoods();
			this.RefreshCurrency().Forget();
		}

		// Token: 0x06033DE3 RID: 212451 RVA: 0x00E84A99 File Offset: 0x00E82C99
		private void OnRefreshPayShop(int shopId, bool isSwitch)
		{
			this.RefreshGoods();
			this.RefreshCurrency().Forget();
		}

		// Token: 0x06033DE4 RID: 212452 RVA: 0x00E84AAC File Offset: 0x00E82CAC
		private int GetShopId()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			RoverRogueActivity? roverRogueActivity;
			return ((roverlikeActivityData != null) ? ((roverlikeActivityData.GetParamConfig() != null) ? new int?(roverRogueActivity.GetValueOrDefault().ShopId) : null) : null).GetValueOrDefault();
		}

		// Token: 0x06033DE5 RID: 212453 RVA: 0x00E84B0F File Offset: 0x00E82D0F
		private List<int> GetSubTabIdList()
		{
			if (this.ShopId <= 0)
			{
				return new List<int>();
			}
			return PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.ShopId, true);
		}

		// Token: 0x06033DE6 RID: 212454 RVA: 0x00E84B31 File Offset: 0x00E82D31
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B767 RID: 112487
		private int ShopId;

		// Token: 0x0401B768 RID: 112488
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<ActivityRegressTabItemPanel> CategoryPanel;

		// Token: 0x0401B769 RID: 112489
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B76A RID: 112490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeShopSubTabItem, int> SubTabScroll;

		// Token: 0x0401B76B RID: 112491
		private int CurrentSubTabId;

		// Token: 0x0401B76C RID: 112492
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ActivityShopGridItem, IPayShopUnionData> GoodsScroll;

		// Token: 0x0200ADC5 RID: 44485
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035B0C RID: 219916
			Caption,
			// Token: 0x04035B0D RID: 219917
			ShopScroller,
			// Token: 0x04035B0E RID: 219918
			ShopItem,
			// Token: 0x04035B0F RID: 219919
			TabScroller,
			// Token: 0x04035B10 RID: 219920
			TabItem,
			// Token: 0x04035B11 RID: 219921
			EmptyItem
		}
	}
}
