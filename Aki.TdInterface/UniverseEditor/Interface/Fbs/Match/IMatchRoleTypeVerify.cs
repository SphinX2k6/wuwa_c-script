using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004402 RID: 17410
	public static class IMatchRoleTypeVerify
	{
		// Token: 0x06019EBD RID: 106173 RVA: 0x003B53B6 File Offset: 0x003B35B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
