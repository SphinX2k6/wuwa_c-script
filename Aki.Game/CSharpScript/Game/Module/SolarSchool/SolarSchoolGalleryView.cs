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

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A27 RID: 23079
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolGalleryView : UiViewBase
	{
		// Token: 0x06038D66 RID: 232806 RVA: 0x00FE96FC File Offset: 0x00FE78FC
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

		// Token: 0x06038D67 RID: 232807 RVA: 0x00FE97C8 File Offset: 0x00FE79C8
		public SolarSchoolGalleryView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D68 RID: 232808 RVA: 0x00FE97DC File Offset: 0x00FE79DC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D69 RID: 232809 RVA: 0x00FE9820 File Offset: 0x00FE7A20
		protected override void OnStart()
		{
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(4), EKeyMode.Default);
			this.TabDataList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.SolarSchoolGalleryView);
			SolarSchoolShortCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetHelpGroupId(703);
			}
			this.SelectTab(SolarSchoolGalleryType.Ending);
		}

		// Token: 0x06038D6A RID: 232810 RVA: 0x00FE9877 File Offset: 0x00FE7A77
		protected override void OnBeforeShow()
		{
			this.UpdateTabRedDot();
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.SetCurrentTabViewState(true);
		}

		// Token: 0x06038D6B RID: 232811 RVA: 0x00FE9890 File Offset: 0x00FE7A90
		protected override void OnBeforeHide()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.SetCurrentTabViewState(false);
		}

		// Token: 0x06038D6C RID: 232812 RVA: 0x00FE98A3 File Offset: 0x00FE7AA3
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06038D6D RID: 232813 RVA: 0x00FE98C0 File Offset: 0x00FE7AC0
		private void SelectTab(SolarSchoolGalleryType tabType)
		{
			SolarSchoolGalleryType? currentTabType = this.CurrentTabType;
			if (tabType == currentTabType.GetValueOrDefault() & currentTabType != null)
			{
				return;
			}
			this.AckTabRedDot(tabType);
			if (this.CurrentTabType != null)
			{
				SolarSchoolGalleryTabItem solarSchoolGalleryTabItem = this.TabDict[this.CurrentTabType.Value];
				if (solarSchoolGalleryTabItem != null)
				{
					solarSchoolGalleryTabItem.SetSelect(false);
				}
			}
			SolarSchoolGalleryTabItem solarSchoolGalleryTabItem2 = this.TabDict[tabType];
			if (solarSchoolGalleryTabItem2 != null)
			{
				solarSchoolGalleryTabItem2.SetSelect(true);
			}
			this.CurrentTabType = new SolarSchoolGalleryType?(tabType);
			UiDynamicTab data = this.TabDataList[tabType - SolarSchoolGalleryType.Ending];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(data, viewName, null, null, null);
		}

		// Token: 0x06038D6E RID: 232814 RVA: 0x00FE997C File Offset: 0x00FE7B7C
		private void AckTabRedDot(SolarSchoolGalleryType tabType)
		{
			if (tabType == SolarSchoolGalleryType.Ending)
			{
				return;
			}
			SolarSchoolActivityData currentActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.AckGalleryTab(tabType);
		}

		// Token: 0x06038D6F RID: 232815 RVA: 0x00FE9999 File Offset: 0x00FE7B99
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			SolarSchoolGalleryEndingTabView solarSchoolGalleryEndingTabView = ((tabViewComponent != null) ? tabViewComponent.GetCurrentTabView() : null) as SolarSchoolGalleryEndingTabView;
			if (solarSchoolGalleryEndingTabView == null)
			{
				return null;
			}
			return solarSchoolGalleryEndingTabView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x06038D70 RID: 232816 RVA: 0x00FE99C0 File Offset: 0x00FE7BC0
		private void UpdateTabRedDot()
		{
			foreach (SolarSchoolGalleryTabItem solarSchoolGalleryTabItem in this.TabDict.Values)
			{
				solarSchoolGalleryTabItem.RefreshRedDot();
			}
		}

		// Token: 0x06038D71 RID: 232817 RVA: 0x00FE9A18 File Offset: 0x00FE7C18
		protected override void OnAfterDestroy()
		{
			if (!SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				return;
			}
			SolarSchoolModel.Instance.ShowSettingView();
		}

		// Token: 0x06038D72 RID: 232818 RVA: 0x00FE9A31 File Offset: 0x00FE7C31
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.UpdateTabRedDot));
		}

		// Token: 0x06038D73 RID: 232819 RVA: 0x00FE9A4F File Offset: 0x00FE7C4F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.UpdateTabRedDot));
		}

		// Token: 0x0401DE9B RID: 122523
		private List<UiDynamicTab> TabDataList;

		// Token: 0x0401DE9C RID: 122524
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401DE9D RID: 122525
		private readonly Dictionary<SolarSchoolGalleryType, SolarSchoolGalleryTabItem> TabDict = new Dictionary<SolarSchoolGalleryType, SolarSchoolGalleryTabItem>();

		// Token: 0x0401DE9E RID: 122526
		private SolarSchoolGalleryType? CurrentTabType;

		// Token: 0x0401DE9F RID: 122527
		[Nullable(2)]
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0200B5F6 RID: 46582
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038448 RID: 230472
			public const int CaptionItem = 0;

			// Token: 0x04038449 RID: 230473
			public const int EndingTabItem = 1;

			// Token: 0x0403844A RID: 230474
			public const int CgTabItem = 2;

			// Token: 0x0403844B RID: 230475
			public const int OpTabItem = 3;

			// Token: 0x0403844C RID: 230476
			public const int TabContentItem = 4;
		}
	}
}
