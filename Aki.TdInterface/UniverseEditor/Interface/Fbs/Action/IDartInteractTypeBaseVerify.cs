using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB0 RID: 27568
	public static class IDartInteractTypeBaseVerify
	{
		// Token: 0x0602F727 RID: 194343 RVA: 0x00678D4E File Offset: 0x00676F4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
