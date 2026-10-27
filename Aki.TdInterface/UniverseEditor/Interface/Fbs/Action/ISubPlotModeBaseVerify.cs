using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F8 RID: 29176
	public static class ISubPlotModeBaseVerify
	{
		// Token: 0x06033C05 RID: 211973 RVA: 0x006F7556 File Offset: 0x006F5756
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
