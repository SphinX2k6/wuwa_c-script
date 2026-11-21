using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B83 RID: 31619
	public static class ITeleportToVehicleInfo_UnionVerify
	{
		// Token: 0x06038F07 RID: 233223 RVA: 0x007B2344 File Offset: 0x007B0544
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITeleportToAndEnterFishingBoatVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITeleportToVehicleInfoVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
