using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC4 RID: 27844
	public static class IEnableCameraOperationVerify
	{
		// Token: 0x0602FFD7 RID: 196567 RVA: 0x00687E4E File Offset: 0x0068604E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
