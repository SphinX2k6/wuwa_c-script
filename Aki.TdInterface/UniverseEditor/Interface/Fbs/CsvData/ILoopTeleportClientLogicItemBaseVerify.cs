using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D9C RID: 19868
	public static class ILoopTeleportClientLogicItemBaseVerify
	{
		// Token: 0x0601ED10 RID: 126224 RVA: 0x0044EC1A File Offset: 0x0044CE1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
