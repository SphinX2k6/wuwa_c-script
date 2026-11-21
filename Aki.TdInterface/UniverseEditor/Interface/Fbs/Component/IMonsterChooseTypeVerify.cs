using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFD RID: 23293
	public static class IMonsterChooseTypeVerify
	{
		// Token: 0x06026475 RID: 156789 RVA: 0x0053E9DE File Offset: 0x0053CBDE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
