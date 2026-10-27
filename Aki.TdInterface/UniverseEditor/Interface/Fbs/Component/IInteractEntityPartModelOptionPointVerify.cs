using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544E RID: 21582
	public static class IInteractEntityPartModelOptionPointVerify
	{
		// Token: 0x060237F2 RID: 145394 RVA: 0x004E95EA File Offset: 0x004E77EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
