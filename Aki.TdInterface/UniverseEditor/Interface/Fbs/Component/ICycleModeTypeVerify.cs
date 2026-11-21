using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CA RID: 21962
	public static class ICycleModeTypeVerify
	{
		// Token: 0x06022F14 RID: 143124 RVA: 0x004CF52E File Offset: 0x004CD72E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
