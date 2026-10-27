using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CF3 RID: 11507
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WaitEntityTaskController : ControllerBase
{
	// Token: 0x0601829A RID: 98970 RVA: 0x006255B6 File Offset: 0x006237B6
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		return true;
	}

	// Token: 0x0601829B RID: 98971 RVA: 0x006255F1 File Offset: 0x006237F1
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		return true;
	}

	// Token: 0x0601829C RID: 98972 RVA: 0x0062562C File Offset: 0x0062382C
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		WorldEntity entity = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		int? num2 = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null;
		WaitEntityTaskModel.Instance.OnAddEntity(num.GetValueOrDefault(), num2.GetValueOrDefault());
	}

	// Token: 0x0601829D RID: 98973 RVA: 0x00625698 File Offset: 0x00623898
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		WorldEntity entity = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		int? num2 = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null;
		WaitEntityTaskModel.Instance.OnRemoveEntity(num.GetValueOrDefault(), num2.GetValueOrDefault());
	}

	// Token: 0x0601829E RID: 98974 RVA: 0x00625704 File Offset: 0x00623904
	public int AddTask(WaitEntityTask task)
	{
		int taskId = this.TaskId;
		this.TaskId = taskId + 1;
		int num = taskId;
		WaitEntityTaskModel.Instance.AddTask(num, task);
		return num;
	}

	// Token: 0x0601829F RID: 98975 RVA: 0x00625730 File Offset: 0x00623930
	public void RemoveTask(int taskId)
	{
		WaitEntityTaskModel.Instance.RemoveTask(taskId);
	}

	// Token: 0x170020A7 RID: 8359
	// (get) Token: 0x060182A0 RID: 98976 RVA: 0x0062573D File Offset: 0x0062393D
	public static WaitEntityTaskController Instance
	{
		get
		{
			return WaitEntityTaskController._Instance;
		}
	}

	// Token: 0x060182A1 RID: 98977 RVA: 0x00625744 File Offset: 0x00623944
	public static WaitEntityTaskController GetOrCreateInstance()
	{
		if (WaitEntityTaskController._Instance == null)
		{
			WaitEntityTaskController.CreateInstance();
		}
		return WaitEntityTaskController._Instance;
	}

	// Token: 0x060182A2 RID: 98978 RVA: 0x00625758 File Offset: 0x00623958
	public static bool CreateInstance()
	{
		if (WaitEntityTaskController._Instance != null)
		{
			return true;
		}
		WaitEntityTaskController._Instance = new WaitEntityTaskController();
		return true;
	}

	// Token: 0x060182A3 RID: 98979 RVA: 0x0062576E File Offset: 0x0062396E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060182A4 RID: 98980 RVA: 0x00625770 File Offset: 0x00623970
	public static void ResetStaticDefaultValue()
	{
		WaitEntityTaskController._Instance = null;
	}

	// Token: 0x060182A5 RID: 98981 RVA: 0x00625778 File Offset: 0x00623978
	static WaitEntityTaskController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WaitEntityTaskController.CreateStaticDefaultValue), new Action(WaitEntityTaskController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B3C0 RID: 46016
	private int TaskId;

	// Token: 0x0400B3C1 RID: 46017
	[Nullable(2)]
	private static WaitEntityTaskController _Instance;
}
