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
	// Token: 0x0200509B RID: 20635
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeHandBookView : UiViewBase
	{
		// Token: 0x170064E8 RID: 25832
		// (get) Token: 0x06033A89 RID: 211593 RVA: 0x00E75AD5 File Offset: 0x00E73CD5
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

		// Token: 0x06033A8A RID: 211594 RVA: 0x00E75AE7 File Offset: 0x00E73CE7
		public RoverlikeHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A8B RID: 211595 RVA: 0x00E75AFC File Offset: 0x00E73CFC
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

		// Token: 0x06033A8C RID: 211596 RVA: 0x00E75B65 File Offset: 0x00E73D65
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033A8D RID: 211597 RVA: 0x00E75B84 File Offset: 0x00E73D84
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeHandBookView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeHandBookView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A8E RID: 211598 RVA: 0x00E75BC7 File Offset: 0x00E73DC7
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033A8F RID: 211599 RVA: 0x00E75BE5 File Offset: 0x00E73DE5
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06033A90 RID: 211600 RVA: 0x00E75BE8 File Offset: 0x00E73DE8
		private void InitTabComponent()
		{
			CommonTabComponentData<RoverlikeTabItem> data = new CommonTabComponentData<RoverlikeTabItem>(new Func<UUIItem, int?, RoverlikeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoverlikeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06033A91 RID: 211601 RVA: 0x00E75C60 File Offset: 0x00E73E60
		private UniTask RefreshTabListAsync()
		{
			RoverlikeHandBookView.<RefreshTabListAsync>d__14 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoverlikeHandBookView.<RefreshTabListAsync>d__14>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A92 RID: 211602 RVA: 0x00E75CA3 File Offset: 0x00E73EA3
		private RoverlikeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoverlikeTabItem();
		}

		// Token: 0x06033A93 RID: 211603 RVA: 0x00E75CAC File Offset: 0x00E73EAC
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06033A94 RID: 211604 RVA: 0x00E75CE4 File Offset: 0x00E73EE4
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			RoverlikeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x06033A95 RID: 211605 RVA: 0x00E75D3C File Offset: 0x00E73F3C
		private void OnRefreshCommonActivityRedDot(int activityId)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityId != ((activityData != null) ? activityData.Id : 0) || this.ActivityData == null)
			{
				return;
			}
			this.RefreshAllTabRedDot();
		}

		// Token: 0x06033A96 RID: 211606 RVA: 0x00E75D64 File Offset: 0x00E73F64
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

		// Token: 0x06033A97 RID: 211607 RVA: 0x00E75DC0 File Offset: 0x00E73FC0
		private bool TabHasRedDot(EUiTabViewName viewName)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && viewName == EUiTabViewName.RoverlikeOutsideBlessTabView && activityData.GetNewUnlockedBlessIds().Count > 0;
		}

		// Token: 0x06033A98 RID: 211608 RVA: 0x00E75DF6 File Offset: 0x00E73FF6
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B65B RID: 112219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<RoverlikeTabItem> TabComponent;

		// Token: 0x0401B65C RID: 112220
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401B65D RID: 112221
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B65E RID: 112222
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0200AD62 RID: 44386
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035944 RID: 219460
			CaptionItem,
			// Token: 0x04035945 RID: 219461
			Content
		}
	}
}
