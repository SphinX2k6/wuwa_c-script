using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1F RID: 23071
	public static class IItemFoundationTypeVerify
	{
		// Token: 0x06025B0F RID: 154383 RVA: 0x0052ABB2 File Offset: 0x00528DB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
