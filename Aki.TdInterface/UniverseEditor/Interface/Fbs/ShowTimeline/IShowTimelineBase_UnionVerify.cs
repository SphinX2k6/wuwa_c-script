using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB4 RID: 16308
	public static class IShowTimelineBase_UnionVerify
	{
		// Token: 0x060163D8 RID: 91096 RVA: 0x0032FCD4 File Offset: 0x0032DED4
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
