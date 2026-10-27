using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x020043FC RID: 17404
	public static class IMatchPhantomRoleVerify
	{
		// Token: 0x06019E91 RID: 106129 RVA: 0x003B4F74 File Offset: 0x003B3174
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
