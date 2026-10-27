using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B8 RID: 21432
	public static class IHookFetchMoveModeBaseVerify
	{
		// Token: 0x060231FD RID: 143869 RVA: 0x004DCC3A File Offset: 0x004DAE3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
