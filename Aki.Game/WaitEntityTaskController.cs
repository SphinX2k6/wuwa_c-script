using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200224D RID: 8781
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WaitEntityTaskController : ControllerBase
{
	// Token: 0x06015B3B RID: 88891 RVA: 0x0064B57A File Offset: 0x0064977A
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		return true;
	}

	// Token: 0x06015B3C RID: 88892 RVA: 0x0064B5B5 File Offset: 0x006497B5
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		return true;
	}

	// Token: 0x06015B3D RID: 88893 RVA: 0x0064B5F0 File Offset: 0x006497F0
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		WorldEntity entity = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		int? num2 = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null;
		WaitEntityTaskModel.Instance.OnAddEntity(num.GetValueOrDefault(), num2.GetValueOrDefault());
	}

	// Token: 0x06015B3E RID: 88894 RVA: 0x0064B65C File Offset: 0x0064985C
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		WorldEntity entity = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		int? num2 = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null;
		WaitEntityTaskModel.Instance.OnRemoveEntity(num.GetValueOrDefault(), num2.GetValueOrDefault());
	}

	// Token: 0x06015B3F RID: 88895 RVA: 0x0064B6C8 File Offset: 0x006498C8
	public int AddTask(WaitEntityTask task)
	{
		int taskId = this.TaskId;
		this.TaskId = taskId + 1;
		int num = taskId;
		WaitEntityTaskModel.Instance.AddTask(num, task);
		return num;
	}

	// Token: 0x06015B40 RID: 88896 RVA: 0x0064B6F4 File Offset: 0x006498F4
	public void RemoveTask(int taskId)
	{
		WaitEntityTaskModel.Instance.RemoveTask(taskId);
	}

	// Token: 0x17002102 RID: 8450
	// (get) Token: 0x06015B41 RID: 88897 RVA: 0x0064B701 File Offset: 0x00649901
	public static WaitEntityTaskController Instance
	{
		get
		{
			return WaitEntityTaskController._Instance;
		}
	}

	// Token: 0x06015B42 RID: 88898 RVA: 0x0064B708 File Offset: 0x00649908
	public static WaitEntityTaskController GetOrCreateInstance()
	{
		if (WaitEntityTaskController._Instance == null)
		{
			WaitEntityTaskController.CreateInstance();
		}
		return WaitEntityTaskController._Instance;
	}

	// Token: 0x06015B43 RID: 88899 RVA: 0x0064B71C File Offset: 0x0064991C
	public static bool CreateInstance()
	{
		if (WaitEntityTaskController._Instance != null)
		{
			return true;
		}
		WaitEntityTaskController._Instance = new WaitEntityTaskController();
		return true;
	}

	// Token: 0x06015B44 RID: 88900 RVA: 0x0064B732 File Offset: 0x00649932
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015B45 RID: 88901 RVA: 0x0064B734 File Offset: 0x00649934
	public static void ResetStaticDefaultValue()
	{
		WaitEntityTaskController._Instance = null;
	}

	// Token: 0x06015B46 RID: 88902 RVA: 0x0064B73C File Offset: 0x0064993C
	static WaitEntityTaskController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityTaskController.CreateStaticDefaultValue), new Action(WaitEntityTaskController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B735 RID: 46901
	private int TaskId;

	// Token: 0x0400B736 RID: 46902
	[Nullable(2)]
	private static WaitEntityTaskController _Instance;
}
