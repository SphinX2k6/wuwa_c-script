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
	// Token: 0x02006909 RID: 26889
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushRewardView : UiTabViewBase
	{
		// Token: 0x060430D0 RID: 274640 RVA: 0x010561FC File Offset: 0x010543FC
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

		// Token: 0x060430D1 RID: 274641 RVA: 0x010562A7 File Offset: 0x010544A7
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BossRefreshBossRushReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x060430D2 RID: 274642 RVA: 0x010562C5 File Offset: 0x010544C5
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BossRefreshBossRushReward, new Action(this.RefreshRewardLayout));
		}

		// Token: 0x060430D3 RID: 274643 RVA: 0x010562E4 File Offset: 0x010544E4
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TabDataLayout = new GenericLayout<BossRushRewardTabItem, BossRushTaskTab>(base.GetVerticalLayout(0), new Func<BossRushRewardTabItem>(this.CreateBossRushRewardTabItem), null, false, true);
			this.RewardLayout = new GenericLayout<BossRushRewardItem, RewardContentData>(base.GetVerticalLayout(2), new Func<BossRushRewardItem>(this.CreateBossRushRewardItem), null, false, true);
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(BossRushModel.Instance.CurrentSelectActivityId) as BossRushData;
			this.BossRushData = bossRushData;
		}

		// Token: 0x060430D4 RID: 274644 RVA: 0x01056368 File Offset: 0x01054568
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

		// Token: 0x060430D5 RID: 274645 RVA: 0x0105639B File Offset: 0x0105459B
		private void RefreshTabLayout()
		{
			GenericLayout<BossRushRewardTabItem, BossRushTaskTab> tabDataLayout = this.TabDataLayout;
			if (tabDataLayout == null)
			{
				return;
			}
			tabDataLayout.RefreshByData(this.BossRushData.GetBossRushAllTabData(), null, false);
		}

		// Token: 0x060430D6 RID: 274646 RVA: 0x010563BA File Offset: 0x010545BA
		private BossRushRewardTabItem CreateBossRushRewardTabItem()
		{
			BossRushRewardTabItem bossRushRewardTabItem = new BossRushRewardTabItem();
			bossRushRewardTabItem.SetClickCallBack(new Action<BossRushRewardTabItem>(this.ClickTabToggle));
			return bossRushRewardTabItem;
		}

		// Token: 0x060430D7 RID: 274647 RVA: 0x010563D3 File Offset: 0x010545D3
		private BossRushRewardItem CreateBossRushRewardItem()
		{
			return new BossRushRewardItem();
		}

		// Token: 0x060430D8 RID: 274648 RVA: 0x010563DA File Offset: 0x010545DA
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

		// Token: 0x060430D9 RID: 274649 RVA: 0x010563FC File Offset: 0x010545FC
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

		// Token: 0x060430DA RID: 274650 RVA: 0x01056508 File Offset: 0x01054708
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x04022E7E RID: 142974
		private GenericLayout<BossRushRewardTabItem, BossRushTaskTab> TabDataLayout;

		// Token: 0x04022E7F RID: 142975
		private BossRushRewardTabItem CurrentSelectTabItem;

		// Token: 0x04022E80 RID: 142976
		private GenericLayout<BossRushRewardItem, RewardContentData> RewardLayout;

		// Token: 0x04022E81 RID: 142977
		private BossRushData BossRushData;

		// Token: 0x04022E82 RID: 142978
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CAB9 RID: 51897
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403D449 RID: 250953
			public const int TabContentItem = 0;

			// Token: 0x0403D44A RID: 250954
			public const int TabItem = 1;

			// Token: 0x0403D44B RID: 250955
			public const int RewardContentItem = 2;

			// Token: 0x0403D44C RID: 250956
			public const int RewardItem = 3;
		}
	}
}
