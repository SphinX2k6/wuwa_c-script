using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E3 RID: 29923
	public static class IUnlockSystemItemTypeVerify
	{
		// Token: 0x06036661 RID: 222817 RVA: 0x0076401E File Offset: 0x0076221E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
