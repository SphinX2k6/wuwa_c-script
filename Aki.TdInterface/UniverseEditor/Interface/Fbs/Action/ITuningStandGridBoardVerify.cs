using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8E RID: 31886
	public static class ITuningStandGridBoardVerify
	{
		// Token: 0x06039822 RID: 235554 RVA: 0x007C33E5 File Offset: 0x007C15E5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
