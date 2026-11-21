using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC2 RID: 31682
	public static class IThreeStageSplineMoveMontageVerify
	{
		// Token: 0x060391BF RID: 233919 RVA: 0x007B7D5B File Offset: 0x007B5F5B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
