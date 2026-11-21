using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004099 RID: 16537
	public static class TTriggerShapeVerify
	{
		// Token: 0x06016C8A RID: 93322 RVA: 0x00340BF8 File Offset: 0x0033EDF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorCollisionTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorRefVolumeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBoxTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICombinationTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IConeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IHollowCylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IHollowSphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ISphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ISpotlightTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IVolumeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
