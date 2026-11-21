using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F49 RID: 28489
	public static class IGroupAiCommunicateModeVerify
	{
		// Token: 0x060314F1 RID: 201969 RVA: 0x006ADD52 File Offset: 0x006ABF52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
