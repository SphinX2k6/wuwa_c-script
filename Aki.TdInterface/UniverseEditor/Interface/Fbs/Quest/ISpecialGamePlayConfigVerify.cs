using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004579 RID: 17785
	public static class ISpecialGamePlayConfigVerify
	{
		// Token: 0x06019E72 RID: 106098 RVA: 0x003B1BB2 File Offset: 0x003AFDB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
