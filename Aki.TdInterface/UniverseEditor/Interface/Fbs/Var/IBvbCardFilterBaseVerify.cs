using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A29 RID: 14889
	public static class IBvbCardFilterBaseVerify
	{
		// Token: 0x06014234 RID: 82484 RVA: 0x002F201A File Offset: 0x002F021A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
