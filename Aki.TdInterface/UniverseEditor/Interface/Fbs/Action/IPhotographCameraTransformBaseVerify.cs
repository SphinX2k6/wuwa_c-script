using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007432 RID: 29746
	public static class IPhotographCameraTransformBaseVerify
	{
		// Token: 0x060340BB RID: 213179 RVA: 0x0070383A File Offset: 0x00701A3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
