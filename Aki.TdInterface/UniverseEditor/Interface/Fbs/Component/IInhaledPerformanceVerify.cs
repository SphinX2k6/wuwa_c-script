using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005412 RID: 21522
	public static class IInhaledPerformanceVerify
	{
		// Token: 0x0602359C RID: 144796 RVA: 0x004E494E File Offset: 0x004E2B4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
