using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200407B RID: 16507
	public static class ITriggerShape_UnionVerify
	{
		// Token: 0x06016BA2 RID: 93090 RVA: 0x0033F440 File Offset: 0x0033D640
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBoxTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHollowSphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHollowCylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IConeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVolumeTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IActorRefVolumeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IActorCollisionTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICombinationTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 12:
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
