using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C44 RID: 11332
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiVisionHandBook : UiCameraTargetTypeBase
{
	// Token: 0x06017A1A RID: 96794 RVA: 0x00603524 File Offset: 0x00601724
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		if (!GlobalData.IsUiSceneOpen)
		{
			return null;
		}
		return UiSceneManager.Instance.GetHandBookCaseActor();
	}

	// Token: 0x06017A1B RID: 96795 RVA: 0x00603539 File Offset: 0x00601739
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		return null;
	}

	// Token: 0x06017A1C RID: 96796 RVA: 0x0060353C File Offset: 0x0060173C
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
		if (handBookVision != null)
		{
			return handBookVision.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
		}
		return null;
	}
}
