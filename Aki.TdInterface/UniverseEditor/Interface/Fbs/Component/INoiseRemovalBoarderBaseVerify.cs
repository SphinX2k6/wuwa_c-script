using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FE RID: 22014
	public static class INoiseRemovalBoarderBaseVerify
	{
		// Token: 0x06024870 RID: 149616 RVA: 0x0050A77A File Offset: 0x0050897A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
