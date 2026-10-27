using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764F RID: 30287
	public static class TBpActorFuncTypeVerify
	{
		// Token: 0x06037253 RID: 225875 RVA: 0x0077A190 File Offset: 0x00778390
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
