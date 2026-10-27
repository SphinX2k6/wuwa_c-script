using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006244 RID: 25156
	public static class IBvbEndTurnVerify
	{
		// Token: 0x0602B601 RID: 177665 RVA: 0x005F89D2 File Offset: 0x005F6BD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
