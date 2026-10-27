using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F02 RID: 28418
	public static class IRollBlockGetRewardVerify
	{
		// Token: 0x0603235E RID: 205662 RVA: 0x006C8B8A File Offset: 0x006C6D8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
