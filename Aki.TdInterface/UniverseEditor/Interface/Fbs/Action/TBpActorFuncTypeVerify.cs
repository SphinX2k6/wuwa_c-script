using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E5D RID: 32349
	public static class TBpActorFuncTypeVerify
	{
		// Token: 0x0603A6F8 RID: 239352 RVA: 0x007DE28C File Offset: 0x007DC48C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICarPaintChangeBpActorFuncVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBrokenBridgeEffectInMobileBpActorFuncVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
