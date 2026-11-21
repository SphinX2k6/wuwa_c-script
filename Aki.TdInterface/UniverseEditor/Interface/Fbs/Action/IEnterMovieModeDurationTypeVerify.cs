using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D33 RID: 27955
	public static class IEnterMovieModeDurationTypeVerify
	{
		// Token: 0x06030386 RID: 197510 RVA: 0x0068E4A2 File Offset: 0x0068C6A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
