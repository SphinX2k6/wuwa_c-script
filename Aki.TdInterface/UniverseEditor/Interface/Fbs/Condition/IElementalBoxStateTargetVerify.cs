using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C0C RID: 19468
	public static class IElementalBoxStateTargetVerify
	{
		// Token: 0x0601ED54 RID: 126292 RVA: 0x00451372 File Offset: 0x0044F572
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
