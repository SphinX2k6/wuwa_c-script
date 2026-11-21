using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E38 RID: 24120
	public static class IRefreshOnHostInteractVerify
	{
		// Token: 0x060284B6 RID: 165046 RVA: 0x005825FA File Offset: 0x005807FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
