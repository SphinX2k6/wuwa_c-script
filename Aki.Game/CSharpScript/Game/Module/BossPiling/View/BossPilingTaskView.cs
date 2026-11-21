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
	// Token: 0x02004BF9 RID: 19449
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingTaskView : UiTickViewBase
	{
		// Token: 0x06030879 RID: 198777 RVA: 0x00D856D2 File Offset: 0x00D838D2
		public BossPilingTaskView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603087A RID: 198778 RVA: 0x00D856DC File Offset: 0x00D838DC
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

		// Token: 0x0603087B RID: 198779 RVA: 0x00D857CC File Offset: 0x00D839CC
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

		// Token: 0x0603087C RID: 198780 RVA: 0x00D858CC File Offset: 0x00D83ACC
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

		// Token: 0x0603087D RID: 198781 RVA: 0x00D858F8 File Offset: 0x00D83AF8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603087E RID: 198782 RVA: 0x00D85916 File Offset: 0x00D83B16
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603087F RID: 198783 RVA: 0x00D85934 File Offset: 0x00D83B34
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x06030880 RID: 198784 RVA: 0x00D85941 File Offset: 0x00D83B41
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnBossPilingReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x06030881 RID: 198785 RVA: 0x00D85960 File Offset: 0x00D83B60
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

		// Token: 0x06030882 RID: 198786 RVA: 0x00D859B1 File Offset: 0x00D83BB1
		private BossPilingRewardTabItem CreateRewardTabItem()
		{
			BossPilingRewardTabItem bossPilingRewardTabItem = new BossPilingRewardTabItem();
			bossPilingRewardTabItem.SetClickCallBack(new Action<BossPilingRewardTabItem>(this.ClickTabToggle));
			return bossPilingRewardTabItem;
		}

		// Token: 0x06030883 RID: 198787 RVA: 0x00D859CA File Offset: 0x00D83BCA
		private BossPilingRewardItem CreateRewardItem()
		{
			return new BossPilingRewardItem();
		}

		// Token: 0x06030884 RID: 198788 RVA: 0x00D859D1 File Offset: 0x00D83BD1
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

		// Token: 0x06030885 RID: 198789 RVA: 0x00D859F4 File Offset: 0x00D83BF4
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

		// Token: 0x04019B00 RID: 105216
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019B01 RID: 105217
		private GenericLayout<BossPilingRewardTabItem, int> TabDataLayout;

		// Token: 0x04019B02 RID: 105218
		[Nullable(2)]
		private BossPilingRewardTabItem CurrentSelectTabItem;

		// Token: 0x04019B03 RID: 105219
		private GenericLayout<BossPilingRewardItem, ActivityRewardData> RewardLayout;

		// Token: 0x04019B04 RID: 105220
		private BossPilingActivityData ActivityData;

		// Token: 0x0200A80D RID: 43021
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04033E7D RID: 212605
			CaptionItem,
			// Token: 0x04033E7E RID: 212606
			TabContentItem,
			// Token: 0x04033E7F RID: 212607
			TabItem,
			// Token: 0x04033E80 RID: 212608
			RewardContentItem,
			// Token: 0x04033E81 RID: 212609
			RewardItem,
			// Token: 0x04033E82 RID: 212610
			TimeRemain
		}
	}
}
