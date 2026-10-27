using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF3 RID: 27379
	public static class IMontageConfigVerify
	{
		// Token: 0x0602FFE1 RID: 196577 RVA: 0x006865B6 File Offset: 0x006847B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
