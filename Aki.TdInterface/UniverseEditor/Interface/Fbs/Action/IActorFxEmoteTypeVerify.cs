using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006726 RID: 26406
	public static class IActorFxEmoteTypeVerify
	{
		// Token: 0x0602CB9A RID: 183194 RVA: 0x0061E4FA File Offset: 0x0061C6FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
