using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F9 RID: 20729
	public static class IElementalBoxStateTargetVerify
	{
		// Token: 0x0602093A RID: 133434 RVA: 0x004849DA File Offset: 0x00482BDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
