using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F7A RID: 24442
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRewardPopUpView : UiViewBase
	{
		// Token: 0x0603E084 RID: 254084 RVA: 0x00EFA3C5 File Offset: 0x00EF85C5
		public ActivityRewardPopUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E085 RID: 254085 RVA: 0x00EFA3DC File Offset: 0x00EF85DC
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

		// Token: 0x0603E086 RID: 254086 RVA: 0x00EFA48E File Offset: 0x00EF868E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshByData));
		}

		// Token: 0x0603E087 RID: 254087 RVA: 0x00EFA4AC File Offset: 0x00EF86AC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.RefreshByData));
		}

		// Token: 0x0603E088 RID: 254088 RVA: 0x00EFA4CC File Offset: 0x00EF86CC
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

		// Token: 0x0603E089 RID: 254089 RVA: 0x00EFA548 File Offset: 0x00EF8748
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

		// Token: 0x0603E08A RID: 254090 RVA: 0x00EFA561 File Offset: 0x00EF8761
		protected TabItem InitTabItem()
		{
			return new TabItem();
		}

		// Token: 0x0603E08B RID: 254091 RVA: 0x00EFA568 File Offset: 0x00EF8768
		protected void Refresh()
		{
			this.RefreshTab();
			this.RefreshTitle();
		}

		// Token: 0x0603E08C RID: 254092 RVA: 0x00EFA576 File Offset: 0x00EF8776
		private void RefreshByData(IActivityRewardViewData data)
		{
			if (this.Data != null && data.Source != this.Data.Source)
			{
				return;
			}
			this.Data = data;
			this.Refresh();
		}

		// Token: 0x0603E08D RID: 254093 RVA: 0x00EFA5A8 File Offset: 0x00EF87A8
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

		// Token: 0x0603E08E RID: 254094 RVA: 0x00EFA694 File Offset: 0x00EF8894
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

		// Token: 0x0603E08F RID: 254095 RVA: 0x00EFA6B5 File Offset: 0x00EF88B5
		[NullableContext(2)]
		private void RefreshTips(bool show, string text = null)
		{
			if (!string.IsNullOrEmpty(text))
			{
				base.GetText(6).SetText(text, true);
			}
			base.GetText(6).SetUIActive(show);
		}

		// Token: 0x0603E090 RID: 254096 RVA: 0x00EFA6DA File Offset: 0x00EF88DA
		private void RefreshTitle()
		{
			if (!string.IsNullOrEmpty(this.Data.TitleTextId))
			{
				base.GetText(0).ShowTextNew(this.Data.TitleTextId);
				return;
			}
			base.GetText(0).ShowTextNew("PrefabTextItem_2743475244_Text");
		}

		// Token: 0x0603E091 RID: 254097 RVA: 0x00EFA718 File Offset: 0x00EF8918
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

		// Token: 0x0603E092 RID: 254098 RVA: 0x00EFA791 File Offset: 0x00EF8991
		private bool TabCanExecuteFunction(bool isSelected, int tabId)
		{
			return true;
		}

		// Token: 0x0402065E RID: 132702
		[Nullable(2)]
		protected IActivityRewardViewData Data;

		// Token: 0x0402065F RID: 132703
		protected List<IActivityRewardData> DataList = new List<IActivityRewardData>();

		// Token: 0x04020660 RID: 132704
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<ActivityRewardPopUpContent, IActivityRewardData> ContentLayout;

		// Token: 0x04020661 RID: 132705
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TabItem, IActivityTab> TabLayout;

		// Token: 0x04020662 RID: 132706
		private int SelectOnTabIndex;
	}
}
