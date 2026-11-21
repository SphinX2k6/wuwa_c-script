using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043BD RID: 17341
	public static class IPhoneMessageProgressTypeBaseVerify
	{
		// Token: 0x060189BE RID: 100798 RVA: 0x00382AA2 File Offset: 0x00380CA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
