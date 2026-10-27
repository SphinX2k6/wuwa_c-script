using System;
using UnrealEngine;

// Token: 0x02002FC3 RID: 12227
public class GameplayCueHideMesh : GameplayCueBase
{
	// Token: 0x06019EC0 RID: 106176 RVA: 0x006C7E98 File Offset: 0x006C6098
	protected override void OnCreate()
	{
		this.HideMesh(true);
	}

	// Token: 0x06019EC1 RID: 106177 RVA: 0x006C7EA1 File Offset: 0x006C60A1
	protected override void OnDestroy()
	{
		this.HideMesh(false);
	}

	// Token: 0x06019EC2 RID: 106178 RVA: 0x006C7EAC File Offset: 0x006C60AC
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
