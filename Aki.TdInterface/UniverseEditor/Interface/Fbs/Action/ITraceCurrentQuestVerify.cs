using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C19 RID: 31769
	public static class ITraceCurrentQuestVerify
	{
		// Token: 0x06039412 RID: 234514 RVA: 0x007BB9AE File Offset: 0x007B9BAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
