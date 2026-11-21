using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B1 RID: 21425
	public static class IAirWallSpawnStyleVerify
	{
		// Token: 0x0602171C RID: 136988 RVA: 0x0049D1EE File Offset: 0x0049B3EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
