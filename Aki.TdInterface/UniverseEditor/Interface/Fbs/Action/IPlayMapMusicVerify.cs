using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D28 RID: 27944
	public static class IPlayMapMusicVerify
	{
		// Token: 0x0603149B RID: 201883 RVA: 0x006AF44A File Offset: 0x006AD64A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
