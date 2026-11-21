using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2A RID: 27946
	public static class IEnterMovieCameraTypeVerify
	{
		// Token: 0x0603033A RID: 197434 RVA: 0x0068DAC2 File Offset: 0x0068BCC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
