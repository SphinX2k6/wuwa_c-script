using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078FE RID: 30974
	public static class ISkillOperationTypeVerify
	{
		// Token: 0x060368A6 RID: 223398 RVA: 0x0074D0B2 File Offset: 0x0074B2B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
