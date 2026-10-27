using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

// Token: 0x02002C3C RID: 11324
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeSailDock : UiCameraTargetTypeBase
{
	// Token: 0x060179FA RID: 96762 RVA: 0x00603117 File Offset: 0x00601317
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		return null;
	}

	// Token: 0x060179FB RID: 96763 RVA: 0x0060311C File Offset: 0x0060131C
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		int sailingPoint = FishingConfig.Instance.GetFishingPortConfig(FishingModel.Instance.DockId).SailingPoint;
		if (sailingPoint == 0)
		{
			return null;
		}
		string result;
		switch (sailingPoint)
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

	// Token: 0x060179FC RID: 96764 RVA: 0x0060318A File Offset: 0x0060138A
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		return null;
	}
}
