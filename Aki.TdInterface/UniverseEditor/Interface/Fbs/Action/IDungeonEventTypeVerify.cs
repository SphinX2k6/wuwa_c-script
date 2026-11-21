using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C88 RID: 27784
	public static class IDungeonEventTypeVerify
	{
		// Token: 0x0602FE09 RID: 196105 RVA: 0x00684E7A File Offset: 0x0068307A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
