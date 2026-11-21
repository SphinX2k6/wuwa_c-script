using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A66 RID: 19046
	public static class TDartboardZoneVerify
	{
		// Token: 0x0601CA25 RID: 117285 RVA: 0x0040A524 File Offset: 0x00408724
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICenterBullZoneVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDoubleScoreZoneVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOuterBullZoneVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISingleScoreZoneVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
