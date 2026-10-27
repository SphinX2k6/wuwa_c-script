using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x0200124E RID: 4686
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskData : IStaticVariableResetter
{
	// Token: 0x06007F3C RID: 32572 RVA: 0x001AF2AE File Offset: 0x001AD4AE
	static DangoMonopolyTaskData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(global::DangoMonopolyTaskData.CreateStaticDefaultValue), new Action(global::DangoMonopolyTaskData.ResetStaticDefaultValue));
	}

	// Token: 0x06007F3D RID: 32573 RVA: 0x001AF2CD File Offset: 0x001AD4CD
	public static void CreateStaticDefaultValue()
	{
		global::DangoMonopolyTaskData.RecycleList = new List<global::DangoMonopolyTaskData>();
	}

	// Token: 0x06007F3E RID: 32574 RVA: 0x001AF2D9 File Offset: 0x001AD4D9
	public static void ResetStaticDefaultValue()
	{
		global::DangoMonopolyTaskData.RecycleList = null;
	}

	// Token: 0x06007F3F RID: 32575 RVA: 0x001AF2E4 File Offset: 0x001AD4E4
	public static global::DangoMonopolyTaskData Create(DangoMonopolyTask config)
	{
		if (global::DangoMonopolyTaskData.RecycleList != null && global::DangoMonopolyTaskData.RecycleList.Count > 0)
		{
			global::DangoMonopolyTaskData dangoMonopolyTaskData = global::DangoMonopolyTaskData.RecycleList[0];
			global::DangoMonopolyTaskData.RecycleList.RemoveAt(0);
			dangoMonopolyTaskData.Init(config);
			return dangoMonopolyTaskData;
		}
		global::DangoMonopolyTaskData dangoMonopolyTaskData2 = new global::DangoMonopolyTaskData(config.TaskId);
		dangoMonopolyTaskData2.Init(config);
		return dangoMonopolyTaskData2;
	}

	// Token: 0x06007F40 RID: 32576 RVA: 0x001AF336 File Offset: 0x001AD536
	public void Recycle()
	{
		if (global::DangoMonopolyTaskData.RecycleList != null)
		{
			global::DangoMonopolyTaskData.RecycleList.Add(this);
		}
	}

	// Token: 0x06007F41 RID: 32577 RVA: 0x001AF34A File Offset: 0x001AD54A
	private DangoMonopolyTaskData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06007F42 RID: 32578 RVA: 0x001AF364 File Offset: 0x001AD564
	private void Init(DangoMonopolyTask config)
	{
		this.Id = config.TaskId;
		this.TaskType = (EDangoMonopolyTaskType)config.TaskType;
		this.TaskDesc = config.Desc;
		this.RewardItemId = config.ItemId;
		this.RewardItemCount = config.ItemNum;
		this.Sort = config.Sort;
		this.Source = config.Source;
	}

	// Token: 0x06007F43 RID: 32579 RVA: 0x001AF3CC File Offset: 0x001AD5CC
	public void ProtoUpdateData(Aki.Protocol.DangoMonopolyTaskData data)
	{
		this.TaskState = data.State;
		this.Progress = data.Progress;
		this.TotalProgress = data.Target;
	}

	// Token: 0x06007F44 RID: 32580 RVA: 0x001AF3F2 File Offset: 0x001AD5F2
	public int GetTaskStateSort()
	{
		if (this.TaskState == DangoMonopolyTaskState.Completed)
		{
			return 0;
		}
		if (this.TaskState == DangoMonopolyTaskState.NotCompleted)
		{
			return 1;
		}
		return 2;
	}

	// Token: 0x06007F45 RID: 32581 RVA: 0x001AF40A File Offset: 0x001AD60A
	public int GetSortResult(global::DangoMonopolyTaskData other)
	{
		if (this.TaskState != other.TaskState)
		{
			return this.GetTaskStateSort() - other.GetTaskStateSort();
		}
		return this.Sort - other.Sort;
	}

	// Token: 0x06007F46 RID: 32582 RVA: 0x001AF435 File Offset: 0x001AD635
	public void JumpSource()
	{
		if (this.Source == 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.Source, null);
	}

	// Token: 0x06007F47 RID: 32583 RVA: 0x001AF44C File Offset: 0x001AD64C
	public bool IsCanReceive()
	{
		return this.TaskState == DangoMonopolyTaskState.Completed;
	}

	// Token: 0x06007F48 RID: 32584 RVA: 0x001AF45A File Offset: 0x001AD65A
	public void SetEndTime(long endTime)
	{
		this.EndTime = endTime;
	}

	// Token: 0x06007F49 RID: 32585 RVA: 0x001AF463 File Offset: 0x001AD663
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x040039E7 RID: 14823
	public int Id;

	// Token: 0x040039E8 RID: 14824
	public EDangoMonopolyTaskType TaskType;

	// Token: 0x040039E9 RID: 14825
	public string TaskDesc = "";

	// Token: 0x040039EA RID: 14826
	public int RewardItemId;

	// Token: 0x040039EB RID: 14827
	public int RewardItemCount;

	// Token: 0x040039EC RID: 14828
	public DangoMonopolyTaskState TaskState;

	// Token: 0x040039ED RID: 14829
	public long EndTime;

	// Token: 0x040039EE RID: 14830
	public int Progress;

	// Token: 0x040039EF RID: 14831
	public int TotalProgress;

	// Token: 0x040039F0 RID: 14832
	public int Sort;

	// Token: 0x040039F1 RID: 14833
	public int Source;

	// Token: 0x040039F2 RID: 14834
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<global::DangoMonopolyTaskData> RecycleList;
}
