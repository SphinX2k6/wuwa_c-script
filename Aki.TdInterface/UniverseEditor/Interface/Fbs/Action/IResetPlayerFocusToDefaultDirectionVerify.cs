using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E93 RID: 28307
	public static class IResetPlayerFocusToDefaultDirectionVerify
	{
		// Token: 0x06032082 RID: 204930 RVA: 0x006C4556 File Offset: 0x006C2756
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
