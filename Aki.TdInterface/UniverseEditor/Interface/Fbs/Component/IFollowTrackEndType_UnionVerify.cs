using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B1 RID: 21169
	public static class IFollowTrackEndType_UnionVerify
	{
		// Token: 0x06022836 RID: 141366 RVA: 0x004C8B40 File Offset: 0x004C6D40
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
