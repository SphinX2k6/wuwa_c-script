using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007582 RID: 30082
	public static class IVisualNovelDisplayItemCloseVerify
	{
		// Token: 0x06036B97 RID: 224151 RVA: 0x0076E0B2 File Offset: 0x0076C2B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
