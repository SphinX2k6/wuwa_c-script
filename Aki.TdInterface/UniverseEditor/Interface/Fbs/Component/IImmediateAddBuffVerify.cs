using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EB RID: 21483
	public static class IImmediateAddBuffVerify
	{
		// Token: 0x0602347C RID: 144508 RVA: 0x004E2942 File Offset: 0x004E0B42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
