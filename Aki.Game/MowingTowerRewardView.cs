using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200138E RID: 5006
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerRewardView : UiViewBase
{
	// Token: 0x06008C46 RID: 35910 RVA: 0x001E1070 File Offset: 0x001DF270
	public MowingTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008C47 RID: 35911 RVA: 0x001E107C File Offset: 0x001DF27C
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

	// Token: 0x06008C48 RID: 35912 RVA: 0x001E1104 File Offset: 0x001DF304
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

	// Token: 0x06008C49 RID: 35913 RVA: 0x001E11E0 File Offset: 0x001DF3E0
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

	// Token: 0x06008C4A RID: 35914 RVA: 0x001E123D File Offset: 0x001DF43D
	private MowingTowerRewardTabItem CreateMowingTowerRewardTabItem()
	{
		MowingTowerRewardTabItem mowingTowerRewardTabItem = new MowingTowerRewardTabItem();
		mowingTowerRewardTabItem.SetClickCallBack(new Action<MowingTowerRewardTabItem>(this.ClickTabToggle));
		return mowingTowerRewardTabItem;
	}

	// Token: 0x06008C4B RID: 35915 RVA: 0x001E1256 File Offset: 0x001DF456
	private MowingTowerRewardItem CreateMowingTowerRewardItem()
	{
		return new MowingTowerRewardItem();
	}

	// Token: 0x06008C4C RID: 35916 RVA: 0x001E125D File Offset: 0x001DF45D
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

	// Token: 0x06008C4D RID: 35917 RVA: 0x001E1280 File Offset: 0x001DF480
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

	// Token: 0x06008C4E RID: 35918 RVA: 0x001E12D1 File Offset: 0x001DF4D1
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMowingTowerReward, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x04003E41 RID: 15937
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003E42 RID: 15938
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MowingTowerRewardTabItem, MowingTowerLevelDetailInfo> TabDataLayout;

	// Token: 0x04003E43 RID: 15939
	[Nullable(2)]
	private MowingTowerRewardTabItem CurrentSelectTabItem;

	// Token: 0x04003E44 RID: 15940
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MowingTowerRewardItem, IActivityRewardData> RewardLayout;

	// Token: 0x04003E45 RID: 15941
	[Nullable(2)]
	private MowingTowerData MowingTowerData;

	// Token: 0x04003E46 RID: 15942
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020079FE RID: 31230
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402826E RID: 164462
		public const int CaptionItem = 0;

		// Token: 0x0402826F RID: 164463
		public const int TabContentItem = 1;

		// Token: 0x04028270 RID: 164464
		public const int TabItem = 2;

		// Token: 0x04028271 RID: 164465
		public const int RewardContentItem = 3;

		// Token: 0x04028272 RID: 164466
		public const int RewardItem = 4;
	}
}
