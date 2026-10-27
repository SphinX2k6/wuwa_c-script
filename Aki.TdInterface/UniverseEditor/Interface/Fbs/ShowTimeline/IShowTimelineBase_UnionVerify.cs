using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAC RID: 15276
	public static class IShowTimelineBase_UnionVerify
	{
		// Token: 0x06014F0E RID: 85774 RVA: 0x0030973C File Offset: 0x0030793C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowTimelineBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowTimelineCheckpointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowTimelineInputVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IShowTimelineActionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IShowTimelineBuffVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IShowTimelineGuideVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
