using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DDE RID: 24030
	public static class IGiantStableValueTypeVerify
	{
		// Token: 0x0602921D RID: 168477 RVA: 0x005A5116 File Offset: 0x005A3316
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
