using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E4 RID: 28900
	public static class ILiveClearScConfigVerify
	{
		// Token: 0x06032307 RID: 205575 RVA: 0x006CA25A File Offset: 0x006C845A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
