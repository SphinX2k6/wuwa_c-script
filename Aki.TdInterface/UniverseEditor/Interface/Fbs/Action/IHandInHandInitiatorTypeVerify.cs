using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F73 RID: 28531
	public static class IHandInHandInitiatorTypeVerify
	{
		// Token: 0x06031629 RID: 202281 RVA: 0x006B285A File Offset: 0x006B0A5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
