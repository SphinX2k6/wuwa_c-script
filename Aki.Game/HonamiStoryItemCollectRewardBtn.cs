using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EBD RID: 7869
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryItemCollectRewardBtn : UiPanelBase
{
	// Token: 0x0600F221 RID: 61985 RVA: 0x003A4C80 File Offset: 0x003A2E80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F222 RID: 61986 RVA: 0x003A4D8C File Offset: 0x003A2F8C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemCollectRewardBtn.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemCollectRewardBtn.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F223 RID: 61987 RVA: 0x003A4DD0 File Offset: 0x003A2FD0
	[NullableContext(1)]
	public void RefreshView(HonamiStoryItemCollectionData itemData)
	{
		this.CurSelectItemData = itemData;
		base.GetSprite(2).SetUIActive(this.CurSelectItemData.State == EHonamiStoryCollectState.Finished);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		using (Dictionary<int, int>.Enumerator enumerator = ConfigDropPackageById.GetConfig(itemData.DropId, true).Value.DropPreview().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int itemId = num;
				int count = num2;
				TItem data = new TItem(new InventoryDefine.GetItemData(itemId, 0), count);
				CommonItemSmallItemGrid rewardItem = this.RewardItem;
				if (rewardItem != null)
				{
					rewardItem.Refresh(data);
				}
			}
		}
		this.RewardItem.SetLockBlackVisible(itemData.State == EHonamiStoryCollectState.Unfinished);
		this.RewardItem.SetRedDotVisible(new bool?(itemData.State == EHonamiStoryCollectState.Finished));
		base.GetItem(3).SetUIActive(itemData.State == EHonamiStoryCollectState.Finished);
		base.GetItem(4).SetUIActive(itemData.State == EHonamiStoryCollectState.Finished);
		this.RewardItem.SetReceivedVisible(itemData.State == EHonamiStoryCollectState.GotReward);
	}

	// Token: 0x0600F224 RID: 61988 RVA: 0x003A4F0C File Offset: 0x003A310C
	private void OnClickRewardBtn()
	{
		if (this.CurSelectItemData == null)
		{
			return;
		}
		switch (this.CurSelectItemData.State)
		{
		case EHonamiStoryCollectState.Unfinished:
			ScrollingTipsController.Instance.ShowTipsByTextId("ConditionGroup_12902001_HintText", Array.Empty<object>());
			return;
		case EHonamiStoryCollectState.Finished:
			HonamiStoryController.Instance.SendHonamiStoryItemCollectionRequest(new List<int>
			{
				this.CurSelectItemData.Id
			});
			return;
		case EHonamiStoryCollectState.GotReward:
			return;
		default:
			return;
		}
	}

	// Token: 0x04006FE5 RID: 28645
	private HonamiStoryItemCollectionData CurSelectItemData;

	// Token: 0x04006FE6 RID: 28646
	private CommonItemSmallItemGrid RewardItem;
}
