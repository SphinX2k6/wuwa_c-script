using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006590 RID: 26000
	public static class IDestroyFishingBoatVerify
	{
		// Token: 0x0602D195 RID: 184725 RVA: 0x0062FAD2 File Offset: 0x0062DCD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
