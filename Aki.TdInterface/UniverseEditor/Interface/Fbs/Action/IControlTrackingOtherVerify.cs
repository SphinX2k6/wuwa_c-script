using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D9 RID: 25817
	public static class IControlTrackingOtherVerify
	{
		// Token: 0x0602CC93 RID: 183443 RVA: 0x006278EF File Offset: 0x00625AEF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
