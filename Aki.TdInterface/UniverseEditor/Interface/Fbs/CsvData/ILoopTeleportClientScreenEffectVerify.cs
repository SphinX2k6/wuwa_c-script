using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004913 RID: 18707
	public static class ILoopTeleportClientScreenEffectVerify
	{
		// Token: 0x0601D3F3 RID: 119795 RVA: 0x0042010B File Offset: 0x0041E30B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
