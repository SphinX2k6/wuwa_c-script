using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C2 RID: 27074
	public static class ICharacterLookAtUnlockDataVerify
	{
		// Token: 0x0602E711 RID: 190225 RVA: 0x0065630E File Offset: 0x0065450E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
