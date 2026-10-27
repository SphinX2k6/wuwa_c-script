using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9D RID: 23453
	public static class IWuWaGoBowTrapVerify
	{
		// Token: 0x06028270 RID: 164464 RVA: 0x005849DA File Offset: 0x00582BDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
