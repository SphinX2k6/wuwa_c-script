using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004901 RID: 18689
	public static class ILoopTeleportClientLogicItemBaseVerify
	{
		// Token: 0x0601D377 RID: 119671 RVA: 0x0041F4BA File Offset: 0x0041D6BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
