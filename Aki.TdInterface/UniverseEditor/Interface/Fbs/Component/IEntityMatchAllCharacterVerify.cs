using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005194 RID: 20884
	public static class IEntityMatchAllCharacterVerify
	{
		// Token: 0x06021C8E RID: 138382 RVA: 0x004AFECE File Offset: 0x004AE0CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
