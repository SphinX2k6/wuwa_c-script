using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D3 RID: 31187
	public static class ISubPlotModePromptWithProfilePicVerify
	{
		// Token: 0x06036F25 RID: 225061 RVA: 0x00758B2A File Offset: 0x00756D2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
