using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639A RID: 25498
	public static class IBvbSelectCardsEndDataVerify
	{
		// Token: 0x0602B4CD RID: 177357 RVA: 0x005E71D2 File Offset: 0x005E53D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
