using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005576 RID: 21878
	public static class IConnectorPathAdvanceVisualVerify
	{
		// Token: 0x06022C18 RID: 142360 RVA: 0x004C9602 File Offset: 0x004C7802
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
