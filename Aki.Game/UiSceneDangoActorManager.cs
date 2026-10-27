using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C5F RID: 11359
public class UiSceneDangoActorManager : IStaticVariableResetter
{
	// Token: 0x06017B6E RID: 97134 RVA: 0x00607735 File Offset: 0x00605935
	static UiSceneDangoActorManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneDangoActorManager.CreateStaticDefaultValue), new Action(UiSceneDangoActorManager.ResetStaticDefaultValue));
	}

	// Token: 0x06017B6F RID: 97135 RVA: 0x00607754 File Offset: 0x00605954
	public static void CreateStaticDefaultValue()
	{
		UiSceneDangoActorManager.CreateIndex = 0;
		UiSceneDangoActorManager.UiSceneDangoActorMap = new Dictionary<int, TsUiSceneDangoActor>();
	}

	// Token: 0x06017B70 RID: 97136 RVA: 0x00607766 File Offset: 0x00605966
	public static void ResetStaticDefaultValue()
	{
		UiSceneDangoActorManager.CreateIndex = 0;
		UiSceneDangoActorManager.UiSceneDangoActorMap = null;
	}

	// Token: 0x06017B71 RID: 97137 RVA: 0x00607774 File Offset: 0x00605974
	[NullableContext(1)]
	public static TsUiSceneDangoActor CreateUiSceneDangoActor(EUiModelUseWay useWay)
	{
		UiSceneDangoActorManager.CreateIndex++;
		TsUiSceneDangoActor tsUiSceneDangoActor = ActorSystem.Instance.Get<TsUiSceneDangoActor>(TsUiSceneDangoActor.StaticClass(), new FTransformDouble(), null, true);
		tsUiSceneDangoActor.Init(UiSceneDangoActorManager.CreateIndex, (int)useWay);
		UiSceneDangoActorManager.UiSceneDangoActorMap.Add(UiSceneDangoActorManager.CreateIndex, tsUiSceneDangoActor);
		return tsUiSceneDangoActor;
	}

	// Token: 0x06017B72 RID: 97138 RVA: 0x006077C4 File Offset: 0x006059C4
	public static bool DestroyUiSceneDangoActor(int index)
	{
		TsUiSceneDangoActor tsUiSceneDangoActor;
		if (UiSceneDangoActorManager.UiSceneDangoActorMap.TryGetValue(index, out tsUiSceneDangoActor))
		{
			tsUiSceneDangoActor.Destroy();
			return UiSceneDangoActorManager.UiSceneDangoActorMap.Remove(index);
		}
		return true;
	}

	// Token: 0x06017B73 RID: 97139 RVA: 0x006077F4 File Offset: 0x006059F4
	public static void SetAllActorVisible(bool visible)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in UiSceneDangoActorManager.UiSceneDangoActorMap.Values)
		{
			UiModelDataComponent uiModelDataComponent = tsUiSceneDangoActor.Model.CheckGetComponent<UiModelDataComponent>();
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetVisible(visible);
			}
		}
	}

	// Token: 0x06017B74 RID: 97140 RVA: 0x0060785C File Offset: 0x00605A5C
	public static void ClearAllUiSceneDangoActor()
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in UiSceneDangoActorManager.UiSceneDangoActorMap.Values)
		{
			tsUiSceneDangoActor.Destroy();
		}
		UiSceneDangoActorManager.UiSceneDangoActorMap.Clear();
	}

	// Token: 0x0400B0AD RID: 45229
	private static int CreateIndex;

	// Token: 0x0400B0AE RID: 45230
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, TsUiSceneDangoActor> UiSceneDangoActorMap;
}
