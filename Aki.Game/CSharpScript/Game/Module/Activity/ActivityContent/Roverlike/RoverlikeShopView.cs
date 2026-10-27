using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006175 RID: 24949
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeShopView : UiViewBase
	{
		// Token: 0x0603F110 RID: 258320 RVA: 0x00F3D723 File Offset: 0x00F3B923
		public RoverlikeShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F111 RID: 258321 RVA: 0x00F3D738 File Offset: 0x00F3B938
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

		// Token: 0x0603F112 RID: 258322 RVA: 0x00F3D828 File Offset: 0x00F3BA28
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeShopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeShopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F113 RID: 258323 RVA: 0x00F3D86B File Offset: 0x00F3BA6B
		protected override void OnBeforeShow()
		{
			this.RefreshCategoryTabs().Forget();
		}

		// Token: 0x0603F114 RID: 258324 RVA: 0x00F3D878 File Offset: 0x00F3BA78
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x0603F115 RID: 258325 RVA: 0x00F3D8B2 File Offset: 0x00F3BAB2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
			EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		}

		// Token: 0x0603F116 RID: 258326 RVA: 0x00F3D8EC File Offset: 0x00F3BAEC
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

		// Token: 0x0603F117 RID: 258327 RVA: 0x00F3D954 File Offset: 0x00F3BB54
		private UniTask RefreshCategoryTabs()
		{
			RoverlikeShopView.<RefreshCategoryTabs>d__14 <RefreshCategoryTabs>d__;
			<RefreshCategoryTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCategoryTabs>d__.<>4__this = this;
			<RefreshCategoryTabs>d__.<>1__state = -1;
			<RefreshCategoryTabs>d__.<>t__builder.Start<RoverlikeShopView.<RefreshCategoryTabs>d__14>(ref <RefreshCategoryTabs>d__);
			return <RefreshCategoryTabs>d__.<>t__builder.Task;
		}

		// Token: 0x0603F118 RID: 258328 RVA: 0x00F3D997 File Offset: 0x00F3BB97
		private ActivityRegressTabItemPanel ProxyCreateCategoryItem([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new ActivityRegressTabItemPanel();
		}

		// Token: 0x0603F119 RID: 258329 RVA: 0x00F3D9A0 File Offset: 0x00F3BBA0
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

		// Token: 0x0603F11A RID: 258330 RVA: 0x00F3D9EC File Offset: 0x00F3BBEC
		private void OnCategorySelected(int index)
		{
			this.RefreshSubTabs();
		}

		// Token: 0x0603F11B RID: 258331 RVA: 0x00F3D9F4 File Offset: 0x00F3BBF4
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

		// Token: 0x0603F11C RID: 258332 RVA: 0x00F3DA5F File Offset: 0x00F3BC5F
		private RoverlikeShopSubTabItem CreateSubTabItem()
		{
			RoverlikeShopSubTabItem roverlikeShopSubTabItem = new RoverlikeShopSubTabItem();
			roverlikeShopSubTabItem.SetShopId(this.ShopId);
			roverlikeShopSubTabItem.SetOnToggle(new Action<int>(this.OnSubTabToggle));
			return roverlikeShopSubTabItem;
		}

		// Token: 0x0603F11D RID: 258333 RVA: 0x00F3DA84 File Offset: 0x00F3BC84
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

		// Token: 0x0603F11E RID: 258334 RVA: 0x00F3DAD4 File Offset: 0x00F3BCD4
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
			this.GoodsScroll.RefreshByDataAsync(payShopTabData.Cast<IPayShopUnionData>().ToList<IPayShopUnionData>(), false, true).Forget();
			this.SetEmptyActive(payShopTabData.Count <= 0);
		}

		// Token: 0x0603F11F RID: 258335 RVA: 0x00F3DB5E File Offset: 0x00F3BD5E
		private void SetEmptyActive(bool isEmpty)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isEmpty);
		}

		// Token: 0x0603F120 RID: 258336 RVA: 0x00F3DB74 File Offset: 0x00F3BD74
		private UniTask RefreshCurrency()
		{
			RoverlikeShopView.<RefreshCurrency>d__23 <RefreshCurrency>d__;
			<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrency>d__.<>4__this = this;
			<RefreshCurrency>d__.<>1__state = -1;
			<RefreshCurrency>d__.<>t__builder.Start<RoverlikeShopView.<RefreshCurrency>d__23>(ref <RefreshCurrency>d__);
			return <RefreshCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x0603F121 RID: 258337 RVA: 0x00F3DBB7 File Offset: 0x00F3BDB7
		private ActivityShopGridItem InitGoodsItem()
		{
			return new ActivityShopGridItem();
		}

		// Token: 0x0603F122 RID: 258338 RVA: 0x00F3DBBE File Offset: 0x00F3BDBE
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshGoods();
			this.RefreshCurrency().Forget();
		}

		// Token: 0x0603F123 RID: 258339 RVA: 0x00F3DBD1 File Offset: 0x00F3BDD1
		private void OnRefreshPayShop(int shopId, bool isSwitch)
		{
			this.RefreshGoods();
			this.RefreshCurrency().Forget();
		}

		// Token: 0x0603F124 RID: 258340 RVA: 0x00F3DBE4 File Offset: 0x00F3BDE4
		private int GetShopId()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			RoverRogueActivity? roverRogueActivity;
			return ((roverlikeActivityData != null) ? ((roverlikeActivityData.GetParamConfig() != null) ? new int?(roverRogueActivity.GetValueOrDefault().ShopId) : null) : null).GetValueOrDefault();
		}

		// Token: 0x0603F125 RID: 258341 RVA: 0x00F3DC47 File Offset: 0x00F3BE47
		private List<int> GetSubTabIdList()
		{
			if (this.ShopId <= 0)
			{
				return new List<int>();
			}
			return PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.ShopId, true);
		}

		// Token: 0x0603F126 RID: 258342 RVA: 0x00F3DC69 File Offset: 0x00F3BE69
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020E3A RID: 134714
		private int ShopId;

		// Token: 0x04020E3B RID: 134715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<ActivityRegressTabItemPanel> CategoryPanel;

		// Token: 0x04020E3C RID: 134716
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04020E3D RID: 134717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeShopSubTabItem, int> SubTabScroll;

		// Token: 0x04020E3E RID: 134718
		private int CurrentSubTabId;

		// Token: 0x04020E3F RID: 134719
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ActivityShopGridItem, IPayShopUnionData> GoodsScroll;

		// Token: 0x0200C3DE RID: 50142
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B1AB RID: 242091
			Caption,
			// Token: 0x0403B1AC RID: 242092
			ShopScroller,
			// Token: 0x0403B1AD RID: 242093
			ShopItem,
			// Token: 0x0403B1AE RID: 242094
			TabScroller,
			// Token: 0x0403B1AF RID: 242095
			TabItem,
			// Token: 0x0403B1B0 RID: 242096
			EmptyItem
		}
	}
}
