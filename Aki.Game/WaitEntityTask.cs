using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

// Token: 0x02002A89 RID: 10889
[NullableContext(1)]
[Nullable(0)]
public class WaitEntityTask
{
	// Token: 0x0601B99F RID: 113055 RVA: 0x008805C8 File Offset: 0x0087E7C8
	public unsafe void AddEntities(long creatureDataId, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		this.AddCustomEntity(creatureDataId);
		this.LoadResultSet.Add(creatureDataId);
		this.CallBack = callBack;
		if (timeout >= 0)
		{
			this.TimeoutId = TimerSystem.Instance.Delay(delegate(float id)
			{
				this.TimeoutId = null;
				if (waitUntil)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "等待实体超时，强行等待";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id类型", "CreatureDataId");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实体", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", this.Reason);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "等待实体超时，强行回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id类型", "CreatureDataId");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("实体列表", creatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", this.Reason);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.DoCallback(null);
			}, (float)timeout, null, null, true, 1f);
		}
		else
		{
			this.TimeoutId = null;
		}
		this.FilterEntity(creatureDataId, checkExist);
		if (this.LoadCustomEntitySet != null)
		{
			foreach (long id2 in this.LoadCustomEntitySet)
			{
				this.FilterEntity(id2, checkExist);
			}
			this.LoadCustomEntitySet = null;
		}
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(true));
	}

	// Token: 0x0601B9A0 RID: 113056 RVA: 0x008806CC File Offset: 0x0087E8CC
	public unsafe void AddEntities(IList<long> creatureDataIds, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		foreach (long num in creatureDataIds)
		{
			this.AddCustomEntity(num);
			this.LoadResultSet.Add(num);
		}
		this.CallBack = callBack;
		if (timeout >= 0)
		{
			this.TimeoutId = TimerSystem.Instance.Delay(delegate(float id)
			{
				this.TimeoutId = null;
				if (waitUntil)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "等待实体超时，强行等待";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id类型", "CreatureDataId");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实体列表", string.Join<long>(",", creatureDataIds));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", this.Reason);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "等待实体超时，强行回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id类型", "CreatureDataId");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("实体列表", string.Join<long>(",", creatureDataIds));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", this.Reason);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.DoCallback(null);
			}, (float)timeout, null, null, true, 1f);
		}
		else
		{
			this.TimeoutId = null;
		}
		foreach (long id3 in creatureDataIds)
		{
			this.FilterEntity(id3, checkExist);
		}
		if (this.LoadCustomEntitySet != null)
		{
			foreach (long id2 in this.LoadCustomEntitySet)
			{
				this.FilterEntity(id2, checkExist);
			}
			this.LoadCustomEntitySet = null;
		}
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(true));
	}

	// Token: 0x0601B9A1 RID: 113057 RVA: 0x0088082C File Offset: 0x0087EA2C
	public unsafe void AddEntitiesWithPbDataId(int pbDataId, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		this.LoadResultSet.Add((long)pbDataId);
		this.CallBack = callBack;
		if (timeout >= 0)
		{
			this.TimeoutId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TimeoutId = null;
				if (waitUntil)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "等待实体超时，强行等待";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id类型", "PbDataId");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实体", pbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", this.Reason);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "等待实体超时，强行回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id类型", "PbDataId");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("实体", pbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", this.Reason);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.DoCallback(new bool?(false));
			}, (float)timeout, null, null, true, 1f);
		}
		else
		{
			this.TimeoutId = null;
		}
		this.FilterEntity((long)pbDataId, checkExist);
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(true));
	}

	// Token: 0x0601B9A2 RID: 113058 RVA: 0x008808CC File Offset: 0x0087EACC
	public unsafe void AddEntitiesWithPbDataId(IList<int> pbDataIds, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		foreach (int num in pbDataIds)
		{
			this.LoadResultSet.Add((long)num);
		}
		this.CallBack = callBack;
		if (timeout >= 0)
		{
			this.TimeoutId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TimeoutId = null;
				if (waitUntil)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "等待实体超时，强行等待";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id类型", "PbDataId");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实体列表", JsonSerializer.Serialize<IList<int>>(pbDataIds, null));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", this.Reason);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "等待实体超时，强行回调";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id类型", "PbDataId");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("实体列表", JsonSerializer.Serialize<IList<int>>(pbDataIds, null));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", this.Reason);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.DoCallback(new bool?(false));
			}, (float)timeout, null, null, true, 1f);
		}
		else
		{
			this.TimeoutId = null;
		}
		foreach (int num2 in pbDataIds)
		{
			this.FilterEntity((long)num2, checkExist);
		}
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(true));
	}

	// Token: 0x0601B9A3 RID: 113059 RVA: 0x008809D0 File Offset: 0x0087EBD0
	private void FilterEntity(long id, bool checkExist = true)
	{
		EntityHandle entityHandle;
		if (this.WaitType.GetValueOrDefault() == EWaitType.PbDataId)
		{
			entityHandle = CreatureModel.Instance.GetEntityByPbDataId((int)id);
		}
		else
		{
			entityHandle = CreatureModel.Instance.GetEntity(id);
		}
		if (entityHandle == null && checkExist)
		{
			this.LoadResultSet.Remove(id);
			return;
		}
		if (entityHandle != null)
		{
			if (entityHandle.IsInit)
			{
				this.LoadResultSet.Remove(id);
				return;
			}
			if (entityHandle.Priority < ResourceSystem.EResourceLoadPriority.Preload)
			{
				entityHandle.Priority = ResourceSystem.EResourceLoadPriority.Preload;
			}
			CharacterController.Instance.SortItem(entityHandle);
		}
	}

	// Token: 0x0601B9A4 RID: 113060 RVA: 0x00880A54 File Offset: 0x0087EC54
	public void OnAddEntity(long creatureDataId, int pbDataId)
	{
		EWaitType? waitType = this.WaitType;
		EWaitType ewaitType = EWaitType.CreatureDataId;
		if (waitType.GetValueOrDefault() == ewaitType & waitType != null)
		{
			this.LoadResultSet.Remove(creatureDataId);
		}
		else if (this.WaitType.GetValueOrDefault() == EWaitType.PbDataId)
		{
			this.LoadResultSet.Remove((long)pbDataId);
		}
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(!this.HasRemoveEntity));
	}

	// Token: 0x0601B9A5 RID: 113061 RVA: 0x00880ACC File Offset: 0x0087ECCC
	public void OnRemoveEntity(long creatureDataId, int pbDataId)
	{
		EWaitType? waitType = this.WaitType;
		EWaitType ewaitType = EWaitType.CreatureDataId;
		if (waitType.GetValueOrDefault() == ewaitType & waitType != null)
		{
			if (!this.LoadResultSet.Contains(creatureDataId))
			{
				return;
			}
			this.LoadResultSet.Remove(creatureDataId);
		}
		else if (this.WaitType.GetValueOrDefault() == EWaitType.PbDataId)
		{
			if (!this.LoadResultSet.Contains((long)pbDataId))
			{
				return;
			}
			this.LoadResultSet.Remove((long)pbDataId);
		}
		this.HasRemoveEntity = true;
		if (this.LoadResultSet.Count > 0)
		{
			return;
		}
		this.DoCallback(new bool?(false));
	}

	// Token: 0x0601B9A6 RID: 113062 RVA: 0x00880B64 File Offset: 0x0087ED64
	private void DoCallback(bool? result)
	{
		if (this.TimeoutId != null)
		{
			TimerSystem.Instance.Remove(this.TimeoutId);
			this.TimeoutId = null;
		}
		this.LoadResultSet.Clear();
		WaitEntityTaskController.Instance.RemoveTask(this.TaskId);
		Action<bool?> callBack = this.CallBack;
		if (callBack == null)
		{
			return;
		}
		callBack(result);
	}

	// Token: 0x0601B9A7 RID: 113063 RVA: 0x00880BC0 File Offset: 0x0087EDC0
	[return: Nullable(2)]
	public unsafe static WaitEntityTask Create(string reason, long creatureDataId, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "WaitEntityTask的Reason不能使用undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (reason.Length < 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "WaitEntityTask的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		WaitEntityTask waitEntityTask = new WaitEntityTask();
		waitEntityTask.WaitType = new EWaitType?(EWaitType.CreatureDataId);
		waitEntityTask.Reason = reason;
		waitEntityTask.TaskId = WaitEntityTaskController.Instance.AddTask(waitEntityTask);
		waitEntityTask.AddEntities(creatureDataId, callBack, timeout, checkExist, waitUntil);
		return waitEntityTask;
	}

	// Token: 0x0601B9A8 RID: 113064 RVA: 0x00880C8C File Offset: 0x0087EE8C
	[return: Nullable(2)]
	public unsafe static WaitEntityTask Create(string reason, IList<long> creatureDataIds, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "WaitEntityTask的Reason不能使用undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (reason.Length < 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "WaitEntityTask的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		WaitEntityTask waitEntityTask = new WaitEntityTask();
		waitEntityTask.WaitType = new EWaitType?(EWaitType.CreatureDataId);
		waitEntityTask.Reason = reason;
		waitEntityTask.TaskId = WaitEntityTaskController.Instance.AddTask(waitEntityTask);
		waitEntityTask.AddEntities(creatureDataIds, callBack, timeout, checkExist, waitUntil);
		return waitEntityTask;
	}

	// Token: 0x0601B9A9 RID: 113065 RVA: 0x00880D58 File Offset: 0x0087EF58
	[return: Nullable(2)]
	public unsafe static WaitEntityTask CreateWithPbDataId(string reason, int pbDataId, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "WaitEntityTask的Reason不能使用undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (reason.Length < 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "WaitEntityTask的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		WaitEntityTask waitEntityTask = new WaitEntityTask();
		waitEntityTask.WaitType = new EWaitType?(EWaitType.PbDataId);
		waitEntityTask.Reason = reason;
		waitEntityTask.TaskId = WaitEntityTaskController.Instance.AddTask(waitEntityTask);
		waitEntityTask.AddEntitiesWithPbDataId(pbDataId, callBack, timeout, checkExist, waitUntil);
		return waitEntityTask;
	}

	// Token: 0x0601B9AA RID: 113066 RVA: 0x00880E24 File Offset: 0x0087F024
	[return: Nullable(2)]
	public unsafe static WaitEntityTask CreateWithPbDataId(string reason, IList<int> pbDataIds, Action<bool?> callBack, int timeout = 60000, bool checkExist = true, bool waitUntil = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "WaitEntityTask的Reason不能使用undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (reason.Length < 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "WaitEntityTask的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		WaitEntityTask waitEntityTask = new WaitEntityTask();
		waitEntityTask.WaitType = new EWaitType?(EWaitType.PbDataId);
		waitEntityTask.Reason = reason;
		waitEntityTask.TaskId = WaitEntityTaskController.Instance.AddTask(waitEntityTask);
		waitEntityTask.AddEntitiesWithPbDataId(pbDataIds, callBack, timeout, checkExist, waitUntil);
		return waitEntityTask;
	}

	// Token: 0x0601B9AB RID: 113067 RVA: 0x00880EF0 File Offset: 0x0087F0F0
	public void Cancel()
	{
		if (this.TimeoutId != null)
		{
			TimerSystem.Instance.Remove(this.TimeoutId);
			this.TimeoutId = null;
		}
		this.LoadResultSet.Clear();
		WaitEntityTaskController.Instance.RemoveTask(this.TaskId);
	}

	// Token: 0x0601B9AC RID: 113068 RVA: 0x00880F30 File Offset: 0x0087F130
	private void AddCustomEntity(long entityId)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
		if (entity != null)
		{
			WorldEntity entity2 = entity.Entity;
			bool flag;
			if (entity2 == null)
			{
				flag = false;
			}
			else
			{
				BaseActorComponent component = entity2.GetComponent<BaseActorComponent>();
				flag = ((component != null) ? new bool?(!component.IsAutonomousProxy) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				WorldEntity entity3 = entity.Entity;
				IList<long> list;
				if (entity3 == null)
				{
					list = null;
				}
				else
				{
					CreatureDataComponent component2 = entity3.GetComponent<CreatureDataComponent>();
					list = ((component2 != null) ? component2.CustomServerEntityIds : null);
				}
				IList<long> list2 = list;
				if (list2 != null)
				{
					if (this.LoadCustomEntitySet == null)
					{
						this.LoadCustomEntitySet = new HashSet<long>();
					}
					foreach (long item in list2)
					{
						this.LoadCustomEntitySet.Add(item);
						this.LoadResultSet.Add(item);
					}
				}
				WorldEntity entity4 = entity.Entity;
				long? num;
				if (entity4 == null)
				{
					num = null;
				}
				else
				{
					CreatureDataComponent component3 = entity4.GetComponent<CreatureDataComponent>();
					num = ((component3 != null) ? new long?(component3.GetSummonerId()) : null);
				}
				long? num2 = num;
				if (num2 != null && num2.Value != 0L)
				{
					if (this.LoadCustomEntitySet == null)
					{
						this.LoadCustomEntitySet = new HashSet<long>();
					}
					this.LoadCustomEntitySet.Add(num2.Value);
					this.LoadResultSet.Add(num2.Value);
				}
				return;
			}
		}
	}

	// Token: 0x0400EE7A RID: 61050
	public const int REASON_LENGTH_LIMIT = 4;

	// Token: 0x0400EE7B RID: 61051
	public const int WAIT_TIME = 60000;

	// Token: 0x0400EE7C RID: 61052
	[Nullable(2)]
	private HashSet<long> LoadCustomEntitySet;

	// Token: 0x0400EE7D RID: 61053
	private readonly HashSet<long> LoadResultSet = new HashSet<long>();

	// Token: 0x0400EE7E RID: 61054
	public EWaitType? WaitType;

	// Token: 0x0400EE7F RID: 61055
	[Nullable(2)]
	private TimerHandle TimeoutId;

	// Token: 0x0400EE80 RID: 61056
	private int TaskId;

	// Token: 0x0400EE81 RID: 61057
	private bool HasRemoveEntity;

	// Token: 0x0400EE82 RID: 61058
	[Nullable(2)]
	public string Reason;

	// Token: 0x0400EE83 RID: 61059
	[Nullable(2)]
	private Action<bool?> CallBack;
}
