using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200408A RID: 16522
	public static class TCombinationTriggerShapeVerify
	{
		// Token: 0x06016C18 RID: 93208 RVA: 0x0033FFE4 File Offset: 0x0033E1E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBoxTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHollowSphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHollowCylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IConeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVolumeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IActorRefVolumeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IActorCollisionTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICombinationTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ISpotlightTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
