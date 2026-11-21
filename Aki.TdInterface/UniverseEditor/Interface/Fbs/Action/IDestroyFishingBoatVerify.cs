using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF8 RID: 27640
	public static class IDestroyFishingBoatVerify
	{
		// Token: 0x0602F919 RID: 194841 RVA: 0x0067BC96 File Offset: 0x00679E96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
