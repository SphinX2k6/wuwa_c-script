using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677A RID: 26490
	public static class IActorVisibilityEffectTypeVerify
	{
		// Token: 0x0602CE69 RID: 183913 RVA: 0x006237E2 File Offset: 0x006219E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
