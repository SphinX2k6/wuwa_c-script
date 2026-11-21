using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A19 RID: 27161
	public static class IClientEventPianoSwitchPhaseVerify
	{
		// Token: 0x0602E986 RID: 190854 RVA: 0x0065AA2E File Offset: 0x00658C2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
