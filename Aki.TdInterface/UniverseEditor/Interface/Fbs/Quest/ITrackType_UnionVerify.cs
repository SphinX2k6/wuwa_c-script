using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004222 RID: 16930
	public static class ITrackType_UnionVerify
	{
		// Token: 0x0601907D RID: 102525 RVA: 0x0039A158 File Offset: 0x00398358
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrackTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrackLocationsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrackEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrackCaptureVisionsVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITrackEntityGroupVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITrackLevelPlayVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
