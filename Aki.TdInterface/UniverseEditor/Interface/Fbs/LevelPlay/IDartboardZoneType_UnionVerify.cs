using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D1 RID: 18641
	public static class IDartboardZoneType_UnionVerify
	{
		// Token: 0x0601B968 RID: 113000 RVA: 0x003E6B20 File Offset: 0x003E4D20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDartboardZoneTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICenterBullZoneVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOuterBullZoneVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISingleScoreZoneVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDoubleScoreZoneVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITripleScoreZoneVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
