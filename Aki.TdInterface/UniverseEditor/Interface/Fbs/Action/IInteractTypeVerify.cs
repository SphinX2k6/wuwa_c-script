using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AA RID: 27050
	public static class IInteractTypeVerify
	{
		// Token: 0x0602F42A RID: 193578 RVA: 0x0066FEDE File Offset: 0x0066E0DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
