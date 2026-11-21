using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E6 RID: 23014
	public static class IInteractPlayerDiractionToNpcVerify
	{
		// Token: 0x0602594C RID: 153932 RVA: 0x0052773E File Offset: 0x0052593E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
