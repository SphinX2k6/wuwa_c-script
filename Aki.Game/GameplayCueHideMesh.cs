using System;
using UnrealEngine;

// Token: 0x02002517 RID: 9495
public class GameplayCueHideMesh : GameplayCueBase
{
	// Token: 0x060177D2 RID: 96210 RVA: 0x006EE764 File Offset: 0x006EC964
	protected override void OnCreate()
	{
		this.HideMesh(true);
	}

	// Token: 0x060177D3 RID: 96211 RVA: 0x006EE76D File Offset: 0x006EC96D
	protected override void OnDestroy()
	{
		this.HideMesh(false);
	}

	// Token: 0x060177D4 RID: 96212 RVA: 0x006EE778 File Offset: 0x006EC978
	private void HideMesh(bool bStart)
	{
		if (this.CueConfig.ParametersLength == 0)
		{
			return;
		}
		foreach (UActorComponent uactorComponent in this.ActorInternal.K2_GetComponentsByClass(UMeshComponent.StaticClass()))
		{
			if (uactorComponent.GetName() == this.CueConfig.Parameters(0))
			{
				bool flag = ((this.CueConfig.ParametersLength > 1) ? this.CueConfig.Parameters(1) : "1") == "1";
				if (!bStart)
				{
					flag = !flag;
				}
				bool bPropagateToChildren = ((this.CueConfig.ParametersLength > 2) ? this.CueConfig.Parameters(2) : "1") == "1";
				((UMeshComponent)uactorComponent).SetHiddenInGame(flag, bPropagateToChildren);
			}
		}
	}
}
