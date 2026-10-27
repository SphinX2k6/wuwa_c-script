using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Infrastructure;
using UnrealEngine;

// Token: 0x02002C41 RID: 11329
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneInfr : UiCameraTargetTypeBase
{
	// Token: 0x06017A0E RID: 96782 RVA: 0x00603387 File Offset: 0x00601587
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		return null;
	}

	// Token: 0x06017A0F RID: 96783 RVA: 0x0060338C File Offset: 0x0060158C
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		if (InfrastructureConfig.Instance.GetRoadConfigById(InfrastructureModel.Instance.InteractingRoadId) == null)
		{
			return null;
		}
		InfrRoadBuild? infrRoadBuild;
		return infrRoadBuild.GetValueOrDefault().BodyCameraSettingsName;
	}

	// Token: 0x06017A10 RID: 96784 RVA: 0x006033C8 File Offset: 0x006015C8
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		return null;
	}
}
