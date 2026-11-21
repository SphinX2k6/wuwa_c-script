using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007509 RID: 29961
	public static class IPreloadCharacterTypeVerify
	{
		// Token: 0x060348AC RID: 215212 RVA: 0x007128B6 File Offset: 0x00710AB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
