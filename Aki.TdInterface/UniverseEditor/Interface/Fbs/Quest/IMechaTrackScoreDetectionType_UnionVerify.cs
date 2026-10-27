using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F25 RID: 16165
	public static class IMechaTrackScoreDetectionType_UnionVerify
	{
		// Token: 0x06016F3F RID: 94015 RVA: 0x0034FD24 File Offset: 0x0034DF24
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
