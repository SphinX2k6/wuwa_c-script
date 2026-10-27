using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598B RID: 22923
	public static class ISplineType_UnionVerify
	{
		// Token: 0x06026D1F RID: 159007 RVA: 0x00557E20 File Offset: 0x00556020
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonSplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IParkourSplineVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IButterflySplineVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEffectSplineVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPatrolSplineVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ILevelAISplineVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IAirPassageSplineVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IContinuesVariableSpeedMovementSplineVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITimePatrolSplineVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IRangeSplineVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IWaySplineVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IMotorSlideSplineVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ISwordRiderRailSplineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
