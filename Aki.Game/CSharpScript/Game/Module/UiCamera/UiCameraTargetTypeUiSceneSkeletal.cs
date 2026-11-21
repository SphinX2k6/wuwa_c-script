using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A8 RID: 14760
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiSceneSkeletal : UiCameraTargetType
	{
		// Token: 0x06026023 RID: 155683 RVA: 0x00AAAD16 File Offset: 0x00AA8F16
		public UiCameraTargetTypeUiSceneSkeletal() : base(EUiCameraAnimationTargetType.UiSceneSkeletal)
		{
		}

		// Token: 0x06026024 RID: 155684 RVA: 0x00AAAD1F File Offset: 0x00AA8F1F
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiSceneSkeletal.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.Actor;
		}

		// Token: 0x06026025 RID: 155685 RVA: 0x00AAAD31 File Offset: 0x00AA8F31
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiSceneSkeletal.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.MainMeshComponent;
		}

		// Token: 0x06026026 RID: 155686 RVA: 0x00AAAD43 File Offset: 0x00AA8F43
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			return null;
		}

		// Token: 0x06026027 RID: 155687 RVA: 0x00AAAD46 File Offset: 0x00AA8F46
		[NullableContext(2)]
		private static UiModelActorComponent GetActorComponent()
		{
			SkeletalObserverHandle lastSkeletalObserver = SkeletalObserverManager.GetLastSkeletalObserver();
			if (lastSkeletalObserver == null)
			{
				return null;
			}
			UiModelBase model = lastSkeletalObserver.Model;
			if (model == null)
			{
				return null;
			}
			return model.CheckGetComponent<UiModelActorComponent>();
		}
	}
}
