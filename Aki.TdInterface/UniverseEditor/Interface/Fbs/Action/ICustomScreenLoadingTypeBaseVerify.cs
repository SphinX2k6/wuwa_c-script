using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B74 RID: 27508
	public static class ICustomScreenLoadingTypeBaseVerify
	{
		// Token: 0x0602F56A RID: 193898 RVA: 0x00675CFA File Offset: 0x00673EFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
