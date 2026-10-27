using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005017 RID: 20503
	public static class IConnectorPathAdvanceVisualVerify
	{
		// Token: 0x06020CF8 RID: 134392 RVA: 0x0048FBB2 File Offset: 0x0048DDB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
