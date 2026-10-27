using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CB RID: 29131
	public static class IStopCameraLookAtVerify
	{
		// Token: 0x06033AD8 RID: 211672 RVA: 0x006F571A File Offset: 0x006F391A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
