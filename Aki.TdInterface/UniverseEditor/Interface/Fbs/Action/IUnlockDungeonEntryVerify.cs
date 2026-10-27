using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D7 RID: 29911
	public static class IUnlockDungeonEntryVerify
	{
		// Token: 0x06036606 RID: 222726 RVA: 0x007635FA File Offset: 0x007617FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
