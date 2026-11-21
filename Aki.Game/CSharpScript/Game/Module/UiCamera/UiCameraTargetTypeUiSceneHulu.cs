using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A6 RID: 14758
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiSceneHulu : UiCameraTargetType
	{
		// Token: 0x0602601A RID: 155674 RVA: 0x00AAABC9 File Offset: 0x00AA8DC9
		public UiCameraTargetTypeUiSceneHulu() : base(EUiCameraAnimationTargetType.UiSceneHulu)
		{
		}

		// Token: 0x0602601B RID: 155675 RVA: 0x00AAABD2 File Offset: 0x00AA8DD2
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiSceneHulu.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.Actor;
		}

		// Token: 0x0602601C RID: 155676 RVA: 0x00AAABE4 File Offset: 0x00AA8DE4
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiSceneHulu.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.MainMeshComponent;
		}

		// Token: 0x0602601D RID: 155677 RVA: 0x00AAABF6 File Offset: 0x00AA8DF6
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			return null;
		}

		// Token: 0x0602601E RID: 155678 RVA: 0x00AAABF9 File Offset: 0x00AA8DF9
		[NullableContext(2)]
		private static UiModelActorComponent GetActorComponent()
		{
			SkeletalObserverHandle huluObserver = UiSceneManager.Instance.GetHuluObserver();
			if (huluObserver == null)
			{
				return null;
			}
			UiModelBase model = huluObserver.Model;
			if (model == null)
			{
				return null;
			}
			return model.CheckGetComponent<UiModelActorComponent>();
		}
	}
}
