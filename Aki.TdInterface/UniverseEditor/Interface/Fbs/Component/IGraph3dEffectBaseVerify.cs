using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005897 RID: 22679
	public static class IGraph3dEffectBaseVerify
	{
		// Token: 0x06024C8B RID: 150667 RVA: 0x0050D236 File Offset: 0x0050B436
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
