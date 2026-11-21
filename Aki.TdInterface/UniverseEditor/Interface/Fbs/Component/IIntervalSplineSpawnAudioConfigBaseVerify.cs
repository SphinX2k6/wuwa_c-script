using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A10 RID: 23056
	public static class IIntervalSplineSpawnAudioConfigBaseVerify
	{
		// Token: 0x06025A96 RID: 154262 RVA: 0x00529C16 File Offset: 0x00527E16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
