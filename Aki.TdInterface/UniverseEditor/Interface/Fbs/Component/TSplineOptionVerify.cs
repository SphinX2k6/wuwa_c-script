using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAD RID: 23725
	public static class TSplineOptionVerify
	{
		// Token: 0x060289FE RID: 166398 RVA: 0x005952D0 File Offset: 0x005934D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAirPassageSplineVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IButterflySplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonSplineVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IContinuesVariableSpeedMovementSplineVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEffectSplineVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILevelAISplineVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IMotorSlideSplineVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IParkourSplineVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IPatrolSplineVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IRangeSplineVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ISwordRiderRailSplineVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ITimePatrolSplineVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IWaySplineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
