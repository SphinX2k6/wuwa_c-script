using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E9 RID: 17129
	public static class TMechaTrackScoreDetectionTypeVerify
	{
		// Token: 0x06019684 RID: 104068 RVA: 0x003A4C48 File Offset: 0x003A2E48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechaTrackScoreMechanismStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechaTrackScoreStuntActionVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
