using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C5 RID: 26309
	public static class IEnterOrbitalCameraControlByMoveVerify
	{
		// Token: 0x0602DBCF RID: 187343 RVA: 0x00641C94 File Offset: 0x0063FE94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
