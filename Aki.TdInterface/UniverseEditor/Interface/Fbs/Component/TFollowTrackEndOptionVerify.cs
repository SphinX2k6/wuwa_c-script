using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C26 RID: 23590
	public static class TFollowTrackEndOptionVerify
	{
		// Token: 0x06028746 RID: 165702 RVA: 0x00591208 File Offset: 0x0058F408
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFollowTrackToFoundationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFollowTrackToSplineDestinationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFollowTrackToStartVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
