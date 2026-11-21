using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706C RID: 28780
	public static class IItemFoundationMatchVerify
	{
		// Token: 0x06031E82 RID: 204418 RVA: 0x006C13AE File Offset: 0x006BF5AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
