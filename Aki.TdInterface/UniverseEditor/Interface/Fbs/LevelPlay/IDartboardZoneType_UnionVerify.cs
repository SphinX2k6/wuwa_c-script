using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004469 RID: 17513
	public static class IDartboardZoneType_UnionVerify
	{
		// Token: 0x0601A197 RID: 106903 RVA: 0x003BA914 File Offset: 0x003B8B14
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
