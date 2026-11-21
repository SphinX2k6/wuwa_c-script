using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B09 RID: 15113
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRewardView : UiTickViewBase
	{
		// Token: 0x06026CEA RID: 158954 RVA: 0x00ADC438 File Offset: 0x00ADA638
		public TowerDefenseRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026CEB RID: 158955 RVA: 0x00ADC444 File Offset: 0x00ADA644
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026CEC RID: 158956 RVA: 0x00ADC534 File Offset: 0x00ADA734
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CED RID: 158957 RVA: 0x00ADC577 File Offset: 0x00ADA777
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026CEE RID: 158958 RVA: 0x00ADC580 File Offset: 0x00ADA780
		protected override void OnStart()
		{
			this.MenuLayout = new GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData>(base.GetScrollViewWithScrollbar(1), new Func<TowerDefenseRewardMenuItem>(this.InitMenuItem), null, false, null);
			this.RewardLayout = new LoopScrollView<TowerDefenseRewardItem, IActivityRewardData>(base.GetLoopScrollViewComponent(5), base.GetLoopScrollViewComponent(5).TemplateGrid, new Func<TowerDefenseRewardItem>(this.InitRewardItem), true);
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshByData));
		}

		// Token: 0x06026CEF RID: 158959 RVA: 0x00ADC5FA File Offset: 0x00ADA7FA
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshByData));
		}

		// Token: 0x06026CF0 RID: 158960 RVA: 0x00ADC618 File Offset: 0x00ADA818
		protected override void OnBeforeShow()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Refresh();
			this.LeftTimeActive = this.RefreshLeftTime();
			this.LeftTimeAccumulator = 0f;
		}

		// Token: 0x06026CF1 RID: 158961 RVA: 0x00ADC640 File Offset: 0x00ADA840
		protected override void OnTick(float delta)
		{
			if (!this.LeftTimeActive)
			{
				return;
			}
			this.LeftTimeAccumulator += delta;
			if (this.LeftTimeAccumulator < 1f)
			{
				return;
			}
			this.LeftTimeAccumulator = 0f;
			this.LeftTimeActive = this.RefreshLeftTime();
		}

		// Token: 0x06026CF2 RID: 158962 RVA: 0x00ADC67E File Offset: 0x00ADA87E
		private TowerDefenseRewardMenuItem InitMenuItem()
		{
			return new TowerDefenseRewardMenuItem
			{
				OnClick = new Action<int>(this.SelectTab)
			};
		}

		// Token: 0x06026CF3 RID: 158963 RVA: 0x00ADC697 File Offset: 0x00ADA897
		private TowerDefenseRewardItem InitRewardItem()
		{
			return new TowerDefenseRewardItem();
		}

		// Token: 0x06026CF4 RID: 158964 RVA: 0x00ADC69E File Offset: 0x00ADA89E
		private void OnRefreshByData(IActivityRewardViewData data)
		{
			if (this.Data != null && data.Source != this.Data.Source)
			{
				return;
			}
			this.Data = data;
			this.RefreshMenuRedDots();
			this.RefreshRewardListByTabIndex(this.SelectedTabIndex);
		}

		// Token: 0x06026CF5 RID: 158965 RVA: 0x00ADC6DC File Offset: 0x00ADA8DC
		private void Refresh()
		{
			List<IActivityRewardDataPage> dataPageList = this.Data.DataPageList;
			if (this.SelectedTabIndex >= dataPageList.Count)
			{
				this.SelectedTabIndex = 0;
			}
			List<TowerDefenseRewardMenuItemData> list = new List<TowerDefenseRewardMenuItemData>();
			for (int i = 0; i < dataPageList.Count; i++)
			{
				list.Add(new TowerDefenseRewardMenuItemData
				{
					Page = dataPageList[i],
					Index = i,
					IsSelected = (i == this.SelectedTabIndex),
					HasRedDot = this.CheckPageHasRedDot(dataPageList[i])
				});
			}
			GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> menuLayout = this.MenuLayout;
			if (menuLayout != null)
			{
				menuLayout.RefreshByData(list, null, false);
			}
			this.RefreshRewardListByTabIndex(this.SelectedTabIndex);
		}

		// Token: 0x06026CF6 RID: 158966 RVA: 0x00ADC784 File Offset: 0x00ADA984
		private void RefreshMenuRedDots()
		{
			List<IActivityRewardDataPage> dataPageList = this.Data.DataPageList;
			for (int i = 0; i < dataPageList.Count; i++)
			{
				GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> menuLayout = this.MenuLayout;
				TowerDefenseRewardMenuItem towerDefenseRewardMenuItem = (menuLayout != null) ? menuLayout.GetScrollItemByIndex(i) : null;
				if (towerDefenseRewardMenuItem != null)
				{
					towerDefenseRewardMenuItem.SetRedDot(this.CheckPageHasRedDot(dataPageList[i]));
				}
			}
		}

		// Token: 0x06026CF7 RID: 158967 RVA: 0x00ADC7DC File Offset: 0x00ADA9DC
		private void SelectTab(int index)
		{
			if (index == this.SelectedTabIndex)
			{
				return;
			}
			int selectedTabIndex = this.SelectedTabIndex;
			this.SelectedTabIndex = index;
			GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> menuLayout = this.MenuLayout;
			if (menuLayout != null)
			{
				TowerDefenseRewardMenuItem scrollItemByIndex = menuLayout.GetScrollItemByIndex(selectedTabIndex);
				if (scrollItemByIndex != null)
				{
					scrollItemByIndex.SetSelected(false);
				}
			}
			GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> menuLayout2 = this.MenuLayout;
			if (menuLayout2 != null)
			{
				TowerDefenseRewardMenuItem scrollItemByIndex2 = menuLayout2.GetScrollItemByIndex(index);
				if (scrollItemByIndex2 != null)
				{
					scrollItemByIndex2.SetSelected(true);
				}
			}
			this.RefreshRewardListByTabIndex(index);
		}

		// Token: 0x06026CF8 RID: 158968 RVA: 0x00ADC844 File Offset: 0x00ADAA44
		private void RefreshRewardListByTabIndex(int index)
		{
			if (index < 0 || index >= this.Data.DataPageList.Count)
			{
				LoopScrollView<TowerDefenseRewardItem, IActivityRewardData> rewardLayout = this.RewardLayout;
				if (rewardLayout == null)
				{
					return;
				}
				rewardLayout.RefreshByData(new List<IActivityRewardData>(), false, null, false);
				return;
			}
			else
			{
				IActivityRewardDataPage activityRewardDataPage = this.Data.DataPageList[index];
				LoopScrollView<TowerDefenseRewardItem, IActivityRewardData> rewardLayout2 = this.RewardLayout;
				if (rewardLayout2 == null)
				{
					return;
				}
				rewardLayout2.RefreshByData(activityRewardDataPage.DataList, false, null, true);
				return;
			}
		}

		// Token: 0x06026CF9 RID: 158969 RVA: 0x00ADC8AC File Offset: 0x00ADAAAC
		private bool CheckPageHasRedDot(IActivityRewardDataPage page)
		{
			using (List<IActivityRewardData>.Enumerator enumerator = page.DataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06026CFA RID: 158970 RVA: 0x00ADC908 File Offset: 0x00ADAB08
		private bool RefreshLeftTime()
		{
			UUIItem item = base.GetItem(3);
			UUIText text = base.GetText(4);
			if (item == null || text == null)
			{
				return false;
			}
			ParsedTowerDefenseMsg orCreateParsedTowerDefenseMsg = TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg();
			if (orCreateParsedTowerDefenseMsg == null)
			{
				item.SetUIActive(false);
				return false;
			}
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(orCreateParsedTowerDefenseMsg, null);
			bool item2 = timeVisibleAndRemainTime.Item1;
			string item3 = timeVisibleAndRemainTime.Item2;
			long item4 = timeVisibleAndRemainTime.Item3;
			if (!item2 || item4 <= 0L)
			{
				item.SetUIActive(false);
				return false;
			}
			item.SetUIActive(true);
			text.SetText(item3, true);
			return true;
		}

		// Token: 0x04015386 RID: 86918
		[Nullable(2)]
		private IActivityRewardViewData Data;

		// Token: 0x04015387 RID: 86919
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04015388 RID: 86920
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> MenuLayout;

		// Token: 0x04015389 RID: 86921
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<TowerDefenseRewardItem, IActivityRewardData> RewardLayout;

		// Token: 0x0401538A RID: 86922
		private int SelectedTabIndex;

		// Token: 0x0401538B RID: 86923
		private float LeftTimeAccumulator;

		// Token: 0x0401538C RID: 86924
		private bool LeftTimeActive;

		// Token: 0x02009710 RID: 38672
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F26C RID: 193132
			public const int CaptionItem = 0;

			// Token: 0x0402F26D RID: 193133
			public const int MenuScroll = 1;

			// Token: 0x0402F26E RID: 193134
			public const int MenuItem = 2;

			// Token: 0x0402F26F RID: 193135
			public const int LeftTimeItem = 3;

			// Token: 0x0402F270 RID: 193136
			public const int LeftTimeTxt = 4;

			// Token: 0x0402F271 RID: 193137
			public const int RewardScroll = 5;
		}
	}
}
