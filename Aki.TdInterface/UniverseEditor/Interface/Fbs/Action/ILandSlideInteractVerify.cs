using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E0 RID: 27104
	public static class ILandSlideInteractVerify
	{
		// Token: 0x0602F616 RID: 194070 RVA: 0x006738FA File Offset: 0x00671AFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
