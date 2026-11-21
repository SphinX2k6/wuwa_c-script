using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A1 RID: 14753
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeSailDock : UiCameraTargetType
	{
		// Token: 0x06026005 RID: 155653 RVA: 0x00AAA99B File Offset: 0x00AA8B9B
		public UiCameraTargetTypeSailDock() : base(EUiCameraAnimationTargetType.SailDock)
		{
		}

		// Token: 0x06026006 RID: 155654 RVA: 0x00AAA9A4 File Offset: 0x00AA8BA4
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			return null;
		}

		// Token: 0x06026007 RID: 155655 RVA: 0x00AAA9A7 File Offset: 0x00AA8BA7
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			return null;
		}

		// Token: 0x06026008 RID: 155656 RVA: 0x00AAA9AC File Offset: 0x00AA8BAC
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			string result;
			switch (FishingConfig.Instance.GetFishingPortConfig(FishingModel.Instance.DockId).SailingPoint)
			{
			case 1:
				result = "FishingShipOne";
				break;
			case 2:
				result = "FishingShipTwo";
				break;
			case 3:
				result = "FishingShipThree";
				break;
			case 4:
				result = "FishingShipFour";
				break;
			default:
				result = null;
				break;
			}
			return result;
		}
	}
}
