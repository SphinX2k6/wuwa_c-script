using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8B RID: 23435
	public static class IWoodElementalMatchVerify
	{
		// Token: 0x060281E0 RID: 164320 RVA: 0x005838D2 File Offset: 0x00581AD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
