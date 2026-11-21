using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BA RID: 21434
	public static class IAkEventTypeConfigVerify
	{
		// Token: 0x06021762 RID: 137058 RVA: 0x0049DA06 File Offset: 0x0049BC06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
