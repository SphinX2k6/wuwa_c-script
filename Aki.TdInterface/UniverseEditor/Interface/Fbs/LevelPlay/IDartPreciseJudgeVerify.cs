using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E3 RID: 18659
	public static class IDartPreciseJudgeVerify
	{
		// Token: 0x0601B9FC RID: 113148 RVA: 0x003E7D46 File Offset: 0x003E5F46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
