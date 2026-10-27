using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200463E RID: 17982
	public static class IBrokenRockHotFixVerify
	{
		// Token: 0x0601B3C8 RID: 111560 RVA: 0x003E0652 File Offset: 0x003DE852
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
