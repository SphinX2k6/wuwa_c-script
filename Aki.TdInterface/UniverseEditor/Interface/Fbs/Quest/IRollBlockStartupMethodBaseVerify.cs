using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F3 RID: 16627
	public static class IRollBlockStartupMethodBaseVerify
	{
		// Token: 0x060183BC RID: 99260 RVA: 0x0037D176 File Offset: 0x0037B376
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
