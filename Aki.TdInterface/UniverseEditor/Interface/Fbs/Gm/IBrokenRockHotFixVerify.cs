using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA6 RID: 19110
	public static class IBrokenRockHotFixVerify
	{
		// Token: 0x0601CB9D RID: 117661 RVA: 0x0040C8EE File Offset: 0x0040AAEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
