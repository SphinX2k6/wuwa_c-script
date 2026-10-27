using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F8 RID: 22008
	public static class INearbyTracking_UnionVerify
	{
		// Token: 0x06024840 RID: 149568 RVA: 0x0050A2A8 File Offset: 0x005084A8
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
