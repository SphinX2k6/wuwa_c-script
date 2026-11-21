using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200465D RID: 18013
	public static class ITrackHandBookBoardConfigVerify
	{
		// Token: 0x0601A685 RID: 108165 RVA: 0x003C24CA File Offset: 0x003C06CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
