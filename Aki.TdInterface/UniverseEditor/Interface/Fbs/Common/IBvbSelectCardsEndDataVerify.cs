using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D63 RID: 23907
	public static class IBvbSelectCardsEndDataVerify
	{
		// Token: 0x06028E63 RID: 167523 RVA: 0x0059E762 File Offset: 0x0059C962
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
