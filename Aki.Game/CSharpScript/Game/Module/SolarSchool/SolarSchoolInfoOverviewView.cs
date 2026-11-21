using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BD RID: 22973
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolInfoOverviewView : SolarSchoolHideHudViewBase
	{
		// Token: 0x060389EC RID: 231916 RVA: 0x00FD7CEE File Offset: 0x00FD5EEE
		[NullableContext(1)]
		public SolarSchoolInfoOverviewView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060389ED RID: 231917 RVA: 0x00FD7D0C File Offset: 0x00FD5F0C
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389EE RID: 231918 RVA: 0x00FD7DB8 File Offset: 0x00FD5FB8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolInfoOverviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolInfoOverviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060389EF RID: 231919 RVA: 0x00FD7DFB File Offset: 0x00FD5FFB
		protected override void OnBeforeShow()
		{
			SolarSchoolInfoOverviewTabItem friendTabItem = this.FriendTabItem;
			if (friendTabItem == null)
			{
				return;
			}
			friendTabItem.SetRedDotVisible(SolarSchoolGamePlayModel.Instance.HasAnyFavorLevelUpPending());
		}

		// Token: 0x060389F0 RID: 231920 RVA: 0x00FD7E18 File Offset: 0x00FD6018
		protected override void OnStart()
		{
			SolarSchoolInfoOverviewViewParam solarSchoolInfoOverviewViewParam = this.OpenParam as SolarSchoolInfoOverviewViewParam;
			EUiTabViewName? euiTabViewName = (solarSchoolInfoOverviewViewParam != null) ? solarSchoolInfoOverviewViewParam.TargetTabViewName : null;
			if (euiTabViewName != null && euiTabViewName.Value == EUiTabViewName.SolarSchoolInfoFriendTabView)
			{
				SolarSchoolInfoOverviewTabItem friendTabItem = this.FriendTabItem;
				if (friendTabItem == null)
				{
					return;
				}
				friendTabItem.SetToggleState(EToggleState.ETT_Checked, true);
				return;
			}
			else
			{
				SolarSchoolInfoOverviewTabItem playerTabItem = this.PlayerTabItem;
				if (playerTabItem == null)
				{
					return;
				}
				playerTabItem.SetToggleState(EToggleState.ETT_Checked, true);
				return;
			}
		}

		// Token: 0x060389F1 RID: 231921 RVA: 0x00FD7E86 File Offset: 0x00FD6086
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x060389F2 RID: 231922 RVA: 0x00FD7EA0 File Offset: 0x00FD60A0
		[NullableContext(1)]
		private SolarSchoolInfoOverviewTabItem CreateTabItem(int index)
		{
			SolarSchoolInfoOverviewTabItem solarSchoolInfoOverviewTabItem = new SolarSchoolInfoOverviewTabItem();
			solarSchoolInfoOverviewTabItem.GridIndex = index;
			solarSchoolInfoOverviewTabItem.SetSelectedCallBack(new Action<int>(this.OnSelectTab));
			solarSchoolInfoOverviewTabItem.SetCanExecuteChange((int tabIndex, bool _) => tabIndex != this.CurrentTabIndex);
			return solarSchoolInfoOverviewTabItem;
		}

		// Token: 0x060389F3 RID: 231923 RVA: 0x00FD7ED4 File Offset: 0x00FD60D4
		private void LoadTabConfig()
		{
			this.TabDataList.Clear();
			this.TabDataList.AddRange(DynamicTabConfig.Instance.GetViewTabList(EUiViewName.SolarSchoolInfoOverviewView));
			foreach (UiDynamicTab value in this.TabDataList)
			{
				EUiTabViewName left = (EUiTabViewName)value.ChildViewName;
				if (left == EUiTabViewName.SolarSchoolInfoPlayerTabView)
				{
					this.PlayerTabData = new UiDynamicTab?(value);
				}
				else if (left == EUiTabViewName.SolarSchoolInfoFriendTabView)
				{
					this.FriendTabData = new UiDynamicTab?(value);
				}
			}
		}

		// Token: 0x060389F4 RID: 231924 RVA: 0x00FD7F8C File Offset: 0x00FD618C
		private void OnSelectTab(int tabIndex)
		{
			if (tabIndex == this.CurrentTabIndex)
			{
				return;
			}
			this.CurrentTabIndex = tabIndex;
			if (tabIndex == 0)
			{
				SolarSchoolInfoOverviewTabItem friendTabItem = this.FriendTabItem;
				if (friendTabItem != null)
				{
					friendTabItem.SetToggleState(EToggleState.ETT_UnChecked, false);
				}
				this.ShowTabView(this.PlayerTabData, EUiTabViewName.SolarSchoolInfoPlayerTabView, this.PlayerTabItem);
				return;
			}
			SolarSchoolInfoOverviewTabItem playerTabItem = this.PlayerTabItem;
			if (playerTabItem != null)
			{
				playerTabItem.SetToggleState(EToggleState.ETT_UnChecked, false);
			}
			this.ShowTabView(this.FriendTabData, EUiTabViewName.SolarSchoolInfoFriendTabView, this.FriendTabItem);
		}

		// Token: 0x060389F5 RID: 231925 RVA: 0x00FD8004 File Offset: 0x00FD6204
		private void ShowTabView(UiDynamicTab? tabData, EUiTabViewName tabViewName, SolarSchoolInfoOverviewTabItem tabItem)
		{
			if (tabData == null)
			{
				TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
				if (tabViewComponent != null)
				{
					tabViewComponent.HideCurrentTabView();
				}
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 角色总览缺少动态页签配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tabViewName", tabViewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			TabViewComponent<UiDynamicTab> tabViewComponent2 = this.TabViewComponent;
			if (tabViewComponent2 == null)
			{
				return;
			}
			tabViewComponent2.ToggleCallBack(tabData.Value, tabViewName, tabItem, this.OpenParam, null);
		}

		// Token: 0x0401DD13 RID: 122131
		[Nullable(1)]
		private readonly List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401DD14 RID: 122132
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401DD15 RID: 122133
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DD16 RID: 122134
		private SolarSchoolInfoOverviewTabItem PlayerTabItem;

		// Token: 0x0401DD17 RID: 122135
		private SolarSchoolInfoOverviewTabItem FriendTabItem;

		// Token: 0x0401DD18 RID: 122136
		private UiDynamicTab? PlayerTabData;

		// Token: 0x0401DD19 RID: 122137
		private UiDynamicTab? FriendTabData;

		// Token: 0x0401DD1A RID: 122138
		private int CurrentTabIndex = -1;

		// Token: 0x0200B566 RID: 46438
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038168 RID: 229736
			public const int Caption = 0;

			// Token: 0x04038169 RID: 229737
			public const int PlayerTab = 1;

			// Token: 0x0403816A RID: 229738
			public const int FriendTab = 2;

			// Token: 0x0403816B RID: 229739
			public const int TabContent = 3;
		}
	}
}
