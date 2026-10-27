using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5B RID: 23387
	public static class IWaySplineCommonPointVerify
	{
		// Token: 0x06028042 RID: 163906 RVA: 0x005806F2 File Offset: 0x0057E8F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
