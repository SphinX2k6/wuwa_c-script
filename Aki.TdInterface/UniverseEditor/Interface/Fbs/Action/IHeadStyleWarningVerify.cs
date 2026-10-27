using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D8 RID: 26840
	public static class IHeadStyleWarningVerify
	{
		// Token: 0x0602ED03 RID: 191747 RVA: 0x0066337E File Offset: 0x0066157E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
