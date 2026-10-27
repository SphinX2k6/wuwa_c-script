using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB4 RID: 23476
	public static class IWuWaGoHintStepBaseVerify
	{
		// Token: 0x06028348 RID: 164680 RVA: 0x005864EA File Offset: 0x005846EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
