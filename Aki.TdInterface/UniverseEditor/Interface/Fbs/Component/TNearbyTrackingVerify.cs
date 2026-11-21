using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006293 RID: 25235
	public static class TNearbyTrackingVerify
	{
		// Token: 0x0602AECE RID: 175822 RVA: 0x005DB7D0 File Offset: 0x005D99D0
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
				result = IDarkTideNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IIconNearbyTrackingVerify.Verify(verifier, tablePos);
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
