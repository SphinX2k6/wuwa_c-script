using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D9 RID: 23001
	public static class IStreamingSourceConfigBaseVerify
	{
		// Token: 0x06027057 RID: 159831 RVA: 0x0055E8B6 File Offset: 0x0055CAB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
