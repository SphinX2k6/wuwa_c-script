using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C19 RID: 23577
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingTaskView : UiTickViewBase
	{
		// Token: 0x0603B92E RID: 244014 RVA: 0x00E35376 File Offset: 0x00E33576
		public BossPilingTaskView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B92F RID: 244015 RVA: 0x00E35380 File Offset: 0x00E33580
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B930 RID: 244016 RVA: 0x00E35470 File Offset: 0x00E33670
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnBossPilingReward, new Action(this.RefreshRewardLayout));
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.CaptionItem.SetTitleByTextIdAndArgNew("BossPilingActivity_RewardTitle", Array.Empty<object>());
			this.TabDataLayout = new GenericLayout<BossPilingRewardTabItem, int>(base.GetVerticalLayout(1), new Func<BossPilingRewardTabItem>(this.CreateRewardTabItem), null, false, true);
			this.RewardLayout = new GenericLayout<BossPilingRewardItem, ActivityRewardData>(base.GetVerticalLayout(3), new Func<BossPilingRewardItem>(this.CreateRewardItem), null, false, true);
			this.ActivityData = BossPilingModel.Instance.GetActivityData();
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(item);
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(item2, true);
		}

		// Token: 0x0603B931 RID: 244017 RVA: 0x00E35570 File Offset: 0x00E33770
		protected override void OnBeforeShow()
		{
			List<int> taskTabList = this.ActivityData.GetTaskTabList();
			GenericLayout<BossPilingRewardTabItem, int> tabDataLayout = this.TabDataLayout;
			if (tabDataLayout == null)
			{
				return;
			}
			tabDataLayout.RefreshByData(taskTabList, null, true);
		}

		// Token: 0x0603B932 RID: 244018 RVA: 0x00E3559C File Offset: 0x00E3379C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B933 RID: 244019 RVA: 0x00E355BA File Offset: 0x00E337BA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B934 RID: 244020 RVA: 0x00E355D8 File Offset: 0x00E337D8
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x0603B935 RID: 244021 RVA: 0x00E355E5 File Offset: 0x00E337E5
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnBossPilingReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x0603B936 RID: 244022 RVA: 0x00E35604 File Offset: 0x00E33804
		protected override void OnTick(float delta)
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(item);
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(item2, true);
		}

		// Token: 0x0603B937 RID: 244023 RVA: 0x00E35655 File Offset: 0x00E33855
		private BossPilingRewardTabItem CreateRewardTabItem()
		{
			BossPilingRewardTabItem bossPilingRewardTabItem = new BossPilingRewardTabItem();
			bossPilingRewardTabItem.SetClickCallBack(new Action<BossPilingRewardTabItem>(this.ClickTabToggle));
			return bossPilingRewardTabItem;
		}

		// Token: 0x0603B938 RID: 244024 RVA: 0x00E3566E File Offset: 0x00E3386E
		private BossPilingRewardItem CreateRewardItem()
		{
			return new BossPilingRewardItem();
		}

		// Token: 0x0603B939 RID: 244025 RVA: 0x00E35675 File Offset: 0x00E33875
		private void ClickTabToggle(BossPilingRewardTabItem item)
		{
			BossPilingRewardTabItem currentSelectTabItem = this.CurrentSelectTabItem;
			if (currentSelectTabItem != null)
			{
				currentSelectTabItem.SetToggleUnCheck();
			}
			this.CurrentSelectTabItem = item;
			this.RefreshRewardLayout();
		}

		// Token: 0x0603B93A RID: 244026 RVA: 0x00E35698 File Offset: 0x00E33898
		private void RefreshRewardLayout()
		{
			if (this.CurrentSelectTabItem == null)
			{
				return;
			}
			List<ActivityRewardData> taskGroupByLevel = this.ActivityData.GetTaskGroupByLevel(this.CurrentSelectTabItem.GetLevelId());
			GenericLayout<BossPilingRewardItem, ActivityRewardData> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(taskGroupByLevel, delegate
			{
				foreach (BossPilingRewardTabItem bossPilingRewardTabItem in this.TabDataLayout.GetLayoutItemList())
				{
					bossPilingRewardTabItem.RefreshRedDot();
				}
			}, true);
		}

		// Token: 0x0401F04F RID: 127055
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401F050 RID: 127056
		private GenericLayout<BossPilingRewardTabItem, int> TabDataLayout;

		// Token: 0x0401F051 RID: 127057
		[Nullable(2)]
		private BossPilingRewardTabItem CurrentSelectTabItem;

		// Token: 0x0401F052 RID: 127058
		private GenericLayout<BossPilingRewardItem, ActivityRewardData> RewardLayout;

		// Token: 0x0401F053 RID: 127059
		private BossPilingActivityData ActivityData;

		// Token: 0x0200BE05 RID: 48645
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040394BA RID: 234682
			CaptionItem,
			// Token: 0x040394BB RID: 234683
			TabContentItem,
			// Token: 0x040394BC RID: 234684
			TabItem,
			// Token: 0x040394BD RID: 234685
			RewardContentItem,
			// Token: 0x040394BE RID: 234686
			RewardItem,
			// Token: 0x040394BF RID: 234687
			TimeRemain
		}
	}
}
