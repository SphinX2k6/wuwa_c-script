using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BD3 RID: 15315
	public static class TShowTimelineVerify
	{
		// Token: 0x060150EA RID: 86250 RVA: 0x0030D614 File Offset: 0x0030B814
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowTimelineActionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowTimelineBuffVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowTimelineCheckpointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IShowTimelineGuideVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IShowTimelineInputVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
