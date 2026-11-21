using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

// Token: 0x020016EF RID: 5871
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class MeshStreamController : ControllerBase
{
	// Token: 0x170015DB RID: 5595
	// (get) Token: 0x0600E477 RID: 58487 RVA: 0x004315A3 File Offset: 0x0042F7A3
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600E478 RID: 58488 RVA: 0x004315A8 File Offset: 0x0042F7A8
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

	// Token: 0x0600E479 RID: 58489 RVA: 0x0043163C File Offset: 0x0042F83C
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

	// Token: 0x0600E47A RID: 58490 RVA: 0x0043168C File Offset: 0x0042F88C
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

	// Token: 0x0600E47B RID: 58491 RVA: 0x00431714 File Offset: 0x0042F914
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

	// Token: 0x0600E47C RID: 58492 RVA: 0x0043175A File Offset: 0x0042F95A
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

	// Token: 0x0600E47D RID: 58493 RVA: 0x0043178C File Offset: 0x0042F98C
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

	// Token: 0x170015DC RID: 5596
	// (get) Token: 0x0600E47E RID: 58494 RVA: 0x0043183E File Offset: 0x0042FA3E
	public static MeshStreamController Instance
	{
		get
		{
			return MeshStreamController._Instance;
		}
	}

	// Token: 0x0600E47F RID: 58495 RVA: 0x00431845 File Offset: 0x0042FA45
	public static MeshStreamController GetOrCreateInstance()
	{
		if (MeshStreamController._Instance == null)
		{
			MeshStreamController.CreateInstance();
		}
		return MeshStreamController._Instance;
	}

	// Token: 0x0600E480 RID: 58496 RVA: 0x00431859 File Offset: 0x0042FA59
	public static bool CreateInstance()
	{
		if (MeshStreamController._Instance != null)
		{
			return true;
		}
		MeshStreamController._Instance = new MeshStreamController();
		return true;
	}

	// Token: 0x0600E481 RID: 58497 RVA: 0x0043186F File Offset: 0x0042FA6F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E482 RID: 58498 RVA: 0x00431871 File Offset: 0x0042FA71
	public static void ResetStaticDefaultValue()
	{
		MeshStreamController._Instance = null;
	}

	// Token: 0x0600E483 RID: 58499 RVA: 0x00431879 File Offset: 0x0042FA79
	static MeshStreamController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MeshStreamController.CreateStaticDefaultValue), new Action(MeshStreamController.ResetStaticDefaultValue));
	}

	// Token: 0x04008293 RID: 33427
	private int IncrementId = 1;

	// Token: 0x04008294 RID: 33428
	private readonly HashSet<int> MeshSteamFinishedTaskSet = new HashSet<int>();

	// Token: 0x04008295 RID: 33429
	private readonly Dictionary<int, MeshStreamTask> MeshStreamTaskMap = new Dictionary<int, MeshStreamTask>();

	// Token: 0x04008296 RID: 33430
	[Nullable(2)]
	private static MeshStreamController _Instance;
}
