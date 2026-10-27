using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA6 RID: 23462
	public static class IWuWaGoEntityBaseVerify
	{
		// Token: 0x060282CA RID: 164554 RVA: 0x0058564E File Offset: 0x0058384E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
