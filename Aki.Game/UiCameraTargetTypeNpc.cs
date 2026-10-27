using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;

// Token: 0x02002C3A RID: 11322
[NullableContext(1)]
[Nullable(0)]
public class UiCameraTargetTypeNpc : UiCameraTargetTypeBase
{
	// Token: 0x060179F1 RID: 96753 RVA: 0x00602EAF File Offset: 0x006010AF
	[return: Nullable(2)]
	public override AActor GetTargetActor(SUiCameraAnimationSettings config)
	{
		return InteractionModel.Instance.CurrentInteractUeActor;
	}

	// Token: 0x060179F2 RID: 96754 RVA: 0x00602EBC File Offset: 0x006010BC
	[NullableContext(2)]
	public override string GetTargetBodyKey()
	{
		int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		if (currentInteractEntityId == null)
		{
			return null;
		}
		Entity entity = EntitySystem.Instance.Get(currentInteractEntityId.Value);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return null;
		}
		string result;
		switch (component.GetModelConfig().体型类型)
		{
		case EBodyType.None:
			result = null;
			break;
		case EBodyType.MaleS:
			result = "MaleS";
			break;
		case EBodyType.MaleM:
			result = "MaleM";
			break;
		case EBodyType.MaleXL:
			result = "MaleXL";
			break;
		case EBodyType.FemaleS:
			result = "FemaleS";
			break;
		case EBodyType.FemaleMS:
			result = "FemaleMS";
			break;
		case EBodyType.FemaleM:
			result = "FemaleM";
			break;
		case EBodyType.FemaleXL:
			result = "FemaleXL";
			break;
		case EBodyType.ShopHand:
			result = "ShopHand";
			break;
		case EBodyType.ShopStore:
			result = "ShopStore";
			break;
		case EBodyType.ShopDoll:
			result = "ShopDoll";
			break;
		case EBodyType.ShopPhonograph:
			result = "ShopPhonograph";
			break;
		case EBodyType.ShopPicture:
			result = "ShopPicture";
			break;
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x060179F3 RID: 96755 RVA: 0x00602FD0 File Offset: 0x006011D0
	[return: Nullable(2)]
	public override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings config)
	{
		AActor currentInteractUeActor = InteractionModel.Instance.CurrentInteractUeActor;
		if (currentInteractUeActor == null || !currentInteractUeActor.IsValid())
		{
			return null;
		}
		return currentInteractUeActor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
	}
}
