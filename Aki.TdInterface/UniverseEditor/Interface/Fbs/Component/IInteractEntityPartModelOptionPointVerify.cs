using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D4 RID: 22996
	public static class IInteractEntityPartModelOptionPointVerify
	{
		// Token: 0x060258AA RID: 153770 RVA: 0x0052665E File Offset: 0x0052485E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
