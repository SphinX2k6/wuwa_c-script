using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006245 RID: 25157
	public static class TFollowTrackEndOptionVerify
	{
		// Token: 0x0602AD38 RID: 175416 RVA: 0x005D9198 File Offset: 0x005D7398
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
