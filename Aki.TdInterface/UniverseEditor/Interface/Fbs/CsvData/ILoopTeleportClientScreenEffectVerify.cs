using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAE RID: 19886
	public static class ILoopTeleportClientScreenEffectVerify
	{
		// Token: 0x0601ED8C RID: 126348 RVA: 0x0044F86B File Offset: 0x0044DA6B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
