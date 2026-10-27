using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AD RID: 20653
	public static class IDollGrabStageAudioStateVerify
	{
		// Token: 0x060212E2 RID: 135906 RVA: 0x0049C2E2 File Offset: 0x0049A4E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
