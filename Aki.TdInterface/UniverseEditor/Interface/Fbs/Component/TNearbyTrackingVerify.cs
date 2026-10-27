using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6B RID: 23659
	public static class TNearbyTrackingVerify
	{
		// Token: 0x060288B0 RID: 166064 RVA: 0x00593438 File Offset: 0x00591638
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAudioPointNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICompassTrackingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IIconNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStealthNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
