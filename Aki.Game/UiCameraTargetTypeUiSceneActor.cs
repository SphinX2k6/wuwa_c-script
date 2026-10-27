using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C3E RID: 11326
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneActor : UiCameraTargetTypeBase
{
	// Token: 0x06017A02 RID: 96770 RVA: 0x00603200 File Offset: 0x00601400
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		if (UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World).GetAllUiSceneLoadingState() != EKuroUiSceneLoadingState.LoadedAndVisible)
		{
			return null;
		}
		return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(config.TargetActorTag).Value, ECollectActorType.UI);
	}

	// Token: 0x06017A03 RID: 96771 RVA: 0x0060323A File Offset: 0x0060143A
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		return null;
	}

	// Token: 0x06017A04 RID: 96772 RVA: 0x0060323D File Offset: 0x0060143D
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		return null;
	}
}
