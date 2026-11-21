using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A4 RID: 14756
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiSceneActor : UiCameraTargetType
	{
		// Token: 0x06026012 RID: 155666 RVA: 0x00AAAAB4 File Offset: 0x00AA8CB4
		public UiCameraTargetTypeUiSceneActor() : base(EUiCameraAnimationTargetType.UiSceneActor)
		{
		}

		// Token: 0x06026013 RID: 155667 RVA: 0x00AAAAC0 File Offset: 0x00AA8CC0
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			if (UKuroUiSceneSystem.GetKuroUiSceneSystem(GlobalData.World).GetAllUiSceneLoadingState() != EKuroUiSceneLoadingState.LoadedAndVisible)
			{
				return null;
			}
			return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(settings.TargetActorTag).Value, ECollectActorType.UI);
		}

		// Token: 0x06026014 RID: 155668 RVA: 0x00AAAAFA File Offset: 0x00AA8CFA
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			return null;
		}

		// Token: 0x06026015 RID: 155669 RVA: 0x00AAAAFD File Offset: 0x00AA8CFD
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			return null;
		}
	}
}
