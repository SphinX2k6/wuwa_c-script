using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432B RID: 17195
	public static class TTrackTypeVerify
	{
		// Token: 0x060197FC RID: 104444 RVA: 0x003A70C8 File Offset: 0x003A52C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrackCaptureVisionsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrackEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrackEntityGroupVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrackLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITrackLocationsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
