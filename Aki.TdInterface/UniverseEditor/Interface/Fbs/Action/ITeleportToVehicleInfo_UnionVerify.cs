using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739C RID: 29596
	public static class ITeleportToVehicleInfo_UnionVerify
	{
		// Token: 0x06035B6C RID: 220012 RVA: 0x0074FE04 File Offset: 0x0074E004
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
