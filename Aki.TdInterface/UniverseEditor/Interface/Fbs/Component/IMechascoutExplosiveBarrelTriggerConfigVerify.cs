using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABE RID: 23230
	public static class IMechascoutExplosiveBarrelTriggerConfigVerify
	{
		// Token: 0x06026174 RID: 156020 RVA: 0x00537DF6 File Offset: 0x00535FF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
