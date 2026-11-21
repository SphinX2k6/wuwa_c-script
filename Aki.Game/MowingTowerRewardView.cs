using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000842 RID: 2114
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerRewardView : UiViewBase
{
	// Token: 0x06005FE1 RID: 24545 RVA: 0x001E9EC4 File Offset: 0x001E80C4
	public MowingTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x001E9ED0 File Offset: 0x001E80D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06005FE3 RID: 24547 RVA: 0x001E9F58 File Offset: 0x001E8158
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
		this.CaptionItem.SetTitleByTextIdAndArgNew("MowingTowerRewardViewTitle", Array.Empty<object>());
		EventSystem.Instance.Add(EEventName.RefreshMowingTowerReward, new Action(this.RefreshRewardLayout));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.TabDataLayout = new GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo>(base.GetVerticalLayout(1), new Func<MowingTowerRewardTabItem>(this.CreateMowingTowerRewardTabItem), null, false, true);
		this.RewardLayout = new GenericLayout<MowingTowerRewardItem, IActivityRewardData>(base.GetVerticalLayout(3), new Func<MowingTowerRewardItem>(this.CreateMowingTowerRewardItem), null, false, true);
		MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(MowingTowerModel.Instance.CurrentSelectActivityId) as MowingTowerData;
		this.MowingTowerData = mowingTowerData;
	}

	// Token: 0x06005FE4 RID: 24548 RVA: 0x001EA034 File Offset: 0x001E8234
	protected override void OnBeforeShow()
	{
		List<MowingTowerLevelDetailInfo> data = new List<MowingTowerLevelDetailInfo>(this.MowingTowerData.GetMowingTowerLevelDetailInfo());
		GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo> tabDataLayout = this.TabDataLayout;
		if (tabDataLayout != null)
		{
			tabDataLayout.RefreshByData(data, delegate
			{
				GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo> tabDataLayout2 = this.TabDataLayout;
				List<MowingTowerRewardTabItem> list = (tabDataLayout2 != null) ? tabDataLayout2.GetLayoutItemList() : null;
				if (list == null)
				{
					return;
				}
				for (int i = 0; i < list.Count; i++)
				{
					MowingTowerRewardTabItem mowingTowerRewardTabItem = list[i];
					mowingTowerRewardTabItem.SetRedDotActive(this.MowingTowerData.HaveLevelRewardCanTake(mowingTowerRewardTabItem.GetLevelId().GetValueOrDefault()));
				}
			}, false);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06005FE5 RID: 24549 RVA: 0x001EA091 File Offset: 0x001E8291
	private MowingTowerRewardTabItem CreateMowingTowerRewardTabItem()
	{
		MowingTowerRewardTabItem mowingTowerRewardTabItem = new MowingTowerRewardTabItem();
		mowingTowerRewardTabItem.SetClickCallBack(new Action<MowingTowerRewardTabItem>(this.ClickTabToggle));
		return mowingTowerRewardTabItem;
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x001EA0AA File Offset: 0x001E82AA
	private MowingTowerRewardItem CreateMowingTowerRewardItem()
	{
		return new MowingTowerRewardItem();
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x001EA0B1 File Offset: 0x001E82B1
	private void ClickTabToggle(MowingTowerRewardTabItem item)
	{
		MowingTowerRewardTabItem currentSelectTabItem = this.CurrentSelectTabItem;
		if (currentSelectTabItem != null)
		{
			currentSelectTabItem.SetToggleUnCheck();
		}
		this.CurrentSelectTabItem = item;
		this.RefreshRewardLayout();
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x001EA0D4 File Offset: 0x001E82D4
	private void RefreshRewardLayout()
	{
		MowingTowerData mowingTowerData = this.MowingTowerData;
		MowingTowerRewardTabItem currentSelectTabItem = this.CurrentSelectTabItem;
		List<IActivityRewardData> rewardByLevelId = mowingTowerData.GetRewardByLevelId((currentSelectTabItem != null) ? currentSelectTabItem.GetLevelId() : null);
		GenericLayout<MowingTowerRewardItem, IActivityRewardData> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(rewardByLevelId, delegate
		{
			GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo> tabDataLayout = this.TabDataLayout;
			List<MowingTowerRewardTabItem> list = (tabDataLayout != null) ? tabDataLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				MowingTowerRewardTabItem mowingTowerRewardTabItem = list[i];
				mowingTowerRewardTabItem.SetRedDotActive(this.MowingTowerData.HaveLevelRewardCanTake(mowingTowerRewardTabItem.GetLevelId().GetValueOrDefault()));
			}
		}, true);
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x001EA125 File Offset: 0x001E8325
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMowingTowerReward, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x04003ED9 RID: 16089
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003EDA RID: 16090
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo> TabDataLayout;

	// Token: 0x04003EDB RID: 16091
	[Nullable(2)]
	private MowingTowerRewardTabItem CurrentSelectTabItem;

	// Token: 0x04003EDC RID: 16092
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MowingTowerRewardItem, IActivityRewardData> RewardLayout;

	// Token: 0x04003EDD RID: 16093
	[Nullable(2)]
	private MowingTowerData MowingTowerData;

	// Token: 0x04003EDE RID: 16094
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02006B88 RID: 27528
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402359B RID: 144795
		public const int CaptionItem = 0;

		// Token: 0x0402359C RID: 144796
		public const int TabContentItem = 1;

		// Token: 0x0402359D RID: 144797
		public const int TabItem = 2;

		// Token: 0x0402359E RID: 144798
		public const int RewardContentItem = 3;

		// Token: 0x0402359F RID: 144799
		public const int RewardItem = 4;
	}
}
