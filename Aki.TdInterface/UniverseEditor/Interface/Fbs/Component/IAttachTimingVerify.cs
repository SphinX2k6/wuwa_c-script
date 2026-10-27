using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC4 RID: 20164
	public static class IAttachTimingVerify
	{
		// Token: 0x0601FC30 RID: 130096 RVA: 0x0046BD5A File Offset: 0x00469F5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
