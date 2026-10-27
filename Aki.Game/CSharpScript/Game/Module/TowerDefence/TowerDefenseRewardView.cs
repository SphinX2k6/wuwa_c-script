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
	// Token: 0x02004B61 RID: 19297
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRewardView : UiTickViewBase
	{
		// Token: 0x06031F5B RID: 204635 RVA: 0x00B981FC File Offset: 0x00B963FC
		public TowerDefenseRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031F5C RID: 204636 RVA: 0x00B98208 File Offset: 0x00B96408
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

		// Token: 0x06031F5D RID: 204637 RVA: 0x00B982F8 File Offset: 0x00B964F8
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F5E RID: 204638 RVA: 0x00B9833B File Offset: 0x00B9653B
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031F5F RID: 204639 RVA: 0x00B98344 File Offset: 0x00B96544
		protected override void OnStart()
		{
			this.MenuLayout = new GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData>(base.GetScrollViewWithScrollbar(1), new Func<TowerDefenseRewardMenuItem>(this.InitMenuItem), null, false, null);
			this.RewardLayout = new LoopScrollView<TowerDefenseRewardItem, IActivityRewardData>(base.GetLoopScrollViewComponent(5), base.GetLoopScrollViewComponent(5).TemplateGrid, new Func<TowerDefenseRewardItem>(this.InitRewardItem), true);
			EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshByData));
		}

		// Token: 0x06031F60 RID: 204640 RVA: 0x00B983BE File Offset: 0x00B965BE
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshByData));
		}

		// Token: 0x06031F61 RID: 204641 RVA: 0x00B983DC File Offset: 0x00B965DC
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

		// Token: 0x06031F62 RID: 204642 RVA: 0x00B98404 File Offset: 0x00B96604
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

		// Token: 0x06031F63 RID: 204643 RVA: 0x00B98442 File Offset: 0x00B96642
		private TowerDefenseRewardMenuItem InitMenuItem()
		{
			return new TowerDefenseRewardMenuItem
			{
				OnClick = new Action<int>(this.SelectTab)
			};
		}

		// Token: 0x06031F64 RID: 204644 RVA: 0x00B9845B File Offset: 0x00B9665B
		private TowerDefenseRewardItem InitRewardItem()
		{
			return new TowerDefenseRewardItem();
		}

		// Token: 0x06031F65 RID: 204645 RVA: 0x00B98462 File Offset: 0x00B96662
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

		// Token: 0x06031F66 RID: 204646 RVA: 0x00B984A0 File Offset: 0x00B966A0
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

		// Token: 0x06031F67 RID: 204647 RVA: 0x00B98548 File Offset: 0x00B96748
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

		// Token: 0x06031F68 RID: 204648 RVA: 0x00B985A0 File Offset: 0x00B967A0
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

		// Token: 0x06031F69 RID: 204649 RVA: 0x00B98608 File Offset: 0x00B96808
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

		// Token: 0x06031F6A RID: 204650 RVA: 0x00B98670 File Offset: 0x00B96870
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

		// Token: 0x06031F6B RID: 204651 RVA: 0x00B986CC File Offset: 0x00B968CC
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

		// Token: 0x0401AA34 RID: 109108
		[Nullable(2)]
		private IActivityRewardViewData Data;

		// Token: 0x0401AA35 RID: 109109
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401AA36 RID: 109110
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TowerDefenseRewardMenuItem, TowerDefenseRewardMenuItemData> MenuLayout;

		// Token: 0x0401AA37 RID: 109111
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<TowerDefenseRewardItem, IActivityRewardData> RewardLayout;

		// Token: 0x0401AA38 RID: 109112
		private int SelectedTabIndex;

		// Token: 0x0401AA39 RID: 109113
		private float LeftTimeAccumulator;

		// Token: 0x0401AA3A RID: 109114
		private bool LeftTimeActive;

		// Token: 0x0200ACF1 RID: 44273
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040348C3 RID: 215235
			public const int CaptionItem = 0;

			// Token: 0x040348C4 RID: 215236
			public const int MenuScroll = 1;

			// Token: 0x040348C5 RID: 215237
			public const int MenuItem = 2;

			// Token: 0x040348C6 RID: 215238
			public const int LeftTimeItem = 3;

			// Token: 0x040348C7 RID: 215239
			public const int LeftTimeTxt = 4;

			// Token: 0x040348C8 RID: 215240
			public const int RewardScroll = 5;
		}
	}
}
