using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B61 RID: 23393
	public static class IWaySplinePointTypeVerify
	{
		// Token: 0x0602807E RID: 163966 RVA: 0x00581032 File Offset: 0x0057F232
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
