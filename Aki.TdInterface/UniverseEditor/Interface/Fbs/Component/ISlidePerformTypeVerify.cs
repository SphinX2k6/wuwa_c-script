using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005931 RID: 22833
	public static class ISlidePerformTypeVerify
	{
		// Token: 0x06026A15 RID: 158229 RVA: 0x005521DA File Offset: 0x005503DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
