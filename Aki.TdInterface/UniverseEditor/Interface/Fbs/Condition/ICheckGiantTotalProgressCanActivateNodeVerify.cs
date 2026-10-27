using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3E RID: 19006
	public static class ICheckGiantTotalProgressCanActivateNodeVerify
	{
		// Token: 0x0601DC21 RID: 121889 RVA: 0x0042F46C File Offset: 0x0042D66C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
