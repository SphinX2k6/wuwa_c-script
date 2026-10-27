using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B3 RID: 22451
	public static class IPullingFoundationTypeVerify
	{
		// Token: 0x06025AE7 RID: 154343 RVA: 0x005328FA File Offset: 0x00530AFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
