using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBC RID: 27836
	public static class IPhotographCameraTransformBaseVerify
	{
		// Token: 0x060310E4 RID: 200932 RVA: 0x006A8606 File Offset: 0x006A6806
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
