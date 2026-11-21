using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399F RID: 14751
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeNpc : UiCameraTargetType
	{
		// Token: 0x06025FFC RID: 155644 RVA: 0x00AAA74D File Offset: 0x00AA894D
		public UiCameraTargetTypeNpc() : base(EUiCameraAnimationTargetType.Npc)
		{
		}

		// Token: 0x06025FFD RID: 155645 RVA: 0x00AAA756 File Offset: 0x00AA8956
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			return InteractionModel.Instance.CurrentInteractUeActor;
		}

		// Token: 0x06025FFE RID: 155646 RVA: 0x00AAA764 File Offset: 0x00AA8964
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			AActor currentInteractUeActor = InteractionModel.Instance.CurrentInteractUeActor;
			if (currentInteractUeActor == null || !currentInteractUeActor.IsValid())
			{
				return null;
			}
			return currentInteractUeActor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
		}

		// Token: 0x06025FFF RID: 155647 RVA: 0x00AAA7A0 File Offset: 0x00AA89A0
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
			Entity entity = (currentInteractEntityId != null) ? EntitySystem.Instance.Get(currentInteractEntityId.Value) : null;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return null;
			}
			string result;
			switch (creatureDataComponent.GetModelConfig().体型类型)
			{
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
	}
}
