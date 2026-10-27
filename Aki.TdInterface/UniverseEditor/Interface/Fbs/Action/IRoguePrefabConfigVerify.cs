using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE4 RID: 28388
	public static class IRoguePrefabConfigVerify
	{
		// Token: 0x0603229C RID: 205468 RVA: 0x006C78E8 File Offset: 0x006C5AE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
