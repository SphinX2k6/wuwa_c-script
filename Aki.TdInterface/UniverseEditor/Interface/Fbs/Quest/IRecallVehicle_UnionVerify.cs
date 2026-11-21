using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E0 RID: 17632
	public static class IRecallVehicle_UnionVerify
	{
		// Token: 0x060197EB RID: 104427 RVA: 0x003A2BC8 File Offset: 0x003A0DC8
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
