using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021BA RID: 8634
[NullableContext(1)]
[Nullable(0)]
public class UiSceneRoleActorManager : Singleton
{
	// Token: 0x06015460 RID: 87136 RVA: 0x0062F2A4 File Offset: 0x0062D4A4
	public TsUiSceneRoleActor CreateUiSceneRoleActor(EUiModelUseWay useWay)
	{
		this.CreateIndex++;
		TsUiSceneRoleActor tsUiSceneRoleActor = ActorSystem.Instance.Spawn<TsUiSceneRoleActor>(TsUiSceneRoleActor.StaticClass(), new FTransformDouble(), null);
		tsUiSceneRoleActor.Init(this.CreateIndex, useWay);
		this.UiSceneRoleActorMap[this.CreateIndex] = tsUiSceneRoleActor;
		return tsUiSceneRoleActor;
	}

	// Token: 0x06015461 RID: 87137 RVA: 0x0062F2F8 File Offset: 0x0062D4F8
	public bool DestroyUiSceneRoleActor(int index)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor;
		if (this.UiSceneRoleActorMap.TryGetValue(index, out tsUiSceneRoleActor))
		{
			tsUiSceneRoleActor.Destroy();
			return this.UiSceneRoleActorMap.Remove(index);
		}
		return true;
	}

	// Token: 0x06015462 RID: 87138 RVA: 0x0062F32C File Offset: 0x0062D52C
	public void ClearAllUiSceneRoleActor()
	{
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.UiSceneRoleActorMap.Values)
		{
			tsUiSceneRoleActor.Destroy();
		}
		this.UiSceneRoleActorMap.Clear();
	}

	// Token: 0x1700202B RID: 8235
	// (get) Token: 0x06015463 RID: 87139 RVA: 0x0062F38C File Offset: 0x0062D58C
	public static UiSceneRoleActorManager Instance
	{
		get
		{
			if (UiSceneRoleActorManager._instance == null)
			{
				UiSceneRoleActorManager._instance = new UiSceneRoleActorManager();
				UiSceneRoleActorManager._instance.OnInit();
			}
			return UiSceneRoleActorManager._instance;
		}
	}

	// Token: 0x06015464 RID: 87140 RVA: 0x0062F3AF File Offset: 0x0062D5AF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015465 RID: 87141 RVA: 0x0062F3B1 File Offset: 0x0062D5B1
	public static void ResetStaticDefaultValue()
	{
		UiSceneRoleActorManager instance = UiSceneRoleActorManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiSceneRoleActorManager._instance = null;
	}

	// Token: 0x06015466 RID: 87142 RVA: 0x0062F3CA File Offset: 0x0062D5CA
	static UiSceneRoleActorManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneRoleActorManager.CreateStaticDefaultValue), new Action(UiSceneRoleActorManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B43C RID: 46140
	private int CreateIndex;

	// Token: 0x0400B43D RID: 46141
	private readonly Dictionary<int, TsUiSceneRoleActor> UiSceneRoleActorMap = new Dictionary<int, TsUiSceneRoleActor>();

	// Token: 0x0400B43E RID: 46142
	[Nullable(2)]
	private static UiSceneRoleActorManager _instance;
}
