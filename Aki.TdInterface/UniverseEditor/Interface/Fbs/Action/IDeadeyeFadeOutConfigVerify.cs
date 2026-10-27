using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006554 RID: 25940
	public static class IDeadeyeFadeOutConfigVerify
	{
		// Token: 0x0602D029 RID: 184361 RVA: 0x0062D8DE File Offset: 0x0062BADE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
