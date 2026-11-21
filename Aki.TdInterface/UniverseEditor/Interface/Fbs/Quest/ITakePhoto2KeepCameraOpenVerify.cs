using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CD RID: 17869
	public static class ITakePhoto2KeepCameraOpenVerify
	{
		// Token: 0x0601A190 RID: 106896 RVA: 0x003B82A6 File Offset: 0x003B64A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
