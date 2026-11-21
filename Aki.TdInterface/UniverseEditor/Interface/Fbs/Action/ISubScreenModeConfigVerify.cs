using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E8 RID: 31208
	public static class ISubScreenModeConfigVerify
	{
		// Token: 0x06036FCB RID: 225227 RVA: 0x00759D72 File Offset: 0x00757F72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
