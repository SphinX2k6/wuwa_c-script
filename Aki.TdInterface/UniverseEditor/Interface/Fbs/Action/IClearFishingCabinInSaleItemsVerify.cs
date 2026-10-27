using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006387 RID: 25479
	public static class IClearFishingCabinInSaleItemsVerify
	{
		// Token: 0x0602C119 RID: 180505 RVA: 0x0060D982 File Offset: 0x0060BB82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
