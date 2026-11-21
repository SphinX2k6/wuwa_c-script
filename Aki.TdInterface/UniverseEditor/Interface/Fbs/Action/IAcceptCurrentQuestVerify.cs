using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CF RID: 26319
	public static class IAcceptCurrentQuestVerify
	{
		// Token: 0x0602C37F RID: 181119 RVA: 0x006058FA File Offset: 0x00603AFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
