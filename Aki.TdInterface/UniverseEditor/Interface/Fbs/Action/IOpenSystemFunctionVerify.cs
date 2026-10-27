using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C44 RID: 27716
	public static class IOpenSystemFunctionVerify
	{
		// Token: 0x06030D27 RID: 199975 RVA: 0x006A1CFE File Offset: 0x0069FEFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
