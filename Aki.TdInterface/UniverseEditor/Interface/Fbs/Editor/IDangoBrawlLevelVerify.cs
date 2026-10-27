using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200484C RID: 18508
	public static class IDangoBrawlLevelVerify
	{
		// Token: 0x0601CA25 RID: 117285 RVA: 0x0040C3FD File Offset: 0x0040A5FD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
