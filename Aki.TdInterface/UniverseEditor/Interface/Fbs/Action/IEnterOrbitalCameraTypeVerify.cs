using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C8 RID: 26312
	public static class IEnterOrbitalCameraTypeVerify
	{
		// Token: 0x0602DBE1 RID: 187361 RVA: 0x00641E5E File Offset: 0x0064005E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
