using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005293 RID: 21139
	public static class IFollowDecorationConfigVerify
	{
		// Token: 0x06022731 RID: 141105 RVA: 0x004C6A66 File Offset: 0x004C4C66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
