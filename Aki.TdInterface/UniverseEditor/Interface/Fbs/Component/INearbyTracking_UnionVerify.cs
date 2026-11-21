using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B96 RID: 23446
	public static class INearbyTracking_UnionVerify
	{
		// Token: 0x06026A50 RID: 158288 RVA: 0x0054A8B0 File Offset: 0x00548AB0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IIconNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAudioPointNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICompassTrackingVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDarkTideNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
