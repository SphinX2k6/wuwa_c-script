using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006118 RID: 24856
	public static class IActorVisibilityEffectTypeVerify
	{
		// Token: 0x0602A788 RID: 173960 RVA: 0x005D983A File Offset: 0x005D7A3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
