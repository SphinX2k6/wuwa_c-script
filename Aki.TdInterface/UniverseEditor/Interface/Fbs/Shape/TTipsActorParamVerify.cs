using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C7E RID: 15486
	public static class TTipsActorParamVerify
	{
		// Token: 0x0601571C RID: 87836 RVA: 0x003193D0 File Offset: 0x003175D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBottomAlignSemiBoxTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBoxTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IConeTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICylinderSectorTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICylinderTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IGraphLineTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IGraphPointTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IHollowCylinderTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IHollowSphereTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ILaserTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ISectorTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ISphereTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ISplineEffectTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ISplineTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ISpotlightTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ITargetPointTipsActorVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ITrackTipsActorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
