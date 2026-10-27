using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005011 RID: 20497
	public static class IConnectorPathAdvanceReceiverVerify
	{
		// Token: 0x06020CB6 RID: 134326 RVA: 0x0048F3F2 File Offset: 0x0048D5F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
