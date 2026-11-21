using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007997 RID: 31127
	public static class IStateProgramSpecialProcessBaseVerify
	{
		// Token: 0x06036DA7 RID: 224679 RVA: 0x007565F2 File Offset: 0x007547F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
