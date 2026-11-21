using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D72 RID: 32114
	public static class IVisualNovelDisplayItemBaseVerify
	{
		// Token: 0x06039F9D RID: 237469 RVA: 0x007D1352 File Offset: 0x007CF552
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
