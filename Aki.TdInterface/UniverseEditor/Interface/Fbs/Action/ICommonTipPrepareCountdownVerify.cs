using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A9 RID: 25769
	public static class ICommonTipPrepareCountdownVerify
	{
		// Token: 0x0602CAA7 RID: 182951 RVA: 0x00621982 File Offset: 0x0061FB82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
