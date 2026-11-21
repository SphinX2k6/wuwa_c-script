using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731B RID: 29467
	public static class INpcGroupSequenceMontageBlendAnimTypeVerify
	{
		// Token: 0x06033618 RID: 210456 RVA: 0x006ED880 File Offset: 0x006EBA80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
