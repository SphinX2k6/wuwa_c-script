using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F8 RID: 27128
	public static class IClearFishingCabinInSaleItemsVerify
	{
		// Token: 0x0602E883 RID: 190595 RVA: 0x00658AD6 File Offset: 0x00656CD6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
