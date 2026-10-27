using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C06 RID: 19462
	public static class IElementalBoxStatePlayerTargetVerify
	{
		// Token: 0x0601ED26 RID: 126246 RVA: 0x00450F37 File Offset: 0x0044F137
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
