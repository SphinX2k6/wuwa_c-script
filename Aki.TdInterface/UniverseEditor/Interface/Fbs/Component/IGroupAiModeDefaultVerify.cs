using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C0 RID: 22720
	public static class IGroupAiModeDefaultVerify
	{
		// Token: 0x06024E25 RID: 151077 RVA: 0x005109F2 File Offset: 0x0050EBF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
