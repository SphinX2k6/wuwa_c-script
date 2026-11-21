using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC4 RID: 19140
	public static class IGmCommandVerify
	{
		// Token: 0x0601CC95 RID: 117909 RVA: 0x0040E1B6 File Offset: 0x0040C3B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
