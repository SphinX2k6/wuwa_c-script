using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A9 RID: 14761
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiVisionHandBook : UiCameraTargetType
	{
		// Token: 0x06026028 RID: 155688 RVA: 0x00AAAD63 File Offset: 0x00AA8F63
		public UiCameraTargetTypeUiVisionHandBook() : base(EUiCameraAnimationTargetType.UiVisionHandBook)
		{
		}

		// Token: 0x06026029 RID: 155689 RVA: 0x00AAAD6C File Offset: 0x00AA8F6C
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			if (!GlobalData.IsUiSceneOpen)
			{
				return null;
			}
			return UiSceneManager.Instance.GetHandBookCaseActor();
		}

		// Token: 0x0602602A RID: 155690 RVA: 0x00AAAD81 File Offset: 0x00AA8F81
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
			return ((handBookVision != null) ? handBookVision.GetComponentByClass(USkeletalMeshComponent.StaticClass()) : null) as USkeletalMeshComponent;
		}

		// Token: 0x0602602B RID: 155691 RVA: 0x00AAADA8 File Offset: 0x00AA8FA8
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			return null;
		}
	}
}
