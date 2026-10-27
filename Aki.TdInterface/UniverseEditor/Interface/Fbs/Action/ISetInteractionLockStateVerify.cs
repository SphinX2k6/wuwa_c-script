using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007006 RID: 28678
	public static class ISetInteractionLockStateVerify
	{
		// Token: 0x06032BAE RID: 207790 RVA: 0x006D851E File Offset: 0x006D671E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
