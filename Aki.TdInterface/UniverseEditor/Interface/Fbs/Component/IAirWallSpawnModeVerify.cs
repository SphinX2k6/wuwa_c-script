using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AB RID: 21419
	public static class IAirWallSpawnModeVerify
	{
		// Token: 0x060216FE RID: 136958 RVA: 0x0049CF7A File Offset: 0x0049B17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
