using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Extension;

// Token: 0x0200224E RID: 8782
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WaitEntityTaskModel : ModelBase
{
	// Token: 0x06015B48 RID: 88904 RVA: 0x0064B763 File Offset: 0x00649963
	public void OnAddEntity(long creatureDataId, int pbDataId)
	{
		this.EntityEventHandler(creatureDataId, pbDataId, true);
	}

	// Token: 0x06015B49 RID: 88905 RVA: 0x0064B76E File Offset: 0x0064996E
	public void OnRemoveEntity(long creatureDataId, int pbDataId)
	{
		this.EntityEventHandler(creatureDataId, pbDataId, false);
	}

	// Token: 0x06015B4A RID: 88906 RVA: 0x0064B779 File Offset: 0x00649979
	protected override bool OnInit()
	{
		this.TaskMap = new Dictionary<int, WaitEntityTask>();
		return true;
	}

	// Token: 0x06015B4B RID: 88907 RVA: 0x0064B787 File Offset: 0x00649987
	protected override bool OnClear()
	{
		Dictionary<int, WaitEntityTask> taskMap = this.TaskMap;
		if (taskMap != null)
		{
			taskMap.Clear();
		}
		return true;
	}

	// Token: 0x06015B4C RID: 88908 RVA: 0x0064B79C File Offset: 0x0064999C
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

	// Token: 0x06015B4D RID: 88909 RVA: 0x0064B837 File Offset: 0x00649A37
	public void RemoveTask(int taskId)
	{
		Dictionary<int, WaitEntityTask> taskMap = this.TaskMap;
		if (taskMap == null)
		{
			return;
		}
		taskMap.Remove(taskId);
	}

	// Token: 0x06015B4E RID: 88910 RVA: 0x0064B84C File Offset: 0x00649A4C
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

	// Token: 0x17002103 RID: 8451
	// (get) Token: 0x06015B4F RID: 88911 RVA: 0x0064B980 File Offset: 0x00649B80
	public static WaitEntityTaskModel Instance
	{
		get
		{
			return WaitEntityTaskModel._Instance;
		}
	}

	// Token: 0x06015B50 RID: 88912 RVA: 0x0064B987 File Offset: 0x00649B87
	public static WaitEntityTaskModel GetOrCreateInstance()
	{
		if (WaitEntityTaskModel._Instance == null)
		{
			WaitEntityTaskModel.CreateInstance();
		}
		return WaitEntityTaskModel._Instance;
	}

	// Token: 0x06015B51 RID: 88913 RVA: 0x0064B99B File Offset: 0x00649B9B
	public static bool CreateInstance()
	{
		if (WaitEntityTaskModel._Instance != null)
		{
			return true;
		}
		WaitEntityTaskModel._Instance = new WaitEntityTaskModel();
		return true;
	}

	// Token: 0x06015B52 RID: 88914 RVA: 0x0064B9B1 File Offset: 0x00649BB1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015B53 RID: 88915 RVA: 0x0064B9B3 File Offset: 0x00649BB3
	public static void ResetStaticDefaultValue()
	{
		WaitEntityTaskModel._Instance = null;
	}

	// Token: 0x06015B54 RID: 88916 RVA: 0x0064B9BB File Offset: 0x00649BBB
	static WaitEntityTaskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityTaskModel.CreateStaticDefaultValue), new Action(WaitEntityTaskModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B737 RID: 46903
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, WaitEntityTask> TaskMap;

	// Token: 0x0400B738 RID: 46904
	private const int MaxTraversingMapScale = 10000;

	// Token: 0x0400B739 RID: 46905
	[Nullable(2)]
	private static WaitEntityTaskModel _Instance;
}
