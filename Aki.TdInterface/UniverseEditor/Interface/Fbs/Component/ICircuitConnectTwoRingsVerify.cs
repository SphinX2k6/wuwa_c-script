using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FB RID: 21755
	public static class ICircuitConnectTwoRingsVerify
	{
		// Token: 0x0602259C RID: 140700 RVA: 0x004BBD36 File Offset: 0x004B9F36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
