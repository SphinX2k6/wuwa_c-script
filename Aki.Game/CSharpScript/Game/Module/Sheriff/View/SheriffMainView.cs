using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Sheriff.View.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C09 RID: 15369
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainView : UiViewBase
	{
		// Token: 0x0602761E RID: 161310 RVA: 0x00B09DC7 File Offset: 0x00B07FC7
		public SheriffMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602761F RID: 161311 RVA: 0x00B09DDC File Offset: 0x00B07FDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnTips));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027620 RID: 161312 RVA: 0x00B09EC4 File Offset: 0x00B080C4
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027621 RID: 161313 RVA: 0x00B09F08 File Offset: 0x00B08108
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			int gameplayId = (int)this.OpenParam;
			this.Proxy = new SheriffMainProxy(gameplayId);
			this.Proxy.InitData();
			this.Proxy.InitGameDataOnBegin();
			this.Proxy.OnClueRecordsCallback = new Action(this.OnClueRecordsCallback);
			this.Proxy.OnAnalysisClueEndCallback = new Action<bool>(this.OnAnalysisClueEndCallback);
			this.Proxy.OnBackFromDetailClueCallback = new Action(this.OnBackFromDetailClueCallback);
			this.Proxy.OnCheckClueDetailCallback = new Action(this.OnCheckClueDetailCallback);
			this.Proxy.OnConclusionInfoCallback = new Action(this.OnConclusionInfoCallback);
			this.Proxy.OnGameplayAllEndCallback = new Action(this.OnGameplayAllEndCallback);
			this.Proxy.OnClickedReplayDialog = new Action(this.OnClickedReplayDialog);
			this.Proxy.OnRefreshHintButton = new Action<bool>(this.OnRefreshHintButton);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.CaptionItem.SetHelpBtnActive(false);
			this.TabDataList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.SheriffMainView);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06027622 RID: 161314 RVA: 0x00B0A088 File Offset: 0x00B08288
		protected override void OnBeforeShow()
		{
			this.RefreshDialogBeforeSelectClue();
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[0], EUiTabViewName.SheriffMainSelectCluePanel, null, this.Proxy, null);
		}

		// Token: 0x06027623 RID: 161315 RVA: 0x00B0A0CC File Offset: 0x00B082CC
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06027624 RID: 161316 RVA: 0x00B0A0E8 File Offset: 0x00B082E8
		protected void RefreshDialogBeforeSelectClue()
		{
			List<string> beforeDialogStateId = this.Proxy.GetBeforeDialogStateId();
			this.DialogPanel.SetUiActive(beforeDialogStateId.Count > 0);
			this.DialogPanel.Refresh(beforeDialogStateId);
		}

		// Token: 0x06027625 RID: 161317 RVA: 0x00B0A124 File Offset: 0x00B08324
		protected void RefreshHintButton(bool isCurIndex)
		{
			bool flag = this.Proxy.CheckNeedHintButton();
			bool flag2 = isCurIndex && flag;
			base.GetButton(2).RootUIComp.Get().SetUIActive(flag2);
			if (flag2)
			{
				this.LevelSequencePlayer.PlayOrReplaySequenceByName("ClueNotice", false, null);
			}
		}

		// Token: 0x06027626 RID: 161318 RVA: 0x00B0A178 File Offset: 0x00B08378
		private void OnClueRecordsCallback()
		{
			this.CaptionItem.SetUiActive(false);
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[1], EUiTabViewName.SheriffMainAnalysisCluePanel, null, this.Proxy, null);
		}

		// Token: 0x06027627 RID: 161319 RVA: 0x00B0A1C4 File Offset: 0x00B083C4
		private void OnAnalysisClueEndCallback(bool isSuccess)
		{
			this.CaptionItem.SetUiActive(true);
			this.RefreshHintButton(true);
			if (isSuccess)
			{
				this.RefreshDialogBeforeSelectClue();
			}
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[0], EUiTabViewName.SheriffMainSelectCluePanel, null, this.Proxy, null);
		}

		// Token: 0x06027628 RID: 161320 RVA: 0x00B0A220 File Offset: 0x00B08420
		private void OnBackFromDetailClueCallback()
		{
			this.CaptionItem.SetUiActive(true);
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[0], EUiTabViewName.SheriffMainSelectCluePanel, null, this.Proxy, null);
		}

		// Token: 0x06027629 RID: 161321 RVA: 0x00B0A26C File Offset: 0x00B0846C
		private void OnCheckClueDetailCallback()
		{
			this.CaptionItem.SetUiActive(false);
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[2], EUiTabViewName.SheriffMainClueDetailPanel, null, this.Proxy, null);
		}

		// Token: 0x0602762A RID: 161322 RVA: 0x00B0A2B8 File Offset: 0x00B084B8
		private void OnConclusionInfoCallback()
		{
			this.CaptionItem.SetUiActive(false);
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[3], EUiTabViewName.SheriffMainConclusionPanel, null, this.Proxy, null);
		}

		// Token: 0x0602762B RID: 161323 RVA: 0x00B0A302 File Offset: 0x00B08502
		private void OnGameplayAllEndCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602762C RID: 161324 RVA: 0x00B0A30B File Offset: 0x00B0850B
		private void OnClickedReplayDialog()
		{
			this.RefreshDialogBeforeSelectClue();
		}

		// Token: 0x0602762D RID: 161325 RVA: 0x00B0A313 File Offset: 0x00B08513
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return null;
			}
			UiTabViewBase currentTabView = tabViewComponent.GetCurrentTabView();
			if (currentTabView == null)
			{
				return null;
			}
			return currentTabView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0602762E RID: 161326 RVA: 0x00B0A332 File Offset: 0x00B08532
		private void OnClickBtnTips()
		{
			this.Proxy.SetNeedHintToggle(true);
			this.Proxy.RefreshHintToggleState();
		}

		// Token: 0x0602762F RID: 161327 RVA: 0x00B0A34C File Offset: 0x00B0854C
		private void OnClickedClose()
		{
			if (this.Proxy.GetCurQuestionIndex() == 0)
			{
				base.CloseMe(null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SheriffCloseConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06027630 RID: 161328 RVA: 0x00B0A39D File Offset: 0x00B0859D
		private void OnRefreshHintButton(bool isCurIndex)
		{
			this.RefreshHintButton(isCurIndex);
		}

		// Token: 0x040157B4 RID: 87988
		protected SheriffMainDialogPanel DialogPanel;

		// Token: 0x040157B5 RID: 87989
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x040157B6 RID: 87990
		protected PopupCaptionItem CaptionItem;

		// Token: 0x040157B7 RID: 87991
		protected SheriffMainProxy Proxy;

		// Token: 0x040157B8 RID: 87992
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x040157B9 RID: 87993
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009819 RID: 38937
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x0402F728 RID: 194344
			public const int Caption = 0;

			// Token: 0x0402F729 RID: 194345
			public const int Content = 1;

			// Token: 0x0402F72A RID: 194346
			public const int BtnTips = 2;

			// Token: 0x0402F72B RID: 194347
			public const int DialogItem = 3;
		}
	}
}
