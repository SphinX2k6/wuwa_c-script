using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E9 RID: 21737
	public static class ICircuitConnectModeBaseVerify
	{
		// Token: 0x0602252C RID: 140588 RVA: 0x004BB386 File Offset: 0x004B9586
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
