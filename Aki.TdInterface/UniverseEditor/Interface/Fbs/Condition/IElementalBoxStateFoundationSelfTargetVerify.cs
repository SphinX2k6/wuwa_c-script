using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C00 RID: 19456
	public static class IElementalBoxStateFoundationSelfTargetVerify
	{
		// Token: 0x0601ECF2 RID: 126194 RVA: 0x00450A4B File Offset: 0x0044EC4B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
