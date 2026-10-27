using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006286 RID: 25222
	public static class ICameraLockTargetBaseVerify
	{
		// Token: 0x0602B8E0 RID: 178400 RVA: 0x005FF18E File Offset: 0x005FD38E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
