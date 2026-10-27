using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D1B RID: 15643
	public static class IAtomicProcessBaseVerify
	{
		// Token: 0x06015966 RID: 88422 RVA: 0x0031E0C2 File Offset: 0x0031C2C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
