using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C80 RID: 23680
	public static class IPasserbyNpcGenerateTypeBaseVerify
	{
		// Token: 0x0602748C RID: 160908 RVA: 0x005613E2 File Offset: 0x0055F5E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
