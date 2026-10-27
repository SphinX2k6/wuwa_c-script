using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551A RID: 21786
	public static class ILookAtTargetPlayerVerify
	{
		// Token: 0x06023FBC RID: 147388 RVA: 0x004F914A File Offset: 0x004F734A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
