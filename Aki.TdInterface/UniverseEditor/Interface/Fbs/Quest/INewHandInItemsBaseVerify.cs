using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004390 RID: 17296
	public static class INewHandInItemsBaseVerify
	{
		// Token: 0x06018733 RID: 100147 RVA: 0x0037C136 File Offset: 0x0037A336
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
