using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C61 RID: 11361
[NullableContext(1)]
[Nullable(0)]
public class UiSceneRoleActorManager : Singleton
{
	// Token: 0x06017BEC RID: 97260 RVA: 0x006097D8 File Offset: 0x006079D8
	public TsUiSceneRoleActor CreateUiSceneRoleActor(EUiModelUseWay useWay)
	{
		this.CreateIndex++;
		TsUiSceneRoleActor tsUiSceneRoleActor = ActorSystem.Instance.Spawn<TsUiSceneRoleActor>(TsUiSceneRoleActor.StaticClass(), new FTransformDouble(), null);
		tsUiSceneRoleActor.Init(this.CreateIndex, useWay);
		this.UiSceneRoleActorMap[this.CreateIndex] = tsUiSceneRoleActor;
		return tsUiSceneRoleActor;
	}

	// Token: 0x06017BED RID: 97261 RVA: 0x0060982C File Offset: 0x00607A2C
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

	// Token: 0x06017BEE RID: 97262 RVA: 0x00609860 File Offset: 0x00607A60
	public void ClearAllUiSceneRoleActor()
	{
		foreach (TsUiSceneRoleActor tsUiSceneRoleActor in this.UiSceneRoleActorMap.Values)
		{
			tsUiSceneRoleActor.Destroy();
		}
		this.UiSceneRoleActorMap.Clear();
	}

	// Token: 0x17001FDA RID: 8154
	// (get) Token: 0x06017BEF RID: 97263 RVA: 0x006098C0 File Offset: 0x00607AC0
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

	// Token: 0x06017BF0 RID: 97264 RVA: 0x006098E3 File Offset: 0x00607AE3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017BF1 RID: 97265 RVA: 0x006098E5 File Offset: 0x00607AE5
	public static void ResetStaticDefaultValue()
	{
		UiSceneRoleActorManager instance = UiSceneRoleActorManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiSceneRoleActorManager._instance = null;
	}

	// Token: 0x06017BF2 RID: 97266 RVA: 0x006098FE File Offset: 0x00607AFE
	static UiSceneRoleActorManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneRoleActorManager.CreateStaticDefaultValue), new Action(UiSceneRoleActorManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0D0 RID: 45264
	private int CreateIndex;

	// Token: 0x0400B0D1 RID: 45265
	private readonly Dictionary<int, TsUiSceneRoleActor> UiSceneRoleActorMap = new Dictionary<int, TsUiSceneRoleActor>();

	// Token: 0x0400B0D2 RID: 45266
	[Nullable(2)]
	private static UiSceneRoleActorManager _instance;
}
