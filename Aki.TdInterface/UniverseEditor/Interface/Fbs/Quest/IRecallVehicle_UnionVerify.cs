using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200409F RID: 16543
	public static class IRecallVehicle_UnionVerify
	{
		// Token: 0x06018152 RID: 98642 RVA: 0x00378D90 File Offset: 0x00376F90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRecallFishingBoatVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRecallVehicleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
