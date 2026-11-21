using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418F RID: 16783
	public static class ICheckTrapDefenseBdBuffQualityUpVerify
	{
		// Token: 0x060171D0 RID: 94672 RVA: 0x0034B472 File Offset: 0x00349672
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
