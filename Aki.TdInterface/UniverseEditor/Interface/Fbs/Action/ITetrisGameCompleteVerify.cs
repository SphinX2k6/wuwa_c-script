using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB0 RID: 31664
	public static class ITetrisGameCompleteVerify
	{
		// Token: 0x060390F5 RID: 233717 RVA: 0x007B65E2 File Offset: 0x007B47E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
