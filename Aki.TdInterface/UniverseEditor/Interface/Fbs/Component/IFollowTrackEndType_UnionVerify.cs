using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581C RID: 22556
	public static class IFollowTrackEndType_UnionVerify
	{
		// Token: 0x060247FA RID: 149498 RVA: 0x00503C3C File Offset: 0x00501E3C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFollowTrackEndTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFollowTrackToStartVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFollowTrackToFoundationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFollowTrackToSplineDestinationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
