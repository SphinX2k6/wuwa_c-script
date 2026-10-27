using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1D RID: 27677
	public static class IOpenQteConfigVerify
	{
		// Token: 0x06030ACE RID: 199374 RVA: 0x0069B9A2 File Offset: 0x00699BA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
