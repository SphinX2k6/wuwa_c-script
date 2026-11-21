using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005998 RID: 22936
	public static class IInhaledPerformanceVerify
	{
		// Token: 0x06025654 RID: 153172 RVA: 0x0052197A File Offset: 0x0051FB7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
