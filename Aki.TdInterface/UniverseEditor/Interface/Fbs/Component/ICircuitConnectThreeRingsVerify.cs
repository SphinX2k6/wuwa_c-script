using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F8 RID: 21752
	public static class ICircuitConnectThreeRingsVerify
	{
		// Token: 0x0602258A RID: 140682 RVA: 0x004BBBBE File Offset: 0x004B9DBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
