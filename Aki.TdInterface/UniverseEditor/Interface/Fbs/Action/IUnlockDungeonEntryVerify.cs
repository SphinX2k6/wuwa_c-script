using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CCD RID: 31949
	public static class IUnlockDungeonEntryVerify
	{
		// Token: 0x06039A1B RID: 236059 RVA: 0x007C684A File Offset: 0x007C4A4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
