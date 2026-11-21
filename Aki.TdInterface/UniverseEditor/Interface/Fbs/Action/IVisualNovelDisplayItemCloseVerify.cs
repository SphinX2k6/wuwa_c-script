using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D78 RID: 32120
	public static class IVisualNovelDisplayItemCloseVerify
	{
		// Token: 0x06039FBF RID: 237503 RVA: 0x007D1656 File Offset: 0x007CF856
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
