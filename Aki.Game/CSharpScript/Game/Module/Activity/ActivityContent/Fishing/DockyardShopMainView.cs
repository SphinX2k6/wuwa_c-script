using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065BF RID: 26047
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopMainView : UiViewBase
	{
		// Token: 0x06041555 RID: 267605 RVA: 0x00FD4FFE File Offset: 0x00FD31FE
		public DockyardShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041556 RID: 267606 RVA: 0x00FD5030 File Offset: 0x00FD3230
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041557 RID: 267607 RVA: 0x00FD50FC File Offset: 0x00FD32FC
		private void InitCaption()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		}

		// Token: 0x06041558 RID: 267608 RVA: 0x00FD5110 File Offset: 0x00FD3310
		private UniTask RefreshCurrency(EUiTabViewName viewName)
		{
			DockyardShopMainView.<RefreshCurrency>d__13 <RefreshCurrency>d__;
			<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrency>d__.<>4__this = this;
			<RefreshCurrency>d__.viewName = viewName;
			<RefreshCurrency>d__.<>1__state = -1;
			<RefreshCurrency>d__.<>t__builder.Start<DockyardShopMainView.<RefreshCurrency>d__13>(ref <RefreshCurrency>d__);
			return <RefreshCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x06041559 RID: 267609 RVA: 0x00FD515C File Offset: 0x00FD335C
		private void RefreshBuyTabItemRedDot()
		{
			int shopId = DockyardModel.Instance.ShopId;
			bool redDotActive = PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
			this.TabItemList[this.TabItemList.Count - 1].SetRedDotActive(redDotActive);
		}

		// Token: 0x0604155A RID: 267610 RVA: 0x00FD51A0 File Offset: 0x00FD33A0
		private UniTask InitTabItem(UUIItem uiItem)
		{
			DockyardShopMainView.<InitTabItem>d__15 <InitTabItem>d__;
			<InitTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabItem>d__.<>4__this = this;
			<InitTabItem>d__.uiItem = uiItem;
			<InitTabItem>d__.<>1__state = -1;
			<InitTabItem>d__.<>t__builder.Start<DockyardShopMainView.<InitTabItem>d__15>(ref <InitTabItem>d__);
			return <InitTabItem>d__.<>t__builder.Task;
		}

		// Token: 0x0604155B RID: 267611 RVA: 0x00FD51EC File Offset: 0x00FD33EC
		private UniTask InitTabComponent()
		{
			DockyardShopMainView.<InitTabComponent>d__16 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<DockyardShopMainView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0604155C RID: 267612 RVA: 0x00FD5230 File Offset: 0x00FD3430
		private UniTask InitPlotPanel()
		{
			DockyardShopMainView.<InitPlotPanel>d__17 <InitPlotPanel>d__;
			<InitPlotPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPlotPanel>d__.<>4__this = this;
			<InitPlotPanel>d__.<>1__state = -1;
			<InitPlotPanel>d__.<>t__builder.Start<DockyardShopMainView.<InitPlotPanel>d__17>(ref <InitPlotPanel>d__);
			return <InitPlotPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0604155D RID: 267613 RVA: 0x00FD5273 File Offset: 0x00FD3473
		private void InitUiBlur()
		{
			AUIBaseActor rootActor = this.RootActor;
			this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(false);
		}

		// Token: 0x0604155E RID: 267614 RVA: 0x00FD52B0 File Offset: 0x00FD34B0
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardShopMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardShopMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604155F RID: 267615 RVA: 0x00FD52F3 File Offset: 0x00FD34F3
		protected override void OnStart()
		{
			this.CacheData = UiTimeDilation.Instance.GetTimeDilationDataCopy();
			this.ShowPlotPanel("OpenShopView");
		}

		// Token: 0x06041560 RID: 267616 RVA: 0x00FD5310 File Offset: 0x00FD3510
		protected void PauseTimeDilation()
		{
			UiViewInfoForTimeDilation uiViewInfoForTimeDilation = new UiViewInfoForTimeDilation();
			uiViewInfoForTimeDilation.TimeDilation = 1f;
			uiViewInfoForTimeDilation.ViewId = base.GetViewId();
			UiViewInfo viewInfo = this.ViewInfo;
			uiViewInfoForTimeDilation.DebugName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			uiViewInfoForTimeDilation.Reason = "DockyardShopMainView.PauseTimeDilation";
			UiViewInfoForTimeDilation gameTimeDilation = uiViewInfoForTimeDilation;
			UiTimeDilation.Instance.SetGameTimeDilation(gameTimeDilation);
		}

		// Token: 0x06041561 RID: 267617 RVA: 0x00FD5378 File Offset: 0x00FD3578
		protected void ResumeTimeDilation()
		{
			if (this.CacheData != null)
			{
				UiViewInfoForTimeDilation gameTimeDilation = new UiViewInfoForTimeDilation
				{
					TimeDilation = this.CacheData.TimeDilation,
					ViewId = this.CacheData.ViewId,
					DebugName = this.CacheData.DebugName,
					Reason = "DockyardShopMainView.ResumeTimeDilation"
				};
				UiTimeDilation.Instance.SetGameTimeDilation(gameTimeDilation);
			}
		}

		// Token: 0x06041562 RID: 267618 RVA: 0x00FD53DD File Offset: 0x00FD35DD
		protected override void OnBeforeShow()
		{
			this.HideCharacter();
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.SetCurrentTabViewState(true);
			}
			this.PauseTimeDilation();
		}

		// Token: 0x06041563 RID: 267619 RVA: 0x00FD53FD File Offset: 0x00FD35FD
		protected override void OnBeforeHide()
		{
			this.ResumeTimeDilation();
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.SetCurrentTabViewState(false);
			}
			this.ShowCharacter();
		}

		// Token: 0x06041564 RID: 267620 RVA: 0x00FD541D File Offset: 0x00FD361D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
			EventSystem.Instance.Add<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OpenTabView));
		}

		// Token: 0x06041565 RID: 267621 RVA: 0x00FD5454 File Offset: 0x00FD3654
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
			EventSystem.Instance.Remove(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OpenTabView));
		}

		// Token: 0x06041566 RID: 267622 RVA: 0x00FD548B File Offset: 0x00FD368B
		private void HandleBuyItem()
		{
			this.ShowPlotPanel("BuyItem");
		}

		// Token: 0x06041567 RID: 267623 RVA: 0x00FD5498 File Offset: 0x00FD3698
		private void OpenTabView(EUiTabViewName? viewName, UiTabViewBase _)
		{
			if (viewName == EUiTabViewName.DockyardBuyTabView)
			{
				this.RefreshBuyTabItemRedDot();
			}
		}

		// Token: 0x06041568 RID: 267624 RVA: 0x00FD54D0 File Offset: 0x00FD36D0
		private void ToggleCallback(int tabIndex)
		{
			int currentTabIndex = this.CurrentTabIndex;
			this.CurrentTabIndex = tabIndex;
			if (currentTabIndex != -1)
			{
				this.TabItemList[currentTabIndex].SetToggleState(EToggleState.ETT_UnChecked, true);
			}
			UiDynamicTab data = this.TabDataList[tabIndex];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			this.RefreshCurrency(euiTabViewName);
			if (euiTabViewName == EUiTabViewName.DockyardSellTabView)
			{
				this.TabViewComponent.ToggleCallBack(data, euiTabViewName, this.TabItemList[tabIndex], this.SellViewModel, null);
				return;
			}
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, this.TabItemList[tabIndex], null, null);
		}

		// Token: 0x06041569 RID: 267625 RVA: 0x00FD557D File Offset: 0x00FD377D
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604156A RID: 267626 RVA: 0x00FD5588 File Offset: 0x00FD3788
		private bool CanExecuteChange(int tabIndex, bool isForce)
		{
			if (this.CurrentTabIndex != -1 && (EUiTabViewName)this.TabDataList[this.CurrentTabIndex].ChildViewName == EUiTabViewName.DockyardSellTabView && this.SellViewModel.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return this.CurrentTabIndex != tabIndex;
		}

		// Token: 0x0604156B RID: 267627 RVA: 0x00FD55FC File Offset: 0x00FD37FC
		protected void HideCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "DockyardShopMainView", false);
			}
		}

		// Token: 0x0604156C RID: 267628 RVA: 0x00FD5630 File Offset: 0x00FD3830
		protected void ShowCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "DockyardShopMainView", false);
			}
		}

		// Token: 0x0604156D RID: 267629 RVA: 0x00FD5664 File Offset: 0x00FD3864
		public void ShowPlotPanel(string performId)
		{
			this.PlotPanel.ShowPanel(performId);
		}

		// Token: 0x0604156E RID: 267630 RVA: 0x00FD5672 File Offset: 0x00FD3872
		public void HidePlotPanel()
		{
			this.PlotPanel.HidePanel();
		}

		// Token: 0x0604156F RID: 267631 RVA: 0x00FD567F File Offset: 0x00FD387F
		public void NotifyUiBlur(bool isActive)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(isActive);
		}

		// Token: 0x04021FFF RID: 139263
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04022000 RID: 139264
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04022001 RID: 139265
		protected List<DockyardShopTabItem> TabItemList = new List<DockyardShopTabItem>();

		// Token: 0x04022002 RID: 139266
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04022003 RID: 139267
		protected int CurrentTabIndex = -1;

		// Token: 0x04022004 RID: 139268
		protected DockyardShopTabViewModel SellViewModel = new DockyardShopTabViewModel();

		// Token: 0x04022005 RID: 139269
		protected DockyardShopPlotPanel PlotPanel;

		// Token: 0x04022006 RID: 139270
		[Nullable(2)]
		protected TsUiBlur UiBlur;

		// Token: 0x04022007 RID: 139271
		[Nullable(2)]
		protected IUiViewInfoForTimeDilation CacheData;

		// Token: 0x0200C7DD RID: 51165
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C5DB RID: 247259
			public const int CaptionItem = 0;

			// Token: 0x0403C5DC RID: 247260
			public const int TabComponent = 1;

			// Token: 0x0403C5DD RID: 247261
			public const int ShopTabItem = 2;

			// Token: 0x0403C5DE RID: 247262
			public const int BuyTabItem = 3;

			// Token: 0x0403C5DF RID: 247263
			public const int PlotItem = 4;
		}
	}
}
