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

// Token: 0x02001392 RID: 5010
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryLimitTaskScoreItem : GridProxyAbstract<HonamiStoryScoreRewardData>
{
	// Token: 0x0600C6A0 RID: 50848 RVA: 0x003B3040 File Offset: 0x003B1240
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

	// Token: 0x0600C6A1 RID: 50849 RVA: 0x003B30EC File Offset: 0x003B12EC
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		this.RewardItemLevelSequence = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600C6A2 RID: 50850 RVA: 0x003B316D File Offset: 0x003B136D
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer rewardItemLevelSequence = this.RewardItemLevelSequence;
		if (rewardItemLevelSequence != null)
		{
			rewardItemLevelSequence.Clear();
		}
		this.RewardItemLevelSequence = null;
	}

	// Token: 0x0600C6A3 RID: 50851 RVA: 0x003B3188 File Offset: 0x003B1388
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

	// Token: 0x0600C6A4 RID: 50852 RVA: 0x003B3264 File Offset: 0x003B1464
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

	// Token: 0x0600C6A5 RID: 50853 RVA: 0x003B332C File Offset: 0x003B152C
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		if (this.Data.State != EHonamiStoryCollectState.Finished)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x04007138 RID: 28984
	private HonamiStoryScoreRewardData Data;

	// Token: 0x04007139 RID: 28985
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400713A RID: 28986
	private TItem? RewardItem;

	// Token: 0x0400713B RID: 28987
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400713C RID: 28988
	[Nullable(2)]
	private LevelSequencePlayer RewardItemLevelSequence;

	// Token: 0x02007635 RID: 30261
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026628 RID: 157224
		RewardItem,
		// Token: 0x04026629 RID: 157225
		SpriteBg,
		// Token: 0x0402662A RID: 157226
		PnlCanGet,
		// Token: 0x0402662B RID: 157227
		TxtPointNum
	}
}
