using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AF RID: 22959
	public static class IStateRepPerfBaseVerify
	{
		// Token: 0x06026E5B RID: 159323 RVA: 0x0055A25A File Offset: 0x0055845A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
