using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005570 RID: 21872
	public static class IConnectorPathAdvanceReceiverVerify
	{
		// Token: 0x06022BD6 RID: 142294 RVA: 0x004C8E42 File Offset: 0x004C7042
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
