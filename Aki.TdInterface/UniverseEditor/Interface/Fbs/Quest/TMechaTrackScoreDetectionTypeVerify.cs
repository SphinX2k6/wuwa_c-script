using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004748 RID: 18248
	public static class TMechaTrackScoreDetectionTypeVerify
	{
		// Token: 0x0601AE06 RID: 110086 RVA: 0x003D0578 File Offset: 0x003CE778
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
