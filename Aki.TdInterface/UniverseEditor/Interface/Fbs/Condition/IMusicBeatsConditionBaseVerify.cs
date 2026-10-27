using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C5A RID: 19546
	public static class IMusicBeatsConditionBaseVerify
	{
		// Token: 0x0601EFE6 RID: 126950 RVA: 0x00455A36 File Offset: 0x00453C36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
