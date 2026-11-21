using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005989 RID: 22921
	public static class IInhalationPerformanceTypeVerify
	{
		// Token: 0x060255E0 RID: 153056 RVA: 0x00520CB2 File Offset: 0x0051EEB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
