using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C4 RID: 17860
	public static class ITakePhoto2CloseCameraAfterFinishActionsVerify
	{
		// Token: 0x0601A0EE RID: 106734 RVA: 0x003B678E File Offset: 0x003B498E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
