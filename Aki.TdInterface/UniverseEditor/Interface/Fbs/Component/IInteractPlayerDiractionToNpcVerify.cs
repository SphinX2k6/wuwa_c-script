using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005460 RID: 21600
	public static class IInteractPlayerDiractionToNpcVerify
	{
		// Token: 0x06023894 RID: 145556 RVA: 0x004EA6CA File Offset: 0x004E88CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
