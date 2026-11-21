using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006777 RID: 26487
	public static class IActorVisibilityEffectDefaultVerify
	{
		// Token: 0x0602CE57 RID: 183895 RVA: 0x0062366A File Offset: 0x0062186A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
