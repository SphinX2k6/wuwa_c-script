using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200135A RID: 4954
[NullableContext(1)]
[Nullable(0)]
public class RewardTargetData
{
	// Token: 0x06008A0A RID: 35338 RVA: 0x001D7F82 File Offset: 0x001D6182
	public RewardTargetData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06008A0B RID: 35339 RVA: 0x001D7FA3 File Offset: 0x001D61A3
	public bool IsFinished()
	{
		return this.Status == TrackMoonTargetState.TrackMoonTargetFinish;
	}

	// Token: 0x06008A0C RID: 35340 RVA: 0x001D7FAE File Offset: 0x001D61AE
	public bool IsTaken()
	{
		return this.Status == TrackMoonTargetState.TrackMoonTargetTaken;
	}

	// Token: 0x06008A0D RID: 35341 RVA: 0x001D7FBC File Offset: 0x001D61BC
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

	// Token: 0x06008A0E RID: 35342 RVA: 0x001D8074 File Offset: 0x001D6274
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

	// Token: 0x04003D8C RID: 15756
	public TrackMoonTargetState Status;

	// Token: 0x04003D8D RID: 15757
	private readonly TaskData TaskData = new TaskData();

	// Token: 0x04003D8E RID: 15758
	public readonly int Id;

	// Token: 0x04003D8F RID: 15759
	public int Current;

	// Token: 0x04003D90 RID: 15760
	public int Target = 1;
}
