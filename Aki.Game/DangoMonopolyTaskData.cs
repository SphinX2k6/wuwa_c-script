using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x02000702 RID: 1794
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskData : IStaticVariableResetter
{
	// Token: 0x060052D3 RID: 21203 RVA: 0x001B7F66 File Offset: 0x001B6166
	static DangoMonopolyTaskData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(global::DangoMonopolyTaskData.CreateStaticDefaultValue), new Action(global::DangoMonopolyTaskData.ResetStaticDefaultValue));
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x001B7F85 File Offset: 0x001B6185
	public static void CreateStaticDefaultValue()
	{
		global::DangoMonopolyTaskData.RecycleList = new List<global::DangoMonopolyTaskData>();
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x001B7F91 File Offset: 0x001B6191
	public static void ResetStaticDefaultValue()
	{
		global::DangoMonopolyTaskData.RecycleList = null;
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x001B7F9C File Offset: 0x001B619C
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

	// Token: 0x060052D7 RID: 21207 RVA: 0x001B7FEE File Offset: 0x001B61EE
	public void Recycle()
	{
		if (global::DangoMonopolyTaskData.RecycleList != null)
		{
			global::DangoMonopolyTaskData.RecycleList.Add(this);
		}
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x001B8002 File Offset: 0x001B6202
	private DangoMonopolyTaskData(int id)
	{
		this.Id = id;
	}

	// Token: 0x060052D9 RID: 21209 RVA: 0x001B801C File Offset: 0x001B621C
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

	// Token: 0x060052DA RID: 21210 RVA: 0x001B8084 File Offset: 0x001B6284
	public void ProtoUpdateData(Aki.Protocol.DangoMonopolyTaskData data)
	{
		this.TaskState = data.State;
		this.Progress = data.Progress;
		this.TotalProgress = data.Target;
	}

	// Token: 0x060052DB RID: 21211 RVA: 0x001B80AA File Offset: 0x001B62AA
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

	// Token: 0x060052DC RID: 21212 RVA: 0x001B80C2 File Offset: 0x001B62C2
	public int GetSortResult(global::DangoMonopolyTaskData other)
	{
		if (this.TaskState != other.TaskState)
		{
			return this.GetTaskStateSort() - other.GetTaskStateSort();
		}
		return this.Sort - other.Sort;
	}

	// Token: 0x060052DD RID: 21213 RVA: 0x001B80ED File Offset: 0x001B62ED
	public void JumpSource()
	{
		if (this.Source == 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.Source, null);
	}

	// Token: 0x060052DE RID: 21214 RVA: 0x001B8104 File Offset: 0x001B6304
	public bool IsCanReceive()
	{
		return this.TaskState == DangoMonopolyTaskState.Completed;
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x001B8112 File Offset: 0x001B6312
	public void SetEndTime(long endTime)
	{
		this.EndTime = endTime;
	}

	// Token: 0x060052E0 RID: 21216 RVA: 0x001B811B File Offset: 0x001B631B
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x04003A7F RID: 14975
	public int Id;

	// Token: 0x04003A80 RID: 14976
	public EDangoMonopolyTaskType TaskType;

	// Token: 0x04003A81 RID: 14977
	public string TaskDesc = "";

	// Token: 0x04003A82 RID: 14978
	public int RewardItemId;

	// Token: 0x04003A83 RID: 14979
	public int RewardItemCount;

	// Token: 0x04003A84 RID: 14980
	public DangoMonopolyTaskState TaskState;

	// Token: 0x04003A85 RID: 14981
	public long EndTime;

	// Token: 0x04003A86 RID: 14982
	public int Progress;

	// Token: 0x04003A87 RID: 14983
	public int TotalProgress;

	// Token: 0x04003A88 RID: 14984
	public int Sort;

	// Token: 0x04003A89 RID: 14985
	public int Source;

	// Token: 0x04003A8A RID: 14986
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<global::DangoMonopolyTaskData> RecycleList;
}
