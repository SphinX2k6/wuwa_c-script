using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517F RID: 20863
	public static class IEntityGroupFailureArbitraryStateVerify
	{
		// Token: 0x06021BC4 RID: 138180 RVA: 0x004AE687 File Offset: 0x004AC887
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
