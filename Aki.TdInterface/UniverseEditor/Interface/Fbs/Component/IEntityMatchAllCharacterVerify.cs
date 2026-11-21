using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F9 RID: 22265
	public static class IEntityMatchAllCharacterVerify
	{
		// Token: 0x06023BE6 RID: 146406 RVA: 0x004E9EEE File Offset: 0x004E80EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
