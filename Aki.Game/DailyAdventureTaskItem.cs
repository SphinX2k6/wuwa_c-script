using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006CA RID: 1738
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyAdventureTaskItem : GridProxyAbstract<DailyAdventureTaskData>
{
	// Token: 0x06004F99 RID: 20377 RVA: 0x001ABA84 File Offset: 0x001A9C84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.ButtonJump));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x001ABC14 File Offset: 0x001A9E14
	protected override UniTask OnBeforeStartAsync()
	{
		DailyAdventureTaskItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DailyAdventureTaskItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x001ABC58 File Offset: 0x001A9E58
	private UniTask CreateRewardItem(AActor item)
	{
		DailyAdventureTaskItem.<CreateRewardItem>d__9 <CreateRewardItem>d__;
		<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRewardItem>d__.<>4__this = this;
		<CreateRewardItem>d__.item = item;
		<CreateRewardItem>d__.<>1__state = -1;
		<CreateRewardItem>d__.<>t__builder.Start<DailyAdventureTaskItem.<CreateRewardItem>d__9>(ref <CreateRewardItem>d__);
		return <CreateRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x06004F9C RID: 20380 RVA: 0x001ABCA4 File Offset: 0x001A9EA4
	private void HandleRewardItemClick(MediumItemGridExtendCallback parameter)
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.TaskState != ERewardState.FinishedAndUnClaimed)
		{
			IItemGridData itemGridData = parameter.Data as IItemGridData;
			ItemController.Instance.OpenItemTipsByItemId(itemGridData.Item.ItemData.ItemId, true, null, false);
			return;
		}
		ActivityDailyAdventureController.Instance.RequestTaskReward(this.Data.TaskId);
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x001ABD08 File Offset: 0x001A9F08
	public override void Refresh(DailyAdventureTaskData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		DailyAdventureTask? dailyAdventureTaskConfig = ActivityDailyAdventureConfig.Instance.GetDailyAdventureTaskConfig(data.TaskId);
		if (dailyAdventureTaskConfig == null)
		{
			return;
		}
		List<string> list = new List<string>(dailyAdventureTaskConfig.Value.TaskFunc());
		if (list.Count >= 1)
		{
			this.TaskJumpType = (EDailyAdventureTaskJumpType)int.Parse(list[0]);
		}
		if (list.Count >= 2)
		{
			this.TaskJumpParams = list.GetRange(1, list.Count - 1);
			if (this.TaskJumpType == EDailyAdventureTaskJumpType.Map)
			{
				this.TaskJumpParams.Add(ActivityDailyAdventureController.Instance.GetDefaultMapMarkId().ToString());
			}
		}
		List<TItem> list2 = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dailyAdventureTaskConfig.Value.TaskReward())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = value
			};
			list2.Add(item);
		}
		if (list2.Count != 1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[日常探险活动] 任务奖励配置不正确";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskId", this.Data.TaskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ItemGridData data2 = new ItemGridData
		{
			Item = list2[0],
			HasClaimed = (this.Data.TaskState == ERewardState.FinishedAndClaimed)
		};
		this.RewardItemGrid.Refresh(data2, this.Data.TaskState == ERewardState.FinishedAndUnClaimed, this.Data.TaskState == ERewardState.Progress);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(dailyAdventureTaskConfig.Value.TaskTitle, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Text_ActivityTaskProgress_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			this.Data.CurrentProgress.ToString(),
			this.Data.TargetProgress.ToString()
		}));
		bool flag = !StringUtils.IsEmpty(dailyAdventureTaskConfig.Value.TaskDescription);
		base.GetItem(4).SetUIActive(flag);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), dailyAdventureTaskConfig.Value.TaskDescription, Array.Empty<object>());
		}
		this.RefreshState(data.TaskState);
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x001ABF90 File Offset: 0x001AA190
	private void RefreshState(ERewardState state)
	{
		switch (state)
		{
		case ERewardState.FinishedAndUnClaimed:
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.SetTextChangeColor(true);
			this.SetIconChangeColor(true);
			base.GetSprite(6).SetAlpha(1f);
			return;
		case ERewardState.Progress:
		{
			bool flag = this.TaskJumpType != EDailyAdventureTaskJumpType.Normal;
			base.GetButton(5).RootUIComp.Get().SetUIActive(flag);
			base.GetItem(7).SetUIActive(!flag);
			this.SetTextChangeColor(false);
			this.SetIconChangeColor(false);
			base.GetSprite(6).SetAlpha(1f);
			return;
		}
		case ERewardState.FinishedAndClaimed:
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.SetTextChangeColor(false);
			this.SetIconChangeColor(false);
			base.GetSprite(6).SetAlpha(0.5f);
			return;
		default:
			return;
		}
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x001AC094 File Offset: 0x001AA294
	private void SetTextChangeColor(bool useChangeColor)
	{
		UUIItem text = base.GetText(3);
		FColor? fcolor = new FColor?(base.GetText(3).changeColor);
		text.SetChangeColor(useChangeColor, fcolor);
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x001AC0C4 File Offset: 0x001AA2C4
	private void SetIconChangeColor(bool useChangeColor)
	{
		UUIItem sprite = base.GetSprite(2);
		FColor? fcolor = new FColor?(base.GetSprite(2).changeColor);
		sprite.SetChangeColor(useChangeColor, fcolor);
	}

	// Token: 0x06004FA1 RID: 20385 RVA: 0x001AC0F2 File Offset: 0x001AA2F2
	private void ButtonJump()
	{
		if (this.Data == null || this.Data.TaskState != ERewardState.Progress)
		{
			return;
		}
		DailyAdventureTaskController.Instance.TrackTaskByType(this.TaskJumpType, this.TaskJumpParams.ToArray());
	}

	// Token: 0x06004FA2 RID: 20386 RVA: 0x001AC126 File Offset: 0x001AA326
	private void ButtonReward()
	{
		if (this.Data == null || this.Data.TaskState != ERewardState.FinishedAndUnClaimed)
		{
			return;
		}
		ActivityDailyAdventureController.Instance.RequestTaskReward(this.Data.TaskId);
	}

	// Token: 0x04003962 RID: 14690
	[Nullable(2)]
	private DailyAdventureTaskData Data;

	// Token: 0x04003963 RID: 14691
	[Nullable(2)]
	private DailyAdventureSmallGridItem RewardItemGrid;

	// Token: 0x04003964 RID: 14692
	protected EDailyAdventureTaskJumpType TaskJumpType = EDailyAdventureTaskJumpType.Normal;

	// Token: 0x04003965 RID: 14693
	protected List<string> TaskJumpParams = new List<string>();

	// Token: 0x04003966 RID: 14694
	private const float NORMAL_BG_ALPHA = 1f;

	// Token: 0x04003967 RID: 14695
	private const float CLAMIED_BG_ALPHA = 0.5f;

	// Token: 0x02006982 RID: 27010
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022BE4 RID: 142308
		public const int ButtonReward = 0;

		// Token: 0x04022BE5 RID: 142309
		public const int Item = 1;

		// Token: 0x04022BE6 RID: 142310
		public const int SpriteIcon = 2;

		// Token: 0x04022BE7 RID: 142311
		public const int TxtName = 3;

		// Token: 0x04022BE8 RID: 142312
		public const int TxtInfo = 4;

		// Token: 0x04022BE9 RID: 142313
		public const int ButtonJump = 5;

		// Token: 0x04022BEA RID: 142314
		public const int SpriteBg = 6;

		// Token: 0x04022BEB RID: 142315
		public const int TxtOngoing = 7;
	}
}
