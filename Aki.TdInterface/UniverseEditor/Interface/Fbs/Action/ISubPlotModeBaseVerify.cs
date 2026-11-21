using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079CD RID: 31181
	public static class ISubPlotModeBaseVerify
	{
		// Token: 0x06036F07 RID: 225031 RVA: 0x007588B6 File Offset: 0x00756AB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
