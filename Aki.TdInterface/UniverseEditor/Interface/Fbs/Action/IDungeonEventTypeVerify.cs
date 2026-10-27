using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006617 RID: 26135
	public static class IDungeonEventTypeVerify
	{
		// Token: 0x0602D638 RID: 185912 RVA: 0x00638312 File Offset: 0x00636512
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
