using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6E RID: 28270
	public static class IFlowActionContextVerify
	{
		// Token: 0x06030D6E RID: 200046 RVA: 0x006A0501 File Offset: 0x0069E701
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
