using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004344 RID: 17220
	public static class IAcmLockedVerify
	{
		// Token: 0x06019880 RID: 104576 RVA: 0x003A7CCE File Offset: 0x003A5ECE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
