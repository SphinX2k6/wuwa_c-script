using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A0 RID: 31136
	public static class IStopCameraLookAtVerify
	{
		// Token: 0x06036DDA RID: 224730 RVA: 0x00756A7A File Offset: 0x00754C7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
