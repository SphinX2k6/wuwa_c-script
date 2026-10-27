using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F24 RID: 20260
	public static class IBoxAkEventVerify
	{
		// Token: 0x060200B3 RID: 131251 RVA: 0x00475614 File Offset: 0x00473814
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
