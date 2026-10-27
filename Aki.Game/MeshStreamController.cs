using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

// Token: 0x0200220B RID: 8715
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class MeshStreamController : ControllerBase
{
	// Token: 0x170015A4 RID: 5540
	// (get) Token: 0x06010FE2 RID: 69602 RVA: 0x00424A0F File Offset: 0x00422C0F
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06010FE3 RID: 69603 RVA: 0x00424A14 File Offset: 0x00422C14
	protected override void OnTick(float delta)
	{
		if (this.MeshSteamFinishedTaskSet.Count == 0)
		{
			return;
		}
		foreach (int key in this.MeshSteamFinishedTaskSet)
		{
			MeshStreamTask meshStreamTask;
			if (this.MeshStreamTaskMap.TryGetValue(key, out meshStreamTask))
			{
				MeshStreamTaskContext context = meshStreamTask.Context;
				if (context != null)
				{
					Action onTaskFinish = context.OnTaskFinish;
					if (onTaskFinish != null)
					{
						onTaskFinish();
					}
				}
			}
		}
		this.MeshSteamFinishedTaskSet.Clear();
	}

	// Token: 0x06010FE4 RID: 69604 RVA: 0x00424AA8 File Offset: 0x00422CA8
	public int AddMeshStreamTask(MeshStreamTaskContext context)
	{
		MeshStreamTask meshStreamTask = new MeshStreamTask();
		MeshStreamTask meshStreamTask2 = meshStreamTask;
		int incrementId = this.IncrementId;
		this.IncrementId = incrementId + 1;
		meshStreamTask2.Id = incrementId;
		this.MeshStreamTaskMap[meshStreamTask.Id] = meshStreamTask;
		meshStreamTask.Context = context;
		this.ExecuteTask(meshStreamTask);
		return meshStreamTask.Id;
	}

	// Token: 0x06010FE5 RID: 69605 RVA: 0x00424AF8 File Offset: 0x00422CF8
	private void ExecuteTask(MeshStreamTask task)
	{
		task.MeshStreamFinishDelegate = delegate(in TArray<USkeletalMesh> skeletalMeshArray, in TArray<UStaticMesh> staticMeshes)
		{
			if (task.TaskState == EMeshStreamTaskState.Canceled)
			{
				return;
			}
			task.TaskState = EMeshStreamTaskState.StreamFinished;
			this.MeshSteamFinishedTaskSet.Add(task.Id);
		};
		MeshStreamTask task2 = task;
		MeshStreamTaskContext context = task.Context;
		MeshStreamTaskContext context2 = task.Context;
		FOnStreamedMeshesCompBundleAllMips fonStreamedMeshesCompBundleAllMips = DelegateUtils.ToManualReleaseDelegate<FOnStreamedMeshesCompBundleAllMips>(task.MeshStreamFinishDelegate);
		task2.SteamingHandleId = UKuroMeshTextureFunctionLibrary.ForceMeshesBundleStreamingInAllMips(context.SkeletalMeshes, context2.StaticMeshes, fonStreamedMeshesCompBundleAllMips);
		task.TaskState = EMeshStreamTaskState.Streaming;
	}

	// Token: 0x06010FE6 RID: 69606 RVA: 0x00424B80 File Offset: 0x00422D80
	public void RemoveMeshStreamTask(int taskId)
	{
		MeshStreamTask meshStreamTask;
		if (!this.MeshStreamTaskMap.TryGetValue(taskId, out meshStreamTask))
		{
			return;
		}
		this.MeshStreamTaskMap.Remove(taskId);
		this.MeshSteamFinishedTaskSet.Remove(taskId);
		this.StopMeshStreaming(meshStreamTask);
		meshStreamTask.TaskState = EMeshStreamTaskState.Canceled;
	}

	// Token: 0x06010FE7 RID: 69607 RVA: 0x00424BC6 File Offset: 0x00422DC6
	private void StopMeshStreaming(MeshStreamTask task)
	{
		if (task.SteamingHandleId < 0)
		{
			return;
		}
		UKuroMeshTextureFunctionLibrary.StopMeshesBundleStreamingInAllMips(task.SteamingHandleId);
		if (task.MeshStreamFinishDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(task.MeshStreamFinishDelegate);
		}
		task.SteamingHandleId = -1;
	}

	// Token: 0x06010FE8 RID: 69608 RVA: 0x00424BF8 File Offset: 0x00422DF8
	protected override bool OnClear()
	{
		if (this.MeshStreamTaskMap.Count > 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MeshStream;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[MeshStream] 清理时有未完成的网格体流送任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskCount", this.MeshStreamTaskMap.Count);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.MeshStreamTaskMap.Clear();
		}
		if (this.MeshSteamFinishedTaskSet.Count > 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MeshStream;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[MeshStream] 清理时有未完成的网格体流送回调";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TaskCount", this.MeshSteamFinishedTaskSet.Count);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.MeshSteamFinishedTaskSet.Clear();
		}
		return true;
	}

	// Token: 0x170015A5 RID: 5541
	// (get) Token: 0x06010FE9 RID: 69609 RVA: 0x00424CAA File Offset: 0x00422EAA
	public static MeshStreamController Instance
	{
		get
		{
			return MeshStreamController._Instance;
		}
	}

	// Token: 0x06010FEA RID: 69610 RVA: 0x00424CB1 File Offset: 0x00422EB1
	public static MeshStreamController GetOrCreateInstance()
	{
		if (MeshStreamController._Instance == null)
		{
			MeshStreamController.CreateInstance();
		}
		return MeshStreamController._Instance;
	}

	// Token: 0x06010FEB RID: 69611 RVA: 0x00424CC5 File Offset: 0x00422EC5
	public static bool CreateInstance()
	{
		if (MeshStreamController._Instance != null)
		{
			return true;
		}
		MeshStreamController._Instance = new MeshStreamController();
		return true;
	}

	// Token: 0x06010FEC RID: 69612 RVA: 0x00424CDB File Offset: 0x00422EDB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010FED RID: 69613 RVA: 0x00424CDD File Offset: 0x00422EDD
	public static void ResetStaticDefaultValue()
	{
		MeshStreamController._Instance = null;
	}

	// Token: 0x06010FEE RID: 69614 RVA: 0x00424CE5 File Offset: 0x00422EE5
	static MeshStreamController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MeshStreamController.CreateStaticDefaultValue), new Action(MeshStreamController.ResetStaticDefaultValue));
	}

	// Token: 0x04008155 RID: 33109
	private int IncrementId = 1;

	// Token: 0x04008156 RID: 33110
	private readonly HashSet<int> MeshSteamFinishedTaskSet = new HashSet<int>();

	// Token: 0x04008157 RID: 33111
	private readonly Dictionary<int, MeshStreamTask> MeshStreamTaskMap = new Dictionary<int, MeshStreamTask>();

	// Token: 0x04008158 RID: 33112
	[Nullable(2)]
	private static MeshStreamController _Instance;
}
