using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749B RID: 29851
	public static class ITuningStandGridBoardVerify
	{
		// Token: 0x06036435 RID: 222261 RVA: 0x00760629 File Offset: 0x0075E829
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
