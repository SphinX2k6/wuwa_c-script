using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C3D RID: 11325
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiGlider : UiCameraTargetTypeBase
{
	// Token: 0x060179FE RID: 96766 RVA: 0x00603195 File Offset: 0x00601395
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		object obj;
		if (gliderSkeletalHandle == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = gliderSkeletalHandle.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		return obj2.Actor;
	}

	// Token: 0x060179FF RID: 96767 RVA: 0x006031C4 File Offset: 0x006013C4
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		return null;
	}

	// Token: 0x06017A00 RID: 96768 RVA: 0x006031C7 File Offset: 0x006013C7
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		object obj;
		if (gliderSkeletalHandle == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = gliderSkeletalHandle.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		return obj2.MainMeshComponent;
	}
}
