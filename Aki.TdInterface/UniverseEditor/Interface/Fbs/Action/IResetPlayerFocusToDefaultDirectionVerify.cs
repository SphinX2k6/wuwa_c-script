using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007617 RID: 30231
	public static class IResetPlayerFocusToDefaultDirectionVerify
	{
		// Token: 0x060350C2 RID: 217282 RVA: 0x0072028A File Offset: 0x0071E48A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
