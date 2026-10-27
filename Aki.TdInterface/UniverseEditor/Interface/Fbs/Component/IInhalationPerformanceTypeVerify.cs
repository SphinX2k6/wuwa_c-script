using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005403 RID: 21507
	public static class IInhalationPerformanceTypeVerify
	{
		// Token: 0x06023528 RID: 144680 RVA: 0x004E3C86 File Offset: 0x004E1E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
