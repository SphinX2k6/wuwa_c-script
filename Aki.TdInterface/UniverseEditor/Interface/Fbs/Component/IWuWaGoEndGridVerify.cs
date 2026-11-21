using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B9 RID: 25017
	public static class IWuWaGoEndGridVerify
	{
		// Token: 0x0602A87C RID: 174204 RVA: 0x005CCF58 File Offset: 0x005CB158
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
