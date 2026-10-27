using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE8 RID: 28648
	public static class ISetEntityTagVerify
	{
		// Token: 0x06032A75 RID: 207477 RVA: 0x006D5688 File Offset: 0x006D3888
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
