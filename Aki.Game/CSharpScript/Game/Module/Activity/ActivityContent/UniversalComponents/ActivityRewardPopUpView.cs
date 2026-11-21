using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F61 RID: 20321
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRewardPopUpView : UiViewBase
	{
		// Token: 0x0603301E RID: 208926 RVA: 0x00E4C0AD File Offset: 0x00E4A2AD
		public ActivityRewardPopUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603301F RID: 208927 RVA: 0x00E4C0C4 File Offset: 0x00E4A2C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
		}

		// Token: 0x06033020 RID: 208928 RVA: 0x00E4C176 File Offset: 0x00E4A376
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshByData));
		}

		// Token: 0x06033021 RID: 208929 RVA: 0x00E4C194 File Offset: 0x00E4A394
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshByData));
		}

		// Token: 0x06033022 RID: 208930 RVA: 0x00E4C1B4 File Offset: 0x00E4A3B4
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IActivityRewardViewData);
			if (this.Data == null)
			{
				return;
			}
			this.ContentLayout = new GenericLayout<ActivityRewardPopUpContent, IActivityRewardData>(base.GetVerticalLayout(1), new Func<ActivityRewardPopUpContent>(this.InitContentItem), null, false, true);
			this.TabLayout = new GenericLayout<TabItem, IActivityTab>(base.GetHorizontalLayout(4), new Func<TabItem>(this.InitTabItem), null, false, true);
			base.GetText(6).SetUIActive(false);
			this.Refresh();
		}

		// Token: 0x06033023 RID: 208931 RVA: 0x00E4C230 File Offset: 0x00E4A430
		protected ActivityRewardPopUpContent InitContentItem()
		{
			return new ActivityRewardPopUpContent
			{
				CloseViewFunction = delegate()
				{
					base.CloseMe(null);
				}
			};
		}

		// Token: 0x06033024 RID: 208932 RVA: 0x00E4C249 File Offset: 0x00E4A449
		protected TabItem InitTabItem()
		{
			return new TabItem();
		}

		// Token: 0x06033025 RID: 208933 RVA: 0x00E4C250 File Offset: 0x00E4A450
		protected void Refresh()
		{
			this.RefreshTab();
			this.RefreshTitle();
		}

		// Token: 0x06033026 RID: 208934 RVA: 0x00E4C25E File Offset: 0x00E4A45E
		private void RefreshByData(IActivityRewardViewData data)
		{
			if (this.Data != null && data.Source != this.Data.Source)
			{
				return;
			}
			this.Data = data;
			this.Refresh();
		}

		// Token: 0x06033027 RID: 208935 RVA: 0x00E4C290 File Offset: 0x00E4A490
		private void RefreshTab()
		{
			if (this.Data.DataPageList.Count == 0)
			{
				return;
			}
			List<IActivityTab> list = new List<IActivityTab>();
			bool flag = false;
			foreach (IActivityRewardDataPage activityRewardDataPage in this.Data.DataPageList)
			{
				if (!flag && activityRewardDataPage.TabName != null && !StringUtils.IsEmpty(activityRewardDataPage.TabName))
				{
					flag = true;
				}
				ActivityTab item = new ActivityTab
				{
					TabData = activityRewardDataPage,
					TabFunction = new Action<int>(this.TabFunction),
					TabCanExecuteFunction = new Func<bool, int, bool>(this.TabCanExecuteFunction)
				};
				list.Add(item);
			}
			GenericLayout<TabItem, IActivityTab> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.RefreshByData(list, delegate
				{
					TabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(this.SelectOnTabIndex);
					if (layoutItemByIndex == null)
					{
						return;
					}
					layoutItemByIndex.SetTabToggleState(true, new bool?(true));
				}, false);
			}
			base.GetItem(3).SetUIActive(flag);
		}

		// Token: 0x06033028 RID: 208936 RVA: 0x00E4C37C File Offset: 0x00E4A57C
		private void RefreshList(List<IActivityRewardData> dataList)
		{
			this.DataList = dataList;
			GenericLayout<ActivityRewardPopUpContent, IActivityRewardData> contentLayout = this.ContentLayout;
			if (contentLayout == null)
			{
				return;
			}
			contentLayout.RefreshByData(this.DataList, null, false);
		}

		// Token: 0x06033029 RID: 208937 RVA: 0x00E4C39D File Offset: 0x00E4A59D
		[NullableContext(2)]
		private void RefreshTips(bool show, string text = null)
		{
			if (!string.IsNullOrEmpty(text))
			{
				base.GetText(6).SetText(text, true);
			}
			base.GetText(6).SetUIActive(show);
		}

		// Token: 0x0603302A RID: 208938 RVA: 0x00E4C3C2 File Offset: 0x00E4A5C2
		private void RefreshTitle()
		{
			if (!string.IsNullOrEmpty(this.Data.TitleTextId))
			{
				base.GetText(0).ShowTextNew(this.Data.TitleTextId);
				return;
			}
			base.GetText(0).ShowTextNew("PrefabTextItem_2743475244_Text");
		}

		// Token: 0x0603302B RID: 208939 RVA: 0x00E4C400 File Offset: 0x00E4A600
		private void TabFunction(int tabId)
		{
			IActivityRewardDataPage activityRewardDataPage = this.Data.DataPageList[tabId];
			int selectOnTabIndex = this.SelectOnTabIndex;
			this.SelectOnTabIndex = tabId;
			if (selectOnTabIndex >= 0 && selectOnTabIndex != this.SelectOnTabIndex)
			{
				TabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(selectOnTabIndex);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.SetTabToggleState(false, new bool?(false));
				}
			}
			this.RefreshList(activityRewardDataPage.DataList);
			this.RefreshTips(activityRewardDataPage.TabTips != null, activityRewardDataPage.TabTips);
		}

		// Token: 0x0603302C RID: 208940 RVA: 0x00E4C479 File Offset: 0x00E4A679
		private bool TabCanExecuteFunction(bool isSelected, int tabId)
		{
			return true;
		}

		// Token: 0x0401B130 RID: 110896
		[Nullable(2)]
		protected IActivityRewardViewData Data;

		// Token: 0x0401B131 RID: 110897
		protected List<IActivityRewardData> DataList = new List<IActivityRewardData>();

		// Token: 0x0401B132 RID: 110898
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<ActivityRewardPopUpContent, IActivityRewardData> ContentLayout;

		// Token: 0x0401B133 RID: 110899
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TabItem, IActivityTab> TabLayout;

		// Token: 0x0401B134 RID: 110900
		private int SelectOnTabIndex;
	}
}
