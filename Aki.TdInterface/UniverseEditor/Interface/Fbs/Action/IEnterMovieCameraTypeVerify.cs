using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B0 RID: 26288
	public static class IEnterMovieCameraTypeVerify
	{
		// Token: 0x0602DB1D RID: 187165 RVA: 0x0064080E File Offset: 0x0063EA0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
