using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FE RID: 29182
	public static class ISubPlotModePromptWithProfilePicVerify
	{
		// Token: 0x06033C23 RID: 212003 RVA: 0x006F77CA File Offset: 0x006F59CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
