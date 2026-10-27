using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C7B RID: 19579
	public static class IPhotographCameraCheckTypeVerify
	{
		// Token: 0x0601F0CC RID: 127180 RVA: 0x00457052 File Offset: 0x00455252
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
