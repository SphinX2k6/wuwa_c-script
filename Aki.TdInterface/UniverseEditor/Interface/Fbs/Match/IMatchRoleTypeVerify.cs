using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x0200486A RID: 18538
	public static class IMatchRoleTypeVerify
	{
		// Token: 0x0601B68A RID: 112266 RVA: 0x003E1532 File Offset: 0x003DF732
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
