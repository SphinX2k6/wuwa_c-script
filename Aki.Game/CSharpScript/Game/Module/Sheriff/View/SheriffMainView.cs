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
	// Token: 0x02004C58 RID: 19544
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainView : UiViewBase
	{
		// Token: 0x0603286B RID: 206955 RVA: 0x00BC517B File Offset: 0x00BC337B
		public SheriffMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603286C RID: 206956 RVA: 0x00BC5190 File Offset: 0x00BC3390
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

		// Token: 0x0603286D RID: 206957 RVA: 0x00BC5278 File Offset: 0x00BC3478
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603286E RID: 206958 RVA: 0x00BC52BC File Offset: 0x00BC34BC
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

		// Token: 0x0603286F RID: 206959 RVA: 0x00BC543C File Offset: 0x00BC363C
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

		// Token: 0x06032870 RID: 206960 RVA: 0x00BC5480 File Offset: 0x00BC3680
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06032871 RID: 206961 RVA: 0x00BC549C File Offset: 0x00BC369C
		protected void RefreshDialogBeforeSelectClue()
		{
			List<string> beforeDialogStateId = this.Proxy.GetBeforeDialogStateId();
			this.DialogPanel.SetUiActive(beforeDialogStateId.Count > 0);
			this.DialogPanel.Refresh(beforeDialogStateId);
		}

		// Token: 0x06032872 RID: 206962 RVA: 0x00BC54D8 File Offset: 0x00BC36D8
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

		// Token: 0x06032873 RID: 206963 RVA: 0x00BC552C File Offset: 0x00BC372C
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

		// Token: 0x06032874 RID: 206964 RVA: 0x00BC5578 File Offset: 0x00BC3778
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

		// Token: 0x06032875 RID: 206965 RVA: 0x00BC55D4 File Offset: 0x00BC37D4
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

		// Token: 0x06032876 RID: 206966 RVA: 0x00BC5620 File Offset: 0x00BC3820
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

		// Token: 0x06032877 RID: 206967 RVA: 0x00BC566C File Offset: 0x00BC386C
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

		// Token: 0x06032878 RID: 206968 RVA: 0x00BC56B6 File Offset: 0x00BC38B6
		private void OnGameplayAllEndCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032879 RID: 206969 RVA: 0x00BC56BF File Offset: 0x00BC38BF
		private void OnClickedReplayDialog()
		{
			this.RefreshDialogBeforeSelectClue();
		}

		// Token: 0x0603287A RID: 206970 RVA: 0x00BC56C7 File Offset: 0x00BC38C7
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

		// Token: 0x0603287B RID: 206971 RVA: 0x00BC56E6 File Offset: 0x00BC38E6
		private void OnClickBtnTips()
		{
			this.Proxy.SetNeedHintToggle(true);
			this.Proxy.RefreshHintToggleState();
		}

		// Token: 0x0603287C RID: 206972 RVA: 0x00BC5700 File Offset: 0x00BC3900
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

		// Token: 0x0603287D RID: 206973 RVA: 0x00BC5751 File Offset: 0x00BC3951
		private void OnRefreshHintButton(bool isCurIndex)
		{
			this.RefreshHintButton(isCurIndex);
		}

		// Token: 0x0401AE57 RID: 110167
		protected SheriffMainDialogPanel DialogPanel;

		// Token: 0x0401AE58 RID: 110168
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401AE59 RID: 110169
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401AE5A RID: 110170
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE5B RID: 110171
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401AE5C RID: 110172
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200ADFB RID: 44539
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034D83 RID: 216451
			public const int Caption = 0;

			// Token: 0x04034D84 RID: 216452
			public const int Content = 1;

			// Token: 0x04034D85 RID: 216453
			public const int BtnTips = 2;

			// Token: 0x04034D86 RID: 216454
			public const int DialogItem = 3;
		}
	}
}
