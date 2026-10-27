using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200447B RID: 17531
	public static class IDartPreciseJudgeVerify
	{
		// Token: 0x0601A22B RID: 107051 RVA: 0x003BBB3A File Offset: 0x003B9D3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
