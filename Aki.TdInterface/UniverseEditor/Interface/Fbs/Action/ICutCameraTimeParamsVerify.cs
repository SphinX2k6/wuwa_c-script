using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006521 RID: 25889
	public static class ICutCameraTimeParamsVerify
	{
		// Token: 0x0602CE90 RID: 183952 RVA: 0x0062ADD6 File Offset: 0x00628FD6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
