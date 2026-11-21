using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EF RID: 21743
	public static class ICircuitConnectOutputPortLayoutVerify
	{
		// Token: 0x0602254C RID: 140620 RVA: 0x004BB646 File Offset: 0x004B9846
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
