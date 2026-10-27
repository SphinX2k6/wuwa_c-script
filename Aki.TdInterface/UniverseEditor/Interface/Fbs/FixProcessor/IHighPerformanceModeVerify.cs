using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004762 RID: 18274
	public static class IHighPerformanceModeVerify
	{
		// Token: 0x0601C21E RID: 115230 RVA: 0x003FC4B2 File Offset: 0x003FA6B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
