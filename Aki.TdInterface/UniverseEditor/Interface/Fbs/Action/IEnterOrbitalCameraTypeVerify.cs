using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D42 RID: 27970
	public static class IEnterOrbitalCameraTypeVerify
	{
		// Token: 0x060303FE RID: 197630 RVA: 0x0068F112 File Offset: 0x0068D312
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
