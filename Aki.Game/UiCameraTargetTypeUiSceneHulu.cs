using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

// Token: 0x02002C40 RID: 11328
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeUiSceneHulu : UiCameraTargetTypeBase
{
	// Token: 0x06017A0A RID: 96778 RVA: 0x0060331E File Offset: 0x0060151E
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle huluObserver = UiSceneManager.Instance.GetHuluObserver();
		object obj;
		if (huluObserver == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = huluObserver.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		return obj2.Actor;
	}

	// Token: 0x06017A0B RID: 96779 RVA: 0x0060334D File Offset: 0x0060154D
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		return null;
	}

	// Token: 0x06017A0C RID: 96780 RVA: 0x00603350 File Offset: 0x00601550
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		SkeletalObserverHandle huluObserver = UiSceneManager.Instance.GetHuluObserver();
		object obj;
		if (huluObserver == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = huluObserver.Model;
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
