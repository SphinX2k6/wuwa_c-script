using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006115 RID: 24853
	public static class IActorVisibilityEffectDefaultVerify
	{
		// Token: 0x0602A776 RID: 173942 RVA: 0x005D96C2 File Offset: 0x005D78C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
