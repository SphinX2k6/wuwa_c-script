using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006749 RID: 26441
	public static class IFaceExpressionConfigVerify
	{
		// Token: 0x0602DFD6 RID: 188374 RVA: 0x00648F9A File Offset: 0x0064719A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
