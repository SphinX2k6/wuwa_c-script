using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D66 RID: 23910
	public static class IBvbStartAiDataVerify
	{
		// Token: 0x06028E75 RID: 167541 RVA: 0x0059E8DA File Offset: 0x0059CADA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
