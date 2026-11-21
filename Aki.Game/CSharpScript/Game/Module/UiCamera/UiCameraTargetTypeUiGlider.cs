using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A2 RID: 14754
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiGlider : UiCameraTargetType
	{
		// Token: 0x06026009 RID: 155657 RVA: 0x00AAAA13 File Offset: 0x00AA8C13
		public UiCameraTargetTypeUiGlider() : base(EUiCameraAnimationTargetType.UiGlider)
		{
		}

		// Token: 0x0602600A RID: 155658 RVA: 0x00AAAA1C File Offset: 0x00AA8C1C
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiGlider.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.Actor;
		}

		// Token: 0x0602600B RID: 155659 RVA: 0x00AAAA2E File Offset: 0x00AA8C2E
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			UiModelActorComponent actorComponent = UiCameraTargetTypeUiGlider.GetActorComponent();
			if (actorComponent == null)
			{
				return null;
			}
			return actorComponent.MainMeshComponent;
		}

		// Token: 0x0602600C RID: 155660 RVA: 0x00AAAA40 File Offset: 0x00AA8C40
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			return null;
		}

		// Token: 0x0602600D RID: 155661 RVA: 0x00AAAA43 File Offset: 0x00AA8C43
		[NullableContext(2)]
		private static UiModelActorComponent GetActorComponent()
		{
			SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
			if (gliderSkeletalHandle == null)
			{
				return null;
			}
			UiModelBase model = gliderSkeletalHandle.Model;
			if (model == null)
			{
				return null;
			}
			return model.CheckGetComponent<UiModelActorComponent>();
		}
	}
}
