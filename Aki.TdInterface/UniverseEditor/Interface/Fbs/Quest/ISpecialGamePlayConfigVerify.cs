using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004138 RID: 16696
	public static class ISpecialGamePlayConfigVerify
	{
		// Token: 0x060187CF RID: 100303 RVA: 0x00387BAA File Offset: 0x00385DAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
