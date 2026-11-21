using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200080E RID: 2062
[NullableContext(1)]
[Nullable(0)]
public class RewardTargetData
{
	// Token: 0x06005DA5 RID: 23973 RVA: 0x001E0DDE File Offset: 0x001DEFDE
	public RewardTargetData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06005DA6 RID: 23974 RVA: 0x001E0DFF File Offset: 0x001DEFFF
	public bool IsFinished()
	{
		return this.Status == TrackMoonTargetState.TrackMoonTargetFinish;
	}

	// Token: 0x06005DA7 RID: 23975 RVA: 0x001E0E0A File Offset: 0x001DF00A
	public bool IsTaken()
	{
		return this.Status == TrackMoonTargetState.TrackMoonTargetTaken;
	}

	// Token: 0x06005DA8 RID: 23976 RVA: 0x001E0E18 File Offset: 0x001DF018
	public List<TItem> GetRewardList()
	{
		Aki.Config.TrackMoonTarget rewardTargetById = MoonChasingRewardConfig.Instance.GetRewardTargetById(this.Id);
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(rewardTargetById.TargetReward);
		List<TItem> list = new List<TItem>();
		foreach (DicIntInt dicIntInt in dropPackage.Value.DropPreviewIter())
		{
			int key = dicIntInt.Key;
			int value = dicIntInt.Value;
			list.Add(new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = value
			});
		}
		return list;
	}

	// Token: 0x06005DA9 RID: 23977 RVA: 0x001E0ED0 File Offset: 0x001DF0D0
	public TaskData ConvertToTaskData()
	{
		Aki.Config.TrackMoonTarget rewardTargetById = MoonChasingRewardConfig.Instance.GetRewardTargetById(this.Id);
		this.TaskData.TaskId = this.Id;
		this.TaskData.IsFinished = this.IsFinished();
		this.TaskData.IsTaken = this.IsTaken();
		this.TaskData.Status = TaskStateResolver.TrackMoonTargetState[this.Status];
		this.TaskData.RewardList = this.GetRewardList();
		this.TaskData.Current = this.Current;
		this.TaskData.Target = this.Target;
		this.TaskData.JumpId = rewardTargetById.TargetFunc;
		this.TaskData.TitleTextId = rewardTargetById.TargetName;
		this.TaskData.ReceiveDelegate = new TaskReceive(MoonChasingController.Instance.TrackMoonTargetRewardRequest);
		return this.TaskData;
	}

	// Token: 0x04003E24 RID: 15908
	public TrackMoonTargetState Status;

	// Token: 0x04003E25 RID: 15909
	private readonly TaskData TaskData = new TaskData();

	// Token: 0x04003E26 RID: 15910
	public readonly int Id;

	// Token: 0x04003E27 RID: 15911
	public int Current;

	// Token: 0x04003E28 RID: 15912
	public int Target = 1;
}
