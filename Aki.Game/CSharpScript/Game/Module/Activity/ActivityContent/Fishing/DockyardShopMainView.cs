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
	// Token: 0x0200553D RID: 21821
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopMainView : UiViewBase
	{
		// Token: 0x0603621A RID: 221722 RVA: 0x00F1C03A File Offset: 0x00F1A23A
		public DockyardShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603621B RID: 221723 RVA: 0x00F1C06C File Offset: 0x00F1A26C
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

		// Token: 0x0603621C RID: 221724 RVA: 0x00F1C138 File Offset: 0x00F1A338
		private void InitCaption()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		}

		// Token: 0x0603621D RID: 221725 RVA: 0x00F1C14C File Offset: 0x00F1A34C
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

		// Token: 0x0603621E RID: 221726 RVA: 0x00F1C198 File Offset: 0x00F1A398
		private void RefreshBuyTabItemRedDot()
		{
			int shopId = DockyardModel.Instance.ShopId;
			bool redDotActive = PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
			this.TabItemList[this.TabItemList.Count - 1].SetRedDotActive(redDotActive);
		}

		// Token: 0x0603621F RID: 221727 RVA: 0x00F1C1DC File Offset: 0x00F1A3DC
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

		// Token: 0x06036220 RID: 221728 RVA: 0x00F1C228 File Offset: 0x00F1A428
		private UniTask InitTabComponent()
		{
			DockyardShopMainView.<InitTabComponent>d__16 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<DockyardShopMainView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x06036221 RID: 221729 RVA: 0x00F1C26C File Offset: 0x00F1A46C
		private UniTask InitPlotPanel()
		{
			DockyardShopMainView.<InitPlotPanel>d__17 <InitPlotPanel>d__;
			<InitPlotPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPlotPanel>d__.<>4__this = this;
			<InitPlotPanel>d__.<>1__state = -1;
			<InitPlotPanel>d__.<>t__builder.Start<DockyardShopMainView.<InitPlotPanel>d__17>(ref <InitPlotPanel>d__);
			return <InitPlotPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036222 RID: 221730 RVA: 0x00F1C2AF File Offset: 0x00F1A4AF
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

		// Token: 0x06036223 RID: 221731 RVA: 0x00F1C2EC File Offset: 0x00F1A4EC
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardShopMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardShopMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036224 RID: 221732 RVA: 0x00F1C32F File Offset: 0x00F1A52F
		protected override void OnStart()
		{
			this.CacheData = UiTimeDilation.Instance.GetTimeDilationDataCopy();
			this.ShowPlotPanel("OpenShopView");
		}

		// Token: 0x06036225 RID: 221733 RVA: 0x00F1C34C File Offset: 0x00F1A54C
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

		// Token: 0x06036226 RID: 221734 RVA: 0x00F1C3B4 File Offset: 0x00F1A5B4
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

		// Token: 0x06036227 RID: 221735 RVA: 0x00F1C419 File Offset: 0x00F1A619
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

		// Token: 0x06036228 RID: 221736 RVA: 0x00F1C439 File Offset: 0x00F1A639
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

		// Token: 0x06036229 RID: 221737 RVA: 0x00F1C459 File Offset: 0x00F1A659
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
			EventSystem.Instance.Add<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OpenTabView));
		}

		// Token: 0x0603622A RID: 221738 RVA: 0x00F1C490 File Offset: 0x00F1A690
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
			EventSystem.Instance.Remove(EEventName.OpenTabView, new Action<EUiTabViewName?, UiTabViewBase>(this.OpenTabView));
		}

		// Token: 0x0603622B RID: 221739 RVA: 0x00F1C4C7 File Offset: 0x00F1A6C7
		private void HandleBuyItem()
		{
			this.ShowPlotPanel("BuyItem");
		}

		// Token: 0x0603622C RID: 221740 RVA: 0x00F1C4D4 File Offset: 0x00F1A6D4
		private void OpenTabView(EUiTabViewName? viewName, UiTabViewBase _)
		{
			if (viewName == EUiTabViewName.DockyardBuyTabView)
			{
				this.RefreshBuyTabItemRedDot();
			}
		}

		// Token: 0x0603622D RID: 221741 RVA: 0x00F1C50C File Offset: 0x00F1A70C
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

		// Token: 0x0603622E RID: 221742 RVA: 0x00F1C5B9 File Offset: 0x00F1A7B9
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603622F RID: 221743 RVA: 0x00F1C5C4 File Offset: 0x00F1A7C4
		private bool CanExecuteChange(int tabIndex, bool isForce)
		{
			if (this.CurrentTabIndex != -1 && (EUiTabViewName)this.TabDataList[this.CurrentTabIndex].ChildViewName == EUiTabViewName.DockyardSellTabView && this.SellViewModel.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return this.CurrentTabIndex != tabIndex;
		}

		// Token: 0x06036230 RID: 221744 RVA: 0x00F1C638 File Offset: 0x00F1A838
		protected void HideCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "DockyardShopMainView", false);
			}
		}

		// Token: 0x06036231 RID: 221745 RVA: 0x00F1C66C File Offset: 0x00F1A86C
		protected void ShowCharacter()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "DockyardShopMainView", false);
			}
		}

		// Token: 0x06036232 RID: 221746 RVA: 0x00F1C6A0 File Offset: 0x00F1A8A0
		public void ShowPlotPanel(string performId)
		{
			this.PlotPanel.ShowPanel(performId);
		}

		// Token: 0x06036233 RID: 221747 RVA: 0x00F1C6AE File Offset: 0x00F1A8AE
		public void HidePlotPanel()
		{
			this.PlotPanel.HidePanel();
		}

		// Token: 0x06036234 RID: 221748 RVA: 0x00F1C6BB File Offset: 0x00F1A8BB
		public void NotifyUiBlur(bool isActive)
		{
			TsUiBlur uiBlur = this.UiBlur;
			if (uiBlur == null)
			{
				return;
			}
			uiBlur.SetEnableUiBlur(isActive);
		}

		// Token: 0x0401C930 RID: 117040
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401C931 RID: 117041
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401C932 RID: 117042
		protected List<DockyardShopTabItem> TabItemList = new List<DockyardShopTabItem>();

		// Token: 0x0401C933 RID: 117043
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401C934 RID: 117044
		protected int CurrentTabIndex = -1;

		// Token: 0x0401C935 RID: 117045
		protected DockyardShopTabViewModel SellViewModel = new DockyardShopTabViewModel();

		// Token: 0x0401C936 RID: 117046
		protected DockyardShopPlotPanel PlotPanel;

		// Token: 0x0401C937 RID: 117047
		[Nullable(2)]
		protected TsUiBlur UiBlur;

		// Token: 0x0401C938 RID: 117048
		[Nullable(2)]
		protected IUiViewInfoForTimeDilation CacheData;

		// Token: 0x0200B1C0 RID: 45504
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F29 RID: 225065
			public const int CaptionItem = 0;

			// Token: 0x04036F2A RID: 225066
			public const int TabComponent = 1;

			// Token: 0x04036F2B RID: 225067
			public const int ShopTabItem = 2;

			// Token: 0x04036F2C RID: 225068
			public const int BuyTabItem = 3;

			// Token: 0x04036F2D RID: 225069
			public const int PlotItem = 4;
		}
	}
}
