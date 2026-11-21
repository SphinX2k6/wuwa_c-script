using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02005859 RID: 22617
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushRewardView : UiTabViewBase
	{
		// Token: 0x06037C28 RID: 228392 RVA: 0x00F97830 File Offset: 0x00F95A30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037C29 RID: 228393 RVA: 0x00F978DB File Offset: 0x00F95ADB
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BossRefreshBossRushReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x06037C2A RID: 228394 RVA: 0x00F978F9 File Offset: 0x00F95AF9
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BossRefreshBossRushReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x06037C2B RID: 228395 RVA: 0x00F97918 File Offset: 0x00F95B18
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TabDataLayout = new GenericLayout<BossRushRewardTabItem, BossRushTaskTab>(base.GetVerticalLayout(0), new Func<BossRushRewardTabItem>(this.CreateBossRushRewardTabItem), null, false, true);
			this.RewardLayout = new GenericLayout<BossRushRewardItem, RewardContentData>(base.GetVerticalLayout(2), new Func<BossRushRewardItem>(this.CreateBossRushRewardItem), null, false, true);
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(BossRushModel.Instance.CurrentSelectActivityId) as BossRushData;
			this.BossRushData = bossRushData;
		}

		// Token: 0x06037C2C RID: 228396 RVA: 0x00F9799C File Offset: 0x00F95B9C
		protected override void OnBeforeShow()
		{
			this.RefreshTabLayout();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06037C2D RID: 228397 RVA: 0x00F979CF File Offset: 0x00F95BCF
		private void RefreshTabLayout()
		{
			GenericLayout<BossRushRewardTabItem, BossRushTaskTab> tabDataLayout = this.TabDataLayout;
			if (tabDataLayout == null)
			{
				return;
			}
			tabDataLayout.RefreshByData(this.BossRushData.GetBossRushAllTabData(), null, false);
		}

		// Token: 0x06037C2E RID: 228398 RVA: 0x00F979EE File Offset: 0x00F95BEE
		private BossRushRewardTabItem CreateBossRushRewardTabItem()
		{
			BossRushRewardTabItem bossRushRewardTabItem = new BossRushRewardTabItem();
			bossRushRewardTabItem.SetClickCallBack(new Action<BossRushRewardTabItem>(this.ClickTabToggle));
			return bossRushRewardTabItem;
		}

		// Token: 0x06037C2F RID: 228399 RVA: 0x00F97A07 File Offset: 0x00F95C07
		private BossRushRewardItem CreateBossRushRewardItem()
		{
			return new BossRushRewardItem();
		}

		// Token: 0x06037C30 RID: 228400 RVA: 0x00F97A0E File Offset: 0x00F95C0E
		private void ClickTabToggle(BossRushRewardTabItem item)
		{
			BossRushRewardTabItem currentSelectTabItem = this.CurrentSelectTabItem;
			if (currentSelectTabItem != null)
			{
				currentSelectTabItem.SetToggleUnCheck();
			}
			this.CurrentSelectTabItem = item;
			this.RefreshRewardLayout();
		}

		// Token: 0x06037C31 RID: 228401 RVA: 0x00F97A30 File Offset: 0x00F95C30
		private void RefreshRewardLayout()
		{
			BossRushData bossRushData = this.BossRushData;
			BossRushRewardTabItem currentSelectTabItem = this.CurrentSelectTabItem;
			bool flag;
			if (currentSelectTabItem == null)
			{
				flag = false;
			}
			else
			{
				int tabId = currentSelectTabItem.GetTab().TabId;
				flag = true;
			}
			List<IActivityRewardData> tabRewardData = bossRushData.GetTabRewardData(flag ? this.CurrentSelectTabItem.GetTab().TabId : 0);
			List<RewardContentData> list = new List<RewardContentData>();
			foreach (IActivityRewardData rewardData in tabRewardData)
			{
				list.Add(new RewardContentData
				{
					RewardData = rewardData
				});
			}
			GenericLayout<BossRushRewardItem, RewardContentData> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.RefreshByData(list, null, true);
			}
			GenericLayout<BossRushRewardTabItem, BossRushTaskTab> tabDataLayout = this.TabDataLayout;
			List<BossRushRewardTabItem> list2 = (tabDataLayout != null) ? tabDataLayout.GetLayoutItemList() : null;
			if (list2 == null)
			{
				return;
			}
			foreach (BossRushRewardTabItem bossRushRewardTabItem in list2)
			{
				bossRushRewardTabItem.RefreshRedDot();
			}
		}

		// Token: 0x06037C32 RID: 228402 RVA: 0x00F97B3C File Offset: 0x00F95D3C
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0401D6DA RID: 120538
		private GenericLayout<BossRushRewardTabItem, BossRushTaskTab> TabDataLayout;

		// Token: 0x0401D6DB RID: 120539
		private BossRushRewardTabItem CurrentSelectTabItem;

		// Token: 0x0401D6DC RID: 120540
		private GenericLayout<BossRushRewardItem, RewardContentData> RewardLayout;

		// Token: 0x0401D6DD RID: 120541
		private BossRushData BossRushData;

		// Token: 0x0401D6DE RID: 120542
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B481 RID: 46209
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037D23 RID: 228643
			public const int TabContentItem = 0;

			// Token: 0x04037D24 RID: 228644
			public const int TabItem = 1;

			// Token: 0x04037D25 RID: 228645
			public const int RewardContentItem = 2;

			// Token: 0x04037D26 RID: 228646
			public const int RewardItem = 3;
		}
	}
}
