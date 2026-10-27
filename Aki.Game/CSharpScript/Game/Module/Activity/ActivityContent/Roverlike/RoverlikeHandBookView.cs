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

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200611D RID: 24861
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeHandBookView : UiViewBase
	{
		// Token: 0x17009186 RID: 37254
		// (get) Token: 0x0603EDC7 RID: 257479 RVA: 0x00F2ECC1 File Offset: 0x00F2CEC1
		[Nullable(2)]
		private RoverlikeActivityData ActivityData
		{
			[NullableContext(2)]
			get
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603EDC8 RID: 257480 RVA: 0x00F2ECD3 File Offset: 0x00F2CED3
		public RoverlikeHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EDC9 RID: 257481 RVA: 0x00F2ECE8 File Offset: 0x00F2CEE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EDCA RID: 257482 RVA: 0x00F2ED51 File Offset: 0x00F2CF51
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603EDCB RID: 257483 RVA: 0x00F2ED70 File Offset: 0x00F2CF70
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeHandBookView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeHandBookView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EDCC RID: 257484 RVA: 0x00F2EDB3 File Offset: 0x00F2CFB3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603EDCD RID: 257485 RVA: 0x00F2EDD1 File Offset: 0x00F2CFD1
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603EDCE RID: 257486 RVA: 0x00F2EDD4 File Offset: 0x00F2CFD4
		private void InitTabComponent()
		{
			CommonTabComponentData<RoverlikeTabItem> data = new CommonTabComponentData<RoverlikeTabItem>(new Func<UUIItem, int?, RoverlikeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoverlikeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0603EDCF RID: 257487 RVA: 0x00F2EE4C File Offset: 0x00F2D04C
		private UniTask RefreshTabListAsync()
		{
			RoverlikeHandBookView.<RefreshTabListAsync>d__14 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoverlikeHandBookView.<RefreshTabListAsync>d__14>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EDD0 RID: 257488 RVA: 0x00F2EE8F File Offset: 0x00F2D08F
		private RoverlikeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoverlikeTabItem();
		}

		// Token: 0x0603EDD1 RID: 257489 RVA: 0x00F2EE98 File Offset: 0x00F2D098
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0603EDD2 RID: 257490 RVA: 0x00F2EED0 File Offset: 0x00F2D0D0
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			RoverlikeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x0603EDD3 RID: 257491 RVA: 0x00F2EF28 File Offset: 0x00F2D128
		private void OnRefreshCommonActivityRedDot(int activityId)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityId != ((activityData != null) ? activityData.Id : 0) || this.ActivityData == null)
			{
				return;
			}
			this.RefreshAllTabRedDot();
		}

		// Token: 0x0603EDD4 RID: 257492 RVA: 0x00F2EF50 File Offset: 0x00F2D150
		private void RefreshAllTabRedDot()
		{
			for (int i = 0; i < this.TabDataList.Count; i++)
			{
				RoverlikeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(i);
				if (tabItemByIndex != null)
				{
					tabItemByIndex.SetRedDotState(this.TabHasRedDot((EUiTabViewName)this.TabDataList[i].ChildViewName));
				}
			}
		}

		// Token: 0x0603EDD5 RID: 257493 RVA: 0x00F2EFAC File Offset: 0x00F2D1AC
		private bool TabHasRedDot(EUiTabViewName viewName)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && viewName == EUiTabViewName.RoverlikeOutsideBlessTabView && activityData.GetNewUnlockedBlessIds().Count > 0;
		}

		// Token: 0x0603EDD6 RID: 257494 RVA: 0x00F2EFE2 File Offset: 0x00F2D1E2
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020D2E RID: 134446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<RoverlikeTabItem> TabComponent;

		// Token: 0x04020D2F RID: 134447
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04020D30 RID: 134448
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04020D31 RID: 134449
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0200C37A RID: 50042
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403AFDF RID: 241631
			CaptionItem,
			// Token: 0x0403AFE0 RID: 241632
			Content
		}
	}
}
