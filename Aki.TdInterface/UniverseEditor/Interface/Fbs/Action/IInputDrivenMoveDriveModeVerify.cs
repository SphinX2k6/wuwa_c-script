using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006965 RID: 26981
	public static class IInputDrivenMoveDriveModeVerify
	{
		// Token: 0x0602F1B3 RID: 192947 RVA: 0x0066B1B2 File Offset: 0x006693B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
