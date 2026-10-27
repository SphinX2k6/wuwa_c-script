using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x02002CF4 RID: 11508
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WaitEntityTaskModel : ModelBase
{
	// Token: 0x060182A7 RID: 98983 RVA: 0x0062579F File Offset: 0x0062399F
	public void OnAddEntity(long creatureDataId, int pbDataId)
	{
		this.EntityEventHandler(creatureDataId, pbDataId, true);
	}

	// Token: 0x060182A8 RID: 98984 RVA: 0x006257AA File Offset: 0x006239AA
	public void OnRemoveEntity(long creatureDataId, int pbDataId)
	{
		this.EntityEventHandler(creatureDataId, pbDataId, false);
	}

	// Token: 0x060182A9 RID: 98985 RVA: 0x006257B5 File Offset: 0x006239B5
	protected override bool OnInit()
	{
		this.TaskMap = new Dictionary<int, WaitEntityTask>();
		return true;
	}

	// Token: 0x060182AA RID: 98986 RVA: 0x006257C3 File Offset: 0x006239C3
	protected override bool OnClear()
	{
		Dictionary<int, WaitEntityTask> taskMap = this.TaskMap;
		if (taskMap != null)
		{
			taskMap.Clear();
		}
		return true;
	}

	// Token: 0x060182AB RID: 98987 RVA: 0x006257D8 File Offset: 0x006239D8
	public unsafe void AddTask(int taskId, WaitEntityTask task)
	{
		Dictionary<int, WaitEntityTask> taskMap = this.TaskMap;
		if (taskMap == null || !taskMap.TryAdd(taskId, task))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "[WaitEntityTaskModel] AddTask 尝试用一个已经存在的任务ID添加新任务, 阻止添加";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("taskId", taskId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("task", task);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TaskMap", this.TaskMap);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x060182AC RID: 98988 RVA: 0x00625873 File Offset: 0x00623A73
	public void RemoveTask(int taskId)
	{
		Dictionary<int, WaitEntityTask> taskMap = this.TaskMap;
		if (taskMap == null)
		{
			return;
		}
		taskMap.Remove(taskId);
	}

	// Token: 0x060182AD RID: 98989 RVA: 0x00625888 File Offset: 0x00623A88
	private unsafe void EntityEventHandler(long creatureDataId, int pbDataId, bool isAdd)
	{
		if (this.TaskMap == null)
		{
			return;
		}
		int count = this.TaskMap.Count;
		using (PoolArray<WaitEntityTask> poolArray = this.TaskMap.Values.ToPoolArray<WaitEntityTask>())
		{
			foreach (WaitEntityTask waitEntityTask in poolArray)
			{
				if (isAdd)
				{
					waitEntityTask.OnAddEntity(creatureDataId, pbDataId);
				}
				else
				{
					waitEntityTask.OnRemoveEntity(creatureDataId, pbDataId);
				}
				if (this.TaskMap.Count - count >= 10000)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[WaitEntityTaskModel] 可能是WaitEntityTask的Callback中又创建了WaitEntityTask，导致死循环, 请检查";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pbDataId", pbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("task", waitEntityTask);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					break;
				}
			}
		}
	}

	// Token: 0x170020A8 RID: 8360
	// (get) Token: 0x060182AE RID: 98990 RVA: 0x006259B4 File Offset: 0x00623BB4
	public static WaitEntityTaskModel Instance
	{
		get
		{
			return WaitEntityTaskModel._Instance;
		}
	}

	// Token: 0x060182AF RID: 98991 RVA: 0x006259BB File Offset: 0x00623BBB
	public static WaitEntityTaskModel GetOrCreateInstance()
	{
		if (WaitEntityTaskModel._Instance == null)
		{
			WaitEntityTaskModel.CreateInstance();
		}
		return WaitEntityTaskModel._Instance;
	}

	// Token: 0x060182B0 RID: 98992 RVA: 0x006259CF File Offset: 0x00623BCF
	public static bool CreateInstance()
	{
		if (WaitEntityTaskModel._Instance != null)
		{
			return true;
		}
		WaitEntityTaskModel._Instance = new WaitEntityTaskModel();
		return true;
	}

	// Token: 0x060182B1 RID: 98993 RVA: 0x006259E5 File Offset: 0x00623BE5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060182B2 RID: 98994 RVA: 0x006259E7 File Offset: 0x00623BE7
	public static void ResetStaticDefaultValue()
	{
		WaitEntityTaskModel._Instance = null;
	}

	// Token: 0x060182B3 RID: 98995 RVA: 0x006259EF File Offset: 0x00623BEF
	static WaitEntityTaskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityTaskModel.CreateStaticDefaultValue), new Action(WaitEntityTaskModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B3C2 RID: 46018
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, WaitEntityTask> TaskMap;

	// Token: 0x0400B3C3 RID: 46019
	private const int MaxTraversingMapScale = 10000;

	// Token: 0x0400B3C4 RID: 46020
	[Nullable(2)]
	private static WaitEntityTaskModel _Instance;
}
