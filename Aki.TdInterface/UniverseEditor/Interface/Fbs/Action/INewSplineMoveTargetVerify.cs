using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9C RID: 27548
	public static class INewSplineMoveTargetVerify
	{
		// Token: 0x06030630 RID: 198192 RVA: 0x00692916 File Offset: 0x00690B16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
