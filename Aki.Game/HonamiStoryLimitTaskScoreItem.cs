using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001ED0 RID: 7888
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryLimitTaskScoreItem : GridProxyAbstract<HonamiStoryScoreRewardData>
{
	// Token: 0x0600F281 RID: 62081 RVA: 0x003A7540 File Offset: 0x003A5740
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F282 RID: 62082 RVA: 0x003A75EC File Offset: 0x003A57EC
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		this.RewardItemLevelSequence = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600F283 RID: 62083 RVA: 0x003A766D File Offset: 0x003A586D
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer rewardItemLevelSequence = this.RewardItemLevelSequence;
		if (rewardItemLevelSequence != null)
		{
			rewardItemLevelSequence.Clear();
		}
		this.RewardItemLevelSequence = null;
	}

	// Token: 0x0600F284 RID: 62084 RVA: 0x003A7688 File Offset: 0x003A5888
	public override void Refresh(HonamiStoryScoreRewardData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.GetText(3).SetText(data.Score.ToString(), true);
		string resourceId;
		if (HonamiStoryDefine.Instance.collectStateToScoreRewardMap.TryGetValue(data.State, out resourceId))
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.Data.DropId);
		bool flag = data.State == EHonamiStoryCollectState.Finished;
		base.GetItem(2).SetUIActive(flag);
		if (flag)
		{
			LevelSequencePlayer rewardItemLevelSequence = this.RewardItemLevelSequence;
			if (rewardItemLevelSequence != null)
			{
				rewardItemLevelSequence.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}
		this.RewardItem = new TItem?(dropPackagePreviewItemList[0]);
		this.RefreshGrid();
	}

	// Token: 0x0600F285 RID: 62085 RVA: 0x003A7764 File Offset: 0x003A5964
	private void RefreshGrid()
	{
		bool lockBlackVisible = this.Data.State == EHonamiStoryCollectState.Unfinished;
		bool value = this.Data.State == EHonamiStoryCollectState.Finished;
		bool value2 = this.Data.State == EHonamiStoryCollectState.GotReward;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = this.Data,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString(),
			IsReceivableVisible = new bool?(value),
			IsReceivedVisible = new bool?(value2),
			IsRedDotVisible = new bool?(value)
		};
		this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.RewardItemGrid.SetLockBlackVisible(lockBlackVisible);
	}

	// Token: 0x0600F286 RID: 62086 RVA: 0x003A782C File Offset: 0x003A5A2C
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		if (this.Data.State != EHonamiStoryCollectState.Finished)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x04007057 RID: 28759
	private HonamiStoryScoreRewardData Data;

	// Token: 0x04007058 RID: 28760
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x04007059 RID: 28761
	private TItem? RewardItem;

	// Token: 0x0400705A RID: 28762
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400705B RID: 28763
	[Nullable(2)]
	private LevelSequencePlayer RewardItemLevelSequence;

	// Token: 0x020084B0 RID: 33968
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B304 RID: 176900
		RewardItem,
		// Token: 0x0402B305 RID: 176901
		SpriteBg,
		// Token: 0x0402B306 RID: 176902
		PnlCanGet,
		// Token: 0x0402B307 RID: 176903
		TxtPointNum
	}
}
