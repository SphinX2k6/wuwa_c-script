using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D48 RID: 32072
	public static class IVisualNovelActivityActionConfigBaseVerify
	{
		// Token: 0x06039E6D RID: 237165 RVA: 0x007CF59A File Offset: 0x007CD79A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
