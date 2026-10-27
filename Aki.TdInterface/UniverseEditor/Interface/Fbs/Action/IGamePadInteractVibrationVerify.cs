using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686C RID: 26732
	public static class IGamePadInteractVibrationVerify
	{
		// Token: 0x0602E9F4 RID: 190964 RVA: 0x0065BCC6 File Offset: 0x00659EC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
