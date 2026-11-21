using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004363 RID: 17251
	public static class IMechaTrackScoreDetectionType_UnionVerify
	{
		// Token: 0x06018597 RID: 99735 RVA: 0x00378F4C File Offset: 0x0037714C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechaTrackScoreDetectionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechaTrackScoreStuntActionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechaTrackScoreMechanismStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMechaTrackScoreTagDetectionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
