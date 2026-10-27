using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200606D RID: 24685
	public static class IAcceptCurrentQuestVerify
	{
		// Token: 0x06029CCB RID: 171211 RVA: 0x005BC416 File Offset: 0x005BA616
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
