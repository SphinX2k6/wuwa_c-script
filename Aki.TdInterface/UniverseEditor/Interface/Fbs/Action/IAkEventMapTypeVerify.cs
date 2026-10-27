using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006184 RID: 24964
	public static class IAkEventMapTypeVerify
	{
		// Token: 0x0602B00F RID: 176143 RVA: 0x005EEC8A File Offset: 0x005ECE8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
