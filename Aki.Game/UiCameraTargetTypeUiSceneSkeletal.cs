using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C43 RID: 11331
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneSkeletal : UiCameraTargetTypeBase
{
	// Token: 0x06017A16 RID: 96790 RVA: 0x006034C5 File Offset: 0x006016C5
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle lastSkeletalObserver = SkeletalObserverManager.GetLastSkeletalObserver();
		object obj;
		if (lastSkeletalObserver == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = lastSkeletalObserver.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		return obj2.Actor;
	}

	// Token: 0x06017A17 RID: 96791 RVA: 0x006034EF File Offset: 0x006016EF
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		return null;
	}

	// Token: 0x06017A18 RID: 96792 RVA: 0x006034F2 File Offset: 0x006016F2
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle lastSkeletalObserver = SkeletalObserverManager.GetLastSkeletalObserver();
		object obj;
		if (lastSkeletalObserver == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = lastSkeletalObserver.Model;
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
