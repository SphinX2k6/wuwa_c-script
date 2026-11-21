using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021B8 RID: 8632
public class UiSceneDangoActorManager : IStaticVariableResetter
{
	// Token: 0x060153E2 RID: 87010 RVA: 0x0062D1F9 File Offset: 0x0062B3F9
	static UiSceneDangoActorManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiSceneDangoActorManager.CreateStaticDefaultValue), new Action(UiSceneDangoActorManager.ResetStaticDefaultValue));
	}

	// Token: 0x060153E3 RID: 87011 RVA: 0x0062D218 File Offset: 0x0062B418
	public static void CreateStaticDefaultValue()
	{
		UiSceneDangoActorManager.CreateIndex = 0;
		UiSceneDangoActorManager.UiSceneDangoActorMap = new Dictionary<int, TsUiSceneDangoActor>();
	}

	// Token: 0x060153E4 RID: 87012 RVA: 0x0062D22A File Offset: 0x0062B42A
	public static void ResetStaticDefaultValue()
	{
		UiSceneDangoActorManager.CreateIndex = 0;
		UiSceneDangoActorManager.UiSceneDangoActorMap = null;
	}

	// Token: 0x060153E5 RID: 87013 RVA: 0x0062D238 File Offset: 0x0062B438
	[NullableContext(1)]
	public static TsUiSceneDangoActor CreateUiSceneDangoActor(EUiModelUseWay useWay)
	{
		UiSceneDangoActorManager.CreateIndex++;
		TsUiSceneDangoActor tsUiSceneDangoActor = ActorSystem.Instance.Get<TsUiSceneDangoActor>(TsUiSceneDangoActor.StaticClass(), new FTransformDouble(), null, true);
		tsUiSceneDangoActor.Init(UiSceneDangoActorManager.CreateIndex, (int)useWay);
		UiSceneDangoActorManager.UiSceneDangoActorMap.Add(UiSceneDangoActorManager.CreateIndex, tsUiSceneDangoActor);
		return tsUiSceneDangoActor;
	}

	// Token: 0x060153E6 RID: 87014 RVA: 0x0062D288 File Offset: 0x0062B488
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

	// Token: 0x060153E7 RID: 87015 RVA: 0x0062D2B8 File Offset: 0x0062B4B8
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

	// Token: 0x060153E8 RID: 87016 RVA: 0x0062D320 File Offset: 0x0062B520
	public static void ClearAllUiSceneDangoActor()
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in UiSceneDangoActorManager.UiSceneDangoActorMap.Values)
		{
			tsUiSceneDangoActor.Destroy();
		}
		UiSceneDangoActorManager.UiSceneDangoActorMap.Clear();
	}

	// Token: 0x0400B419 RID: 46105
	private static int CreateIndex;

	// Token: 0x0400B41A RID: 46106
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, TsUiSceneDangoActor> UiSceneDangoActorMap;
}
